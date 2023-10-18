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
                case Level.初級:Rate = 1; break;
                case Level.中級: Rate = 2; break;
                case Level.上級: Rate = 3; break;
            }

            //リザルトの表示
            correctTextBox.Text = (playForm.CorrectCouter.ToString())+"回";
            MissTextBox.Text = (playForm.MissCounter.ToString()) + "回";
            TotalScoreTextBox.Text=((playForm.CorrectCouter-playForm.MissCounter)>0)? ((playForm.CorrectCouter - playForm.MissCounter)*Rate).ToString():"0";

            //リザルトの初期化
            playForm.CorrectCouter = 0;
            playForm.MissCounter = 0;

            //選択言語、レベルの表示
            langLevelTextBox.Text = $"<{PlayerDTO.Lang}>                             <{PlayerDTO.level.ToString()}>";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            playForm play=new playForm();
            this.Hide();
            play.ShowDialog();
            this.Close();

        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            
        }

        private void languageSelectionButton_Click(object sender, EventArgs e)
        {
            languageSelectionForm lang = new languageSelectionForm();
            this.Hide();
            lang.ShowDialog();
            this.Close();
        }

        private void runkingButton_Click(object sender, EventArgs e)
        {
            runkingForm runk = new runkingForm();
            this.Hide();
            runk.ShowDialog();
            this.Close();
        }
    }
}
