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
                //入力値チェック
                bool check = this.Check();
                if (check == false)
                {
                    return;
                }

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
            //ファイルの存在確認
            string str = "";
            if (Directory.Exists(@"C:\healthcare") == false)
            {
                str += $"healthcareファイルが存在しません\n";
            }
            if (File.Exists(@"C:\healthcare\exerciseList.txt") == false)
            {
                str += $"exerciseListファイルが存在しません\n";
            }
            if (File.Exists(@"C:\healthcare\week_exerciseRecord.txt") == false)
            {
                str += $"exerciseRecord.txtファイルが存在しません\n";
            }
            if (str != "")
            {
                MessageBox.Show(str);
                this.Close();
                return;
            }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }

        private bool Check()
        {
            string str = "";
            if (exerciseComboBox.SelectedIndex < 0)
            {
                str += $"運動内容が選択されていません\n";
            }
            if (exerciseTimeTextBox.Text.Contains(",") || weightTextBox.Text.Contains(","))
            {
                str += $"「,」は使用不可です\n";
            }
            if (exerciseTimeTextBox.Text == "")
            {
                str += $"運動時間が入力されていません\n";
            }
            if (weightTextBox.Text == "")
            {
                str += $"体重が入力されていません\n";
            }
            if (exerciseTimeTextBox.Text != "" && (int.TryParse(exerciseTimeTextBox.Text, out int time) == false))
            {
                str += $"運動時間に数値以外を入力することはできません\n";
            }
            if (weightTextBox.Text != "" && (int.TryParse(weightTextBox.Text, out int weight) == false))
            {
                str += $"体重に数値以外を入力することはできません\n";
            }

            if (str != "")
            {
                MessageBox.Show(str);
                return false;
            }
            else
            {
                return true;
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
