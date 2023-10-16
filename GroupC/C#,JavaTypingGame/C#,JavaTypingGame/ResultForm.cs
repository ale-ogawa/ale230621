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
            play.Show();
            this.Hide();

        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }
    }
}
