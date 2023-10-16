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
    public partial class runkingForm : Form
    {
        public runkingForm()
        {
            InitializeComponent();
        }

        private void menueButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
