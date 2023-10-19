using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.IO;
using WindowsFormsApp1;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
        //新規登録画面
    {
        public Form2()
        {
            InitializeComponent();
            mRadioButton.Checked = true;
        }

        //戻る
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //登録
        private void registerButton_Click(object sender, EventArgs e)
        {
                //入力値チェック
                bool tcheck = this.TextCheck();
                if (tcheck == false)
                {
                    return;
                }
                //アカウント重複チェック
                bool dcheck = this.DuplicateCheck();
                if (dcheck == false)
                {
                    MessageBox.Show($"このユーザーIDは既に登録されています");
                    return;
                }
                //登録確認ダイアログボックスの表示
                DialogResult result = MessageBox.Show("新規ユーザーを登録しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("キャンセルしました");
                    return;
                }
                //入力された項目にてuserListファイルに追加
                string gender = mRadioButton.Checked == true ? "男" : "女";
                User user = new User(idTextBox.Text, passwordTextBox.Text, birthdayTextBox.Text, gender);
                user.UserAdd(user);
                //入力されていた項目の削除
                this.Clear();
                //ログイン画面へ遷移
                this.Close();
                Form3 form3 = new Form3();
                form3.Show();
        }

        //入力値チェック
        private bool TextCheck()
        {
            int id, password, birthday;
            if(idTextBox.Text == "" || passwordTextBox.Text == "" || birthdayTextBox.Text == "")
            {
                MessageBox.Show("入力されていない項目が存在します");
            }
            if (idTextBox.Text.Length != 8 || int.TryParse(idTextBox.Text, out id) == false)
            {
                MessageBox.Show("設定条件を満たしていない項目があります");
                return false;
            }
            else if (passwordTextBox.Text.Length != 4 || int.TryParse(passwordTextBox.Text, out password) == false)
            {
                MessageBox.Show("設定条件を満たしていない項目があります");
                return false;
            }
            else if (birthdayTextBox.Text.Length != 8 || int.TryParse(birthdayTextBox.Text, out birthday) == false)
            {
                MessageBox.Show("設定条件を満たしていない項目があります");
                return false;
            }
            else
            {
                return true;
            }
        }

        //アカウント重複チェック
        private bool DuplicateCheck()
        {
            try
            {
                List<string> userList = File.ReadAllLines(@"C:\healthcare\userList.txt", Encoding.GetEncoding("utf-8")).ToList();
                foreach (string line in userList)
                {
                    string[] userInfo = line.Split(',');
                    if (userInfo[0] == idTextBox.Text)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("ファイルが存在しません");
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
            return true;
        }

        //入力項目のクリア
        private void Clear()
        {
            idTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            birthdayTextBox.Text = string.Empty;
        }

    }
}
