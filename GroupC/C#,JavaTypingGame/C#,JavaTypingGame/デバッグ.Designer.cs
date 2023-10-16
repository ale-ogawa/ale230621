namespace C__JavaTypingGame
{
    partial class デバッグ
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
            this.entryBottun = new System.Windows.Forms.Button();
            this.loginBottun = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // entryBottun
            // 
            this.entryBottun.Location = new System.Drawing.Point(586, 79);
            this.entryBottun.Name = "entryBottun";
            this.entryBottun.Size = new System.Drawing.Size(75, 23);
            this.entryBottun.TabIndex = 0;
            this.entryBottun.Text = "登録";
            this.entryBottun.UseVisualStyleBackColor = true;
            this.entryBottun.Click += new System.EventHandler(this.entryBottun_Click);
            // 
            // loginBottun
            // 
            this.loginBottun.Location = new System.Drawing.Point(586, 144);
            this.loginBottun.Name = "loginBottun";
            this.loginBottun.Size = new System.Drawing.Size(75, 23);
            this.loginBottun.TabIndex = 1;
            this.loginBottun.Text = "ログイン";
            this.loginBottun.UseVisualStyleBackColor = true;
            this.loginBottun.Click += new System.EventHandler(this.loginBottun_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(109, 79);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 19);
            this.name.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(109, 146);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 19);
            this.pass.TabIndex = 3;
            // 
            // デバッグ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.name);
            this.Controls.Add(this.loginBottun);
            this.Controls.Add(this.entryBottun);
            this.Name = "デバッグ";
            this.Text = "デバッグ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entryBottun;
        private System.Windows.Forms.Button loginBottun;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox pass;
    }
}