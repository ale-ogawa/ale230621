using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using typingGame;

namespace C__JavaTypingGame
{
    //リザルト画面
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

            //登録ユーザーは得点をランキングテーブルに保存
            if (PlayerDTO.Login)
            {
                PlayerDAO playerDAO = new PlayerDAO();
                playerDAO.RunkingData();
            }
            //ゲストユーザーの場合スコアをローカルに保存
            else 
            {
                //次回ログイン時のスコア登録
              　 DialogResult result= MessageBox.Show($"今回のスコアを一時的に保存して次回ログイン時にランキングに登録します。スコアを保存しますか?\n今回のスコア：{PlayerDTO.score}","確認",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    using(StreamWriter sr = new StreamWriter(@"C:\GitRepos\ale230621\GroupC\C#,JavaTypingGame\プレイ記録\スコア.csv",true))
                    {
                        sr.WriteLine(PlayerDTO.Lang+","+ PlayerDTO.score.ToString());
                    }
                    MessageBox.Show("保存完了しました。");
                }
            }

            //リザルトの初期化
            playForm.CorrectCouter = 0;
            playForm.MissCounter = 0;

            //選択言語、レベルの表示
            langLevelTextBox.Text = $"<{PlayerDTO.Lang}>                             <{PlayerDTO.level.ToString()}>";
        }
        /// <summary>
        /// プレイ画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void retryButton_Click(object sender, EventArgs e)
        {
            ControlForm.CloseAndShow(this, typeof(playForm));
        }
        /// <summary>
        /// 言語選択画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void languageSelectionButton_Click(object sender, EventArgs e)
        {
            ControlForm.CloseAndShow(this,typeof(languageSelectionForm));
        }
        /// <summary>
        /// ランキング画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void runkingButton_Click(object sender, EventArgs e)
        {
            if (PlayerDTO.Login) ControlForm.CloseAndShow(this, typeof(runkingForm));
            else MessageBox.Show("ゲストプレイではランキングの閲覧はできません");
        }
        /// <summary>
        /// システムの終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
