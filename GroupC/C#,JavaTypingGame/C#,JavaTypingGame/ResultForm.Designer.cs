namespace C__JavaTypingGame
{
    partial class ResultForm
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
            this.runkingButton = new System.Windows.Forms.Button();
            this.retryButton = new System.Windows.Forms.Button();
            this.languageSelectionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TotalScoreTextBox = new System.Windows.Forms.TextBox();
            this.MissTextBox = new System.Windows.Forms.TextBox();
            this.correctTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.langLevelTextBox = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // runkingButton
            // 
            this.runkingButton.Location = new System.Drawing.Point(66, 98);
            this.runkingButton.Name = "runkingButton";
            this.runkingButton.Size = new System.Drawing.Size(232, 55);
            this.runkingButton.TabIndex = 0;
            this.runkingButton.Text = "ランキングを表示";
            this.runkingButton.UseVisualStyleBackColor = true;
            this.runkingButton.Click += new System.EventHandler(this.runkingButton_Click);
            // 
            // retryButton
            // 
            this.retryButton.Location = new System.Drawing.Point(66, 197);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(232, 55);
            this.retryButton.TabIndex = 1;
            this.retryButton.Text = "リトライ";
            this.retryButton.UseVisualStyleBackColor = true;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            // 
            // languageSelectionButton
            // 
            this.languageSelectionButton.Location = new System.Drawing.Point(66, 298);
            this.languageSelectionButton.Name = "languageSelectionButton";
            this.languageSelectionButton.Size = new System.Drawing.Size(232, 55);
            this.languageSelectionButton.TabIndex = 2;
            this.languageSelectionButton.Text = "メニューに戻る";
            this.languageSelectionButton.UseVisualStyleBackColor = true;
            this.languageSelectionButton.Click += new System.EventHandler(this.languageSelectionButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(60, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "入力正解数";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TotalScoreTextBox);
            this.groupBox1.Controls.Add(this.MissTextBox);
            this.groupBox1.Controls.Add(this.correctTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(355, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 264);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "リザルト";
            // 
            // TotalScoreTextBox
            // 
            this.TotalScoreTextBox.Enabled = false;
            this.TotalScoreTextBox.Location = new System.Drawing.Point(230, 210);
            this.TotalScoreTextBox.Name = "TotalScoreTextBox";
            this.TotalScoreTextBox.Size = new System.Drawing.Size(100, 19);
            this.TotalScoreTextBox.TabIndex = 8;
            // 
            // MissTextBox
            // 
            this.MissTextBox.Enabled = false;
            this.MissTextBox.Location = new System.Drawing.Point(230, 135);
            this.MissTextBox.Name = "MissTextBox";
            this.MissTextBox.Size = new System.Drawing.Size(100, 19);
            this.MissTextBox.TabIndex = 7;
            // 
            // correctTextBox
            // 
            this.correctTextBox.Enabled = false;
            this.correctTextBox.Location = new System.Drawing.Point(230, 57);
            this.correctTextBox.Name = "correctTextBox";
            this.correctTextBox.Size = new System.Drawing.Size(100, 19);
            this.correctTextBox.TabIndex = 6;
            this.correctTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(60, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "トータルスコア";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(60, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "ミスタイプ数";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // langLevelTextBox
            // 
            this.langLevelTextBox.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.langLevelTextBox.Location = new System.Drawing.Point(64, 36);
            this.langLevelTextBox.Name = "langLevelTextBox";
            this.langLevelTextBox.Size = new System.Drawing.Size(696, 59);
            this.langLevelTextBox.TabIndex = 5;
            this.langLevelTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.langLevelTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.languageSelectionButton);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.runkingButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "リザルト画面";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runkingButton;
        private System.Windows.Forms.Button retryButton;
        private System.Windows.Forms.Button languageSelectionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox correctTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalScoreTextBox;
        private System.Windows.Forms.TextBox MissTextBox;
        private System.Windows.Forms.Label langLevelTextBox;
    }
}