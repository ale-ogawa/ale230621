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

        /// <summary>
        /// ゲストプレイボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //ログイン状態の代入
            PlayerDTO.Login = false;

            //メッセージの表示
            MessageBox.Show("ゲストプレイではランキングの登録及び閲覧ができません。");

            //画面遷移
            ControlForm.CloseAndShow(this, typeof(languageSelectionForm));

        }
    }
}
