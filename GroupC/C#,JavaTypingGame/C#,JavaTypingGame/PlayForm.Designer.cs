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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(24, 12);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(58, 19);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "残り時間";
            this.textBox.UseWaitCursor = true;
            // 
            // timeCountTextBox
            // 
            this.timeCountTextBox.Location = new System.Drawing.Point(88, 12);
            this.timeCountTextBox.Name = "timeCountTextBox";
            this.timeCountTextBox.Size = new System.Drawing.Size(28, 19);
            this.timeCountTextBox.TabIndex = 1;
            this.timeCountTextBox.Text = "60";
            this.timeCountTextBox.UseWaitCursor = true;
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.questionLabel.Enabled = false;
            this.questionLabel.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.questionLabel.Location = new System.Drawing.Point(22, 34);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(1300, 305);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.UseWaitCursor = true;
            // 
            // endBottun
            // 
            this.endBottun.Location = new System.Drawing.Point(1227, 653);
            this.endBottun.Name = "endBottun";
            this.endBottun.Size = new System.Drawing.Size(97, 38);
            this.endBottun.TabIndex = 4;
            this.endBottun.Text = "終了";
            this.endBottun.UseVisualStyleBackColor = true;
            this.endBottun.UseWaitCursor = true;
            this.endBottun.Click += new System.EventHandler(this.endBottun_Click);
            // 
            // answerTextBox
            // 
            this.answerTextBox.AcceptsReturn = true;
            this.answerTextBox.Location = new System.Drawing.Point(24, 342);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(1300, 305);
            this.answerTextBox.TabIndex = 5;
            this.answerTextBox.UseWaitCursor = true;
            this.answerTextBox.TextChanged += new System.EventHandler(this.answerTextBox_TextChanged);
            // 
            // startBottun
            // 
            this.startBottun.Location = new System.Drawing.Point(24, 653);
            this.startBottun.Name = "startBottun";
            this.startBottun.Size = new System.Drawing.Size(97, 38);
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(131, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "□は半角スペースキーを入力してください";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            // 
            // playForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1370, 693);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBottun);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.endBottun);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.timeCountTextBox);
            this.Controls.Add(this.textBox);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "playForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "問題画面";
            this.UseWaitCursor = true;
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
        private System.Windows.Forms.Label label1;
    }
}

