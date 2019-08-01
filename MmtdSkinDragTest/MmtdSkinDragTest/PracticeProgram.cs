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

namespace MmtdSkinDragTest
{
    public partial class PracticeProgram : Form
    {
        int testType = 0; // 0: skin drag, 1: poke
        int zPos = 90;
        string[] patternString = { "u", "d" };
        string[] tactile = { "drag", "poke", "stretch" };
        int stimuliIdx = 0;
        string currPattern;
        int maxOnsetDelay = 1000;
        long timeAsk = 0;
        long timeAnswer = 0;
        bool answerMode = false;
        PokeCmdSend pokeSend;

        public PracticeProgram()
        {
            InitializeComponent();
        }

        public void initProgram(SerialPort sp, int tType, int zInitPos, string logId)
        {
            serialPort1 = sp;
            testType = tType;
            zPos = zInitPos;

            // Create PokeCmdSend module if poke mode
            if (tactile[tType] == "poke")
            {
                pokeSend = new PokeCmdSend(sp);
            }

            if (tactile[tType] == "drag")
            {
                servoXYMove(85, 0);
                servoZMove(zPos + 40, 0);
            }
        }

        private void clickAnswer(string ansPattern)
        {
            if(answerMode)
            {
                if(currPattern == ansPattern && currPattern == "u")
                {
                    buttonUp.FlatAppearance.BorderColor = Color.Green;
                    buttonUp.FlatAppearance.BorderSize = 3;
                    Delay(500);
                    buttonUp.FlatAppearance.BorderSize = 0;
                }
                else if(currPattern == ansPattern && currPattern == "d")
                {
                    buttonDown.FlatAppearance.BorderColor = Color.Green;
                    buttonDown.FlatAppearance.BorderSize = 3;
                    Delay(500);
                    buttonDown.FlatAppearance.BorderSize = 0;
                }
                else if(currPattern != ansPattern && currPattern == "u")
                {
                    buttonUp.FlatAppearance.BorderColor = Color.Green;
                    buttonUp.FlatAppearance.BorderSize = 3;
                    buttonDown.FlatAppearance.BorderColor = Color.Red;
                    buttonDown.FlatAppearance.BorderSize = 3;
                    Delay(500);
                    buttonUp.FlatAppearance.BorderSize = 0;
                    buttonDown.FlatAppearance.BorderSize = 0;
                }
                else if (currPattern != ansPattern && currPattern == "d")
                {
                    buttonUp.FlatAppearance.BorderColor = Color.Red;
                    buttonUp.FlatAppearance.BorderSize = 3;
                    buttonDown.FlatAppearance.BorderColor = Color.Green;
                    buttonDown.FlatAppearance.BorderSize = 3;
                    Delay(500);
                    buttonUp.FlatAppearance.BorderSize = 0;
                    buttonDown.FlatAppearance.BorderSize = 0;
                }
                buttonPlay.Enabled = true;
                buttonPlay.BackgroundImage = Image.FromFile(@"..\..\play icon.png");
                answerMode = false;
            }
            else
            {
                labelGuide.Text = "Playing";
                playPattern(ansPattern);
                labelGuide.Text = "";
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
                    pokeSend.playCmd("4,0,2;5,135,2;6,270,2;");
                }
                else if (pattern == "d")
                {
                    pokeSend.playCmd("4,270,2;5,135,2;6,0,2;");
                }
            }
            else if (tactile[testType] == "stretch")
            {
                if (pattern == "u")
                {
                    servoXYMove(81, 85);    // 1.875mm
                    Delay(100);
                    servoXYMove(82, 81);
                    Delay(100);
                    servoXYMove(83, 82);
                    Delay(100);
                    servoXYMove(84, 83);
                    Delay(100);
                    servoXYMove(85, 84);
                }
                else if (pattern == "d")
                {
                    servoXYMove(89, 85);    // 1.875mm
                    Delay(100);
                    servoXYMove(88, 89);
                    Delay(100);
                    servoXYMove(87, 88);
                    Delay(100);
                    servoXYMove(86, 87);
                    Delay(100);
                    servoXYMove(85, 86);
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

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            currPattern = patternString[rand.Next(2)];
            buttonPlay.Enabled = false;
            buttonPlay.BackgroundImage = Image.FromFile(@"..\..\play disable.png");
            labelGuide.Text = "Playing";
            Random random = new Random();
            Delay(random.Next(maxOnsetDelay) + 1000);

            playPattern(currPattern);
            labelGuide.Text = "Click the answer";
            answerMode = true;
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
            buttonUp.BackgroundImage = Image.FromFile(@"..\..\up hover.png");
        }

        private void buttonUp_MouseLeave(object sender, EventArgs e)
        {
            if (buttonUp.Enabled)
                buttonUp.BackgroundImage = Image.FromFile(@"..\..\up arrow.png");
        }

        private void buttonPlay_MouseEnter(object sender, EventArgs e)
        {
            buttonPlay.BackgroundImage = Image.FromFile(@"..\..\play hover.png");
        }

        private void buttonPlay_MouseLeave(object sender, EventArgs e)
        {
            if (buttonPlay.Enabled)
                buttonPlay.BackgroundImage = Image.FromFile(@"..\..\play icon.png");
        }

        private void buttonDown_MouseEnter(object sender, EventArgs e)
        {
            buttonDown.BackgroundImage = Image.FromFile(@"..\..\down hover.png");
        }

        private void buttonDown_MouseLeave(object sender, EventArgs e)
        {
            if (buttonDown.Enabled)
                buttonDown.BackgroundImage = Image.FromFile(@"..\..\down arrow.png");
        }
    }
}
