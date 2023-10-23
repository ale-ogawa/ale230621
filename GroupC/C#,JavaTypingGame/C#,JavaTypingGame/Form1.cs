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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm();
            login.ShowDialog();
            this.Close();
        }

        private void newRegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            newRegistrationForm newRs = new newRegistrationForm();
            newRs.ShowDialog();
            this.Close();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }
    }
}
