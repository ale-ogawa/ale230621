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
	}
}
