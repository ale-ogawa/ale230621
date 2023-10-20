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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp3
{
    public partial class Form5 : Form
    //食事記録入力画面
    {
        public Form5()
        {
            InitializeComponent();
            mealChoiceRadioButton.Checked = true;
        }

        //戻る
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //食事の記録を追加する 
        private void addButton_Click(object sender, EventArgs e)
        {
            //選択で記録追加するとき
            if (mealChoiceRadioButton.Checked == true)
            {
                this.Choice();
            }
            //入力で記録追加するとき
            else
            {
                this.Input();
            }
        }

        //クリア
        private void clearButton_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        //食事内容を選択するラジオボタンをチェック
        private void choiceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mealChoiceRadioButton.Checked == true)
            {
                mealTextBox.Enabled = false;
                energyTextBox.Enabled = false;
            }
            else
            {
                mealTextBox.Enabled = true;
                energyTextBox.Enabled = true;
            }
        }

        //食事内容を入力するラジオボタンをチェック
        private void inputRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mealInputRadioButton.Checked == true)
            {
                mealChoiceRadioButton.Enabled = true;
                mealComboBox.Enabled = false;
            }
            else
            {
                mealChoiceRadioButton.Enabled = true;
                mealComboBox.Enabled = true;
            }
        }

        //選択で記録追加する場合
        private void Choice()
        {
            try
            {
                if (mealComboBox.SelectedIndex < 0)
                {
                    MessageBox.Show("食事内容が選択されていません");
                }
                else
                {
                    int index = mealComboBox.SelectedIndex;
                    List<string> mealList = File.ReadAllLines(@"C:\healthcare\mealList.txt", Encoding.GetEncoding("utf-8")).ToList();
                    string[] selectedMeal = mealList[index].Split(',');

                    string userId = LoginAccount.UserId;
                    string day = DateTime.Now.ToString("MM/dd");
                    string meal = selectedMeal[0];
                    string energy = selectedMeal[1];
                    string addTime = DateTime.Now.ToString("HH:mm");

                    using (StreamWriter writer = new StreamWriter(@"C:\healthcare\week_mealRecord.txt", true, Encoding.GetEncoding("utf-8")))
                    {
                        writer.WriteLine(userId + "," + day + "," + meal + "," + energy + "," + addTime);
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

        //入力で記録追加する場合
        private void Input()
        {
            try
            {
                //入力値チェック
                bool check = this.Check();
                if (check == false)
                {
                    return;
                }

                string userId = LoginAccount.UserId;
                string day = DateTime.Now.ToString("MM/dd");
                string meal = mealTextBox.Text;
                string energy = energyTextBox.Text;
                string addTime = DateTime.Now.ToString("HH:mm");
                using (StreamWriter writer = new StreamWriter(@"C:\healthcare\week_mealRecord.txt", true, Encoding.GetEncoding("utf-8")))
                {
                    writer.WriteLine(userId + "," + day + "," + meal + "," + energy + "kcal," + addTime);
                }
                this.Clear();
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

        private void Form5_Load(object sender, EventArgs e)
        {
            //コンボボックスへの要素格納
            try
            {
                using (StreamReader reader = new StreamReader(@"C:\healthcare\mealList.txt", Encoding.GetEncoding("utf-8")))
                {
                    while (reader.Peek() >= 0)
                    {
                        mealComboBox.Items.Add(reader.ReadLine());
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

        //入力された項目のクリア
        private void Clear()
        {
            mealComboBox.SelectedIndex = -1;
            mealTextBox.Text = string.Empty;
            energyTextBox.Text = string.Empty;
        }

        private bool Check()
        {
            string str = "";
            if (energyTextBox.Text.Contains(",") || mealTextBox.Text.Contains(","))
            {
                str += $"「,」は使用不可です\n";
            }
            if (mealTextBox.Text == "")
            {
                str += $"食事内容が入力されていません\n";
            }
            if (energyTextBox.Text == "")
            {
                str += $"摂取カロリーが入力されていません";
            }
            if (energyTextBox.Text != "" && (int.TryParse(energyTextBox.Text, out int kcal) == false))
            {
                str += $"摂取カロリーに数値以外を入力することはできません\n";
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

    }
}
