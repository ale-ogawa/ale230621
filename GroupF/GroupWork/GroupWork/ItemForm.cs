using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupWork
{
	public partial class ItemForm : Form
	{
		//食材情報リスト
		private List<Item> ingredientList = new List<Item>();
		//メニュー情報リスト
		private List<System.Windows.Forms.Menu> menuList = new List<System.Windows.Forms.Menu>();


		private string connStr = "Server =localhost; Port=3306; Database=menusuggestions; Uid=root; Pwd=root; Charset=utf8";
		private MySqlConnection conn = new MySqlConnection();


		public ItemForm()
		{
			InitializeComponent();

			itmLabel.Font = new Font("Arial", 10, FontStyle.Bold);
			dateLabel.Font = new Font("Arial", 10, FontStyle.Bold);
			itemBoxLabel.Font = new Font("Arial", 10, FontStyle.Bold);
			sortLabel.Font = new Font("Arial", 10, FontStyle.Bold);


			backButton.Font = new Font("Arial", 10, FontStyle.Bold);
			itemAddButton.Font = new Font("Arial", 10, FontStyle.Bold);
			itemUpdateButton.Font = new Font("Arial", 10, FontStyle.Bold);
			itemSortButton.Font = new Font("Arial", 10, FontStyle.Bold);
			selectMenuButton.Font = new Font("Arial", 10, FontStyle.Bold);
			deleteButton.Font = new Font("Arial", 10, FontStyle.Bold);
		}

		private void itemMenu()
		{
			//SQLクエリを作成
			string query =
				"SELECT ite_name FROM menusuggestions.item";

			//データベース接続を作成
			using (conn = new MySqlConnection(connStr))
			{
				//SQLクエリ実行準備
				MySqlCommand cmd = new MySqlCommand(query, conn);

				//データベース接続を開く
				conn.Open();

				//SQLクエリを実行、データを取得
				MySqlDataReader reader = cmd.ExecuteReader();

				//コンボボックスにデータを追加
				while (reader.Read())
				{
					itemComboBox.Items.Add(reader["ite_name"].ToString());
				}

				//データベースを閉じる
				reader.Close();
				conn.Close();
			}
		}

		public void saveFood(string foodName, DateTime expDate)
		{
			string query = "INSERT INTO menusuggestions.item(ite_name,ite_time) VALUES(@foodName,@expDate)";

			MySqlCommand cmd = new MySqlCommand(query, conn);
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


		private void backButton_Click(object sender, EventArgs e)
		{
			HomeForm hm = new HomeForm();
			hm.StartPosition = FormStartPosition.Manual;
			hm.Location = this.Location;
			hm.FormClosing += (s, args) => this.Show();
			hm.Show();
			this.Hide();
		}

		private void itemSortButton_Click(object sender, EventArgs e)
		{

		}

		private void ItemForm_Load(object sender, EventArgs e)
		{
			itemMenu();
			GetNewIngCB();
		}

		private void itemAddButton_Click(object sender, EventArgs e)
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


		private void deleteButton_Click(object sender, EventArgs e)
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
	}
}
