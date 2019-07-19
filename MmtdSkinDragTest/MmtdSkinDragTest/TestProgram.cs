using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace MmtdSkinDragTest
{
    public partial class TestProgram : Form
    {
        int testType = 0; // 0: skin drag, 1: poke
        int zPos = 90;
        string[] patternString = { "u", "d" };
        string[] randSeq = new string[100];
        string[] tactile = { "drag", "poke" };
        int stimuliIdx = 0;
        string currPattern;
        int maxOnsetDelay = 1000;
        long timeAsk = 0;
        long timeAnswer = 0;
        TextWriter logWriter;
        PokeCmdSend pokeSend;

        public TestProgram()
        {
            InitializeComponent();
        }

        public void initProgram(SerialPort sp, int tType, int zInitPos, string logId)
        {
            serialPort1 = sp;
            testType = tType;
            zPos = zInitPos;

            // Randomize pattern sequence
            int[] randIdx = new int[100];
            for (int i = 0; i < 100; i++)
            {
                randIdx[i] = -1;
            }
            for (int i = 0; i < 100; i++)
            {
                Random rand = new Random();
                int tmp = rand.Next(100);
                while (randIdx.Contains(tmp))
                {
                    tmp = rand.Next(100);
                }
                randIdx[i] = tmp;
            }

            for (int i = 0; i < 100; i++)
            {
                randSeq[randIdx[i]] = patternString[i % 2];
            }

            // Create PokeCmdSend module if poke mode
            if(tactile[tType] == "poke")
            {
                pokeSend = new PokeCmdSend(sp);
            }

            logWriter = new StreamWriter("ExpDir_" + tactile[testType] + "_" + logId + ".csv", true);
            logWriter.WriteLine("Trial#, Pattern, Answer, Correct, RT(ms)");

            buttonUp.Enabled = false;
            buttonDown.Enabled = false;

            buttonUp.BackgroundImage = Image.FromFile(@"D:\workspace\MmtdSkinDragTest\MmtdSkinDragTest\up disable.png");
            buttonDown.BackgroundImage = Image.FromFile(@"D:\workspace\MmtdSkinDragTest\MmtdSkinDragTest\down disable.png");

            if (tactile[tType] == "drag")
            {
                servoXYMove(85, 0);
                servoZMove(zPos + 40, 0);
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            currPattern = randSeq[stimuliIdx];
            buttonPlay.Enabled = false;
            buttonPlay.BackgroundImage = Image.FromFile(@"D:\workspace\MmtdSkinDragTest\MmtdSkinDragTest\play disable.png");
            labelGuide.Text = "Playing";
            Random random = new Random();
            Delay(random.Next(maxOnsetDelay) + 1000);

            playPattern(currPattern);
            timeAsk = DateTime.Now.Ticks;
            labelGuide.Text = "Click the answer";
            buttonUp.Enabled = true;
            buttonDown.Enabled = true;
            buttonUp.BackgroundImage = Image.FromFile(@"D:\workspace\MmtdSkinDragTest\MmtdSkinDragTest\up arrow.png");
            buttonDown.BackgroundImage = Image.FromFile(@"D:\workspace\MmtdSkinDragTest\MmtdSkinDragTest\down arrow.png");
        }

        private void clickAnswer(string ansPattern)
        {
            buttonUp.Enabled = false;
            buttonDown.Enabled = false;

            buttonUp.BackgroundImage = Image.FromFile(@"D:\workspace\MmtdSkinDragTest\MmtdSkinDragTest\up disable.png");
            buttonDown.BackgroundImage = Image.FromFile(@"D:\workspace\MmtdSkinDragTest\MmtdSkinDragTest\down disable.png");

            timeAnswer = DateTime.Now.Ticks;
            long RT = (timeAnswer - timeAsk) / 10000;

            if (currPattern == ansPattern)
            {
                logWriter.WriteLine((stimuliIdx+1).ToString() + "," + currPattern + "," + ansPattern + "," + "1" + "," + RT.ToString());
                logWriter.Flush();
            }
            else
            {
                logWriter.WriteLine((stimuliIdx+1).ToString() + "," + currPattern + "," + ansPattern + "," + "0" + "," + RT.ToString());
                logWriter.Flush();
            }

            if (++stimuliIdx >= 100)
            {
                labelGuide.Text = "Finished!";
                labelOrder.Text = "Finished!";
            }
            else
            {
                Delay(500);

                labelOrder.Text = (stimuliIdx + 1).ToString() + " / 100";
                labelGuide.Text = "";
                buttonPlay.Enabled = true;
                buttonPlay.BackgroundImage = Image.FromFile(@"D:\workspace\MmtdSkinDragTest\MmtdSkinDragTest\play icon.png");
            }
        }

        private void playPattern(string pattern)
        {
            if (tactile[testType] == "drag")
            {
                if (pattern == "u")
                {
                    servoXYMove(117, 85);   // XY +15mm from init pos
                    servoZMove(zPos - 40, zPos + 40);  // Z +2mm from init pos
                    servoXYMove(53, 117);    // XY -15mm from init pos                    
                    servoZMove(zPos + 40, zPos - 40);   // Z init pos
                    servoXYMove(85, 53);    //XY init pos
                }
                else if (pattern == "d")
                {
                    servoXYMove(53, 85);    // XY -15mm from init pos
                    servoZMove(zPos - 40, zPos + 40);  // Z +2mm from init pos
                    servoXYMove(117, 58);   // XY +15mm from init pos
                    servoZMove(zPos + 40, zPos - 40);   // Z init pos
                    servoXYMove(85, 117);    //XY init pos
                }
            }
            else if (tactile[testType] == "poke")
            {
                if (pattern == "u")
                {
                    pokeSend.playCmd("4,0,2;5,85,2;6,170,2;");
                }
                else if (pattern == "d")
                {
                    pokeSend.playCmd("4,170,2;5,85,2;6,0,2;");
                }
            }
        }

        private void servoXYMove(int deg, int prevDeg)
        {
            double speedXY = 200; //deg/s
            int distance = Math.Abs(deg - prevDeg);
            double delayTime = (double)distance / speedXY * 1000.0;
            serialPort1.WriteLine("x" + deg.ToString());
            Delay((int)delayTime);
        }

        private void servoZMove(int deg, int prevDeg)
        {
            double speedZ = 1000; //deg/s
            int distance = Math.Abs(deg - prevDeg);
            double delayTime = (double)distance / speedZ * 1000.0;
            serialPort1.WriteLine("z" + deg.ToString());
            Delay((int)delayTime);
        }

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);
            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            clickAnswer("u");
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            clickAnswer("d");
        }

        private void buttonUp_MouseEnter(object sender, EventArgs e)
        {
            buttonUp.BackgroundImage = Image.FromFile(@"D:\workspace\MmtdSkinDragTest\MmtdSkinDragTest\up hover.png");
        }

        private void buttonUp_MouseLeave(object sender, EventArgs e)
        {
            if(buttonUp.Enabled)
                buttonUp.BackgroundImage = Image.FromFile(@"D:\workspace\MmtdSkinDragTest\MmtdSkinDragTest\up arrow.png");
        }

        private void buttonPlay_MouseEnter(object sender, EventArgs e)
        {
            buttonPlay.BackgroundImage = Image.FromFile(@"D:\workspace\MmtdSkinDragTest\MmtdSkinDragTest\play hover.png");
        }

        private void buttonPlay_MouseLeave(object sender, EventArgs e)
        {
            if(buttonPlay.Enabled)
                buttonPlay.BackgroundImage = Image.FromFile(@"D:\workspace\MmtdSkinDragTest\MmtdSkinDragTest\play icon.png");
        }

        private void buttonDown_MouseEnter(object sender, EventArgs e)
        {
            buttonDown.BackgroundImage = Image.FromFile(@"D:\workspace\MmtdSkinDragTest\MmtdSkinDragTest\down hover.png");
        }

        private void buttonDown_MouseLeave(object sender, EventArgs e)
        {
            if(buttonDown.Enabled)
                buttonDown.BackgroundImage = Image.FromFile(@"D:\workspace\MmtdSkinDragTest\MmtdSkinDragTest\down arrow.png");
        }
    }
}
