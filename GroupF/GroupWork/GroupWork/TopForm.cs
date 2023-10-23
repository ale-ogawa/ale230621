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

namespace GroupWork
{
	public partial class TopForm : Form
	{
        MySqlConnection conn = null;
        public TopForm()
		{
			InitializeComponent();

            //MsSQLへのコネクションを確立
            //try
            //{
            //    conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString);
            //}
            //catch (MySqlException me)
            //{
            //    MessageBox.Show(me.Message);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            startButton.Font = new Font("Arial",20,FontStyle.Bold);

			////ピクチャーボックスに画像を挿入する例
			//pictureBox1.Image = new Bitmap("C:\\temp\\hamburg.png");
			////画像のサイズ変更
			//pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			////ピクチャーボックスに画像を挿入する例
			//pictureBox2.Image = new Bitmap("C:\\temp\\reizouko.png");
			////画像のサイズ変更
			//pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			////ピクチャーボックスに画像を挿入する例
			//pictureBox3.Image = new Bitmap("C:\\temp\\kondate.png");
			////画像のサイズ変更
			//pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		private void startButton_Click(object sender, EventArgs e)
		{
            //HomeForm tf = new HomeForm();
            //tf.StartPosition = FormStartPosition.Manual;
            //tf.Location = this.Location;
            //tf.FormClosing += (s, args) => this.Show();
            //tf.Show();
            //this.Hide();

            DisplayMessage();
            //トップ画面を非表示
            //this.Visible = false;

            //ホーム画面を呼び出す
            HomeForm hf = new HomeForm();
            hf.ShowDialog();

            //フォーム画面を閉じる
            //this.Close();

        }

        /// <summary>
        /// 賞味期限が一週間以内のものが存在するとき、メッセージを表示する
        /// </summary>
        private void DisplayMessage()
        {
            ////スタートボタンをクリックしたときの日付を取得する
            //DateTime now = DateTime.Now;

            ////食材情報を取得し、リストに格納する
            //List<Item> itemList = GetItem();

            ////該当する食材名を追加する
            //string itemNames = null;
            ////日付を取得した一週間後の日付
            //DateTime limDate = now.AddDays(7);

            //if (itemList != null)
            //{
            //    foreach (Item item in itemList)
            //    {
            //        DateTime date = item.ItemDate;
            //        string name = item.ItemName;
            //        if (now <= date && date <= limDate)
            //        {
            //            itemNames += $"<{name}>,";
            //        }
            //    }
            //    if (itemNames != null)
            //    {
            //        string trimmedItemNames = itemNames.Substring(0, itemNames.Length - 1);
            //        MessageBox.Show($"{trimmedItemNames}の賞味期限が一週間以内です",
            //            "注意",
            //            MessageBoxButtons.OK,
            //            MessageBoxIcon.Warning);
            //    }
            //}
            //else
            //{
            //    return;
            //}
        }

        private List<Item> GetItem()
        {
            //MySQLに接続
            conn.Open();

            string sql = "SELECT ite_name,ite_date FROM Item;";
            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            //食材情報を格納するリスト
            List<Item> itemList = new List<Item>();

            //SQLで抽出した食材情報をリストに格納する
            while (reader.Read())
            {
                //NULL出ない場合はリストにDateTime型のディクショナリに格納する
                if (!reader.IsDBNull(0))
                {
                    itemList.Add(new Item(reader.GetString(0), reader.GetDateTime(1)));
                }
            }
            reader.Close();

            //MySqlの接続を解除する
            conn.Close();

            return itemList;
        }

    }
}
