namespace GroupWork
{
	partial class ItemForm
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
            this.itmLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.itemAddButton = new System.Windows.Forms.Button();
            this.itemUpdateButton = new System.Windows.Forms.Button();
            this.itemSortButton = new System.Windows.Forms.Button();
            this.selectMenuButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.itemBoxLabel = new System.Windows.Forms.Label();
            this.sortLabel = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.menuChoice = new System.Windows.Forms.ComboBox();
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
            // itmLabel
            // 
            this.itmLabel.BackColor = System.Drawing.Color.Orange;
            this.itmLabel.Location = new System.Drawing.Point(189, 72);
            this.itmLabel.Name = "itmLabel";
            this.itmLabel.Size = new System.Drawing.Size(100, 23);
            this.itmLabel.TabIndex = 1;
            this.itmLabel.Text = "食材名";
            this.itmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Orange;
            this.dateLabel.Location = new System.Drawing.Point(189, 111);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(100, 23);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "賞味期限";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(295, 74);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(297, 19);
            this.itemNameTextBox.TabIndex = 3;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(295, 113);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(297, 19);
            this.dateTextBox.TabIndex = 4;
            // 
            // itemAddButton
            // 
            this.itemAddButton.BackColor = System.Drawing.Color.DarkOrange;
            this.itemAddButton.Location = new System.Drawing.Point(422, 168);
            this.itemAddButton.Name = "itemAddButton";
            this.itemAddButton.Size = new System.Drawing.Size(140, 26);
            this.itemAddButton.TabIndex = 5;
            this.itemAddButton.Text = "食材登録";
            this.itemAddButton.UseVisualStyleBackColor = false;
            this.itemAddButton.Click += new System.EventHandler(this.itemAddButton_Click);
            // 
            // itemUpdateButton
            // 
            this.itemUpdateButton.BackColor = System.Drawing.Color.DarkOrange;
            this.itemUpdateButton.Location = new System.Drawing.Point(585, 168);
            this.itemUpdateButton.Name = "itemUpdateButton";
            this.itemUpdateButton.Size = new System.Drawing.Size(140, 26);
            this.itemUpdateButton.TabIndex = 6;
            this.itemUpdateButton.Text = "食材更新";
            this.itemUpdateButton.UseVisualStyleBackColor = false;
            this.itemUpdateButton.Click += new System.EventHandler(this.itemUpdateButton_Click);
            // 
            // itemSortButton
            // 
            this.itemSortButton.BackColor = System.Drawing.Color.DarkOrange;
            this.itemSortButton.Location = new System.Drawing.Point(329, 219);
            this.itemSortButton.Name = "itemSortButton";
            this.itemSortButton.Size = new System.Drawing.Size(244, 83);
            this.itemSortButton.TabIndex = 7;
            this.itemSortButton.Text = "この食材でメニューを\r\n絞り込む";
            this.itemSortButton.UseVisualStyleBackColor = false;
            this.itemSortButton.Click += new System.EventHandler(this.itemSortButton_Click);
            // 
            // selectMenuButton
            // 
            this.selectMenuButton.BackColor = System.Drawing.Color.DarkOrange;
            this.selectMenuButton.Location = new System.Drawing.Point(329, 319);
            this.selectMenuButton.Name = "selectMenuButton";
            this.selectMenuButton.Size = new System.Drawing.Size(244, 83);
            this.selectMenuButton.TabIndex = 8;
            this.selectMenuButton.Text = "選択したメニュー\r\nを表示する";
            this.selectMenuButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkOrange;
            this.deleteButton.Location = new System.Drawing.Point(620, 219);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 83);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "食材消去";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // itemBoxLabel
            // 
            this.itemBoxLabel.BackColor = System.Drawing.Color.Orange;
            this.itemBoxLabel.Location = new System.Drawing.Point(66, 168);
            this.itemBoxLabel.Name = "itemBoxLabel";
            this.itemBoxLabel.Size = new System.Drawing.Size(184, 23);
            this.itemBoxLabel.TabIndex = 10;
            this.itemBoxLabel.Text = "食材一覧";
            this.itemBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sortLabel
            // 
            this.sortLabel.BackColor = System.Drawing.Color.Orange;
            this.sortLabel.Location = new System.Drawing.Point(66, 309);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(184, 23);
            this.sortLabel.TabIndex = 11;
            this.sortLabel.Text = "絞り込まれたメニュー一覧";
            this.sortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemComboBox
            // 
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(68, 195);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(121, 20);
            this.itemComboBox.TabIndex = 12;
            // 
            // menuChoice
            // 
            this.menuChoice.FormattingEnabled = true;
            this.menuChoice.Location = new System.Drawing.Point(68, 335);
            this.menuChoice.Name = "menuChoice";
            this.menuChoice.Size = new System.Drawing.Size(121, 20);
            this.menuChoice.TabIndex = 13;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuChoice);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.sortLabel);
            this.Controls.Add(this.itemBoxLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.selectMenuButton);
            this.Controls.Add(this.itemSortButton);
            this.Controls.Add(this.itemUpdateButton);
            this.Controls.Add(this.itemAddButton);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.itmLabel);
            this.Controls.Add(this.backButton);
            this.Name = "ItemForm";
            this.Text = "食材一覧";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.Label itmLabel;
		private System.Windows.Forms.Label dateLabel;
		private System.Windows.Forms.TextBox itemNameTextBox;
		private System.Windows.Forms.TextBox dateTextBox;
		private System.Windows.Forms.Button itemAddButton;
		private System.Windows.Forms.Button itemUpdateButton;
		private System.Windows.Forms.Button itemSortButton;
		private System.Windows.Forms.Button selectMenuButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Label itemBoxLabel;
		private System.Windows.Forms.Label sortLabel;
		private System.Windows.Forms.ComboBox itemComboBox;
		private System.Windows.Forms.ComboBox menuChoice;
	}
}