﻿using System;
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

        public void PlayerRegistration(PlayerDTO player)
        {
            //tableにユーザーを格納するsql
            string sql = "INSERT INTO user_table(user_id, user_name, user_password)" +
                "VALUES(user_id, @user_name, @user_password)";

            //sql分に値の代入
            Conn.Open();
            MySqlCommand mySql = new MySqlCommand(sql, Conn);
            mySql.Parameters.AddWithValue("user_id", DBNull.Value);

            if (PlayerDTO.Name.Length <= 0 && PlayerDTO.Name.Length > 10)
                throw new ArgumentException("ユーザー名は0文字以上10文字以内でお願いします");
            mySql.Parameters.AddWithValue("@user_name", PlayerDTO.Name);

            //パスワード文字数判断
            if (IsAlphanumeric(PlayerDTO.Pass))
            {
                if (PlayerDTO.Pass.Length<=0&&PlayerDTO.Pass.Length >= 4 && PlayerDTO.Pass.Length <= 10)
                    mySql.Parameters.AddWithValue("@user_password", PlayerDTO.Pass);
                else throw new ArgumentException("パスワードは4文字以上10文字以下の文字数で設定してください");
            }
            else { throw new ArgumentException("パスワードに英数字以外が入力されています"); }
            //transactionの開始
            transaction = Conn.BeginTransaction();
            mySql.ExecuteNonQuery();
            transaction.Commit();
            Conn.Close();

            //ログイン
            if (PlayerLogin(player) != false)
            {
                MessageBox.Show("登録しました");
            }
        }
        public bool PlayerLogin(PlayerDTO player)
        {
            bool check=false;
            //sql文の用意
            string sql = "SELECT * FROM USER_TABLE WHERE user_name=@user_name && user_password=@user_password";
            Conn.Open();

            //sql文に値を入れる
            MySqlCommand com = new MySqlCommand(sql, Conn);
            com.Parameters.AddWithValue("@user_name", PlayerDTO.Name);
            com.Parameters.AddWithValue("@user_password", PlayerDTO.Pass);

            MySqlDataReader reader = com.ExecuteReader(); //コマンドの読み取り//

            while (reader.Read())
            {
                check= true;
            }
            reader.Close();
            return check;
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
                com.Parameters.AddWithValue("@user_name", PlayerDTO.Name);
                com.Parameters.AddWithValue("@user_password", PlayerDTO.Pass);

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

        public void RunkingData()
        {
            try
            {
                string sql = "INSERT INTO ranking_table(score_id, user_id, user_name, ranguage, user_score)" +
                    " VALUES (null, (select user_id from user_table where user_name=@user_name), @user_name, @ranguage, @user_score)";

                Conn.Open();
                MySqlCommand com = new MySqlCommand(sql, Conn);
                com.Parameters.AddWithValue("@user_name", PlayerDTO.Name);
                com.Parameters.AddWithValue("@ranguage", PlayerDTO.Lang);
                com.Parameters.AddWithValue("@user_score", PlayerDTO.score);

                transaction = Conn.BeginTransaction();
                com.ExecuteNonQuery();
                transaction.Commit();
            }catch (Exception e) { transaction.Rollback(); MessageBox.Show(e.Message);}
            finally { Conn.Close(); }
        }
        public static bool IsAlphanumeric(string target)
        {
            return new Regex("^[0-9a-zA-Z]+$").IsMatch(target);
        }
        public DataTable DetaGetC()
        {
            DataTable dt = null;
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
                Conn.Close();//コネクションを閉める

                dt = new DataTable();
                //sql文と接続情報を指定し、データアダプタを作成
                MySqlDataAdapter da = new MySqlDataAdapter(sql, Conn);
                //データを取得
                da.Fill(dt);
            return dt;
        }
        public DataTable DetaGetJava()
        {
            DataTable dt = null;
            string sql = "SELECT user_name,user_score FROM ranking_table WHERE ranguage='Java' ORDER BY user_score DESC limit 10";
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
            Conn.Close();//コネクションを閉める

            dt = new DataTable();
            //sql文と接続情報を指定し、データアダプタを作成
            MySqlDataAdapter da = new MySqlDataAdapter(sql, Conn);
            //データを取得
            da.Fill(dt);
            return dt;
        }
    }
}
