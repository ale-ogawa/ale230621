namespace GachaSimulator
{
    partial class TopForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.closeTopButton = new System.Windows.Forms.Button();
            this.CreateGacha = new System.Windows.Forms.Button();
            this.itemListButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ガチャシミュレーター";
            // 
            // rollButton
            // 
            this.rollButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rollButton.ForeColor = System.Drawing.Color.DarkGray;
            this.rollButton.Location = new System.Drawing.Point(201, 98);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(208, 38);
            this.rollButton.TabIndex = 1;
            this.rollButton.Text = "ガチャを回す！";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // closeTopButton
            // 
            this.closeTopButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.closeTopButton.Location = new System.Drawing.Point(246, 219);
            this.closeTopButton.Name = "closeTopButton";
            this.closeTopButton.Size = new System.Drawing.Size(120, 23);
            this.closeTopButton.TabIndex = 2;
            this.closeTopButton.Text = "終わる";
            this.closeTopButton.UseVisualStyleBackColor = true;
            this.closeTopButton.Click += new System.EventHandler(this.closeTopButton_Click);
            // 
            // CreateGacha
            // 
            this.CreateGacha.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CreateGacha.Location = new System.Drawing.Point(201, 40);
            this.CreateGacha.Name = "CreateGacha";
            this.CreateGacha.Size = new System.Drawing.Size(208, 38);
            this.CreateGacha.TabIndex = 3;
            this.CreateGacha.Text = "ガチャを作る！";
            this.CreateGacha.UseVisualStyleBackColor = true;
            this.CreateGacha.Click += new System.EventHandler(this.createButton_Click);
            // 
            // itemListButton
            // 
            this.itemListButton.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.itemListButton.Location = new System.Drawing.Point(201, 155);
            this.itemListButton.Name = "itemListButton";
            this.itemListButton.Size = new System.Drawing.Size(208, 38);
            this.itemListButton.TabIndex = 4;
            this.itemListButton.Text = "所持品確認";
            this.itemListButton.UseVisualStyleBackColor = true;
            this.itemListButton.Click += new System.EventHandler(this.itemListButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(260, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "(C)2023 E-han";
            // 
            // TopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemListButton);
            this.Controls.Add(this.CreateGacha);
            this.Controls.Add(this.closeTopButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.label1);
            this.Name = "TopForm";
            this.Text = "トップ画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button closeTopButton;
        private System.Windows.Forms.Button CreateGacha;
        private System.Windows.Forms.Button itemListButton;
        private System.Windows.Forms.Label label2;
    }
}

