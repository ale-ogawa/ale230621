namespace GroupWork
{
	partial class MenuRegisterForm
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
			this.addButton = new System.Windows.Forms.Button();
			this.pictureAddBotton = new System.Windows.Forms.Button();
			this.addPictureBox = new System.Windows.Forms.PictureBox();
			this.backButton = new System.Windows.Forms.Button();
			this.clearTextButton = new System.Windows.Forms.Button();
			this.menuLabel = new System.Windows.Forms.Label();
			this.kcalLabel = new System.Windows.Forms.Label();
			this.genreLabel = new System.Windows.Forms.Label();
			this.itemLabel = new System.Windows.Forms.Label();
			this.recipeLabel = new System.Windows.Forms.Label();
			this.picturePassLabel = new System.Windows.Forms.Label();
			this.timeLabel = new System.Windows.Forms.Label();
			this.genreBox = new System.Windows.Forms.ComboBox();
			this.menuBox = new System.Windows.Forms.TextBox();
			this.kcalBox = new System.Windows.Forms.TextBox();
			this.itemBox = new System.Windows.Forms.TextBox();
			this.recipeBox = new System.Windows.Forms.TextBox();
			this.picturePassBox = new System.Windows.Forms.TextBox();
			this.timeBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.BackColor = System.Drawing.Color.DarkOrange;
			this.addButton.Location = new System.Drawing.Point(592, 383);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(95, 63);
			this.addButton.TabIndex = 0;
			this.addButton.Text = "登録";
			this.addButton.UseVisualStyleBackColor = false;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// pictureAddBotton
			// 
			this.pictureAddBotton.BackColor = System.Drawing.Color.DarkOrange;
			this.pictureAddBotton.Location = new System.Drawing.Point(436, 45);
			this.pictureAddBotton.Name = "pictureAddBotton";
			this.pictureAddBotton.Size = new System.Drawing.Size(121, 52);
			this.pictureAddBotton.TabIndex = 1;
			this.pictureAddBotton.Text = "画像アップロード";
			this.pictureAddBotton.UseVisualStyleBackColor = false;
			this.pictureAddBotton.Click += new System.EventHandler(this.pictureAddBotton_Click);
			// 
			// addPictureBox
			// 
			this.addPictureBox.Location = new System.Drawing.Point(592, 12);
			this.addPictureBox.Name = "addPictureBox";
			this.addPictureBox.Size = new System.Drawing.Size(196, 164);
			this.addPictureBox.TabIndex = 2;
			this.addPictureBox.TabStop = false;
			// 
			// backButton
			// 
			this.backButton.BackColor = System.Drawing.Color.DarkOrange;
			this.backButton.Location = new System.Drawing.Point(12, 390);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(75, 48);
			this.backButton.TabIndex = 3;
			this.backButton.Text = "戻る";
			this.backButton.UseVisualStyleBackColor = false;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// clearTextButton
			// 
			this.clearTextButton.BackColor = System.Drawing.Color.DarkOrange;
			this.clearTextButton.Location = new System.Drawing.Point(693, 383);
			this.clearTextButton.Name = "clearTextButton";
			this.clearTextButton.Size = new System.Drawing.Size(95, 63);
			this.clearTextButton.TabIndex = 4;
			this.clearTextButton.Text = "クリア";
			this.clearTextButton.UseVisualStyleBackColor = false;
			this.clearTextButton.Click += new System.EventHandler(this.clearTextButton_Click);
			// 
			// menuLabel
			// 
			this.menuLabel.BackColor = System.Drawing.Color.Orange;
			this.menuLabel.Location = new System.Drawing.Point(16, 45);
			this.menuLabel.Name = "menuLabel";
			this.menuLabel.Size = new System.Drawing.Size(85, 19);
			this.menuLabel.TabIndex = 5;
			this.menuLabel.Text = "メニュー名";
			this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// kcalLabel
			// 
			this.kcalLabel.BackColor = System.Drawing.Color.Orange;
			this.kcalLabel.Location = new System.Drawing.Point(16, 87);
			this.kcalLabel.Name = "kcalLabel";
			this.kcalLabel.Size = new System.Drawing.Size(83, 19);
			this.kcalLabel.TabIndex = 6;
			this.kcalLabel.Text = "カロリー";
			this.kcalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// genreLabel
			// 
			this.genreLabel.BackColor = System.Drawing.Color.Orange;
			this.genreLabel.Location = new System.Drawing.Point(16, 139);
			this.genreLabel.Name = "genreLabel";
			this.genreLabel.Size = new System.Drawing.Size(83, 20);
			this.genreLabel.TabIndex = 7;
			this.genreLabel.Text = "ジャンル";
			this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// itemLabel
			// 
			this.itemLabel.BackColor = System.Drawing.Color.Orange;
			this.itemLabel.Location = new System.Drawing.Point(16, 192);
			this.itemLabel.Name = "itemLabel";
			this.itemLabel.Size = new System.Drawing.Size(81, 20);
			this.itemLabel.TabIndex = 8;
			this.itemLabel.Text = "食材";
			this.itemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// recipeLabel
			// 
			this.recipeLabel.BackColor = System.Drawing.Color.Orange;
			this.recipeLabel.Location = new System.Drawing.Point(16, 258);
			this.recipeLabel.Name = "recipeLabel";
			this.recipeLabel.Size = new System.Drawing.Size(81, 20);
			this.recipeLabel.TabIndex = 9;
			this.recipeLabel.Text = "作り方";
			this.recipeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picturePassLabel
			// 
			this.picturePassLabel.BackColor = System.Drawing.Color.Orange;
			this.picturePassLabel.Location = new System.Drawing.Point(349, 110);
			this.picturePassLabel.Name = "picturePassLabel";
			this.picturePassLabel.Size = new System.Drawing.Size(81, 20);
			this.picturePassLabel.TabIndex = 10;
			this.picturePassLabel.Text = "画像パス";
			this.picturePassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timeLabel
			// 
			this.timeLabel.BackColor = System.Drawing.Color.Orange;
			this.timeLabel.Location = new System.Drawing.Point(349, 140);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(81, 20);
			this.timeLabel.TabIndex = 11;
			this.timeLabel.Text = "所要時間";
			this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// genreBox
			// 
			this.genreBox.FormattingEnabled = true;
			this.genreBox.Items.AddRange(new object[] {
            "和食",
            "洋食",
            "中華",
            "韓国料理",
            "イタリアン"});
			this.genreBox.Location = new System.Drawing.Point(105, 139);
			this.genreBox.Name = "genreBox";
			this.genreBox.Size = new System.Drawing.Size(211, 20);
			this.genreBox.TabIndex = 12;
			// 
			// menuBox
			// 
			this.menuBox.Location = new System.Drawing.Point(107, 45);
			this.menuBox.Name = "menuBox";
			this.menuBox.Size = new System.Drawing.Size(211, 19);
			this.menuBox.TabIndex = 13;
			// 
			// kcalBox
			// 
			this.kcalBox.Location = new System.Drawing.Point(105, 87);
			this.kcalBox.Name = "kcalBox";
			this.kcalBox.Size = new System.Drawing.Size(211, 19);
			this.kcalBox.TabIndex = 14;
			// 
			// itemBox
			// 
			this.itemBox.Location = new System.Drawing.Point(103, 193);
			this.itemBox.Multiline = true;
			this.itemBox.Name = "itemBox";
			this.itemBox.Size = new System.Drawing.Size(623, 50);
			this.itemBox.TabIndex = 15;
			// 
			// recipeBox
			// 
			this.recipeBox.Location = new System.Drawing.Point(103, 259);
			this.recipeBox.Multiline = true;
			this.recipeBox.Name = "recipeBox";
			this.recipeBox.Size = new System.Drawing.Size(623, 118);
			this.recipeBox.TabIndex = 16;
			// 
			// picturePassBox
			// 
			this.picturePassBox.Location = new System.Drawing.Point(436, 110);
			this.picturePassBox.Name = "picturePassBox";
			this.picturePassBox.Size = new System.Drawing.Size(147, 19);
			this.picturePassBox.TabIndex = 17;
			// 
			// timeBox
			// 
			this.timeBox.Location = new System.Drawing.Point(436, 140);
			this.timeBox.Name = "timeBox";
			this.timeBox.Size = new System.Drawing.Size(111, 19);
			this.timeBox.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(322, 94);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(26, 12);
			this.label8.TabIndex = 19;
			this.label8.Text = "kcal";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(553, 148);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(17, 12);
			this.label9.TabIndex = 20;
			this.label9.Text = "分";
			// 
			// MenuRegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.timeBox);
			this.Controls.Add(this.picturePassBox);
			this.Controls.Add(this.recipeBox);
			this.Controls.Add(this.itemBox);
			this.Controls.Add(this.kcalBox);
			this.Controls.Add(this.menuBox);
			this.Controls.Add(this.genreBox);
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.picturePassLabel);
			this.Controls.Add(this.recipeLabel);
			this.Controls.Add(this.itemLabel);
			this.Controls.Add(this.genreLabel);
			this.Controls.Add(this.kcalLabel);
			this.Controls.Add(this.menuLabel);
			this.Controls.Add(this.clearTextButton);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.addPictureBox);
			this.Controls.Add(this.pictureAddBotton);
			this.Controls.Add(this.addButton);
			this.Name = "MenuRegisterForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MenuRegisterForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button pictureAddBotton;
		private System.Windows.Forms.PictureBox addPictureBox;
		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.Button clearTextButton;
		private System.Windows.Forms.Label menuLabel;
		private System.Windows.Forms.Label kcalLabel;
		private System.Windows.Forms.Label genreLabel;
		private System.Windows.Forms.Label itemLabel;
		private System.Windows.Forms.Label recipeLabel;
		private System.Windows.Forms.Label picturePassLabel;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.ComboBox genreBox;
		private System.Windows.Forms.TextBox menuBox;
		private System.Windows.Forms.TextBox kcalBox;
		private System.Windows.Forms.TextBox itemBox;
		private System.Windows.Forms.TextBox recipeBox;
		private System.Windows.Forms.TextBox picturePassBox;
		private System.Windows.Forms.TextBox timeBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
	}
}