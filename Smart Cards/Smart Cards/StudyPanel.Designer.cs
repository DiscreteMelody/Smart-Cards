namespace Smart_Cards
{
    partial class StudyPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.patientInformationPanel = new System.Windows.Forms.Panel();
            this.sampleDeck1Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sampleDeck2Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sampleDeck3Title = new System.Windows.Forms.Label();
            this.patientInformationPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientInformationPanel
            // 
            this.patientInformationPanel.BackColor = System.Drawing.Color.White;
            this.patientInformationPanel.Controls.Add(this.sampleDeck1Title);
            this.patientInformationPanel.Location = new System.Drawing.Point(3, 3);
            this.patientInformationPanel.Name = "patientInformationPanel";
            this.patientInformationPanel.Size = new System.Drawing.Size(301, 363);
            this.patientInformationPanel.TabIndex = 5;
            // 
            // sampleDeck1Title
            // 
            this.sampleDeck1Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sampleDeck1Title.AutoSize = true;
            this.sampleDeck1Title.BackColor = System.Drawing.Color.Transparent;
            this.sampleDeck1Title.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleDeck1Title.Location = new System.Drawing.Point(42, 10);
            this.sampleDeck1Title.Name = "sampleDeck1Title";
            this.sampleDeck1Title.Size = new System.Drawing.Size(213, 32);
            this.sampleDeck1Title.TabIndex = 0;
            this.sampleDeck1Title.Text = "Sample Deck 1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.sampleDeck2Title);
            this.panel1.Location = new System.Drawing.Point(310, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 363);
            this.panel1.TabIndex = 6;
            // 
            // sampleDeck2Title
            // 
            this.sampleDeck2Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sampleDeck2Title.AutoSize = true;
            this.sampleDeck2Title.BackColor = System.Drawing.Color.Transparent;
            this.sampleDeck2Title.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleDeck2Title.Location = new System.Drawing.Point(42, 10);
            this.sampleDeck2Title.Name = "sampleDeck2Title";
            this.sampleDeck2Title.Size = new System.Drawing.Size(213, 32);
            this.sampleDeck2Title.TabIndex = 0;
            this.sampleDeck2Title.Text = "Sample Deck 2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.sampleDeck3Title);
            this.panel2.Location = new System.Drawing.Point(3, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 363);
            this.panel2.TabIndex = 7;
            // 
            // sampleDeck3Title
            // 
            this.sampleDeck3Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sampleDeck3Title.AutoSize = true;
            this.sampleDeck3Title.BackColor = System.Drawing.Color.Transparent;
            this.sampleDeck3Title.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleDeck3Title.Location = new System.Drawing.Point(42, 10);
            this.sampleDeck3Title.Name = "sampleDeck3Title";
            this.sampleDeck3Title.Size = new System.Drawing.Size(213, 32);
            this.sampleDeck3Title.TabIndex = 0;
            this.sampleDeck3Title.Text = "Sample Deck 3";
            // 
            // StudyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.patientInformationPanel);
            this.Name = "StudyPanel";
            this.Size = new System.Drawing.Size(549, 418);
            this.patientInformationPanel.ResumeLayout(false);
            this.patientInformationPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel patientInformationPanel;
        private System.Windows.Forms.Label sampleDeck1Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label sampleDeck2Title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label sampleDeck3Title;
    }
}
