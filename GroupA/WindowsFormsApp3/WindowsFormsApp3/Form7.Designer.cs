namespace WindowsFormsApp3
{
    partial class Form7
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.recommendEnergyLabel = new System.Windows.Forms.Label();
            this.inputEnergyLabel = new System.Windows.Forms.Label();
            this.outputEnergyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnHomeButton
            // 
            this.returnHomeButton.Location = new System.Drawing.Point(440, 298);
            this.returnHomeButton.Name = "returnHomeButton";
            this.returnHomeButton.Size = new System.Drawing.Size(99, 42);
            this.returnHomeButton.TabIndex = 0;
            this.returnHomeButton.Text = "ホーム";
            this.returnHomeButton.UseVisualStyleBackColor = true;
            this.returnHomeButton.Click += new System.EventHandler(this.returnHomeButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(122, 134);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(74, 12);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "メッセージ表示";
            // 
            // recommendEnergyLabel
            // 
            this.recommendEnergyLabel.AutoSize = true;
            this.recommendEnergyLabel.Location = new System.Drawing.Point(122, 91);
            this.recommendEnergyLabel.Name = "recommendEnergyLabel";
            this.recommendEnergyLabel.Size = new System.Drawing.Size(88, 12);
            this.recommendEnergyLabel.TabIndex = 2;
            this.recommendEnergyLabel.Text = "推奨カロリー表示";
            // 
            // inputEnergyLabel
            // 
            this.inputEnergyLabel.AutoSize = true;
            this.inputEnergyLabel.Location = new System.Drawing.Point(124, 175);
            this.inputEnergyLabel.Name = "inputEnergyLabel";
            this.inputEnergyLabel.Size = new System.Drawing.Size(88, 12);
            this.inputEnergyLabel.TabIndex = 3;
            this.inputEnergyLabel.Text = "摂取カロリー表示";
            // 
            // outputEnergyLabel
            // 
            this.outputEnergyLabel.AutoSize = true;
            this.outputEnergyLabel.Location = new System.Drawing.Point(250, 175);
            this.outputEnergyLabel.Name = "outputEnergyLabel";
            this.outputEnergyLabel.Size = new System.Drawing.Size(88, 12);
            this.outputEnergyLabel.TabIndex = 4;
            this.outputEnergyLabel.Text = "消費カロリー表示";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.outputEnergyLabel);
            this.Controls.Add(this.inputEnergyLabel);
            this.Controls.Add(this.recommendEnergyLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.returnHomeButton);
            this.Name = "Form7";
            this.Text = "メッセージ";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnHomeButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label recommendEnergyLabel;
        private System.Windows.Forms.Label inputEnergyLabel;
        private System.Windows.Forms.Label outputEnergyLabel;
    }
}