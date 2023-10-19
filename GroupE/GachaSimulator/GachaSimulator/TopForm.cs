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
    public partial class TopForm : Form
    {
        public TopForm()
        {
            InitializeComponent();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ガチャを回したよ！");
        }

        private void closeTopButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();
            createForm.ShowDialog();
        }

        private void itemListButton_Click(object sender, EventArgs e)
        {
            ItemListForm itemListForm = new ItemListForm();
            itemListForm.ShowDialog();
        }

    }
}
