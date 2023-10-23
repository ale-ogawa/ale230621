namespace GroupWork
{
	partial class HomeForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuButton = new System.Windows.Forms.Button();
			this.itemButton = new System.Windows.Forms.Button();
			this.backButton1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// menuButton
			// 
			this.menuButton.BackColor = System.Drawing.Color.DarkOrange;
			this.menuButton.Location = new System.Drawing.Point(534, 108);
			this.menuButton.Name = "menuButton";
			this.menuButton.Size = new System.Drawing.Size(234, 68);
			this.menuButton.TabIndex = 0;
			this.menuButton.Text = "メニュー";
			this.menuButton.UseVisualStyleBackColor = false;
			this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
			// 
			// itemButton
			// 
			this.itemButton.BackColor = System.Drawing.Color.DarkOrange;
			this.itemButton.Location = new System.Drawing.Point(534, 257);
			this.itemButton.Name = "itemButton";
			this.itemButton.Size = new System.Drawing.Size(234, 68);
			this.itemButton.TabIndex = 1;
			this.itemButton.Text = "食材";
			this.itemButton.UseVisualStyleBackColor = false;
			this.itemButton.Click += new System.EventHandler(this.itemButton_Click);
			// 
			// backButton1
			// 
			this.backButton1.BackColor = System.Drawing.Color.DarkOrange;
			this.backButton1.Location = new System.Drawing.Point(13, 13);
			this.backButton1.Name = "backButton1";
			this.backButton1.Size = new System.Drawing.Size(75, 48);
			this.backButton1.TabIndex = 2;
			this.backButton1.Text = "戻る";
			this.backButton1.UseVisualStyleBackColor = false;
			this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(68, 139);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(154, 164);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(275, 54);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(199, 351);
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// HomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.backButton1);
			this.Controls.Add(this.itemButton);
			this.Controls.Add(this.menuButton);
			this.Name = "HomeForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.HomeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button menuButton;
		private System.Windows.Forms.Button itemButton;
		private System.Windows.Forms.Button backButton1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}