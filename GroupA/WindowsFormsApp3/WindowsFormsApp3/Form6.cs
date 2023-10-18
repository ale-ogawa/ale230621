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
            if (exerciseComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("追加する項目が選択されていません");
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

                string path = @"C:\healthcare\week_exerciseRecord.txt";
                using (StreamWriter writer = new StreamWriter(path, true, Encoding.GetEncoding("utf-8")))
                {
                    writer.WriteLine(userId + "," + day + "," + exercise + "," + exerciseTime + "分," + energy + "kcal," + addTime);
                }
                this.Clear();
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
                string path = @"C:\healthcare\exerciseList.txt";
                List<string> exerciseList = File.ReadAllLines(path, Encoding.GetEncoding("utf-8")).ToList();
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

        private void Clear()
        {
            exerciseComboBox.SelectedIndex = -1;
            exerciseTimeTextBox.Text = string.Empty;
            weightTextBox.Text = string.Empty;
        }

    }
}
