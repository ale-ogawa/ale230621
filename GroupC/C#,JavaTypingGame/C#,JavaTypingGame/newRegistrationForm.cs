using C__JavaTypingGame;
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
    //新規登録画面
    public partial class newRegistrationForm : Form
    {
        public newRegistrationForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// タイトル画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            ControlForm.CloseAndShow(this, typeof(Form1));
        }
        /// <summary>
        /// パスワードの目隠
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (passCheck.Checked)passText.PasswordChar = (char)0;
            else passText.PasswordChar = (char)1;
        }

        private void passText_TextChanged(object sender, EventArgs e)
        {
            passText.PasswordChar = '・';
        }
        /// <summary>
        /// 新規登録確認画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            RegistrationForm Registration = new RegistrationForm(this.userText.Text, this.passText.Text);
            Registration.ShowDialog();

            this.Close();
        }       
    }
}
