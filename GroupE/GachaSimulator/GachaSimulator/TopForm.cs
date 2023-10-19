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

        // 「ガチャを回す！」ボタンを押した時
        private void rollButton_Click(object sender, EventArgs e)
        {
            // 「ガチャを回す！」ボタンの色が「黒である」時
            if(rollButton.ForeColor==Color.Black)
            {
                RollForm rollForm = new RollForm();
                rollForm.ShowDialog();
            }
            // 「ガチャを回す！」ボタンの色が「黒でない＝灰色」の時
            else
            {
                MessageBox.Show("ガチャの設定がないため、回せません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        }

        // 「終わる」ボタンを押した時
        private void closeTopButton_Click(object sender, EventArgs e)
        {
            // アプリを終了するか尋ねるダイアログを表示
            DialogResult result = MessageBox.Show("アプリを終了しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // 「はい」が押された時
            if(result==DialogResult.Yes)
            {
                Application.Exit();
            }
            // 「いいえ」が押された時は、ダイアログを閉じるだけ（何もしない）
        }

        // 「ガチャを作る！」ボタンを押した時
        private void createButton_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();
            createForm.ShowDialog();
        }

        //　「所持品確認」ボタンを押した時
        private void itemListButton_Click(object sender, EventArgs e)
        {
            ItemListForm itemListForm = new ItemListForm();
            itemListForm.ShowDialog();
        }

    }
}
