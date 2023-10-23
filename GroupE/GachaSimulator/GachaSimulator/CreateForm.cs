using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

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
            MessageBox.Show("トップ画面に戻ります");

            Close();
        }

        private void readCsvButton_Click(object sender, EventArgs e)
        {
            try
            {
                TextFieldParser parser = new TextFieldParser(@"C:\gachacsv\gachasetting.csv", Encoding.GetEncoding("shift_jis"));
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

                MessageBox.Show("読み込みが完了しました");
            }
            catch (FileNotFoundException) 
            {
                MessageBox.Show("ファイルが存在しません");
            }
        }

        private void saveCsvButton_Click(object sender, EventArgs e)
        {
           
            try
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

                    MessageBox.Show("保存しました");

                }
            } catch(FileNotFoundException)
            {
                MessageBox.Show("ファイルが存在しません");
            }
        }

        //private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        //{
        //    // 対象のセルの行インデックスと列インデックスを取得します。
        //    var rowIndex = e.RowIndex;
        //    var columnIndex = e.ColumnIndex;

        //    // ヘッダ行またはヘッダ列の場合
        //    if ((rowIndex < 0) || (columnIndex < 0))
        //    {
        //        // 何もしません。
        //        return;
        //    }

        //    // 対象列ではない場合
        //    if ((columnIndex != 2) || (columnIndex != 3))
        //    {
        //        // 何もしません。
        //        return;
        //    }

        //    // 入力前の値を取得します。
        //    var dataGridView = (DataGridView)sender;
        //    var oldValue = dataGridView.Rows[rowIndex].Cells[columnIndex].Value.ToString();

        //    // 入力された値を取得します。
        //    var newValue = e.FormattedValue.ToString();

        //    // 値が変更されていない場合
        //    if (oldValue.Equals(newValue))
        //    {
        //        // 何もしない。
        //        return;
        //    }

        //    // 入力された値が整数ではない場合
        //    var nValue = 0;
        //    if (!int.TryParse(newValue, out nValue))
        //    {
        //        MessageBox.Show("正の正数を入力してください。");

        //        // 入力を無効にする。
        //        e.Cancel = true;
        //        return;
        //    }

        //    // 負の数の場合
        //    if (nValue < 0)
        //    {
        //        MessageBox.Show("正の正数を入力してください。");

        //        // 入力を無効にする。
        //        e.Cancel = true;
        //        return;
        //    }
        //}
    }
}
