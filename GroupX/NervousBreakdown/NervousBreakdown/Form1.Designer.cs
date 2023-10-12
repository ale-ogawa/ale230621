namespace NervousBreakdown {
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelGuidance = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonpretermit = new System.Windows.Forms.Button();
            this.buttonfinish = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelGuidance
            // 
            this.labelGuidance.AutoSize = true;
            this.labelGuidance.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelGuidance.ForeColor = System.Drawing.Color.DarkRed;
            this.labelGuidance.Location = new System.Drawing.Point(31, 25);
            this.labelGuidance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelGuidance.Name = "labelGuidance";
            this.labelGuidance.Size = new System.Drawing.Size(79, 26);
            this.labelGuidance.TabIndex = 1;
            this.labelGuidance.Text = "label2";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonStart.ForeColor = System.Drawing.Color.Black;
            this.buttonStart.Location = new System.Drawing.Point(1003, 866);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(295, 102);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "ゲームスタート";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("HG丸ｺﾞｼｯｸM-PRO", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(1012, 256);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 33);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkKhaki;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(996, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "経過時間";
            // 
            // buttonpretermit
            // 
            this.buttonpretermit.Enabled = false;
            this.buttonpretermit.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonpretermit.Location = new System.Drawing.Point(1003, 980);
            this.buttonpretermit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonpretermit.Name = "buttonpretermit";
            this.buttonpretermit.Size = new System.Drawing.Size(141, 102);
            this.buttonpretermit.TabIndex = 5;
            this.buttonpretermit.Text = "中断";
            this.buttonpretermit.UseVisualStyleBackColor = true;
            this.buttonpretermit.Click += new System.EventHandler(this.buttonpretermit_Click);
            // 
            // buttonfinish
            // 
            this.buttonfinish.Enabled = false;
            this.buttonfinish.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonfinish.Location = new System.Drawing.Point(1157, 980);
            this.buttonfinish.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonfinish.Name = "buttonfinish";
            this.buttonfinish.Size = new System.Drawing.Size(141, 102);
            this.buttonfinish.TabIndex = 6;
            this.buttonfinish.Text = "終了";
            this.buttonfinish.UseVisualStyleBackColor = true;
            this.buttonfinish.Click += new System.EventHandler(this.buttonfinish_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(1003, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "ルール";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1474, 1095);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonfinish);
            this.Controls.Add(this.buttonpretermit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelGuidance);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "神経衰弱";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelGuidance;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonpretermit;
        private System.Windows.Forms.Button buttonfinish;
        private System.Windows.Forms.Button button1;
    }
}

