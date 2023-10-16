namespace typingGame
{
    partial class runkingForm
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
            this.CLabel = new System.Windows.Forms.Label();
            this.JavaLabel = new System.Windows.Forms.Label();
            this.CdataGridView = new System.Windows.Forms.DataGridView();
            this.JavadataGridView = new System.Windows.Forms.DataGridView();
            this.menueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JavadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CLabel
            // 
            this.CLabel.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CLabel.Location = new System.Drawing.Point(96, 19);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(165, 39);
            this.CLabel.TabIndex = 3;
            this.CLabel.Text = "C#";
            this.CLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JavaLabel
            // 
            this.JavaLabel.Font = new System.Drawing.Font("ＭＳ 明朝", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JavaLabel.Location = new System.Drawing.Point(492, 19);
            this.JavaLabel.Name = "JavaLabel";
            this.JavaLabel.Size = new System.Drawing.Size(165, 39);
            this.JavaLabel.TabIndex = 5;
            this.JavaLabel.Text = "Java";
            this.JavaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CdataGridView
            // 
            this.CdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CdataGridView.Location = new System.Drawing.Point(41, 61);
            this.CdataGridView.Name = "CdataGridView";
            this.CdataGridView.RowTemplate.Height = 21;
            this.CdataGridView.Size = new System.Drawing.Size(302, 261);
            this.CdataGridView.TabIndex = 6;
            // 
            // JavadataGridView
            // 
            this.JavadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JavadataGridView.Location = new System.Drawing.Point(419, 61);
            this.JavadataGridView.Name = "JavadataGridView";
            this.JavadataGridView.RowTemplate.Height = 21;
            this.JavadataGridView.Size = new System.Drawing.Size(302, 261);
            this.JavadataGridView.TabIndex = 7;
            // 
            // menueButton
            // 
            this.menueButton.Location = new System.Drawing.Point(289, 341);
            this.menueButton.Name = "menueButton";
            this.menueButton.Size = new System.Drawing.Size(189, 48);
            this.menueButton.TabIndex = 18;
            this.menueButton.Text = "メニューに戻る";
            this.menueButton.UseVisualStyleBackColor = true;
            this.menueButton.Click += new System.EventHandler(this.menueButton_Click);
            // 
            // runkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.menueButton);
            this.Controls.Add(this.JavadataGridView);
            this.Controls.Add(this.CdataGridView);
            this.Controls.Add(this.JavaLabel);
            this.Controls.Add(this.CLabel);
            this.Name = "runkingForm";
            this.Text = "runkingForm";
            ((System.ComponentModel.ISupportInitialize)(this.CdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JavadataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CLabel;
        private System.Windows.Forms.Label JavaLabel;
        private System.Windows.Forms.DataGridView CdataGridView;
        private System.Windows.Forms.DataGridView JavadataGridView;
        private System.Windows.Forms.Button menueButton;
    }
}