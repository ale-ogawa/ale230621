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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loginButton = new System.Windows.Forms.Button();
            this.newRegistrationButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gustButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginButton.BackgroundImage")));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.loginButton.ForeColor = System.Drawing.Color.Transparent;
            this.loginButton.Location = new System.Drawing.Point(291, 143);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(210, 65);
            this.loginButton.TabIndex = 3;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // newRegistrationButton
            // 
            this.newRegistrationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newRegistrationButton.BackgroundImage")));
            this.newRegistrationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.newRegistrationButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.newRegistrationButton.Location = new System.Drawing.Point(291, 218);
            this.newRegistrationButton.Name = "newRegistrationButton";
            this.newRegistrationButton.Size = new System.Drawing.Size(210, 65);
            this.newRegistrationButton.TabIndex = 4;
            this.newRegistrationButton.UseVisualStyleBackColor = true;
            this.newRegistrationButton.Click += new System.EventHandler(this.newRegistrationButton_Click);
            // 
            // endButton
            // 
            this.endButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("endButton.BackgroundImage")));
            this.endButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.endButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.endButton.Location = new System.Drawing.Point(291, 370);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(210, 65);
            this.endButton.TabIndex = 5;
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(135, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 131);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // gustButton
            // 
            this.gustButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gustButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gustButton.Location = new System.Drawing.Point(291, 293);
            this.gustButton.Name = "gustButton";
            this.gustButton.Size = new System.Drawing.Size(210, 65);
            this.gustButton.TabIndex = 7;
            this.gustButton.Text = "ゲストプレイ";
            this.gustButton.UseVisualStyleBackColor = true;
            this.gustButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(213)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gustButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.newRegistrationButton);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button newRegistrationButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button gustButton;
    }
}

