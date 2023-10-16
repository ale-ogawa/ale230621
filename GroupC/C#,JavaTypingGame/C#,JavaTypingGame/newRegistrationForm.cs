using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace typingGame
{
    public partial class newRegistrationForm : Form
    {
        public  object userNameText;
        public  object passwordText;

        public newRegistrationForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void passCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (passCheck.Checked == true)
                passText.PasswordChar = (char)0;
            else if (passCheck.Checked == false)
                passText.PasswordChar = (char)1;

        }

        private void passText_TextChanged(object sender, EventArgs e)
        {
            passText.PasswordChar = '・';
            passwordText = passText.Text;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            RegistrationForm Registration = new RegistrationForm();
            Registration.ShowDialog();
           
        }

        private void userText_TextChanged(object sender, EventArgs e)
        {
            userNameText = userText.Text;
        }
    }
}
