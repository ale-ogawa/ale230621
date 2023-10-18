namespace WindowsFormsApp3
{
    partial class Form11
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
            this.energyDataGridView = new System.Windows.Forms.DataGridView();
            this.returnHomeButton = new System.Windows.Forms.Button();
            this.recommendEnergyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.energyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // energyDataGridView
            // 
            this.energyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.energyDataGridView.Location = new System.Drawing.Point(12, 34);
            this.energyDataGridView.Name = "energyDataGridView";
            this.energyDataGridView.RowTemplate.Height = 21;
            this.energyDataGridView.Size = new System.Drawing.Size(539, 246);
            this.energyDataGridView.TabIndex = 0;
            // 
            // returnHomeButton
            // 
            this.returnHomeButton.Location = new System.Drawing.Point(12, 299);
            this.returnHomeButton.Name = "returnHomeButton";
            this.returnHomeButton.Size = new System.Drawing.Size(87, 47);
            this.returnHomeButton.TabIndex = 1;
            this.returnHomeButton.Text = "戻る";
            this.returnHomeButton.UseVisualStyleBackColor = true;
            this.returnHomeButton.Click += new System.EventHandler(this.returnHomeButton_Click);
            // 
            // recommendEnergyLabel
            // 
            this.recommendEnergyLabel.AutoSize = true;
            this.recommendEnergyLabel.Location = new System.Drawing.Point(12, 9);
            this.recommendEnergyLabel.Name = "recommendEnergyLabel";
            this.recommendEnergyLabel.Size = new System.Drawing.Size(142, 12);
            this.recommendEnergyLabel.TabIndex = 2;
            this.recommendEnergyLabel.Text = "1日の推奨エネルギー量表示";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.recommendEnergyLabel);
            this.Controls.Add(this.returnHomeButton);
            this.Controls.Add(this.energyDataGridView);
            this.Name = "Form11";
            this.Text = "1週間の摂取カロリー履歴";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.energyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView energyDataGridView;
        private System.Windows.Forms.Button returnHomeButton;
        private System.Windows.Forms.Label recommendEnergyLabel;
    }
}