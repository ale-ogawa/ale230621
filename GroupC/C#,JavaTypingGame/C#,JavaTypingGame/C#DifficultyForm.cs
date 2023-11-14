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
    //C# 難易度選択画面
    public partial class C_DifficultyForm : Form
    {
        public C_DifficultyForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 言語選択画面呼出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            ControlForm.CloseAndShow(this,typeof(languageSelectionForm));
        }
        /// <summary>
        /// Level初級に設定,プレイ画面の呼出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void beginnerButton_Click(object sender, EventArgs e)
        {
            //Levelの設定
            PlayerDTO.level = Level.初級;

            //画面遷移
            ControlForm.CloseAndShow(this, typeof(playForm));
        }
        /// <summary>
        /// Level中級に設定,プレイ画面の呼出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void intermediateButton_Click(object sender, EventArgs e)
        {
            //Levelの設定
            PlayerDTO.level = Level.中級;

            //画面遷移
            ControlForm.CloseAndShow(this, typeof(playForm));
        }
        /// <summary>
        ///  Level上級に設定,プレイ画面の呼出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void advancedButton_Click(object sender, EventArgs e)
        {
            //Levelの設定
            PlayerDTO.level = Level.上級;

            //画面遷移
            ControlForm.CloseAndShow(this, typeof(playForm));
        }
        private void C_DifficultyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
