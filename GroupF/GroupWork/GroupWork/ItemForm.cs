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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace GroupWork
{
	public partial class ItemForm : Form
	{

		private MySqlConnection connection;
		private MySqlCommand command;
		private string server;
		private string database;
		private string uid;
		private string password;
		private int port;
		private string charset;

		//食材情報リスト
		private List<Item> ingredientList = new List<Item>();
		//メニュー情報リスト
		private List<System.Windows.Forms.Menu> menuList = new List<System.Windows.Forms.Menu>();

        private MySqlConnection conn = null;


        //private string connStr = "Server =localhost; Port=3306; Database=menusuggestions; Uid=root; Pwd=root; Charset=utf8";
        //private MySqlConnection conn = new MySqlConnection();

        public ItemForm()
		{
			InitializeComponent();

			InitializeDatabaseConnection();
			LoadIngredients();


			backButton.Font = new Font("Arial", 10, FontStyle.Bold);
			itmLabel.Font = new Font("Arial", 10, FontStyle.Bold);
			dateLabel.Font = new Font("Arial", 10, FontStyle.Bold);
			itemBoxLabel.Font = new Font("Arial", 10, FontStyle.Bold);
			sortLabel.Font = new Font("Arial", 10, FontStyle.Bold);
			itemRegisterButton.Font = new Font("Arial", 10, FontStyle.Bold);
			itemUpdateButton.Font = new Font("Arial", 10, FontStyle.Bold);
			menuChoiceButton.Font = new Font("Arial", 10, FontStyle.Bold);
			itemDeleteButton.Font = new Font("Arial", 10, FontStyle.Bold);
			menuShowButton.Font = new Font("Arial", 10, FontStyle.Bold);


            //
            //コネクションの確立
            try
            {
                conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString);

            }
            catch (MySqlException me)
            {
                MessageBox.Show(me.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void LoadIngredients()
		{
			//try
			//{
			//	connection.Open();
			//	string query = "SELECT ite_name FROM menusuggestions.item";
			//	command = new MySqlCommand(query, connection);
			//	MySqlDataReader reader = command.ExecuteReader();

			//	while (reader.Read())
			//	{
			//		itemComboBox.Items.Add(reader["ite_name"].ToString());
			//	}

			//	reader.Close();
			//	connection.Close();
			//}
			//catch (MySqlException ex)
			//{
			//	MessageBox.Show($"Error: {ex.Message}");
			//}
		}

		private void InitializeDatabaseConnection()
		{
			//server = "localhost";
			//database = "menusuggestions";
			//uid = "root";
			//password = "root";
			//port = 3306;
			//charset = "utf8";

			//string connectionString = $"SERVER={server};PORT={port};DATABASE={database};UID={uid};PASSWORD={password};CHARSET={charset}";
			//connection = new MySqlConnection(connectionString);
		}

		private void itemMenu()
		{
			////SQLクエリを作成
			//string query =
			//	"SELECT ite_name FROM menusuggestions.item";

			////データベース接続を作成
			//using (conn = new MySqlConnection(conn))
			//{
			//	//SQLクエリ実行準備
			//	MySqlCommand cmd = new MySqlCommand(query, conn);

			//	//データベース接続を開く
			//	conn.Open();

			//	//SQLクエリを実行、データを取得
			//	MySqlDataReader reader = cmd.ExecuteReader();

			//	//コンボボックスにデータを追加
			//	while (reader.Read())
			//	{
			//		itemComboBox.Items.Add(reader["ite_name"].ToString());
			//	}

			//	//データベースを閉じる
			//	reader.Close();
			//	conn.Close();
			//}
		}



		public void saveFood(string foodName,DateTime expDate)
		{
			string query = "INSERT INTO menusuggestions.item(ite_name,ite_time) VALUES(@foodName,@expDate)";

			MySqlCommand cmd = new MySqlCommand(query,conn);
			cmd.Parameters.AddWithValue("@foodName", foodName);
			cmd.Parameters.AddWithValue("@expDate", expDate);

			try
			{
				conn.Open();
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show("入力エラー");
			}
			finally
			{
				Console.WriteLine();
			}
		}


		private void ItemForm_Load_1(object sender, EventArgs e)
		{
			//itemMenu();
			//GetNewIngCB();
		}

		private void itemRegisterButton_Click(object sender, EventArgs e)
		{

			//確認メッセージを表示
			DialogResult result = MessageBox.Show("食材を追加しますか?",
				"確認",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question);

			if (result == DialogResult.OK)  //OKのときの処理
			{
				InsertIngredient();
				//GetNewIngCB();    //更新機能は更新ボタンで行う場合
				MessageBox.Show("追加しました");
			}
			else if (result == DialogResult.Cancel)   //キャンセルの時の処理
			{
				MessageBox.Show("キャンセルしました");
			}
		}

		private void InsertIngredient()
		{
            //MySqlTransaction transaction = null;
            //if (conn == null)
            //{
            //	return; // コネクションが無効な場合は何もせずに終了
            //}

            //string sql = "INSERT INTO Item(ite_name, ite_date) VALUES (@ite_name, @ite_date)";
            //string itemName = itemNameTextBox.Text;
            //string itemDate = dateTextBox.Text;

            //try
            //{
            //	conn.Open();
            //	MySqlCommand cmd = new MySqlCommand(sql, conn);
            //	cmd.Parameters.AddWithValue("@ite_name", itemName);
            //	cmd.Parameters.AddWithValue("@ite_date", itemDate);
            //	transaction = conn.BeginTransaction();
            //	cmd.ExecuteNonQuery();
            //	transaction.Commit();
            //}
            //catch (MySqlException me)
            //{
            //	MessageBox.Show(me.Message);
            //	transaction?.Rollback();
            //	throw;
            //}
            //catch (Exception ex)
            //{
            //	MessageBox.Show(ex.Message);
            //	conn?.Close();
            //}
            //finally
            //{
            //	conn.Close();
            //}


            MySqlTransaction transaction = null;
            if (conn == null)
            {
                return; // コネクションが無効な場合は何もせずに終了
            }

            string sql = "INSERT INTO Item(ite_name, ite_date) VALUES (@ite_name, @ite_date)";
            string itemName = itemNameTextBox.Text;
            string itemDate = dateTextBox.Text;

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ite_name", itemName);
                cmd.Parameters.AddWithValue("@ite_date", itemDate);
                transaction = conn.BeginTransaction();
                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (MySqlException me)
            {
                MessageBox.Show(me.Message);
                transaction?.Rollback();
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn?.Close();
            }
            finally
            {
                conn.Close();
            }



        }

		private void itemUpdateButton_Click(object sender, EventArgs e)
		{
			GetNewIngCB();
			MessageBox.Show("更新しました");
		}

		private void GetNewIngCB()
		{
			//現在の食材一覧のリストを削除する
			itemComboBox.DataSource = null;
			itemComboBox.Items.Clear();
			ingredientList.Clear();

			GetIngredientName();

			itemComboBox.DataSource = ingredientList;

			itemComboBox.DisplayMember = "ItemInfo"; // 食材クラスの表示プロパティ名
			itemComboBox.ValueMember = "ItemId"; // 食材クラスの値プロパティ名
		}

		private void GetIngredientName()
		{
			//MySQLに接続
			conn.Open();

			//MySQLから食材情報を抽出しリストに格納する
			string sql = "SELECT ite_number,ite_name,ite_date FROM Item;";

			MySqlCommand command = new MySqlCommand(sql, conn);
			MySqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				//食材ID、食材名、賞味期限をコンストラクタに引数で渡す
				ingredientList.Add(new Item(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2)));
			}
			reader.Close();

			//MySQLの接続を解除
			conn.Close();
		}

		private void menuChoiceButton_Click(object sender, EventArgs e)
		{
			if (itemComboBox.SelectedItem != null)
			{
				try
				{
					connection.Open();
					string selectedIngredient = itemComboBox.SelectedItem.ToString();
					string query = $"SELECT men_name FROM menusuggestions.menu WHERE men_item LIKE '%{selectedIngredient}%'";
					command = new MySqlCommand(query, connection);

					MySqlDataReader reader = command.ExecuteReader();
					List<string> menuList = new List<string>();

					while (reader.Read())
					{
						menuList.Add(reader["men_name"].ToString());
					}

					reader.Close();
					connection.Close();

					menuChoice.DataSource = menuList;

					MessageBox.Show($"{menuChoice.Items.Count}件表示します。");
				}
				catch (MySqlException ex)
				{
					MessageBox.Show($"Error: {ex.Message}");
				}
			}
			else
			{
				MessageBox.Show("食材をを選択してください。");
			}
		}
			private void GetNewMenuCB()
		{
			//現在のメニュー一覧のリストを削除する
			menuChoice.DataSource = null;
			menuChoice.Items.Clear();
			menuList.Clear();

			GetNewMenuName();
			menuChoice.DataSource = menuList;

			menuChoice.DisplayMember = "MenuName"; // メニュークラスの表示プロパティ名
			menuChoice.ValueMember = "MenuId"; // メニュークラスの値プロパティ名

		}

		private void GetNewMenuName()
		{
			Item ingName = (Item)itemComboBox.SelectedItem;

			//MySQLに接続
			conn.Open();

			//MySQLからメニュー名を抽出しリストに格納する
			string sql = "SELECT men_number,men_name FROM Menu WHERE men_item LIKE @men_item";

			MySqlCommand command = new MySqlCommand(sql, conn);
			command.Parameters.AddWithValue("@men_item", "%" + ingName.ItemName + "%");
			MySqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				//menuList.Add(new Menu(reader.GetInt32(0), reader.GetString(1)));
			}
			reader.Close();

			//MySQLの接続を解除
			conn.Close();
		}

		private void menuShowButton_Click(object sender, EventArgs e)
		{
			if (menuChoice.SelectedItem != null)
			{
				string selectMenu = menuChoice.SelectedItem.ToString();

				RecipeForm rf = new RecipeForm(selectMenu);
				rf.StartPosition = FormStartPosition.Manual;
				rf.Location = this.Location;
				rf.FormClosing += (s, args) => this.Show();
				rf.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("メニューを選択してください。");
			}
		}

		private void itemDeleteButton_Click(object sender, EventArgs e)
		{
			//確認メッセージを表示
			DialogResult result = MessageBox.Show("食材を削除すると元に戻せません。食材を削除しますか?",
				"確認",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Warning);

			if (result == DialogResult.OK)  //OKのときの処理
			{
				RemoveIngredient();
				//GetNewIngCB();
				MessageBox.Show("削除しました");
			}
			else if (result == DialogResult.Cancel)   //キャンセルの時の処理
			{
				MessageBox.Show("キャンセルしました");
			}
			}
		private void RemoveIngredient()
		{
			MySqlTransaction transaction = null;
			if (conn == null)
			{
				return; // コネクションが無効な場合は何もせずに終了
			}

			string sql = "DELETE FROM Item WHERE ite_number = @ite_number";
			int iteNum = ingredientList[itemComboBox.SelectedIndex].ItemId;

			try
			{
				conn.Open();
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@ite_number", iteNum);
				transaction = conn.BeginTransaction();
				cmd.ExecuteNonQuery();
				transaction.Commit();
			}
			catch (MySqlException me)
			{
				MessageBox.Show(me.Message);
				transaction?.Rollback();
				throw;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				conn?.Close();
			}
			finally
			{
				conn.Close();
			}
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			HomeForm mf = new HomeForm();
			mf.StartPosition = FormStartPosition.Manual;
			mf.Location = this.Location;
			mf.FormClosing += (s, args) => this.Show();
			mf.Show();
			this.Hide();
		}

		
	}
	
}
