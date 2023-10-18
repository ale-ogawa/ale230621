namespace WindowsFormsApp3
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.exerciseRecordAddButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exerciseComboBox = new System.Windows.Forms.ComboBox();
            this.exerciseTimeTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "運動内容";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "運動時間";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "体重";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(12, 294);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(90, 45);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "戻る";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // exerciseRecordAddButton
            // 
            this.exerciseRecordAddButton.Location = new System.Drawing.Point(169, 288);
            this.exerciseRecordAddButton.Name = "exerciseRecordAddButton";
            this.exerciseRecordAddButton.Size = new System.Drawing.Size(229, 51);
            this.exerciseRecordAddButton.TabIndex = 4;
            this.exerciseRecordAddButton.Text = "運動記録を追加する";
            this.exerciseRecordAddButton.UseVisualStyleBackColor = true;
            this.exerciseRecordAddButton.Click += new System.EventHandler(this.exerciseRecordAddButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(481, 295);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 44);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "クリア";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exerciseComboBox
            // 
            this.exerciseComboBox.FormattingEnabled = true;
            this.exerciseComboBox.Location = new System.Drawing.Point(234, 49);
            this.exerciseComboBox.Name = "exerciseComboBox";
            this.exerciseComboBox.Size = new System.Drawing.Size(134, 20);
            this.exerciseComboBox.TabIndex = 6;
            // 
            // exerciseTimeTextBox
            // 
            this.exerciseTimeTextBox.Location = new System.Drawing.Point(234, 120);
            this.exerciseTimeTextBox.Name = "exerciseTimeTextBox";
            this.exerciseTimeTextBox.Size = new System.Drawing.Size(100, 19);
            this.exerciseTimeTextBox.TabIndex = 7;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(234, 184);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 19);
            this.weightTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "(半角数字)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "(半角数字)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "kg";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.exerciseTimeTextBox);
            this.Controls.Add(this.exerciseComboBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exerciseRecordAddButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "運動記録入力";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button exerciseRecordAddButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox exerciseComboBox;
        private System.Windows.Forms.TextBox exerciseTimeTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}