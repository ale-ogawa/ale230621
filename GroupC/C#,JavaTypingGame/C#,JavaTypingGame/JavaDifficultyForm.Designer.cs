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
            this.backButton = new System.Windows.Forms.Button();
            this.advancedButton = new System.Windows.Forms.Button();
            this.intermediateButton = new System.Windows.Forms.Button();
            this.beginnerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(218, 322);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(327, 47);
            this.backButton.TabIndex = 24;
            this.backButton.Text = "言語選択に戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.beginnerButton_Click);
            // 
            // advancedButton
            // 
            this.advancedButton.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.advancedButton.Location = new System.Drawing.Point(255, 216);
            this.advancedButton.Name = "advancedButton";
            this.advancedButton.Size = new System.Drawing.Size(241, 82);
            this.advancedButton.TabIndex = 23;
            this.advancedButton.Text = "上級";
            this.advancedButton.UseVisualStyleBackColor = true;
            this.advancedButton.Click += new System.EventHandler(this.beginnerButton_Click);
            // 
            // intermediateButton
            // 
            this.intermediateButton.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.intermediateButton.Location = new System.Drawing.Point(255, 115);
            this.intermediateButton.Name = "intermediateButton";
            this.intermediateButton.Size = new System.Drawing.Size(241, 82);
            this.intermediateButton.TabIndex = 22;
            this.intermediateButton.Text = "中級";
            this.intermediateButton.UseVisualStyleBackColor = true;
            this.intermediateButton.Click += new System.EventHandler(this.beginnerButton_Click);
            // 
            // beginnerButton
            // 
            this.beginnerButton.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.beginnerButton.Location = new System.Drawing.Point(255, 12);
            this.beginnerButton.Name = "beginnerButton";
            this.beginnerButton.Size = new System.Drawing.Size(241, 82);
            this.beginnerButton.TabIndex = 21;
            this.beginnerButton.Text = "初級";
            this.beginnerButton.UseVisualStyleBackColor = true;
            this.beginnerButton.Click += new System.EventHandler(this.beginnerButton_Click);
            // 
            // JavaDifficultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.advancedButton);
            this.Controls.Add(this.intermediateButton);
            this.Controls.Add(this.beginnerButton);
            this.Name = "JavaDifficultyForm";
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