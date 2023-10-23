using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace GachaSimulator
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }


        private void returnTopButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void readCsvButton_Click(object sender, EventArgs e)
        {
            TextFieldParser parser = new TextFieldParser(@"C:\gachacsv\gachasetting.csv", Encoding.GetEncoding("Shift_JIS"));
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(","); // 区切り文字はコンマ

            // データをすべてクリア
            dataGridView1.Rows.Clear();

            while (!parser.EndOfData)
            {
                string[] row = parser.ReadFields(); // 1行読み込み
                // 読み込んだデータ(1行をDataGridViewに表示する)
                dataGridView1.Rows.Add(row);
            }
        }

        private void saveCsvButton_Click(object sender, EventArgs e)
        {
            // 保存用のファイルを開く
            using (StreamWriter writer = new StreamWriter(@"C:\gachacsv\gachasetting.csv", false, Encoding.GetEncoding("shift_jis")))
            {

                dataGridView1.AllowUserToAddRows = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value == null)
                    {
                        dataGridView1.Rows.RemoveAt(row.Index);
                    }
                }

                int rowCount = dataGridView1.Rows.Count;

                // ユーザによる行追加が許可されている場合は、最後の新規入力用の
                // 1行分を差し引く
                if (dataGridView1.AllowUserToAddRows == true)
                {
                    rowCount = rowCount - 1;
                }

                // 行
                for (int i = 0; i < rowCount; i++)
                {
                    // リストの初期化
                    List<String> strList = new List<String>();

                    // 列
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        strList.Add(dataGridView1[j, i].Value.ToString());
                    }
                    String[] strArray = strList.ToArray(); // 配列へ変換

                    // CSV 形式に変換
                    String strCsvData = String.Join(",", strArray);

                    writer.WriteLine(strCsvData);
                }

                dataGridView1.AllowUserToAddRows = true;

            }
        }
    }
}
