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
            this.passText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.passCheck = new System.Windows.Forms.CheckBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(174, 180);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(277, 19);
            this.passText.TabIndex = 2;
            this.passText.TextChanged += new System.EventHandler(this.passText_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameLabel.Location = new System.Drawing.Point(98, 37);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(187, 38);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "ユーザー名";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(185, 78);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(277, 19);
            this.userText.TabIndex = 4;
            this.userText.TextChanged += new System.EventHandler(this.userText_TextChanged);
            // 
            // passLabel
            // 
            this.passLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passLabel.Location = new System.Drawing.Point(98, 139);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(187, 38);
            this.passLabel.TabIndex = 5;
            this.passLabel.Text = "パスワード";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passCheck
            // 
            this.passCheck.AutoSize = true;
            this.passCheck.Location = new System.Drawing.Point(174, 216);
            this.passCheck.Name = "passCheck";
            this.passCheck.Size = new System.Drawing.Size(101, 16);
            this.passCheck.TabIndex = 6;
            this.passCheck.Text = "パスワードを見る";
            this.passCheck.UseVisualStyleBackColor = true;
            this.passCheck.CheckedChanged += new System.EventHandler(this.passCheck_CheckedChanged);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(134, 245);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(151, 54);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "ログイン";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(457, 259);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(135, 40);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 311);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passCheck);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.passText);
            this.Name = "loginForm";
            this.Text = "liginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.CheckBox passCheck;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button backButton;
    }
}