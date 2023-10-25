using C__JavaTypingGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace typingGame
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 title = new Form1();
            title.ShowDialog();
            this.Close();
        }

        private void passCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (passCheck.Checked == true)
                passText.PasswordChar = (char)0;
            else if (passCheck.Checked == false)
                passText.PasswordChar = (char)1;
        }
        private void passText_TextChanged(object sender, EventArgs e)
        {
            passText.PasswordChar = '・';
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                //DBに確認
                PlayerDTO player = new PlayerDTO(userText.Text, passText.Text);
                PlayerDAO playerDAO = new PlayerDAO();
                bool check= playerDAO.PlayerLogin(player);
                if (check != false)
                {
                    MessageBox.Show("ログインしました");
                    
                    //ゲストプレイ時のスコアが残っていた場合
                    if(File.Exists(@"C:\GitRepos\ale230621\GroupC\C#,JavaTypingGame\プレイ記録\スコア.csv"))
                    {
                        DialogResult result = MessageBox.Show($"ゲストプレイ時のスコアが保存されています。スコアをランキングに登録しますか?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (result == DialogResult.Yes)
                        {
                            using (StreamReader sr = new StreamReader(@"C:\GitRepos\ale230621\GroupC\C#,JavaTypingGame\プレイ記録\スコア.csv"))
                            {
                                string line = null;
                                while((line = sr.ReadLine()) != null)
                                {
                                    PlayerDAO dao=new PlayerDAO();
                                    string[] lines = line.Split(',');
                                    PlayerDTO.Lang = lines[0];
                                    PlayerDTO.score = int.Parse(lines[1]);
                                    dao.RunkingData();
                                }
                                MessageBox.Show("スコアをランキングに登録しました");
                            }
                            File.Delete(@"C:\GitRepos\ale230621\GroupC\C#,JavaTypingGame\プレイ記録\スコア.csv");
                        }
                        PlayerDTO.Lang = null;
                        PlayerDTO.score = 0;
                        PlayerDTO.guest = null;
                    }

                    //画面遷移
                    this.Hide();
                    languageSelectionForm ls = new languageSelectionForm();
                    ls.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("ログイン情報に誤りがあります");
            }
            catch (MySql.Data.MySqlClient.MySqlException mysqlEX) { MessageBox.Show("データベースに接続できません。\nコネクション情報に誤りがある可能性があります。"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void loginForm_Activated(object sender, EventArgs e)
        {
            userText.Focus();
        }
    }
}
