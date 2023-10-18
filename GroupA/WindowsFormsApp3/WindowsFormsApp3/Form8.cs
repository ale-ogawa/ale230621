using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form8 : Form
        //一週間の履歴選択画面
    {
        public Form8()
        {
            InitializeComponent();
        }

        //食事履歴
        private void mealRecordButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form9 form9 = new Form9();
            form9.Show();
        }

        //運動履歴
        private void exerciseRecordButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form10 form10 = new Form10();
            form10.Show();
        }

        //摂取カロリー履歴
        private void energyRecordButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form11 form11 = new Form11();
            form11.Show();
        }

        //ホーム
        private void returnHomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
