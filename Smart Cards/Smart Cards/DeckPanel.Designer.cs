namespace Smart_Cards
{
    partial class DeckPanel
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
            this.deckTitleLabel = new System.Windows.Forms.Label();
            this.studyLabel = new System.Windows.Forms.Label();
            this.editLabel = new System.Windows.Forms.Label();
            this.circularButton1 = new Smart_Cards.CircularButton();
            this.circularButton2 = new Smart_Cards.CircularButton();
            this.SuspendLayout();
            // 
            // deckTitleLabel
            // 
            this.deckTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.deckTitleLabel.AutoSize = true;
            this.deckTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.deckTitleLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deckTitleLabel.Location = new System.Drawing.Point(55, 11);
            this.deckTitleLabel.Name = "deckTitleLabel";
            this.deckTitleLabel.Size = new System.Drawing.Size(190, 32);
            this.deckTitleLabel.TabIndex = 1;
            this.deckTitleLabel.Text = "Sample Deck";
            // 
            // studyLabel
            // 
            this.studyLabel.AutoSize = true;
            this.studyLabel.BackColor = System.Drawing.Color.Transparent;
            this.studyLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studyLabel.Location = new System.Drawing.Point(56, 165);
            this.studyLabel.Name = "studyLabel";
            this.studyLabel.Size = new System.Drawing.Size(68, 25);
            this.studyLabel.TabIndex = 10;
            this.studyLabel.Text = "Study";
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.BackColor = System.Drawing.Color.Transparent;
            this.editLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLabel.Location = new System.Drawing.Point(191, 165);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(48, 25);
            this.editLabel.TabIndex = 11;
            this.editLabel.Text = "Edit";
            // 
            // circularButton1
            // 
            this.circularButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.circularButton1.BorderColor = System.Drawing.Color.DarkGray;
            this.circularButton1.BorderRadius = 20;
            this.circularButton1.FlatAppearance.BorderSize = 0;
            this.circularButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton1.Location = new System.Drawing.Point(174, 80);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(82, 82);
            this.circularButton1.TabIndex = 3;
            this.circularButton1.UseVisualStyleBackColor = false;
            // 
            // circularButton2
            // 
            this.circularButton2.BorderColor = System.Drawing.Color.Empty;
            this.circularButton2.BorderRadius = 0;
            this.circularButton2.Location = new System.Drawing.Point(61, 80);
            this.circularButton2.Name = "circularButton2";
            this.circularButton2.Size = new System.Drawing.Size(76, 82);
            this.circularButton2.TabIndex = 12;
            this.circularButton2.Text = "circularButton2";
            this.circularButton2.UseVisualStyleBackColor = true;
            // 
            // DeckPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.circularButton2);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.studyLabel);
            this.Controls.Add(this.circularButton1);
            this.Controls.Add(this.deckTitleLabel);
            this.Name = "DeckPanel";
            this.Size = new System.Drawing.Size(301, 230);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deckTitleLabel;
        private CircularButton circularButton1;
        private System.Windows.Forms.Label studyLabel;
        private System.Windows.Forms.Label editLabel;
        private CircularButton circularButton2;
    }
}
