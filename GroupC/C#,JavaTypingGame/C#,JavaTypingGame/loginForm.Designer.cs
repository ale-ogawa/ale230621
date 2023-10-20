namespace typingGame
{
    partial class loginForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.passCheck = new System.Windows.Forms.CheckBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.userText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.backButton.Location = new System.Drawing.Point(479, 309);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(138, 54);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.loginButton.Location = new System.Drawing.Point(181, 309);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(138, 54);
            this.loginButton.TabIndex = 14;
            this.loginButton.Text = "ログイン";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passCheck
            // 
            this.passCheck.AutoSize = true;
            this.passCheck.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passCheck.Location = new System.Drawing.Point(275, 247);
            this.passCheck.Name = "passCheck";
            this.passCheck.Size = new System.Drawing.Size(120, 16);
            this.passCheck.TabIndex = 13;
            this.passCheck.Text = "パスワードを見る";
            this.passCheck.UseVisualStyleBackColor = true;
            this.passCheck.CheckedChanged += new System.EventHandler(this.passCheck_CheckedChanged);
            // 
            // passLabel
            // 
            this.passLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passLabel.Location = new System.Drawing.Point(147, 167);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(187, 38);
            this.passLabel.TabIndex = 12;
            this.passLabel.Text = "パスワード";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameLabel.Location = new System.Drawing.Point(147, 65);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(187, 38);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "ユーザー名";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(275, 208);
            this.passText.Name = "passText";
            this.passText.PasswordChar = '・';
            this.passText.Size = new System.Drawing.Size(277, 19);
            this.passText.TabIndex = 9;
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(275, 106);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(277, 19);
            this.userText.TabIndex = 11;
            // 
            // loginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passCheck);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.passText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginForm";
            this.Activated += new System.EventHandler(this.loginForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox passCheck;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox userText;
    }
}