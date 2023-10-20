using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GroupWork
{
	public partial class RecipeForm : Form
	{
		private string connStr = "Server =localhost; Port=3306; Database=menusuggestions; Uid=root; Pwd=root; Charset=utf8";
		private string selectMenu;

		//画像パス用変数
        string imagePath="";

        public RecipeForm(string menu)
		{
			InitializeComponent();

			selectMenu = menu;
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			MenuRegisterForm mrf = new MenuRegisterForm();
			mrf.StartPosition = FormStartPosition.Manual;
			mrf.Location = this.Location;
			mrf.FormClosing += (s, args) => this.Show();
			mrf.Show();
			this.Hide();
		}

		private void RecipeForm_Load(object sender, EventArgs e)
		{
			using(MySqlConnection conn = new MySqlConnection(connStr))
			{
				string query = "SELECT men_name,men_genre,men_kcal,men_time,men_item,men_recipe,men_pic FROM menusuggestions.menu WHERE men_name = @menuName";

				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@menuName", selectMenu);
				conn.Open();
				MySqlDataReader reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					menuDisplayLabel.Text = reader["men_name"].ToString();
					genreDisplayLabel.Text = reader["men_genre"].ToString();
					kcalDisplayLabel.Text = reader["men_kcal"].ToString();
					timeDisplayLabel.Text = reader["men_time"].ToString();
					itemDisplaayLabel.Text = reader["men_item"].ToString();
					recipeDisplayLabel.Text = reader["men_recipe"].ToString();
					imagePath = reader["men_pic"].ToString();



					//画像の取得と表示(今林さん作成画像表示コード)
					//picDisplayBox.Image = new Bitmap(reader["men_pic"].ToString()); //Image.FromFile(reader["men_pic"].ToString());
					//picDisplayBox.SizeMode = PictureBoxSizeMode.StretchImage;
				}

				//画像呼び出し説明→DBで「\マーク」を「他の文字」に入れ替えて保存しておいた。
				//呼び出すときは逆に「他の文字」を「\マーク」に入れ替えて呼び出す
				string str2 = imagePath.Replace("変更用", "\\");
				textBox1.Text = str2;
				textBox2.Text = imagePath;
                picDisplayBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picDisplayBox.ImageLocation = str2;


				reader.Close();
			}
		}

        private void picDisplayBox_Click(object sender, EventArgs e)
        {

        }
    }
}
