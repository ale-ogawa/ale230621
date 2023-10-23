using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using typingGame;

namespace C__JavaTypingGame
{
    public partial class ResultForm : Form
    {
        private int Rate { get; set; }
        public ResultForm()
        {
            InitializeComponent();

            //Rateの設定
            switch (PlayerDTO.level)
            {
                case Level.初級: Rate = 1; break;
                case Level.中級: Rate = 2; break;
                case Level.上級: Rate = 3; break;
            }

            //リザルトの表示
            correctTextBox.Text = (playForm.CorrectCouter.ToString()) + "回";
            MissTextBox.Text = (playForm.MissCounter.ToString()) + "回";
            PlayerDTO.score = ((playForm.CorrectCouter - playForm.MissCounter) > 0) ? ((playForm.CorrectCouter - playForm.MissCounter) * Rate) : 0;
            TotalScoreTextBox.Text = PlayerDTO.score.ToString();

            //得点をランキングテーブルに保存
            PlayerDAO playerDAO = new PlayerDAO();
            playerDAO.RunkingData();

            //リザルトの初期化
            playForm.CorrectCouter = 0;
            playForm.MissCounter = 0;

            //選択言語、レベルの表示
            langLevelTextBox.Text = $"<{PlayerDTO.Lang}>                             <{PlayerDTO.level.ToString()}>";
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            //プレイ画面へ遷移
            ControlForm.CloseAndShow(this, typeof(playForm));
        }


        private void languageSelectionButton_Click(object sender, EventArgs e)
        {
            //言語選択画面へ遷移
            ControlForm.CloseAndShow(this,typeof(languageSelectionForm));
        }

        private void runkingButton_Click(object sender, EventArgs e)
        {
            //ランキング画面へ遷移
            ControlForm.CloseAndShow(this, typeof(runkingForm));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
