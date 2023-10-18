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
    public partial class Form4 : Form
        //ホーム画面
    {
        public Form4()
        {
            InitializeComponent();
        }

        //食事記録入力
        private void eatButton_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        //運動記録入力

        private void exerciseButton_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        //1日の結果
        private void today_historyButton_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        //1週間の記録
        private void week_historyButton_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        //ログアウト
        private void logoutButton_Click(object sender, EventArgs e)
        {
            //ログアウト確認ダイアログボックス表示
            DialogResult result = MessageBox.Show("ログアウトしますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("キャンセルしました");
                return;
            }
            this.Close();
        }
    }
}
