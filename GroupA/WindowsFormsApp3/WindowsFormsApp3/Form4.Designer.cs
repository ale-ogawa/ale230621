namespace WindowsFormsApp3
{
    partial class Form4
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
            this.eatButton = new System.Windows.Forms.Button();
            this.today_historyButton = new System.Windows.Forms.Button();
            this.exerciseButton = new System.Windows.Forms.Button();
            this.week_historyButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eatButton
            // 
            this.eatButton.Location = new System.Drawing.Point(46, 38);
            this.eatButton.Name = "eatButton";
            this.eatButton.Size = new System.Drawing.Size(178, 69);
            this.eatButton.TabIndex = 0;
            this.eatButton.Text = "食事記録入力";
            this.eatButton.UseVisualStyleBackColor = true;
            this.eatButton.Click += new System.EventHandler(this.eatButton_Click);
            // 
            // today_historyButton
            // 
            this.today_historyButton.Location = new System.Drawing.Point(285, 38);
            this.today_historyButton.Name = "today_historyButton";
            this.today_historyButton.Size = new System.Drawing.Size(186, 69);
            this.today_historyButton.TabIndex = 1;
            this.today_historyButton.Text = "1日の結果";
            this.today_historyButton.UseVisualStyleBackColor = true;
            this.today_historyButton.Click += new System.EventHandler(this.today_historyButton_Click);
            // 
            // exerciseButton
            // 
            this.exerciseButton.Location = new System.Drawing.Point(46, 144);
            this.exerciseButton.Name = "exerciseButton";
            this.exerciseButton.Size = new System.Drawing.Size(178, 69);
            this.exerciseButton.TabIndex = 2;
            this.exerciseButton.Text = "運動記録入力";
            this.exerciseButton.UseVisualStyleBackColor = true;
            this.exerciseButton.Click += new System.EventHandler(this.exerciseButton_Click);
            // 
            // week_historyButton
            // 
            this.week_historyButton.Location = new System.Drawing.Point(285, 144);
            this.week_historyButton.Name = "week_historyButton";
            this.week_historyButton.Size = new System.Drawing.Size(186, 69);
            this.week_historyButton.TabIndex = 3;
            this.week_historyButton.Text = "1週間の記録";
            this.week_historyButton.UseVisualStyleBackColor = true;
            this.week_historyButton.Click += new System.EventHandler(this.week_historyButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(405, 292);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(109, 46);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "ログアウト";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.week_historyButton);
            this.Controls.Add(this.exerciseButton);
            this.Controls.Add(this.today_historyButton);
            this.Controls.Add(this.eatButton);
            this.Name = "Form4";
            this.Text = "ホーム";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eatButton;
        private System.Windows.Forms.Button today_historyButton;
        private System.Windows.Forms.Button exerciseButton;
        private System.Windows.Forms.Button week_historyButton;
        private System.Windows.Forms.Button logoutButton;
    }
}