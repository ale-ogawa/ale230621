using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using WindowsFormsApp1;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    //ログイン画面
    {
        public Form3()
        {
            InitializeComponent();
        }

        //戻る
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ログイン
        private void homeLoginButton_Click(object sender, EventArgs e)
        {
            //入力値チェック
            bool check = this.Check();
            if (check == false)
            {
                return;
            }

            //アカウント認証
            bool login = this.Login();
            if (login == false)
            {
                MessageBox.Show("ログインに失敗しました");
                return;
            }
            MessageBox.Show("ログインに成功しました");


            //画面遷移
            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }

        //入力値チェック
        private bool Check()
        {
            string str = "";
            int id, password;

            if (idTextBox.Text == "")
            {
                str += $"ユーザーIDが入力されていません\n";
            }
            if (idTextBox.Text != "" && (idTextBox.Text.Length != 8 || int.TryParse(idTextBox.Text, out id) == false))
            {
                str += $"ユーザーIDは半角数字8桁です\n";
            }
            if (passwordTextBox.Text == "")
            {
                str += $"パスワードが入力されていません\n";
            }
            if (passwordTextBox.Text != "" && (passwordTextBox.Text.Length != 4 || int.TryParse(passwordTextBox.Text, out password) == false))
            {
                str += $"パスワードは半角数字4桁です\n";
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

        //アカウント認証　成功した場合はログインアカウントのインスタンス生成
        private bool Login()
        {
            try
            {
                List<string> userList = File.ReadAllLines(@"C:\healthcare\userList.txt", Encoding.GetEncoding("utf-8")).ToList();
                foreach (string line in userList)
                {
                    string[] userInfo = line.Split(',');
                    if (userInfo[0] == idTextBox.Text && userInfo[1] == passwordTextBox.Text)
                    {
                        LoginAccount account = new LoginAccount(new User(userInfo[0], userInfo[1], userInfo[2], userInfo[3].ToCharArray()[0]));
                        return true;
                    }
                }
                return false;
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
            return true;
        }

    }
}
