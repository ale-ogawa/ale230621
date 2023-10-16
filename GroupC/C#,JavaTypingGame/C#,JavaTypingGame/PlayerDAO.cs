using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using ZstdSharp;

namespace C__JavaTypingGame
{
    internal class PlayerDAO
    {
        //コネクション
        private MySqlConnection Conn { get; set; }
        //トランザクション
        MySqlTransaction transaction = null;

        //コネクション情報
        private string ConnStr { get; } = "Server=192.168.1.133;Port=3306;Database=typing_game;Uid=groupC;Pwd=password;Charset=utf8;Pooling=true";

        public PlayerDAO()
        {
            Conn = new MySqlConnection(ConnStr);
            Debug.WriteLine("コネクション確立");
        }

        /// <summary>
        /// 新規登録メソッド
        /// </summary>
        /// <param name="player">ユーザー名,password</param>
        /// <returns>string</returns>
        
        //ここから　重複確認
        public void NameCheck(string name)
        {
            string sql = "INSERT INTO typing_game.user_table(user_id, book_id)" +
                " SELECT 5, 10, WHERE NOT EXISTS(SELECT user_id " +
                "FROM users_books WHERE user_id = 5 AND book_id = 10)";

        }
        public void PlayerRegistration(PlayerDTO player)
        {
            string result = null;
            try
            {
                //tableにユーザーを格納するsql
                string sql = "INSERT INTO typing_game.user_table(user_id, user_name, user_password)" +
                    "VALUES(user_id, @user_name, @user_password)";

                //sql分に値の代入
                Conn.Open();
                MySqlCommand mySql = new MySqlCommand(sql, Conn);
                mySql.Parameters.AddWithValue("user_id", DBNull.Value);
                //table内にユーザー名がかぶってないか判断

                mySql.Parameters.AddWithValue("@user_name", player.Name);

                //パスワード文字数判断
                if (MyMethod.IsAlphanumeric(player.Pass))
                {
                    if (player.Pass.Length >= 4 && player.Pass.Length <= 10)
                        mySql.Parameters.AddWithValue("@user_password", player.Pass);
                    else throw new ArgumentException("パスワードは4文字以上10文字以下の文字数で設定してください");
                }
                else { throw new ArgumentException("パスワードに英数字以外が入力されています"); }
                //transactionの開始
                transaction = Conn.BeginTransaction();
                int returnValue = mySql.ExecuteNonQuery();
                transaction.Commit();
                Conn.Close();

                //ログイン
                if (PlayerLogin(player) != false)
                {
                    result = "登録しました";
                    MessageBox.Show(result);
                }
                //else
                //{
                //    result = "このユーザー名は既に使用されています";
                //    MessageBox.Show(result);
                //}
            }
            catch (ArgumentException Aex)
            {
                MessageBox.Show(Aex.Message);
                transaction.Rollback();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                transaction.Rollback();
            }
        }
        public bool PlayerLogin(PlayerDTO player)
        {
            //sql文の用意
            string sql = "SELECT user_id,user_name,user_password FROM USER_TABLE WHERE user_name=@user_name && user_password=@user_password ;";


            MySqlDataAdapter da = null;
            Conn.Open();

            //sql文に値を入れる
            MySqlCommand com = new MySqlCommand(sql, Conn);
            com.Parameters.AddWithValue("@user_name", player.Name);
            com.Parameters.AddWithValue("@user_password", player.Pass);

            //プレイヤー名とパスワードの一致を確認
            da = new MySqlDataAdapter(sql, Conn);

            //一致していればtrue,していなければfalseを返す
            if (da != null) return true;
            else return false;
        }

        public void PlayerEntry(PlayerDTO player)
        {
            //sql文の用意
            string sql = "Insert into USER_TABLE values(null,@user_name,@user_password)";

            MySqlTransaction trn = null;
            try
            {
                Conn.Open();

                //sql文に値を入れる
                MySqlCommand com = new MySqlCommand(sql, Conn);
                com.Parameters.AddWithValue("@user_name", player.Name);
                com.Parameters.AddWithValue("@user_password", player.Pass);

                //トランザクションの開始
                trn = Conn.BeginTransaction();

                //実行
                com.ExecuteNonQuery();

                //確定               
                trn.Commit();
            }
            catch (Exception e) { trn.Rollback(); MessageBox.Show(e.Message); throw e; }
            finally { Conn.Close(); }
        }

        public void Runking()
        {

        }

    }
}
