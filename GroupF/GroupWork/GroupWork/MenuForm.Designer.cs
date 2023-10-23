namespace GroupWork
{
	partial class MenuForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.groupLabel = new System.Windows.Forms.Label();
            this.calLabel = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.calComboBox = new System.Windows.Forms.ComboBox();
            this.menuComboBox = new System.Windows.Forms.ComboBox();
            this.addUpdateButton = new System.Windows.Forms.Button();
            this.recipeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DarkOrange;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 42);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // groupLabel
            // 
            this.groupLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.groupLabel.Location = new System.Drawing.Point(12, 61);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(246, 35);
            this.groupLabel.TabIndex = 3;
            this.groupLabel.Text = "ジャンル検索";
            this.groupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calLabel
            // 
            this.calLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calLabel.Location = new System.Drawing.Point(10, 247);
            this.calLabel.Name = "calLabel";
            this.calLabel.Size = new System.Drawing.Size(246, 35);
            this.calLabel.TabIndex = 4;
            this.calLabel.Text = "カロリー検索";
            this.calLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuLabel
            // 
            this.menuLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuLabel.Location = new System.Drawing.Point(369, 12);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(419, 30);
            this.menuLabel.TabIndex = 5;
            this.menuLabel.Text = "メニュー一覧";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(14, 99);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(244, 20);
            this.groupComboBox.TabIndex = 6;
            // 
            // calComboBox
            // 
            this.calComboBox.FormattingEnabled = true;
            this.calComboBox.Location = new System.Drawing.Point(12, 285);
            this.calComboBox.Name = "calComboBox";
            this.calComboBox.Size = new System.Drawing.Size(246, 20);
            this.calComboBox.TabIndex = 7;
            // 
            // menuComboBox
            // 
            this.menuComboBox.FormattingEnabled = true;
            this.menuComboBox.Location = new System.Drawing.Point(371, 45);
            this.menuComboBox.Name = "menuComboBox";
            this.menuComboBox.Size = new System.Drawing.Size(417, 20);
            this.menuComboBox.TabIndex = 8;
            // 
            // addUpdateButton
            // 
            this.addUpdateButton.BackColor = System.Drawing.Color.DarkOrange;
            this.addUpdateButton.Location = new System.Drawing.Point(560, 379);
            this.addUpdateButton.Name = "addUpdateButton";
            this.addUpdateButton.Size = new System.Drawing.Size(111, 59);
            this.addUpdateButton.TabIndex = 10;
            this.addUpdateButton.Text = "メニュー\r\n登録/編集";
            this.addUpdateButton.UseVisualStyleBackColor = false;
            this.addUpdateButton.Click += new System.EventHandler(this.addUpdateButton_Click);
            // 
            // recipeButton
            // 
            this.recipeButton.BackColor = System.Drawing.Color.DarkOrange;
            this.recipeButton.Location = new System.Drawing.Point(443, 379);
            this.recipeButton.Name = "recipeButton";
            this.recipeButton.Size = new System.Drawing.Size(111, 59);
            this.recipeButton.TabIndex = 11;
            this.recipeButton.Text = "レシピ表示";
            this.recipeButton.UseVisualStyleBackColor = false;
            this.recipeButton.Click += new System.EventHandler(this.recipeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.DarkOrange;
            this.updateButton.Location = new System.Drawing.Point(326, 379);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(111, 59);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "検索";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkOrange;
            this.deleteButton.Location = new System.Drawing.Point(677, 379);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 59);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "メニュー\r\n消去";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.recipeButton);
            this.Controls.Add(this.addUpdateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.menuComboBox);
            this.Controls.Add(this.calComboBox);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.calLabel);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.backButton);
            this.Name = "MenuForm";
            this.Text = "メニュー操作画面";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.Label groupLabel;
		private System.Windows.Forms.Label calLabel;
		private System.Windows.Forms.Label menuLabel;
		private System.Windows.Forms.ComboBox groupComboBox;
		private System.Windows.Forms.ComboBox calComboBox;
		private System.Windows.Forms.ComboBox menuComboBox;
		private System.Windows.Forms.Button addUpdateButton;
		private System.Windows.Forms.Button recipeButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button deleteButton;
	}
}