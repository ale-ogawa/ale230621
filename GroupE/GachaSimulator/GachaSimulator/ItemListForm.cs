using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GachaSimulator
{
    public partial class ItemListForm : Form
    {
        public ItemListForm()
        {
            InitializeComponent();

            string filePath = @"C:\gachacsv\gachasetting2.csv";

            // CSVファイルをDataTableに読み込む
            DataTable dt = new DataTable();
            using (StreamReader rd = new StreamReader(filePath))
            {
                // 最初の行を読み込んで列数を取得
                string[] firstLine = rd.ReadLine().Split(',');
                int numberOfColumns = firstLine.Length;

                dt.Columns.Add("ID");
                dt.Columns.Add("レア度");
                dt.Columns.Add("名前");

                dt.Rows.Add(firstLine);

                while (!rd.EndOfStream)
                {
                    string[] data = rd.ReadLine().Split(',');
                    dt.Rows.Add(data);
                }

                // データグリッドビューにデータテーブルをバインド
                dataGridView1.DataSource = dt;

            }

        }

        private void returnTopButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
