using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GroupWork
{
	public partial class MenuForm : Form
	{
		private string connStr = "Server =localhost; Port=3306; Database=menusuggestions; Uid=root; Pwd=root; Charset=utf8";

		public MenuForm()
		{
			InitializeComponent();

			backButton.Font = new Font("Arial", 10, FontStyle.Bold);
			updateButton.Font = new Font("Arial", 10, FontStyle.Bold);
			recipeButton.Font = new Font("Arial", 10, FontStyle.Bold);
			addUpdateButton.Font = new Font("Arial", 10, FontStyle.Bold);
			deleteButton.Font = new Font("Arial", 10, FontStyle.Bold);
			groupLabel.Font = new Font("Arial", 20, FontStyle.Bold);
			menuLabel.Font = new Font("Arial", 20, FontStyle.Bold);
			calLabel.Font = new Font("Arial", 20, FontStyle.Bold);


		}

		private void backButton_Click(object sender, EventArgs e)
		{
			HomeForm tf = new HomeForm();
			tf.StartPosition = FormStartPosition.Manual;
			tf.Location = this.Location;
			tf.FormClosing += (s, args) => this.Show();
			tf.Show();
			this.Hide();
		}

		private void MenuForm_Load(object sender, EventArgs e)
		{
			MenuComboBox();
			genreAdd();
			calAdd();
		}

		private void genreAdd()
		{
			groupComboBox.Items.Add("和");
			groupComboBox.Items.Add("洋食");
			groupComboBox.Items.Add("中華");
			groupComboBox.Items.Add("韓国料理");
			groupComboBox.Items.Add("イタリアン");
		}

		private void calAdd()
		{
			calComboBox.Items.Add(300);
			calComboBox.Items.Add(800);
			calComboBox.Items.Add(1100);
			calComboBox.Items.Add(1500);
		}

		private void MenuComboBox()
		{
			//SQLクエリを作成
			string query =
				"SELECT men_name FROM menusuggestions.menu";

			//データベース接続を作成
			using (MySqlConnection conn = new MySqlConnection(connStr))
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
					menuComboBox.Items.Add(reader["men_name"].ToString());
				}

				//データベースを閉じる
				reader.Close();
				conn.Close();


			}

		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			UpdateMenuList();
		}

		private void UpdateMenuList()
		{
			if (groupComboBox.SelectedItem != null || calComboBox.SelectedItem != null)
			{
				string genre = groupComboBox.SelectedItem?.ToString();
				int? calories = calComboBox.SelectedItem != null ? int.Parse(calComboBox.SelectedItem.ToString()) : (int?)null;

				using (MySqlConnection conn = new MySqlConnection(connStr))
				{
					try
					{
						conn.Open();

						//SQLクエリを作成
						string query =
							"SELECT men_name FROM menusuggestions.menu WHERE ";

						if (!string.IsNullOrEmpty(genre))
						{
							query += "men_genre = @genre";
						}

						if (calories.HasValue)
						{
							if (!string.IsNullOrEmpty(genre))
							{
								query += "AND";
							}

							query += "men_kcal <= @calories";
						}

						using (MySqlCommand cmd = new MySqlCommand(query, conn))
						{
							if (!string.IsNullOrEmpty(genre))
							{
								cmd.Parameters.AddWithValue("@genre", genre);
							}

							if (calories.HasValue)
							{
								cmd.Parameters.AddWithValue("@calories", calories);
							}

							using (MySqlDataReader reader = cmd.ExecuteReader())
							{
								menuComboBox.Items.Clear();

								while (reader.Read())
								{
									string menuName = reader.GetString("men_name");

									menuComboBox.Items.Add(menuName);
								}
								MessageBox.Show("メニューリストを更新しました。");
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("指定された条件では検索できませんでした。");
					}
				}
			}
			else
			{
				MessageBox.Show("ジャンルもしくはカロリーを選択してください。");
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			deleteSelectMenu();
		}

		public void deleteSelectMenu()
		{
			if (menuComboBox.SelectedItem != null)
			{
				string selectMenu = menuComboBox.SelectedItem.ToString();

				using (MySqlConnection conn = new MySqlConnection(connStr))
				{
					try
					{
						conn.Open();

						//SQLクエリを作成
						string query =
							"DELETE FROM menusuggestions.menu WHERE men_name = @menuName";

						using (MySqlCommand cmd = new MySqlCommand(query, conn))
						{
							cmd.Parameters.AddWithValue("@menuName", selectMenu);

							cmd.ExecuteNonQuery();
						}

						menuComboBox.Items.Remove(selectMenu);

						MessageBox.Show("選択したメニューを消去しました。");

					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
			else
			{
				MessageBox.Show("消去するメニューを選択してください。");
			}
		}

		private void addUpdateButton_Click(object sender, EventArgs e)
		{
			MenuRegisterForm mrf = new MenuRegisterForm();
			mrf.StartPosition = FormStartPosition.Manual;
			mrf.Location = this.Location;
			mrf.FormClosing += (s, args) => this.Show();
			mrf.Show();
			this.Hide();
		}

		private void recipeButton_Click(object sender, EventArgs e)
		{
			if(menuComboBox.SelectedItem != null)
			{
				string selectMenu = menuComboBox.SelectedItem.ToString();

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
	}
}

