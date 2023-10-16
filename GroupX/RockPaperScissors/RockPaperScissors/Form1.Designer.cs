namespace RockPaperScissors {
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.components = new System.ComponentModel.Container();
            this.Label2 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.PicCPU = new System.Windows.Forms.PictureBox();
            this.PicPa = new System.Windows.Forms.PictureBox();
            this.PicCh = new System.Windows.Forms.PictureBox();
            this.PicGu = new System.Windows.Forms.PictureBox();
            this.billLabel = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.drowLab = new System.Windows.Forms.Label();
            this.loseLab = new System.Windows.Forms.Label();
            this.winLab = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PicCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGu)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label2.Location = new System.Drawing.Point(594, 9);
            this.Label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(195, 73);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "あなた";
            // 
            // StartButton
            // 
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StartButton.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartButton.Location = new System.Drawing.Point(0, 729);
            this.StartButton.Margin = new System.Windows.Forms.Padding(6);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(1062, 106);
            this.StartButton.TabIndex = 22;
            this.StartButton.Text = "START！！";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PicCPU
            // 
            this.PicCPU.Location = new System.Drawing.Point(31, 116);
            this.PicCPU.Margin = new System.Windows.Forms.Padding(6);
            this.PicCPU.Name = "PicCPU";
            this.PicCPU.Size = new System.Drawing.Size(222, 233);
            this.PicCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCPU.TabIndex = 21;
            this.PicCPU.TabStop = false;
            // 
            // PicPa
            // 
            this.PicPa.Location = new System.Drawing.Point(818, 116);
            this.PicPa.Margin = new System.Windows.Forms.Padding(6);
            this.PicPa.Name = "PicPa";
            this.PicPa.Size = new System.Drawing.Size(231, 236);
            this.PicPa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPa.TabIndex = 20;
            this.PicPa.TabStop = false;
            this.PicPa.Click += new System.EventHandler(this.PicPa_Click);
            // 
            // PicCh
            // 
            this.PicCh.Location = new System.Drawing.Point(572, 116);
            this.PicCh.Margin = new System.Windows.Forms.Padding(6);
            this.PicCh.Name = "PicCh";
            this.PicCh.Size = new System.Drawing.Size(234, 236);
            this.PicCh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCh.TabIndex = 19;
            this.PicCh.TabStop = false;
            this.PicCh.Click += new System.EventHandler(this.PicCh_Click);
            // 
            // PicGu
            // 
            this.PicGu.Location = new System.Drawing.Point(338, 116);
            this.PicGu.Margin = new System.Windows.Forms.Padding(6);
            this.PicGu.Name = "PicGu";
            this.PicGu.Size = new System.Drawing.Size(222, 236);
            this.PicGu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicGu.TabIndex = 18;
            this.PicGu.TabStop = false;
            this.PicGu.Click += new System.EventHandler(this.PicGu_Click);
            // 
            // billLabel
            // 
            this.billLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billLabel.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.billLabel.Location = new System.Drawing.Point(0, 0);
            this.billLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(1037, 119);
            this.billLabel.TabIndex = 17;
            this.billLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox1
            // 
            this.GroupBox1.AutoSize = true;
            this.GroupBox1.Controls.Add(this.drowLab);
            this.GroupBox1.Controls.Add(this.loseLab);
            this.GroupBox1.Controls.Add(this.winLab);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox1.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(1030, 147);
            this.GroupBox1.TabIndex = 16;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "【勝敗結果】";
            // 
            // drowLab
            // 
            this.drowLab.Location = new System.Drawing.Point(589, 56);
            this.drowLab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.drowLab.Name = "drowLab";
            this.drowLab.Size = new System.Drawing.Size(104, 48);
            this.drowLab.TabIndex = 6;
            this.drowLab.Text = "0";
            this.drowLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loseLab
            // 
            this.loseLab.ForeColor = System.Drawing.Color.Red;
            this.loseLab.Location = new System.Drawing.Point(381, 56);
            this.loseLab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.loseLab.Name = "loseLab";
            this.loseLab.Size = new System.Drawing.Size(104, 48);
            this.loseLab.TabIndex = 5;
            this.loseLab.Text = "0";
            this.loseLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winLab
            // 
            this.winLab.ForeColor = System.Drawing.Color.Blue;
            this.winLab.Location = new System.Drawing.Point(191, 56);
            this.winLab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.winLab.Name = "winLab";
            this.winLab.Size = new System.Drawing.Size(104, 48);
            this.winLab.TabIndex = 4;
            this.winLab.Text = "0";
            this.winLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(312, 64);
            this.Label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(52, 32);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "勝";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(17, 64);
            this.Label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(173, 32);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "あなたは";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(520, 64);
            this.Label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(52, 32);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "敗";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(711, 64);
            this.Label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(210, 48);
            this.Label6.TabIndex = 2;
            this.Label6.Text = "分けです";
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label1.Location = new System.Drawing.Point(6, 14);
            this.Label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(326, 64);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "コンピュータ";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PicPa);
            this.panel1.Controls.Add(this.PicCh);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.PicGu);
            this.panel1.Controls.Add(this.PicCPU);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 365);
            this.panel1.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.billLabel);
            this.panel3.Location = new System.Drawing.Point(12, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1037, 119);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.GroupBox1);
            this.panel4.Location = new System.Drawing.Point(19, 486);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1030, 147);
            this.panel4.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1062, 835);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StartButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "じゃんけんゲーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGu)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button StartButton;
        internal System.Windows.Forms.PictureBox PicCPU;
        internal System.Windows.Forms.PictureBox PicPa;
        internal System.Windows.Forms.PictureBox PicCh;
        internal System.Windows.Forms.PictureBox PicGu;
        internal System.Windows.Forms.Label billLabel;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label drowLab;
        internal System.Windows.Forms.Label loseLab;
        internal System.Windows.Forms.Label winLab;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

