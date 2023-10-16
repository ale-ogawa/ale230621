namespace typingGame
{
    partial class languageSelectionForm
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
            this.CButton = new System.Windows.Forms.Button();
            this.JavaButton = new System.Windows.Forms.Button();
            this.titleButton = new System.Windows.Forms.Button();
            this.runkingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CButton
            // 
            this.CButton.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CButton.Location = new System.Drawing.Point(240, 54);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(255, 99);
            this.CButton.TabIndex = 11;
            this.CButton.Text = "C#";
            this.CButton.UseVisualStyleBackColor = true;
            // 
            // JavaButton
            // 
            this.JavaButton.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JavaButton.Location = new System.Drawing.Point(240, 195);
            this.JavaButton.Name = "JavaButton";
            this.JavaButton.Size = new System.Drawing.Size(255, 99);
            this.JavaButton.TabIndex = 12;
            this.JavaButton.Text = "Java";
            this.JavaButton.UseVisualStyleBackColor = true;
            // 
            // titleButton
            // 
            this.titleButton.Location = new System.Drawing.Point(468, 332);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(189, 48);
            this.titleButton.TabIndex = 13;
            this.titleButton.Text = "タイトルに戻る";
            this.titleButton.UseVisualStyleBackColor = true;
            // 
            // runkingButton
            // 
            this.runkingButton.Location = new System.Drawing.Point(71, 332);
            this.runkingButton.Name = "runkingButton";
            this.runkingButton.Size = new System.Drawing.Size(189, 48);
            this.runkingButton.TabIndex = 14;
            this.runkingButton.Text = "ランキング";
            this.runkingButton.UseVisualStyleBackColor = true;
            // 
            // languageSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.runkingButton);
            this.Controls.Add(this.titleButton);
            this.Controls.Add(this.JavaButton);
            this.Controls.Add(this.CButton);
            this.Name = "languageSelectionForm";
            this.Text = "languageSelectionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button JavaButton;
        private System.Windows.Forms.Button titleButton;
        private System.Windows.Forms.Button runkingButton;
    }
}