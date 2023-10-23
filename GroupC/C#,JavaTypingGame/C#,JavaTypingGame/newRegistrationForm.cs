using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace typingGame
{
    public partial class newRegistrationForm : Form
    {
        public newRegistrationForm()
        {
            InitializeComponent();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 title = new Form1();
            title.ShowDialog();
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
        }

        private void checkButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            RegistrationForm Registration = new RegistrationForm(this.userText.Text, this.passText.Text);
            Registration.ShowDialog();

            this.Close();
        }       
    }
}
