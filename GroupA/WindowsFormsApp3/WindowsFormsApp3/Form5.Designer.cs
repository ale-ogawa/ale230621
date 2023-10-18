namespace WindowsFormsApp3
{
    partial class Form5
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
            this.returnButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mealTextBox = new System.Windows.Forms.TextBox();
            this.energyTextBox = new System.Windows.Forms.TextBox();
            this.mealComboBox = new System.Windows.Forms.ComboBox();
            this.mealChoiceRadioButton = new System.Windows.Forms.RadioButton();
            this.mealInputRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(12, 297);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(86, 48);
            this.returnButton.TabIndex = 0;
            this.returnButton.Text = "戻る";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(177, 297);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(215, 48);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "食事の記録を追加する";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(465, 297);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 48);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "クリア";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "食事内容";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "摂取カロリー";
            // 
            // mealTextBox
            // 
            this.mealTextBox.Location = new System.Drawing.Point(140, 172);
            this.mealTextBox.Name = "mealTextBox";
            this.mealTextBox.Size = new System.Drawing.Size(102, 19);
            this.mealTextBox.TabIndex = 7;
            // 
            // energyTextBox
            // 
            this.energyTextBox.Location = new System.Drawing.Point(417, 172);
            this.energyTextBox.Name = "energyTextBox";
            this.energyTextBox.Size = new System.Drawing.Size(94, 19);
            this.energyTextBox.TabIndex = 8;
            // 
            // mealComboBox
            // 
            this.mealComboBox.FormattingEnabled = true;
            this.mealComboBox.Location = new System.Drawing.Point(119, 49);
            this.mealComboBox.Name = "mealComboBox";
            this.mealComboBox.Size = new System.Drawing.Size(152, 20);
            this.mealComboBox.TabIndex = 9;
            // 
            // mealChoiceRadioButton
            // 
            this.mealChoiceRadioButton.AutoSize = true;
            this.mealChoiceRadioButton.Location = new System.Drawing.Point(31, 12);
            this.mealChoiceRadioButton.Name = "mealChoiceRadioButton";
            this.mealChoiceRadioButton.Size = new System.Drawing.Size(123, 16);
            this.mealChoiceRadioButton.TabIndex = 10;
            this.mealChoiceRadioButton.TabStop = true;
            this.mealChoiceRadioButton.Text = "食事内容を選択する";
            this.mealChoiceRadioButton.UseVisualStyleBackColor = true;
            this.mealChoiceRadioButton.CheckedChanged += new System.EventHandler(this.choiceRadioButton_CheckedChanged);
            // 
            // mealInputRadioButton
            // 
            this.mealInputRadioButton.AutoSize = true;
            this.mealInputRadioButton.Location = new System.Drawing.Point(31, 133);
            this.mealInputRadioButton.Name = "mealInputRadioButton";
            this.mealInputRadioButton.Size = new System.Drawing.Size(123, 16);
            this.mealInputRadioButton.TabIndex = 11;
            this.mealInputRadioButton.TabStop = true;
            this.mealInputRadioButton.Text = "食事内容を入力する";
            this.mealInputRadioButton.UseVisualStyleBackColor = true;
            this.mealInputRadioButton.CheckedChanged += new System.EventHandler(this.inputRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "(半角数字)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "kcal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "(例)ご飯";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mealInputRadioButton);
            this.Controls.Add(this.mealChoiceRadioButton);
            this.Controls.Add(this.mealComboBox);
            this.Controls.Add(this.energyTextBox);
            this.Controls.Add(this.mealTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.returnButton);
            this.Name = "Form5";
            this.Text = "食事記録入力";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mealTextBox;
        private System.Windows.Forms.TextBox energyTextBox;
        private System.Windows.Forms.ComboBox mealComboBox;
        private System.Windows.Forms.RadioButton mealChoiceRadioButton;
        private System.Windows.Forms.RadioButton mealInputRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}