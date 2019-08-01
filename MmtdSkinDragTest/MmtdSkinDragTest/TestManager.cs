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
    public partial class TestManager : Form
    {
        public TestManager()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Get available ports
            String[] ports = SerialPort.GetPortNames();
            // Display ports in combobox
            comboBoxSerials.Items.Clear();
            comboBoxSerials.Items.AddRange(ports);
            if (ports.Length > 0)
            {
                comboBoxSerials.SelectedIndex = comboBoxSerials.Items.Count - 1;
                serialPort1.BaudRate = 115200;
                serialPort1.DtrEnable = true;
                serialPort1.RtsEnable = true;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //Connect to combobox selected serial port
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = (String)comboBoxSerials.Items[comboBoxSerials.SelectedIndex];
                serialPort1.Open();
                string line = serialPort1.ReadExisting();
                Console.WriteLine("Start");
                if (line == "Ready for command...")
                    buttonConnect.BackColor = Color.Orange;
            }
            else
            {
                serialPort1.Close();
                buttonConnect.BackColor = SystemColors.ButtonFace;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            TestProgram program = new TestProgram();
            program.initProgram(serialPort1, comboBoxType.SelectedIndex, Convert.ToInt32(textBoxZpos.Text), textBoxId.Text);
            program.Show();
            //this.Hide();
        }

        private void buttonCalibration_Click(object sender, EventArgs e)
        {
            PokeCalib pokeCalib = new PokeCalib(serialPort1);
            pokeCalib.Show();
            //this.Hide();
        }

        private void buttonPractice_Click(object sender, EventArgs e)
        {
            PracticeProgram practice = new PracticeProgram();
            practice.initProgram(serialPort1, comboBoxType.SelectedIndex, Convert.ToInt32(textBoxZpos.Text), textBoxId.Text);
            practice.Show();
        }
    }
}
