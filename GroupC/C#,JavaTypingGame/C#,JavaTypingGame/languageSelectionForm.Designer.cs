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
            this.runkingButton = new System.Windows.Forms.Button();
            this.titleButton = new System.Windows.Forms.Button();
            this.JavaButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // runkingButton
            // 
            this.runkingButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.runkingButton.Location = new System.Drawing.Point(105, 349);
            this.runkingButton.Name = "runkingButton";
            this.runkingButton.Size = new System.Drawing.Size(189, 48);
            this.runkingButton.TabIndex = 18;
            this.runkingButton.Text = "ランキング";
            this.runkingButton.UseVisualStyleBackColor = true;
            this.runkingButton.Click += new System.EventHandler(this.runkingButton_Click);
            // 
            // titleButton
            // 
            this.titleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.titleButton.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleButton.Location = new System.Drawing.Point(501, 349);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(189, 48);
            this.titleButton.TabIndex = 17;
            this.titleButton.Text = "タイトルに戻る";
            this.titleButton.UseVisualStyleBackColor = true;
            this.titleButton.Click += new System.EventHandler(this.titleButton_Click);
            // 
            // JavaButton
            // 
            this.JavaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.JavaButton.Font = new System.Drawing.Font("ＭＳ 明朝", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JavaButton.Location = new System.Drawing.Point(274, 216);
            this.JavaButton.Name = "JavaButton";
            this.JavaButton.Size = new System.Drawing.Size(255, 99);
            this.JavaButton.TabIndex = 16;
            this.JavaButton.Text = "Java";
            this.JavaButton.UseVisualStyleBackColor = true;
            this.JavaButton.Click += new System.EventHandler(this.JavaButton_Click);
            // 
            // CButton
            // 
            this.CButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CButton.Font = new System.Drawing.Font("ＭＳ 明朝", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CButton.Location = new System.Drawing.Point(274, 88);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(255, 99);
            this.CButton.TabIndex = 15;
            this.CButton.Text = "C#";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(280, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "言語を選択してください";
            // 
            // languageSelectionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.runkingButton);
            this.Controls.Add(this.titleButton);
            this.Controls.Add(this.JavaButton);
            this.Controls.Add(this.CButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "languageSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "languageSelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runkingButton;
        private System.Windows.Forms.Button titleButton;
        private System.Windows.Forms.Button JavaButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Label label1;
    }
}