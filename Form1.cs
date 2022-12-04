using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_DropDown(object sender, EventArgs e)
        {
            /*btn_Submit.Enabled = true;
            btn_Submit2.Enabled = true;*/
        }
        private void comboBox_TextChanged(object sender, EventArgs e)
        {
            if (comboBox.Text == "one")
            {
                btn_Submit.Enabled = false;
            }
            else if (comboBox.Text == "two")
            {
                btn_Submit2.Enabled = false;
            }
            else if (comboBox.Text == "three")
            {
                btn_Submit.Enabled = false;
                btn_Submit2.Enabled = false;
            }
            else if (comboBox.Text == "four")
            {
                btn_Submit.Enabled = true;
                btn_Submit2.Enabled = true;
            }
        }
    }
}
