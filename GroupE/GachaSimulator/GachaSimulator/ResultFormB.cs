using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GachaSimulator
{
    public partial class ResultFormB : Form
    {
        public ResultFormB()
        {
            InitializeComponent();
            nameB.Text = "ファイヤー";
        }

        //test用
        int id = 0002;
        string level = "B";

        int num = 0;　//残回数


        //「次へ」ボタン押下時
        private void nextButton_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\gachacsv\gachasetting2.csv";

            //ここからcsvファイルに書き込むプログラムを作成する

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                // ID,level,name
                sw.WriteLine(id + "," + level + "," + nameB.Text);


                this.Close();

                ////残りの回数が0の場合
                //if (num <= 0)
                //{
                //    // ID,level,name
                //    sw.WriteLine(id + "," + level + "," + nameB.Text);


                //    RollForm rollForm = new RollForm();
                //    rollForm.Show();
                //    this.Close();


                //}
                ////残りの回数が1以上の場合
                //else
                //{
                //    // ID,level,name
                //    sw.WriteLine(id + "," + level + "," + nameB.Text);
                //    RollForm rollForm = new RollForm();
                //    rollForm.Show();
                //    this.Close();

                //    //次の「【C-3～6】獲得ガチャ表示画面」表示

                //}


            }

        }
        //「全ての結果を保存して戻る」ボタン押下時
        private void skipAllButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
