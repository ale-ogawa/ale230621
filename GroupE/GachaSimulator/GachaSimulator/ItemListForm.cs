using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GachaSimulator
{
    public partial class ItemListForm : Form
    {
        public ItemListForm()
        {
            InitializeComponent();
        }

        private void returnTopButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
