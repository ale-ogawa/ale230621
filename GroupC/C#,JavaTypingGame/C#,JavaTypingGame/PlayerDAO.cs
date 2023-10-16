using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace C__JavaTypingGame
{
    internal class PlayerDAO
    {
        //コネクション
        private MySqlConnection Conn {  get; set; }

        //コネクション情報
        private string ConnStr { get; } = "Server=localhost;Port=3306;Database=typing_game;Uid=groupeC;Pwd=password;Charset=utf8;Pooling=true";

        public PlayerDAO()
        {
            Conn = new MySqlConnection(ConnStr);
            Debug.WriteLine("コネクション確立");
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
            com.Parameters.AddWithValue("@user_password",player.Pass);

            //プレイヤー名とパスワードの一致を確認
            da = new MySqlDataAdapter(sql, Conn);

            //一致していればtrue,していなければfalseを返す
            if(da != null) return true;
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
            catch (Exception e) { trn.Rollback(); MessageBox.Show(e.Message);throw e; }
            finally { Conn.Close(); }
        }

        public void Runking()
        {

        }
    }
}
