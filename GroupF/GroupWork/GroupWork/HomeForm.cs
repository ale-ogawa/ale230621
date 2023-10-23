using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace GroupWork
{
	public partial class HomeForm : Form
	{
		public HomeForm()
		{
			InitializeComponent();

			backButton1.Font = new Font("Arial", 10, FontStyle.Bold);
			menuButton.Font = new Font("Arial", 20, FontStyle.Bold);
			itemButton.Font = new Font("Arial", 20, FontStyle.Bold);

			//ピクチャーボックスに画像を挿入する例
			pictureBox1.Image = new Bitmap("C:\\temp\\hamburg.png");
			//画像のサイズ変更
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			//ピクチャーボックスに画像を挿入する例
			pictureBox2.Image = new Bitmap("C:\\temp\\reizouko.png");
			//画像のサイズ変更
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		private void backButton1_Click(object sender, EventArgs e)
		{
			TopForm tf = new TopForm();
			tf.StartPosition = FormStartPosition.Manual;
			tf.Location = this.Location;
			tf.FormClosing += (s, args) => this.Show();
			tf.Show();
			this.Hide();
		}

		private void menuButton_Click(object sender, EventArgs e)
		{
			MenuForm mf = new MenuForm();
			mf.StartPosition = FormStartPosition.Manual;
			mf.Location = this.Location;
			mf.FormClosing += (s, args) => this.Show();
			mf.Show();
			this.Hide();
		}

		private void itemButton_Click(object sender, EventArgs e)
		{
			ItemForm itf = new ItemForm();
			itf.StartPosition = FormStartPosition.Manual;
			itf.Location = this.Location;
			itf.FormClosing += (s, args) => this.Show();
			itf.Show();
			this.Hide();
		}

		private void HomeForm_Load(object sender, EventArgs e)
		{
			nowTime();
		}

		public void nowTime()
		{
			string connStr = "Server =localhost; Port=3306; Database=menusuggestions; Uid=root; Pwd=root; Charset=utf8";

			MySqlConnection conn = new MySqlConnection(connStr);
			conn.Open();

			DateTime now = DateTime.Now;//現在の日付
			DateTime oneWeek = now.AddDays(7);//一週間後の日付

			//賞味期限一週間以内の食材を抽出するクエリ
			string query = "SELECT ite_name " +
				"FROM menusuggestions.item " +
				"WHERE ite_date <= @now AND " +
				"ite_date <= @oneWeek";

			MySqlCommand cmd = new MySqlCommand(query, conn);
			cmd.Parameters.AddWithValue("@now", now);
			cmd.Parameters.AddWithValue("@oneWeek", oneWeek);

			//クエリ実行、結果取得、ダイアログ表示
			using (MySqlDataReader reader = cmd.ExecuteReader())
			{
				StringBuilder sb = new StringBuilder();

				while (reader.Read())
				{
					string iteName = reader.GetString("ite_name");
					sb.Append(iteName + "の賞味期限が近づいています。");

					if (sb.Length > 0)
					{
						MessageBox.Show(sb.ToString(), "賞味期限の近づいた食材");
					}
					else
					{
						MessageBox.Show("賞味期限の近づいた食材はありません。");
					}
				}
				conn.Close();
			}
		}
	}
}
