namespace typingGame
{
    partial class Form1
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
            this.title = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.newRegistrationButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("ＭＳ 明朝", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.title.Location = new System.Drawing.Point(135, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(495, 91);
            this.title.TabIndex = 1;
            this.title.Text = "title";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(275, 140);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(210, 65);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "ログイン";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // newRegistrationButton
            // 
            this.newRegistrationButton.Location = new System.Drawing.Point(275, 231);
            this.newRegistrationButton.Name = "newRegistrationButton";
            this.newRegistrationButton.Size = new System.Drawing.Size(210, 65);
            this.newRegistrationButton.TabIndex = 3;
            this.newRegistrationButton.Text = "新規登録";
            this.newRegistrationButton.UseVisualStyleBackColor = true;
            this.newRegistrationButton.Click += new System.EventHandler(this.newRegistrationButton_Click);
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(275, 314);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(210, 65);
            this.endButton.TabIndex = 4;
            this.endButton.Text = "終了";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.newRegistrationButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button newRegistrationButton;
        private System.Windows.Forms.Button endButton;
    }
}

