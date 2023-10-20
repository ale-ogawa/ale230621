namespace typingGame
{
    partial class JavaDifficultyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JavaDifficultyForm));
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
            this.backButton.Location = new System.Drawing.Point(200, 318);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(372, 72);
            this.backButton.TabIndex = 24;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // advancedButton
            // 
            this.advancedButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("advancedButton.BackgroundImage")));
            this.advancedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.advancedButton.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.advancedButton.Location = new System.Drawing.Point(255, 216);
            this.advancedButton.Name = "advancedButton";
            this.advancedButton.Size = new System.Drawing.Size(241, 82);
            this.advancedButton.TabIndex = 23;
            this.advancedButton.UseVisualStyleBackColor = true;
            this.advancedButton.Click += new System.EventHandler(this.advancedButton_Click);
            // 
            // intermediateButton
            // 
            this.intermediateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("intermediateButton.BackgroundImage")));
            this.intermediateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.intermediateButton.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.intermediateButton.Location = new System.Drawing.Point(255, 124);
            this.intermediateButton.Name = "intermediateButton";
            this.intermediateButton.Size = new System.Drawing.Size(241, 77);
            this.intermediateButton.TabIndex = 22;
            this.intermediateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.intermediateButton.UseVisualStyleBackColor = true;
            this.intermediateButton.Click += new System.EventHandler(this.intermediateButton_Click);
            // 
            // beginnerButton
            // 
            this.beginnerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("beginnerButton.BackgroundImage")));
            this.beginnerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.beginnerButton.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.beginnerButton.Location = new System.Drawing.Point(255, 25);
            this.beginnerButton.Name = "beginnerButton";
            this.beginnerButton.Size = new System.Drawing.Size(241, 82);
            this.beginnerButton.TabIndex = 21;
            this.beginnerButton.UseVisualStyleBackColor = true;
            this.beginnerButton.Click += new System.EventHandler(this.beginnerButton_Click);
            // 
            // JavaDifficultyForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.advancedButton);
            this.Controls.Add(this.intermediateButton);
            this.Controls.Add(this.beginnerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JavaDifficultyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JavaDifficultyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button advancedButton;
        private System.Windows.Forms.Button intermediateButton;
        private System.Windows.Forms.Button beginnerButton;
    }
}