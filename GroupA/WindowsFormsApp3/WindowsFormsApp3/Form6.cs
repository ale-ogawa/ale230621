using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp3
{
    public partial class Form6 : Form
        //運動記録入力画面
    {
        public Form6()
        {
            InitializeComponent();
        }

        //戻る
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //運動記録を追加する
        private void exerciseRecordAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                //運動内容が選択されていない場合
                if (exerciseComboBox.SelectedIndex < 0)
                {
                    MessageBox.Show("追加する項目が選択されていません");
                }
                //入力内容に「,」が含まれている場合
                else if(exerciseTimeTextBox.Text.Contains(",") || weightTextBox.Text.Contains(","))
                {
                    MessageBox.Show(",は使用しないでください");
                }
                //運動時間、体重に入力がされていない場合
                else if (exerciseTimeTextBox.Text == "" || weightTextBox.Text == "")
                {
                    MessageBox.Show("入力されていない項目が存在します");
                }
                //運動時間、体重に数値以外が入力されていない場合
                else if((int.TryParse(exerciseTimeTextBox.Text, out int time) == false) || (int.TryParse(weightTextBox.Text, out int weight) == false))
                {
                    MessageBox.Show("数値以外を入力することはできません");
                }
                else
                {
                    int index = exerciseComboBox.SelectedIndex;
                    List<string> mealList = File.ReadAllLines(@"C:\healthcare\exerciseList.txt", Encoding.GetEncoding("utf-8")).ToList();
                    string[] selectedExercise = mealList[index].Split(',');

                    string userId = LoginAccount.UserId;
                    string day = DateTime.Now.ToString("MM/dd");
                    string exercise = selectedExercise[0];
                    string exerciseTime = exerciseTimeTextBox.Text;
                    //消費カロリーの計算　METs×時間×体重(kg)×1.05
                    double energyCalc = double.Parse(selectedExercise[1]) * (double.Parse(exerciseTimeTextBox.Text) / 60) * int.Parse(weightTextBox.Text) * 1.05;
                    double energy = Math.Floor(energyCalc);
                    string addTime = DateTime.Now.ToString("HH:mm");

                    using (StreamWriter writer = new StreamWriter(@"C:\healthcare\week_exerciseRecord.txt", true, Encoding.GetEncoding("utf-8")))
                    {
                        writer.WriteLine(userId + "," + day + "," + exercise + "," + exerciseTime + "分," + energy + "kcal," + addTime);
                    }
                    this.Clear();
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

        //クリア
        private void clearButton_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //コンボボックスへの要素格納
            try
            {
                List<string> exerciseList = File.ReadAllLines(@"C:\healthcare\exerciseList.txt", Encoding.GetEncoding("utf-8")).ToList();
                foreach (var n in exerciseList)
                {
                    string[] list = n.Split(',');
                    exerciseComboBox.Items.Add(list[0]);
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

        private void Clear()
        {
            exerciseComboBox.SelectedIndex = -1;
            exerciseTimeTextBox.Text = string.Empty;
            weightTextBox.Text = string.Empty;
        }
    }
}
