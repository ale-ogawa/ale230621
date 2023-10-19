namespace GachaSimulator
{
    partial class RollForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RollForm));
            this.label1 = new System.Windows.Forms.Label();
            this.juelsNumLabel = new System.Windows.Forms.Label();
            this.juelsNum = new System.Windows.Forms.Label();
            this.rollOnceButton = new System.Windows.Forms.Button();
            this.roll10timesButton = new System.Windows.Forms.Button();
            this.rollForDebugButtonClicked = new System.Windows.Forms.Button();
            this.addJuelsButton = new System.Windows.Forms.Button();
            this.returnTopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // juelsNumLabel
            // 
            resources.ApplyResources(this.juelsNumLabel, "juelsNumLabel");
            this.juelsNumLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.juelsNumLabel.Name = "juelsNumLabel";
            // 
            // juelsNum
            // 
            resources.ApplyResources(this.juelsNum, "juelsNum");
            this.juelsNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.juelsNum.Name = "juelsNum";
            // 
            // rollOnceButton
            // 
            resources.ApplyResources(this.rollOnceButton, "rollOnceButton");
            this.rollOnceButton.Name = "rollOnceButton";
            this.rollOnceButton.UseVisualStyleBackColor = true;
            this.rollOnceButton.Click += new System.EventHandler(this.rollOnceButton_Click);
            // 
            // roll10timesButton
            // 
            resources.ApplyResources(this.roll10timesButton, "roll10timesButton");
            this.roll10timesButton.Name = "roll10timesButton";
            this.roll10timesButton.UseVisualStyleBackColor = true;
            this.roll10timesButton.Click += new System.EventHandler(this.roll10timesButton_Click);
            // 
            // rollForDebugButtonClicked
            // 
            resources.ApplyResources(this.rollForDebugButtonClicked, "rollForDebugButtonClicked");
            this.rollForDebugButtonClicked.Name = "rollForDebugButtonClicked";
            this.rollForDebugButtonClicked.UseVisualStyleBackColor = true;
            this.rollForDebugButtonClicked.Click += new System.EventHandler(this.rollForDebugButtonClicked_Click);
            // 
            // addJuelsButton
            // 
            resources.ApplyResources(this.addJuelsButton, "addJuelsButton");
            this.addJuelsButton.Name = "addJuelsButton";
            this.addJuelsButton.UseVisualStyleBackColor = true;
            this.addJuelsButton.Click += new System.EventHandler(this.addJuelsButton_Click);
            // 
            // returnTopButton
            // 
            resources.ApplyResources(this.returnTopButton, "returnTopButton");
            this.returnTopButton.Name = "returnTopButton";
            this.returnTopButton.UseVisualStyleBackColor = true;
            this.returnTopButton.Click += new System.EventHandler(this.returnTopButton_Click);
            // 
            // RollForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.returnTopButton);
            this.Controls.Add(this.addJuelsButton);
            this.Controls.Add(this.rollForDebugButtonClicked);
            this.Controls.Add(this.roll10timesButton);
            this.Controls.Add(this.rollOnceButton);
            this.Controls.Add(this.juelsNum);
            this.Controls.Add(this.juelsNumLabel);
            this.Controls.Add(this.label1);
            this.Name = "RollForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label juelsNumLabel;
        private System.Windows.Forms.Label juelsNum;
        private System.Windows.Forms.Button rollOnceButton;
        private System.Windows.Forms.Button roll10timesButton;
        private System.Windows.Forms.Button rollForDebugButtonClicked;
        private System.Windows.Forms.Button addJuelsButton;
        private System.Windows.Forms.Button returnTopButton;
    }
}