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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            newRegistrationForm nr = new newRegistrationForm();
            this.userName.Text = nr.userNameText.ToString();
            this.password.Text = nr.passwordText.ToString();
        }

        private void passCheck_CheckedChanged(object sender, EventArgs e)
        {
           
        }
 
        //newRegistrationformのpasswordを参照

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
