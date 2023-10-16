namespace typingGame
{
    partial class RegistrationForm
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
            this.checkText = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.passCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkText
            // 
            this.checkText.AutoSize = true;
            this.checkText.Location = new System.Drawing.Point(165, 176);
            this.checkText.Name = "checkText";
            this.checkText.Size = new System.Drawing.Size(245, 12);
            this.checkText.TabIndex = 0;
            this.checkText.Text = "登録内容を確認し、よろしければ登録をしてください";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameLabel.Location = new System.Drawing.Point(121, 61);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "ユーザー名：";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passLabel
            // 
            this.passLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passLabel.Location = new System.Drawing.Point(121, 112);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(100, 23);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "パスワード：";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.userName.Location = new System.Drawing.Point(227, 61);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(220, 23);
            this.userName.TabIndex = 3;
            this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.password.Location = new System.Drawing.Point(227, 112);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(220, 23);
            this.password.TabIndex = 4;
            this.password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(402, 255);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(135, 40);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 59);
            this.button1.TabIndex = 10;
            this.button1.Text = "登録";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // passCheck
            // 
            this.passCheck.AutoSize = true;
            this.passCheck.Location = new System.Drawing.Point(220, 148);
            this.passCheck.Name = "passCheck";
            this.passCheck.Size = new System.Drawing.Size(101, 16);
            this.passCheck.TabIndex = 11;
            this.passCheck.Text = "パスワードを見る";
            this.passCheck.UseVisualStyleBackColor = true;
            this.passCheck.CheckedChanged += new System.EventHandler(this.passCheck_CheckedChanged);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 307);
            this.Controls.Add(this.passCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.checkText);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox passCheck;
    }
}