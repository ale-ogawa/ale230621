using System.Windows.Forms;

namespace GachaSimulator
{
    partial class CreateForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.レア度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名前 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnTopButton = new System.Windows.Forms.Button();
            this.readCsvButton = new System.Windows.Forms.Button();
            this.saveCsvButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.レア度,
            this.名前});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(492, 160);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // レア度
            // 
            this.レア度.HeaderText = "レア度";
            this.レア度.Name = "レア度";
            // 
            // 名前
            // 
            this.名前.HeaderText = "名前";
            this.名前.Name = "名前";
            // 
            // returnTopButton
            // 
            this.returnTopButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.returnTopButton.Location = new System.Drawing.Point(198, 215);
            this.returnTopButton.Name = "returnTopButton";
            this.returnTopButton.Size = new System.Drawing.Size(123, 23);
            this.returnTopButton.TabIndex = 1;
            this.returnTopButton.Text = "決定して戻る";
            this.returnTopButton.UseVisualStyleBackColor = true;
            this.returnTopButton.Click += new System.EventHandler(this.returnTopButton_Click);
            // 
            // readCsvButton
            // 
            this.readCsvButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.readCsvButton.Location = new System.Drawing.Point(71, 186);
            this.readCsvButton.Name = "readCsvButton";
            this.readCsvButton.Size = new System.Drawing.Size(182, 21);
            this.readCsvButton.TabIndex = 2;
            this.readCsvButton.Text = "CSVファイルの読み込み";
            this.readCsvButton.UseVisualStyleBackColor = true;
            this.readCsvButton.Click += new System.EventHandler(this.readCsvButton_Click);
            // 
            // saveCsvButton
            // 
            this.saveCsvButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.saveCsvButton.Location = new System.Drawing.Point(277, 186);
            this.saveCsvButton.Name = "saveCsvButton";
            this.saveCsvButton.Size = new System.Drawing.Size(165, 21);
            this.saveCsvButton.TabIndex = 3;
            this.saveCsvButton.Text = "CSVファイルに出力";
            this.saveCsvButton.UseVisualStyleBackColor = true;
            this.saveCsvButton.Click += new System.EventHandler(this.saveCsvButton_Click);
            // 
            // CreateForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 250);
            this.Controls.Add(this.saveCsvButton);
            this.Controls.Add(this.readCsvButton);
            this.Controls.Add(this.returnTopButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CreateForm";
            this.Text = "ガチャを作る";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button returnTopButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn レア度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名前;
        private System.Windows.Forms.Button readCsvButton;
        private System.Windows.Forms.Button saveCsvButton;
    }
}