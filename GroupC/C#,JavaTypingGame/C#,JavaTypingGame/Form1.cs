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
    //タイトル画面
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ログイン画面の呼出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            ControlForm.CloseAndShow(this,typeof(loginForm));
        }
        /// <summary>
        /// 新規登録画面の呼出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newRegistrationButton_Click(object sender, EventArgs e)
        {
            ControlForm.CloseAndShow(this, typeof(newRegistrationForm));
        }
        /// <summary>
        /// システムの終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
