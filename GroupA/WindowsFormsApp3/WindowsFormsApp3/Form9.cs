using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp3
{
    public partial class Form9 : Form
    //1週間の食事履歴画面
    {
        string path = @"C:\healthcare\week_mealRecord.txt";
        string day1 = DateTime.Now.ToString("MM/dd");
        string day2 = DateTime.Now.AddDays(-1).ToString("MM/dd");
        string day3 = DateTime.Now.AddDays(-2).ToString("MM/dd");
        string day4 = DateTime.Now.AddDays(-3).ToString("MM/dd");
        string day5 = DateTime.Now.AddDays(-4).ToString("MM/dd");
        string day6 = DateTime.Now.AddDays(-5).ToString("MM/dd");
        string day7 = DateTime.Now.AddDays(-6).ToString("MM/dd");

        public Form9()
        {
            InitializeComponent();
        }

        //戻る
        private void returnHomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form8 form8 = new Form8();
            form8.Show();
        }

        //削除
        private void deleteButton_Click(object sender, EventArgs e)
        {
            //削除確認ダイアログ表示
            DialogResult result = MessageBox.Show("選択されている行を削除しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("キャンセルしました");
                return;
            }
            else
            {
                try
                {
                    string day = mealDataGridView.CurrentRow.Cells[0].Value.ToString();
                    string meal = mealDataGridView.CurrentRow.Cells[1].Value.ToString();
                    string energy = mealDataGridView.CurrentRow.Cells[2].Value.ToString();
                    string addTime = mealDataGridView.CurrentRow.Cells[3].Value.ToString();
                    List<string> updateList = File.ReadAllLines(path).ToList();
                    updateList.Remove(LoginAccount.UserId + "," + day + "," + meal + "," + energy + "," + addTime);
                    File.WriteAllLines(path, updateList);
                    int index = this.mealDataGridView.CurrentCell.RowIndex;
                    mealDataGridView.Rows.RemoveAt(index);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("ファイルが存在しません");
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                }
            }
        }

        //Form9ロード時最初に実行されるメソッド
        private void Form9_Load(object sender, EventArgs e)
        {
            //データグリッドビューの項目設定
            mealDataGridView.ColumnCount = 4;
            mealDataGridView.Columns[0].HeaderText = "日付";
            mealDataGridView.Columns[1].HeaderText = "食事内容";
            mealDataGridView.Columns[2].HeaderText = "摂取カロリー";
            mealDataGridView.Columns[3].HeaderText = "登録時刻";
            try
            {
                //ファイルから読み込んだ内容をデータグリッドビューに表示
                using (StreamReader reader = new StreamReader(path, Encoding.GetEncoding("utf-8")))
                {
                    while (reader.Peek() >= 0)
                    {
                        string[] record = reader.ReadLine().Split(',');
                        if (record[0] == LoginAccount.UserId && ((record[1] == day1) || (record[1] == day2) || (record[1] == day3) || (record[1] == day4) || (record[1] == day5) || (record[1] == day6) || (record[1] == day7)))
                        {
                            mealDataGridView.Rows.Add(record[1], record[2], record[3], record[4]);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("ファイルが存在しません");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }
    }
}
