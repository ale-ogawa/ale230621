namespace WindowsFormsApp3
{
    partial class Form8
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
            this.mealRecordButton = new System.Windows.Forms.Button();
            this.exerciseRecordButton = new System.Windows.Forms.Button();
            this.energyRecordButton = new System.Windows.Forms.Button();
            this.returnHomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mealRecordButton
            // 
            this.mealRecordButton.Location = new System.Drawing.Point(102, 38);
            this.mealRecordButton.Name = "mealRecordButton";
            this.mealRecordButton.Size = new System.Drawing.Size(312, 63);
            this.mealRecordButton.TabIndex = 0;
            this.mealRecordButton.Text = "食事履歴";
            this.mealRecordButton.UseVisualStyleBackColor = true;
            this.mealRecordButton.Click += new System.EventHandler(this.mealRecordButton_Click);
            // 
            // exerciseRecordButton
            // 
            this.exerciseRecordButton.Location = new System.Drawing.Point(102, 121);
            this.exerciseRecordButton.Name = "exerciseRecordButton";
            this.exerciseRecordButton.Size = new System.Drawing.Size(312, 63);
            this.exerciseRecordButton.TabIndex = 1;
            this.exerciseRecordButton.Text = "運動履歴";
            this.exerciseRecordButton.UseVisualStyleBackColor = true;
            this.exerciseRecordButton.Click += new System.EventHandler(this.exerciseRecordButton_Click);
            // 
            // energyRecordButton
            // 
            this.energyRecordButton.Location = new System.Drawing.Point(102, 208);
            this.energyRecordButton.Name = "energyRecordButton";
            this.energyRecordButton.Size = new System.Drawing.Size(312, 64);
            this.energyRecordButton.TabIndex = 2;
            this.energyRecordButton.Text = "カロリー履歴";
            this.energyRecordButton.UseVisualStyleBackColor = true;
            this.energyRecordButton.Click += new System.EventHandler(this.energyRecordButton_Click);
            // 
            // returnHomeButton
            // 
            this.returnHomeButton.Location = new System.Drawing.Point(433, 287);
            this.returnHomeButton.Name = "returnHomeButton";
            this.returnHomeButton.Size = new System.Drawing.Size(89, 54);
            this.returnHomeButton.TabIndex = 3;
            this.returnHomeButton.Text = "ホーム";
            this.returnHomeButton.UseVisualStyleBackColor = true;
            this.returnHomeButton.Click += new System.EventHandler(this.returnHomeButton_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.returnHomeButton);
            this.Controls.Add(this.energyRecordButton);
            this.Controls.Add(this.exerciseRecordButton);
            this.Controls.Add(this.mealRecordButton);
            this.Name = "Form8";
            this.Text = "1週間の履歴選択";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mealRecordButton;
        private System.Windows.Forms.Button exerciseRecordButton;
        private System.Windows.Forms.Button energyRecordButton;
        private System.Windows.Forms.Button returnHomeButton;
    }
}