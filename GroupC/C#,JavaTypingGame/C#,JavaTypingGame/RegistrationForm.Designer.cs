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
            this.nameLabel = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.passCheck = new System.Windows.Forms.CheckBox();
            this.checkText = new System.Windows.Forms.Label();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameLabel.Location = new System.Drawing.Point(220, 79);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "ユーザー名：";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.userName.Location = new System.Drawing.Point(326, 79);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(220, 23);
            this.userName.TabIndex = 4;
            this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passLabel
            // 
            this.passLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passLabel.Location = new System.Drawing.Point(220, 161);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(100, 23);
            this.passLabel.TabIndex = 5;
            this.passLabel.Text = "パスワード：";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.password.Location = new System.Drawing.Point(326, 161);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(220, 23);
            this.password.TabIndex = 6;
            this.password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.password.Visible = false;
            // 
            // passCheck
            // 
            this.passCheck.AutoSize = true;
            this.passCheck.Location = new System.Drawing.Point(329, 199);
            this.passCheck.Name = "passCheck";
            this.passCheck.Size = new System.Drawing.Size(101, 16);
            this.passCheck.TabIndex = 12;
            this.passCheck.Text = "パスワードを見る";
            this.passCheck.UseVisualStyleBackColor = true;
            this.passCheck.CheckedChanged += new System.EventHandler(this.passCheck_CheckedChanged);
            // 
            // checkText
            // 
            this.checkText.AutoSize = true;
            this.checkText.Location = new System.Drawing.Point(250, 241);
            this.checkText.Name = "checkText";
            this.checkText.Size = new System.Drawing.Size(245, 12);
            this.checkText.TabIndex = 13;
            this.checkText.Text = "登録内容を確認し、よろしければ登録をしてください";
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(190, 295);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(157, 59);
            this.RegistrationButton.TabIndex = 14;
            this.RegistrationButton.Text = "登録";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(468, 304);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(135, 40);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "-------------------------------------\r\n";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.checkText);
            this.Controls.Add(this.passCheck);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.nameLabel);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.CheckBox passCheck;
        private System.Windows.Forms.Label checkText;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button backButton;
        public System.Windows.Forms.Label userName;
        public System.Windows.Forms.Label password;
        private System.Windows.Forms.Label label1;
    }
}