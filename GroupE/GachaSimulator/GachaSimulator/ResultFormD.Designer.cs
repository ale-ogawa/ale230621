namespace GachaSimulator
{
    partial class ResultFormD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultFormD));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameD = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.skipAllButton = new System.Windows.Forms.Button();
            this.gacha_blue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gacha_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "獲得したガチャは…";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(164, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "残念！はずれガチャ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(389, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "です！";
            // 
            // nameD
            // 
            this.nameD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameD.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameD.Location = new System.Drawing.Point(164, 189);
            this.nameD.Name = "nameD";
            this.nameD.Size = new System.Drawing.Size(192, 29);
            this.nameD.TabIndex = 3;
            this.nameD.Text = "あいうえお";
            this.nameD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nextButton.Location = new System.Drawing.Point(115, 231);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "次へ";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // skipAllButton
            // 
            this.skipAllButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.skipAllButton.Location = new System.Drawing.Point(266, 231);
            this.skipAllButton.Name = "skipAllButton";
            this.skipAllButton.Size = new System.Drawing.Size(212, 23);
            this.skipAllButton.TabIndex = 5;
            this.skipAllButton.Text = "全ての結果を保存して戻る";
            this.skipAllButton.UseVisualStyleBackColor = true;
            this.skipAllButton.Click += new System.EventHandler(this.skipAllButton_Click);
            // 
            // gacha_blue
            // 
            this.gacha_blue.Image = ((System.Drawing.Image)(resources.GetObject("gacha_blue.Image")));
            this.gacha_blue.Location = new System.Drawing.Point(158, 36);
            this.gacha_blue.Name = "gacha_blue";
            this.gacha_blue.Size = new System.Drawing.Size(198, 129);
            this.gacha_blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gacha_blue.TabIndex = 6;
            this.gacha_blue.TabStop = false;
            // 
            // ResultFormD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(534, 266);
            this.Controls.Add(this.gacha_blue);
            this.Controls.Add(this.skipAllButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.nameD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResultFormD";
            this.Text = "ガチャ結果画面";
            ((System.ComponentModel.ISupportInitialize)(this.gacha_blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nameD;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button skipAllButton;
        private System.Windows.Forms.PictureBox gacha_blue;
    }
}