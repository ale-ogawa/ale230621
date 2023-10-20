namespace typingGame
{
    partial class C_DifficultyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_DifficultyForm));
            this.backButton = new System.Windows.Forms.Button();
            this.advancedButton = new System.Windows.Forms.Button();
            this.intermediateButton = new System.Windows.Forms.Button();
            this.beginnerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.Location = new System.Drawing.Point(204, 328);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(344, 73);
            this.backButton.TabIndex = 28;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // advancedButton
            // 
            this.advancedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.advancedButton.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.advancedButton.Location = new System.Drawing.Point(254, 216);
            this.advancedButton.Name = "advancedButton";
            this.advancedButton.Size = new System.Drawing.Size(241, 82);
            this.advancedButton.TabIndex = 27;
            this.advancedButton.UseVisualStyleBackColor = true;
            this.advancedButton.Click += new System.EventHandler(this.advancedButton_Click);
            // 
            // intermediateButton
            // 
            this.intermediateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("intermediateButton.BackgroundImage")));
            this.intermediateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.intermediateButton.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.intermediateButton.Location = new System.Drawing.Point(254, 115);
            this.intermediateButton.Name = "intermediateButton";
            this.intermediateButton.Size = new System.Drawing.Size(241, 82);
            this.intermediateButton.TabIndex = 26;
            this.intermediateButton.UseVisualStyleBackColor = true;
            this.intermediateButton.Click += new System.EventHandler(this.intermediateButton_Click);
            // 
            // beginnerButton
            // 
            this.beginnerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("beginnerButton.BackgroundImage")));
            this.beginnerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.beginnerButton.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.beginnerButton.Location = new System.Drawing.Point(254, 12);
            this.beginnerButton.Name = "beginnerButton";
            this.beginnerButton.Size = new System.Drawing.Size(241, 82);
            this.beginnerButton.TabIndex = 25;
            this.beginnerButton.UseVisualStyleBackColor = true;
            this.beginnerButton.Click += new System.EventHandler(this.beginnerButton_Click);
            // 
            // C_DifficultyForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.advancedButton);
            this.Controls.Add(this.intermediateButton);
            this.Controls.Add(this.beginnerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "C_DifficultyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C_DifficultyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button advancedButton;
        private System.Windows.Forms.Button intermediateButton;
        private System.Windows.Forms.Button beginnerButton;
    }
}