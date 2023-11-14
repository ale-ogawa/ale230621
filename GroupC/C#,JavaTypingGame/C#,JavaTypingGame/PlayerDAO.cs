using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace C__JavaTypingGame
{
    //データベースにアクセスしてSQL文を投げるクラス
    internal class PlayerDAO
    {
        //コネクション
        private MySqlConnection Conn { get; set; }
        //トランザクション
        private MySqlTransaction transaction = null;

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
        public void PlayerRegistration(PlayerDTO player)
        {
            // SQL　INSERT文のフォーマット
            string sql = "INSERT INTO user_table(user_id, user_name, user_password)" +
                "VALUES(user_id, @user_name, @user_password)";

            //SQL文に値の代入
            Conn.Open();
            MySqlCommand mySql = new MySqlCommand(sql, Conn);
            mySql.Parameters.AddWithValue("user_id", DBNull.Value);

            //ユーザー名文字数判断
            if (PlayerDTO.Name.Length > 0 || PlayerDTO.Name.Length <= 10)
            {
                if (Exists(PlayerDTO.Name) == true)
                    throw new ArgumentException("このユーザー名は既に使われています");
                else mySql.Parameters.AddWithValue("@user_name", PlayerDTO.Name);

            }
            else throw new ArgumentException("ユーザー名は0文字以上10文字以内でお願いします");

            //パスワード文字数判断
            if (PlayerDTO.Pass.Length <= 0)
                throw new ArgumentException("パスワードが入力されていません");
            if (IsAlphanumeric(PlayerDTO.Pass))
            {
                if (PlayerDTO.Pass.Length >= 4 && PlayerDTO.Pass.Length <= 10)
                    mySql.Parameters.AddWithValue("@user_password", PlayerDTO.Pass);
                else throw new ArgumentException("パスワードは4文字以上10文字以下の文字数で設定してください");
            }
            else { throw new ArgumentException("パスワードに英数字以外が入力されています"); }

            //transactionの開始
            try
            {
                transaction = Conn.BeginTransaction();
                mySql.ExecuteNonQuery();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw new Exception("データベースに接続できません。\nsql文又はコネクション情報に誤りがある可能性があります。");
            }
            finally { Conn.Close(); }
            MessageBox.Show("登録しました");
        }
        /// <summary>
        /// ユーザーがDBに登録済みbool型で返す
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public bool PlayerLogin(PlayerDTO player)
        {
            bool check = false;

            //SQL SELECT文のフォーマット
            string sql = "SELECT * FROM USER_TABLE WHERE user_name=@user_name && user_password=@user_password";
            Conn.Open();

            //SQL文に値を入れる
            MySqlCommand com = new MySqlCommand(sql, Conn);
            com.Parameters.AddWithValue("@user_name", PlayerDTO.Name);
            com.Parameters.AddWithValue("@user_password", PlayerDTO.Pass);

            MySqlDataReader reader = com.ExecuteReader(); //コマンドの読み取り//

            //ユーザー情報が一致するデータがあればtrueを返す
            while (reader.Read())
            {
                check = true;
            }
            reader.Close();
            Conn.Close();
            return check;
        }
        /// <summary>
        /// スコアをDBへ登録
        /// </summary>
        /// <exception cref="ConstraintException"></exception>
        public void RunkingData()
        {
            try
            {
                //SQL INSERT文のフォーマット
                string sql = "INSERT INTO ranking_table(score_id, user_id, user_name, ranguage, user_score)" +
                    " VALUES (null, (select user_id from user_table where user_name=@user_name), @user_name, @ranguage, @user_score)";

                Conn.Open();
                MySqlCommand com = new MySqlCommand(sql, Conn);

                //各パラメータへの代入
                com.Parameters.AddWithValue("@user_name", PlayerDTO.Name);
                com.Parameters.AddWithValue("@ranguage", PlayerDTO.Lang);
                com.Parameters.AddWithValue("@user_score", PlayerDTO.score);

                //トランザクション
                transaction = Conn.BeginTransaction();
                com.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (MySqlException)
            {
                transaction.Rollback();
                throw new ConstraintException("データベースに接続できません。\nsql文又はコネクション情報に誤りがある可能性があります。");
            }
            catch (Exception e) { transaction.Rollback(); MessageBox.Show(e.Message); }
            finally { Conn.Close(); }
        }
        /// <summary>
        /// 英数字判別メソッド
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool IsAlphanumeric(string target)
        {
            return new Regex("^[0-9a-zA-Z]+$").IsMatch(target);
        }
        /// <summary>
        /// C#のランキングテーブルを取得
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ConstraintException"></exception>
        public DataTable DetaGetC()
        {
            try
            {
                DataTable dt = null;
                //SQL SELECT文フォーマット
                string sql = "SELECT user_name,user_score FROM ranking_table WHERE ranguage='C#' ORDER BY user_score DESC limit 10";
                Conn.Open();//コネクションを開ける
                MySqlCommand command = new MySqlCommand(sql, Conn);//作ったコネクションに対してのsql文
                MySqlDataReader reader = command.ExecuteReader(); //コマンドの読み取り//
                /*ここまでテンプレ*/

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string columnName = reader.GetName(i);
                        object columnValue = reader[i];
                        Debug.Write($"{columnName}:{columnValue}");
                    }
                    Debug.WriteLine("");
                }
                reader.Close();
                dt = new DataTable();

                //sql文と接続情報を指定し、データアダプタを作成
                MySqlDataAdapter da = new MySqlDataAdapter(sql, Conn);

                //データを取得
                da.Fill(dt);
                return dt;
            }
            catch (MySqlException)
            {
                throw new ConstraintException("データベースに接続できません。\nsql文又はコネクション情報に誤りがある可能性があります。");
            }
            catch (Exception e) { transaction.Rollback(); MessageBox.Show(e.Message); return null; }
            finally { Conn.Close(); }
        }
        /// <summary>
        /// Javaのランキングテーブル取得
        /// </summary>
        /// <returns></returns>
        public DataTable DetaGetJava()
        {
            DataTable dt = null;

            //SQL SELECT文フォーマット
            string sql = "SELECT user_name,user_score FROM ranking_table WHERE ranguage='Java' ORDER BY user_score DESC limit 10";

            Conn.Open();
            MySqlCommand command = new MySqlCommand(sql, Conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string columnName = reader.GetName(i);
                    object columnValue = reader[i];
                    Debug.Write($"{columnName}:{columnValue}");
                }
                Debug.WriteLine("");
            }
            reader.Close();
            Conn.Close();

            dt = new DataTable();
            //sql文と接続情報を指定し、データアダプタを作成
            MySqlDataAdapter da = new MySqlDataAdapter(sql, Conn);
            //データを取得
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// ユーザー名の重複チェック
        /// </summary>
        /// <param name="user_name"></param>
        /// <returns></returns>
        public bool Exists(string user_name)
        {
            bool check = false;
            //SQL SELECT文フォーマット
            string sql = "SELECT * FROM USER_TABLE WHERE user_name=@user_name";

            //SQL文に値を入れる
            MySqlCommand com = new MySqlCommand(sql, Conn);
            com.Parameters.AddWithValue("@user_name", user_name);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                check = true;
            }
            reader.Close();
            return check;

        }
    }
}
