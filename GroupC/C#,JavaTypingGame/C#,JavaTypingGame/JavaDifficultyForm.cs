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
    //Java 難易度選択画面
    public partial class JavaDifficultyForm : Form
    {
        public JavaDifficultyForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 言語選択画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            ControlForm.CloseAndShow(this,typeof(languageSelectionForm));
        }
        /// <summary>
        /// 難易度初級に設定、プレイ画面に遷移
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
        ///  難易度中級に設定、プレイ画面に遷移
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
        ///  難易度上級に設定、プレイ画面に遷移
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
    }
}
