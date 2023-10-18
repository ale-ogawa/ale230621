namespace WindowsFormsApp3
{
    partial class Form10
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
            this.exerciseDataGridView = new System.Windows.Forms.DataGridView();
            this.returnHomeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exerciseDataGridView
            // 
            this.exerciseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exerciseDataGridView.Location = new System.Drawing.Point(12, 12);
            this.exerciseDataGridView.Name = "exerciseDataGridView";
            this.exerciseDataGridView.RowTemplate.Height = 21;
            this.exerciseDataGridView.Size = new System.Drawing.Size(463, 260);
            this.exerciseDataGridView.TabIndex = 0;
            // 
            // returnHomeButton
            // 
            this.returnHomeButton.Location = new System.Drawing.Point(13, 294);
            this.returnHomeButton.Name = "returnHomeButton";
            this.returnHomeButton.Size = new System.Drawing.Size(98, 45);
            this.returnHomeButton.TabIndex = 1;
            this.returnHomeButton.Text = "戻る";
            this.returnHomeButton.UseVisualStyleBackColor = true;
            this.returnHomeButton.Click += new System.EventHandler(this.returnHomeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(383, 294);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 44);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.returnHomeButton);
            this.Controls.Add(this.exerciseDataGridView);
            this.Name = "Form10";
            this.Text = "1週間の運動履歴";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView exerciseDataGridView;
        private System.Windows.Forms.Button returnHomeButton;
        private System.Windows.Forms.Button deleteButton;
    }
}