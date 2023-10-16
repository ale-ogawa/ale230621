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
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameLabel.Location = new System.Drawing.Point(90, 37);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(187, 38);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "新規ユーザー名";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(181, 78);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(277, 19);
            this.userText.TabIndex = 1;
            this.userText.TextChanged += new System.EventHandler(this.userText_TextChanged);
            // 
            // passLabel
            // 
            this.passLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passLabel.Location = new System.Drawing.Point(90, 144);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(187, 38);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "パスワード";
            this.passLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(181, 185);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(277, 19);
            this.passText.TabIndex = 3;
            this.passText.TextChanged += new System.EventHandler(this.passText_TextChanged);
            // 
            // passCheck
            // 
            this.passCheck.AutoSize = true;
            this.passCheck.Location = new System.Drawing.Point(181, 221);
            this.passCheck.Name = "passCheck";
            this.passCheck.Size = new System.Drawing.Size(101, 16);
            this.passCheck.TabIndex = 4;
            this.passCheck.Text = "パスワードを見る";
            this.passCheck.UseVisualStyleBackColor = true;
            this.passCheck.CheckedChanged += new System.EventHandler(this.passCheck_CheckedChanged);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(131, 243);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(151, 54);
            this.checkButton.TabIndex = 8;
            this.checkButton.Text = "確認";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(411, 257);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(135, 40);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 309);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.passCheck);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.nameLabel);
            this.Name = "newRegistrationForm";
            this.Text = "newRegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.CheckBox passCheck;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button backButton;
    }
}