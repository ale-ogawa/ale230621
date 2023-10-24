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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GroupWork
{
	public partial class MenuRegisterForm : Form
	{

		string Selectall5;
		int men_number;
		string men_name;
		int men_kcal;
		int men_time;
		string men_genre;
		string men_item;
		string men_recipe;

		string boxname;
		string boxkcal;
		string boxtime;
		string boxgenre;
		string boxitem;
		string boxrecipe;
		string boxpic;


		//画像パス用変数
		string path = "";

		// ★接続情報
		private static readonly string Server = "localhost";      // ホスト名
		private static readonly int Port = 3306;                  // ポート番号
		private static readonly string Database = "menusuggestions";        // データベース名
		private static readonly string Uid = "root";              // ユーザ名
		private static readonly string Pwd = "root"; // パスワード

		private static readonly string ConnectionString = "Server =localhost; Port=3306; Database=menusuggestions; Uid=root; Pwd=root; Charset=utf8";



		public MenuRegisterForm()
		{
			InitializeComponent();


			backButton.Font = new Font("Arial", 10, FontStyle.Bold);
			menuLabel.Font = new Font("Arial", 10, FontStyle.Bold);
			kcalLabel.Font = new Font("Arial", 10, FontStyle.Bold);
			genreLabel.Font = new Font("Arial", 10, FontStyle.Bold);
			itemLabel.Font = new Font("Arial", 10, FontStyle.Bold);
			recipeLabel.Font = new Font("Arial", 10, FontStyle.Bold);
			pictureAddBotton.Font = new Font("Arial", 10, FontStyle.Bold);
			picturePassLabel.Font = new Font("Arial", 10, FontStyle.Bold);
			timeLabel.Font = new Font("Arial", 10, FontStyle.Bold);
			addButton.Font = new Font("Arial", 10, FontStyle.Bold);
			clearTextButton.Font = new Font("Arial", 10, FontStyle.Bold);
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			try
			{
				// ★コネクションオブジェクトとコマンドオブジェクトを生成します。
				using (var connection = new MySqlConnection(ConnectionString))
				using (var command = new MySqlCommand(Selectall5, connection))
				{
					// ★コネクションをオープンします。
					connection.Open();

					// ★SQLを起動します。
					command.Connection = connection;

					//★SQL文の定義
					boxname = "'" + menuBox.Text + "'";
					boxkcal = kcalBox.Text;
					boxtime = timeBox.Text;
					boxgenre = "'" + genreBox.Text + "'";
					boxitem = "'" + itemBox.Text + "'";
					boxrecipe = "'" + recipeBox.Text + "'";
					boxpic = "'" + picturePassBox.Text + "'";

					string picStr = boxpic.Replace("\\", "変更用");

					//★INSERT文の定義

					if (menuBox.Text == "" || menuBox.Text == "" || kcalBox.Text == "" || timeBox.Text == ""
					|| genreBox.Text == "" || itemBox.Text == "" || recipeBox.Text == "" || picturePassBox.Text == "")
					{
						//メッセージボックスを表示する
						DialogResult result = MessageBox.Show("空白の項目があります。\n「はい」➡空白のまま登録する。\n「いいえ」➡もう一度入力し直す。",
							"Empty items?",
							MessageBoxButtons.YesNoCancel,
							MessageBoxIcon.Exclamation,
							MessageBoxDefaultButton.Button2);

						//何が選択されたか調べる
						if (result == DialogResult.Yes)
						{
							//「はい」が選択された時
							//Console.WriteLine("「はい」が選択されました");
						}
						else if (result == DialogResult.No)
						{
							//「いいえ」が選択された時
							return;
						}
						else if (result == DialogResult.Cancel)
						{
							//「キャンセル」が選択された時
							//Console.WriteLine("「キャンセル」が選択されました");
							return;
						}
					}

					if (picturePassBox == null)//画像パスの登録がない場合はNULLのままDBテーブルへ登録
					{
						Selectall5 = $"use menusuggestions; insert into menu values(null,{boxname},{boxkcal},{boxtime},{boxgenre},{boxitem},{boxrecipe},null);";//$付与は{}内に変数指定可。@付与は複数文同時実行可                                                                                                                                     //★ CommandTextプロパティにMySQLで実行するSQLステートメント（命令文）を設定します。
						command.CommandText = Selectall5;
					}
					else if (menuBox == null)//メニュー名がない場合
					{
						Selectall5 = $"use menusuggestions; insert into menu values(null,null,{boxkcal},{boxtime},{boxgenre},{boxitem},{boxrecipe},{picStr});";//$付与は{}内に変数指定可。@付与は複数文同時実行可                                                                                                                                     //★ CommandTextプロパティにMySQLで実行するSQLステートメント（命令文）を設定します。
						command.CommandText = Selectall5;
					}
					else if (kcalBox == null)
					{
						Selectall5 = $"use menusuggestions; insert into menu values(null,{boxname},null,{boxtime},{boxgenre},{boxitem},{boxrecipe},{picStr});";//$付与は{}内に変数指定可。@付与は複数文同時実行可                                                                                                                                     //★ CommandTextプロパティにMySQLで実行するSQLステートメント（命令文）を設定します。
						command.CommandText = Selectall5;
					}
					else if (timeBox == null)
					{
						Selectall5 = $"use menusuggestions; insert into menu values(null,{boxname},{boxkcal},null,{boxgenre},{boxitem},{boxrecipe},{picStr});";//$付与は{}内に変数指定可。@付与は複数文同時実行可                                                                                                                                     //★ CommandTextプロパティにMySQLで実行するSQLステートメント（命令文）を設定します。
						command.CommandText = Selectall5;
					}
					else if (genreBox == null)
					{
						Selectall5 = $"use menusuggestions; insert into menu values(null,{boxname},{boxkcal},{boxtime},null,{boxitem},{boxrecipe},{picStr});";//$付与は{}内に変数指定可。@付与は複数文同時実行可                                                                                                                                     //★ CommandTextプロパティにMySQLで実行するSQLステートメント（命令文）を設定します。
						command.CommandText = Selectall5;
					}
					else if (itemBox == null)
					{
						Selectall5 = $"use menusuggestions; insert into menu values(null,{boxname},{boxkcal},{boxtime},{boxgenre},null,{boxrecipe},{picStr});";//$付与は{}内に変数指定可。@付与は複数文同時実行可                                                                                                                                     //★ CommandTextプロパティにMySQLで実行するSQLステートメント（命令文）を設定します。
						command.CommandText = Selectall5;
					}
					else if (recipeBox == null)
					{
						Selectall5 = $"use menusuggestions; insert into menu values(null,{boxname},{boxkcal},{boxtime},{boxgenre},{boxitem},null,{picStr});";//$付与は{}内に変数指定可。@付与は複数文同時実行可                                                                                                                                     //★ CommandTextプロパティにMySQLで実行するSQLステートメント（命令文）を設定します。
						command.CommandText = Selectall5;
					}

					if (recipeBox == null)//画像パスの登録がない場合はNULLのままDBテーブルへ登録
					{
						Selectall5 = $"use menusuggestions; insert into menu values(null,{boxname},{boxkcal},{boxtime},{boxgenre},{boxitem},{boxrecipe},null);";//$付与は{}内に変数指定可。@付与は複数文同時実行可                                                                                                                                     //★ CommandTextプロパティにMySQLで実行するSQLステートメント（命令文）を設定します。
						command.CommandText = Selectall5;
					}

					else if (recipeBox != null)//画像バスの登録がある場合はパスをDBテーブルへ登録
					{
						Selectall5 = $"use menusuggestions; insert into menu values(null,{boxname},{boxkcal},{boxtime},{boxgenre},{boxitem},{boxrecipe},{picStr});";
						command.CommandText = Selectall5;
					}

					MessageBox.Show("メニューが登録されました");





					//string Selectall3 = "use menusuggestion; insert into menu values(null,'ハンバーグ',500,20,'洋','ひき肉、パン粉','ひき肉をこねる',null);";

					//★上の命令文で設定されたSQLデータを実行
					var reader = command.ExecuteReader();

					//★コネクションをクローズします
					reader.Close();//command.ExecuteReader()を閉じる
				}
			}
			catch (Exception ee)
			{
				MessageBox.Show(ee.Message);//例外処理はメッセージボックスに表示
			}
		}
	


		private void pictureAddBotton_Click(object sender, EventArgs e)
		{
			//テキストボックスをクリア
			menuBox.Text = "";

			//ファイルダイアログを生成する
			OpenFileDialog op = new OpenFileDialog();
			op.Title = "ファイルを開く";
			op.InitialDirectory = @"C:\";
			op.Filter = "すべてのファイル(*.*)|*.*";
			op.FilterIndex = 1;

			//オープンファイルダイアログを表示する
			DialogResult dialog = op.ShowDialog();

			//「開く」ボタンが選択された時の処理
			if (dialog == DialogResult.OK)
			{
				path = op.FileName;//pathはスコープの関係から「string path」で外の場所に定義する
			}
			//「キャンセル」時の処理
			else if (dialog == DialogResult.Cancel)
			{ }

			//テキストボックスにパスを表示
			picturePassBox.Text = path;
			//ピクチャーボックスに読み込んだパスから画像表示
			addPictureBox.ImageLocation = $@"{path}";
		}

		private void clearTextButton_Click(object sender, EventArgs e)
		{
			menuBox.Text = "";
			kcalBox.Text = "";
			timeBox.Text = "";
			genreBox.Text = "";
			itemBox.Text = "";
			recipeBox.Text = "";
			picturePassBox.Text = "";
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			MenuForm mf = new MenuForm();
			mf.StartPosition = FormStartPosition.Manual;
			mf.Location = this.Location;
			mf.FormClosing += (s, args) => this.Show();
			mf.Show();
			this.Hide();
		}

	}
}

