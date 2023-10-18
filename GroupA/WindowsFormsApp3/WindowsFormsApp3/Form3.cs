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
            if ((idTextBox.Text == "") || (passwordTextBox.Text == "") || (idTextBox.Text.Length != 8) || (passwordTextBox.Text.Length != 4))
            {
                MessageBox.Show("入力されている内容に誤りがあります");
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
            List<string> userList = File.ReadAllLines(@"C:\healthcare\userList.txt", Encoding.GetEncoding("utf-8")).ToList();
            foreach (string line in userList)
            {
                string[] userInfo = line.Split(',');
                if (userInfo[0] == idTextBox.Text && userInfo[1] == passwordTextBox.Text)
                {
                    LoginAccount account = new LoginAccount(new User(userInfo[0], userInfo[1], userInfo[2], userInfo[3]));
                    return true;
                }
            }
            return false;
        }

    }
}
