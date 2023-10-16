namespace C__JavaTypingGame
{
    partial class playForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox = new System.Windows.Forms.TextBox();
            this.timeCountTextBox = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.endBottun = new System.Windows.Forms.Button();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.startBottun = new System.Windows.Forms.Button();
            this.CountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(32, 44);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(76, 22);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "残り時間";
            this.textBox.UseWaitCursor = true;
            // 
            // timeCountTextBox
            // 
            this.timeCountTextBox.Location = new System.Drawing.Point(117, 44);
            this.timeCountTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeCountTextBox.Name = "timeCountTextBox";
            this.timeCountTextBox.Size = new System.Drawing.Size(36, 22);
            this.timeCountTextBox.TabIndex = 1;
            this.timeCountTextBox.Text = "60";
            this.timeCountTextBox.UseWaitCursor = true;
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.questionLabel.Enabled = false;
            this.questionLabel.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.questionLabel.Location = new System.Drawing.Point(29, 70);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(1003, 197);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.UseWaitCursor = true;
            this.questionLabel.Click += new System.EventHandler(this.questionLabel_Click);
            // 
            // endBottun
            // 
            this.endBottun.Location = new System.Drawing.Point(903, 474);
            this.endBottun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endBottun.Name = "endBottun";
            this.endBottun.Size = new System.Drawing.Size(129, 48);
            this.endBottun.TabIndex = 4;
            this.endBottun.Text = "終了";
            this.endBottun.UseVisualStyleBackColor = true;
            this.endBottun.UseWaitCursor = true;
            // 
            // answerTextBox
            // 
            this.answerTextBox.AcceptsReturn = true;
            this.answerTextBox.Location = new System.Drawing.Point(32, 271);
            this.answerTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(999, 197);
            this.answerTextBox.TabIndex = 5;
            this.answerTextBox.UseWaitCursor = true;
            this.answerTextBox.TextChanged += new System.EventHandler(this.answerTextBox_TextChanged);
            // 
            // startBottun
            // 
            this.startBottun.Location = new System.Drawing.Point(32, 483);
            this.startBottun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startBottun.Name = "startBottun";
            this.startBottun.Size = new System.Drawing.Size(129, 48);
            this.startBottun.TabIndex = 6;
            this.startBottun.Text = "開始";
            this.startBottun.UseVisualStyleBackColor = true;
            this.startBottun.UseWaitCursor = true;
            this.startBottun.Click += new System.EventHandler(this.startBottun_Click);
            // 
            // CountDownTimer
            // 
            this.CountDownTimer.Interval = 1000;
            this.CountDownTimer.Tick += new System.EventHandler(this.CountDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 493);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "デバッグ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // playForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startBottun);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.endBottun);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.timeCountTextBox);
            this.Controls.Add(this.textBox);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "playForm";
            this.Text = "問題画面";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.playForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox timeCountTextBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button endBottun;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button startBottun;
        private System.Windows.Forms.Timer CountDownTimer;
        private System.Windows.Forms.Button button1;
    }
}

