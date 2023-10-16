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
    public partial class languageSelectionForm : Form
    {
        public languageSelectionForm()
        {
            InitializeComponent();
        }
        private void CButton_Click(object sender, EventArgs e)
        {

        }

        private void titleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 title = new Form1();
            title.ShowDialog();
            this.Close();
        }

        private void JavaButton_Click(object sender, EventArgs e)
        {

        }

        private void runkingButton_Click(object sender, EventArgs e)
        {
            runkingForm ruking =new runkingForm();
            ruking.ShowDialog();
            
        }
    }
}
