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
    public partial class PokeCalib : Form
    {
        int[] idlePos = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public PokeCalib(SerialPort sp)
        {
            InitializeComponent();
            serialPort1 = sp;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            int moduleIdx = Convert.ToInt32(domainUpDownPokeNum.Text) - 1;
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine(String.Format("t{0}{1:d2}", moduleIdx + 1, --idlePos[moduleIdx]));
                Console.WriteLine(serialPort1.ReadLine());
            }
            if (idlePos[moduleIdx] < 70)
                buttonDown.Enabled = true;
            if (idlePos[moduleIdx] <= 0)
                buttonUp.Enabled = false;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            int moduleIdx = Convert.ToInt32(domainUpDownPokeNum.Text) - 1;
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine(String.Format("t{0}{1:d2}", moduleIdx + 1, ++idlePos[moduleIdx]));
                Console.WriteLine(serialPort1.ReadLine());
            }
            if (idlePos[moduleIdx] >= 70)
                buttonDown.Enabled = false;
            if (idlePos[moduleIdx] > 0)
                buttonUp.Enabled = true;
        }

        private void domainUpDownPokeNum_SelectedItemChanged(object sender, EventArgs e)
        {
            int moduleIdx = Convert.ToInt32(domainUpDownPokeNum.Text) - 1;
            if (idlePos[moduleIdx] >= 70)
            {
                buttonDown.Enabled = false;
                buttonUp.Enabled = true;
            }
            else if (idlePos[moduleIdx] <= 0)
            {
                buttonUp.Enabled = false;
                buttonDown.Enabled = true;
            }
            else
            {
                buttonUp.Enabled = true;
                buttonDown.Enabled = true;
            }
        }
    }
}
