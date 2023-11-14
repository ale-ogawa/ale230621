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
    //言語選択画面
    public partial class languageSelectionForm : Form
    {
        public languageSelectionForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// タイトル画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void titleButton_Click(object sender, EventArgs e)
        {
            ControlForm.CloseAndShow(this, typeof(Form1));
        }
        /// <summary>
        /// 言語をC#に設定、難易度選択画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CButton_Click(object sender, EventArgs e)
        {
            //Langに言語を設定
            PlayerDTO.Lang = "C#";

            //画面遷移
            ControlForm.CloseAndShow(this, typeof(C_DifficultyForm));
        }
        /// <summary>
        /// 言語をJavaに設定、難易度選択画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JavaButton_Click(object sender, EventArgs e)
        {
            //Langに言語を設定
            PlayerDTO.Lang = "Java";

            //画面遷移
            ControlForm.CloseAndShow(this, typeof(JavaDifficultyForm));
        }
        /// <summary>
        /// ランキング画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void runkingButton_Click(object sender, EventArgs e)
        {
            //ゲストプレイヤーはランキング画面遷移を防止
            if (PlayerDTO.Login) ControlForm.CloseAndShow(this, typeof(runkingForm));
            else MessageBox.Show("ゲストプレイではランキングの閲覧はできません");
        }
    }
}
