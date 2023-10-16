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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        private void userText_TextChanged(object sender, EventArgs e)
        {

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

        private void userText_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //DBに確認

            //画面遷移
            this.Hide();
            languageSelectionForm ls=new languageSelectionForm();
            ls.ShowDialog();
            this.Close();
        }
    }
}
