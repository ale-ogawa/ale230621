namespace WindowsFormsApp3
{
    partial class Form9
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
            this.returnHomeButton = new System.Windows.Forms.Button();
            this.mealDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mealDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // returnHomeButton
            // 
            this.returnHomeButton.Location = new System.Drawing.Point(12, 291);
            this.returnHomeButton.Name = "returnHomeButton";
            this.returnHomeButton.Size = new System.Drawing.Size(91, 49);
            this.returnHomeButton.TabIndex = 0;
            this.returnHomeButton.Text = "戻る";
            this.returnHomeButton.UseVisualStyleBackColor = true;
            this.returnHomeButton.Click += new System.EventHandler(this.returnHomeButton_Click);
            // 
            // mealDataGridView
            // 
            this.mealDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mealDataGridView.Location = new System.Drawing.Point(12, 12);
            this.mealDataGridView.MultiSelect = false;
            this.mealDataGridView.Name = "mealDataGridView";
            this.mealDataGridView.RowTemplate.Height = 21;
            this.mealDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mealDataGridView.Size = new System.Drawing.Size(476, 257);
            this.mealDataGridView.TabIndex = 2;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(399, 291);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 49);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.mealDataGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.returnHomeButton);
            this.Name = "Form9";
            this.Text = "1週間の食事履歴";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mealDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnHomeButton;
        private System.Windows.Forms.DataGridView mealDataGridView;
        private System.Windows.Forms.Button deleteButton;
    }
}