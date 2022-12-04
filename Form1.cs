using System;
using System.Net.Mail;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool input;
            input = ValidateEmail(textBox1.Text);
            if (input==true)
            {
                label1.Text = "You are Right";
            }
            else if(input==false)
            {
                label1.Text = "You are wrong";
            }
        }
        public bool ValidateEmail(string email)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(email))
            {
                isValid = false;
            }
            else
            {
                try
                {
                    MailAddress m = new MailAddress(email);
                    isValid = true;
                }
                catch (FormatException)
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
