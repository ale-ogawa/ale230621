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
    //ログイン画面
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// タイトル画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {   
            ControlForm.CloseAndShow(this, typeof(Form1));
        }
        /// <summary>
        /// パスワードの目隠
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (passCheck.Checked)passText.PasswordChar = (char)0;
            else passText.PasswordChar = (char)1;
        }
        private void passText_TextChanged(object sender, EventArgs e)
        {
            passText.PasswordChar = '・';
        }
        /// <summary>
        /// ユーザーログイン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                //入力されたユーザー名とパスワードの一致をDBに確認
                PlayerDTO player = new PlayerDTO(userText.Text, passText.Text);
                PlayerDAO playerDAO = new PlayerDAO();
                bool check= playerDAO.PlayerLogin(player);

                //一致した場合
                if (check != false)
                {
                    MessageBox.Show("ログインしました");
                    
                    //ゲストプレイ時のスコアが残っていた場合
                    if(File.Exists(@"C:\GitRepos\ale230621\GroupC\C#,JavaTypingGame\プレイ記録\スコア.csv"))
                    {
                        DialogResult result = MessageBox.Show($"ゲストプレイ時のスコアが保存されています。スコアをランキングに登録しますか?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (result == DialogResult.Yes)
                        {
                            //保存されているスコアをDBに登録
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
                            //登録完了後ファイル削除
                            File.Delete(@"C:\GitRepos\ale230621\GroupC\C#,JavaTypingGame\プレイ記録\スコア.csv");
                        }
                    }

                    //画面遷移
                    ControlForm.CloseAndShow(this, typeof(languageSelectionForm));
                }
                //不一致の場合
                else MessageBox.Show("ログイン情報に誤りがあります");
            }
            catch (MySql.Data.MySqlClient.MySqlException) { MessageBox.Show("データベースに接続できません。\nコネクション情報に誤りがある可能性があります。"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void loginForm_Activated(object sender, EventArgs e)
        {
            //カーソル初期位置
            userText.Focus();
        }
    }
}
