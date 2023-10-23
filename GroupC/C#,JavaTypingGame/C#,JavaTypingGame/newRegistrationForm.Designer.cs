namespace typingGame
{
    partial class newRegistrationForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.passCheck = new System.Windows.Forms.CheckBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nameLabel.Location = new System.Drawing.Point(171, 70);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(187, 38);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "新規ユーザー名";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(266, 111);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(277, 19);
            this.userText.TabIndex = 2;
            // 
            // passLabel
            // 
            this.passLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passLabel.Location = new System.Drawing.Point(171, 153);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(187, 38);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "パスワード";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(266, 194);
            this.passText.Name = "passText";
            this.passText.PasswordChar = '・';
            this.passText.Size = new System.Drawing.Size(277, 19);
            this.passText.TabIndex = 4;
            // 
            // passCheck
            // 
            this.passCheck.AutoSize = true;
            this.passCheck.Location = new System.Drawing.Point(266, 229);
            this.passCheck.Name = "passCheck";
            this.passCheck.Size = new System.Drawing.Size(101, 16);
            this.passCheck.TabIndex = 5;
            this.passCheck.Text = "パスワードを見る";
            this.passCheck.UseVisualStyleBackColor = true;
            this.passCheck.CheckedChanged += new System.EventHandler(this.passCheck_CheckedChanged);
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkButton.Location = new System.Drawing.Point(140, 320);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(151, 54);
            this.checkButton.TabIndex = 9;
            this.checkButton.Text = "確認";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.backButton.Location = new System.Drawing.Point(529, 320);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(135, 54);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(211, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "*4文字以上10文字以下の英数字で設定してください。";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newRegistrationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.passCheck);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newRegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.CheckBox passCheck;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button backButton;
        public System.Windows.Forms.TextBox userText;
        public System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Label label1;
    }
}