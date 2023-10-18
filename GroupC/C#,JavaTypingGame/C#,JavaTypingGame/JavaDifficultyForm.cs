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
    public partial class JavaDifficultyForm : Form
    {
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            languageSelectionForm languageSelectionForm = new languageSelectionForm();
            languageSelectionForm.ShowDialog();
            this.Close();
        }

        private void beginnerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            playForm pf = new playForm();
            pf.ShowDialog();
            this.Close();
        }

        private void intermediateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            playForm pf = new playForm();
            pf.ShowDialog();
            this.Close();
        }

        private void advancedButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            playForm pf = new playForm();
            pf.ShowDialog();
            this.Close();
        }
    }
}
