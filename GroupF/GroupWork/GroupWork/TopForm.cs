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
	public partial class TopForm : Form
	{
		public TopForm()
		{
			InitializeComponent();
			startButton.Font = new Font("Arial",20,FontStyle.Bold);

			//ピクチャーボックスに画像を挿入する例
			pictureBox1.Image = new Bitmap("C:\\temp\\hamburg.png");
			//画像のサイズ変更
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			//ピクチャーボックスに画像を挿入する例
			pictureBox2.Image = new Bitmap("C:\\temp\\reizouko.png");
			//画像のサイズ変更
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			//ピクチャーボックスに画像を挿入する例
			pictureBox3.Image = new Bitmap("C:\\temp\\kondate.png");
			//画像のサイズ変更
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			HomeForm tf = new HomeForm();
			tf.StartPosition = FormStartPosition.Manual;
			tf.Location = this.Location;
			tf.FormClosing += (s, args) => this.Show();
			tf.Show();
			this.Hide();
		}

	}
}
