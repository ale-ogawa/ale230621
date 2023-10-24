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
            this.itemRegisterButton = new System.Windows.Forms.Button();
            this.itemUpdateButton = new System.Windows.Forms.Button();
            this.menuChoiceButton = new System.Windows.Forms.Button();
            this.menuShowButton = new System.Windows.Forms.Button();
            this.itemDeleteButton = new System.Windows.Forms.Button();
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
            // itemRegisterButton
            // 
            this.itemRegisterButton.BackColor = System.Drawing.Color.DarkOrange;
            this.itemRegisterButton.Location = new System.Drawing.Point(422, 168);
            this.itemRegisterButton.Name = "itemRegisterButton";
            this.itemRegisterButton.Size = new System.Drawing.Size(140, 26);
            this.itemRegisterButton.TabIndex = 5;
            this.itemRegisterButton.Text = "食材登録";
            this.itemRegisterButton.UseVisualStyleBackColor = false;
            this.itemRegisterButton.Click += new System.EventHandler(this.itemRegisterButton_Click);
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
            // menuChoiceButton
            // 
            this.menuChoiceButton.BackColor = System.Drawing.Color.DarkOrange;
            this.menuChoiceButton.Location = new System.Drawing.Point(329, 219);
            this.menuChoiceButton.Name = "menuChoiceButton";
            this.menuChoiceButton.Size = new System.Drawing.Size(244, 83);
            this.menuChoiceButton.TabIndex = 7;
            this.menuChoiceButton.Text = "この食材でメニューを\r\n絞り込む";
            this.menuChoiceButton.UseVisualStyleBackColor = false;
            this.menuChoiceButton.Click += new System.EventHandler(this.menuChoiceButton_Click);
            // 
            // menuShowButton
            // 
            this.menuShowButton.BackColor = System.Drawing.Color.DarkOrange;
            this.menuShowButton.Location = new System.Drawing.Point(329, 319);
            this.menuShowButton.Name = "menuShowButton";
            this.menuShowButton.Size = new System.Drawing.Size(244, 83);
            this.menuShowButton.TabIndex = 8;
            this.menuShowButton.Text = "選択したメニュー\r\nを表示する";
            this.menuShowButton.UseVisualStyleBackColor = false;
            this.menuShowButton.Click += new System.EventHandler(this.menuShowButton_Click);
            // 
            // itemDeleteButton
            // 
            this.itemDeleteButton.BackColor = System.Drawing.Color.DarkOrange;
            this.itemDeleteButton.Location = new System.Drawing.Point(620, 219);
            this.itemDeleteButton.Name = "itemDeleteButton";
            this.itemDeleteButton.Size = new System.Drawing.Size(105, 83);
            this.itemDeleteButton.TabIndex = 9;
            this.itemDeleteButton.Text = "食材消去";
            this.itemDeleteButton.UseVisualStyleBackColor = false;
            this.itemDeleteButton.Click += new System.EventHandler(this.itemDeleteButton_Click);
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
            this.itemComboBox.Location = new System.Drawing.Point(68, 194);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(221, 20);
            this.itemComboBox.TabIndex = 14;
            // 
            // menuChoice
            // 
            this.menuChoice.FormattingEnabled = true;
            this.menuChoice.Location = new System.Drawing.Point(68, 335);
            this.menuChoice.Name = "menuChoice";
            this.menuChoice.Size = new System.Drawing.Size(221, 20);
            this.menuChoice.TabIndex = 15;
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
            this.Controls.Add(this.itemDeleteButton);
            this.Controls.Add(this.menuShowButton);
            this.Controls.Add(this.menuChoiceButton);
            this.Controls.Add(this.itemUpdateButton);
            this.Controls.Add(this.itemRegisterButton);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.itmLabel);
            this.Controls.Add(this.backButton);
            this.Name = "ItemForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ItemForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.Label itmLabel;
		private System.Windows.Forms.Label dateLabel;
		private System.Windows.Forms.TextBox itemNameTextBox;
		private System.Windows.Forms.TextBox dateTextBox;
		private System.Windows.Forms.Button itemRegisterButton;
		private System.Windows.Forms.Button itemUpdateButton;
		private System.Windows.Forms.Button menuChoiceButton;
		private System.Windows.Forms.Button menuShowButton;
		private System.Windows.Forms.Button itemDeleteButton;
		private System.Windows.Forms.Label itemBoxLabel;
		private System.Windows.Forms.Label sortLabel;
		private System.Windows.Forms.ComboBox itemComboBox;
		private System.Windows.Forms.ComboBox menuChoice;
	}
}