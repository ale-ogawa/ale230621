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
        public ResultForm()
        {
            InitializeComponent();

            //リザルトの表示
            correctTextBox.Text = (playForm.CorrectCouter.ToString())+"回";
            MissTextBox.Text = (playForm.MissCounter.ToString()) + "回";
            TotalScoreTextBox.Text=((playForm.CorrectCouter-playForm.MissCounter)>0)? (playForm.CorrectCouter - playForm.MissCounter).ToString():"0";

            //リザルトの初期化
            playForm.CorrectCouter = 0;
            playForm.MissCounter = 0;
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
