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
            this.studyButton = new Smart_Cards.CircularButton();
            this.editButton = new Smart_Cards.CircularButton();
            this.SuspendLayout();
            // 
            // deckTitleLabel
            // 
            this.deckTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.deckTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.deckTitleLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deckTitleLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deckTitleLabel.Location = new System.Drawing.Point(3, 15);
            this.deckTitleLabel.Name = "deckTitleLabel";
            this.deckTitleLabel.Size = new System.Drawing.Size(277, 32);
            this.deckTitleLabel.TabIndex = 1;
            this.deckTitleLabel.Text = "Sample Deck";
            this.deckTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studyLabel
            // 
            this.studyLabel.AutoSize = true;
            this.studyLabel.BackColor = System.Drawing.Color.Transparent;
            this.studyLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studyLabel.Location = new System.Drawing.Point(46, 165);
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
            this.editLabel.Location = new System.Drawing.Point(181, 165);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(48, 25);
            this.editLabel.TabIndex = 11;
            this.editLabel.Text = "Edit";
            // 
            // studyButton
            // 
            this.studyButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.studyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.studyButton.BorderColor = System.Drawing.Color.DarkGray;
            this.studyButton.BorderRadius = 20;
            this.studyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studyButton.FlatAppearance.BorderSize = 0;
            this.studyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studyButton.Image = global::Smart_Cards.Properties.Resources.study_icon_light;
            this.studyButton.Location = new System.Drawing.Point(39, 80);
            this.studyButton.Name = "studyButton";
            this.studyButton.Size = new System.Drawing.Size(82, 82);
            this.studyButton.TabIndex = 12;
            this.studyButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.editButton.BorderColor = System.Drawing.Color.DarkGray;
            this.editButton.BorderRadius = 20;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Image = global::Smart_Cards.Properties.Resources.edit_icon_light;
            this.editButton.Location = new System.Drawing.Point(164, 80);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(82, 82);
            this.editButton.TabIndex = 3;
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // DeckPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.studyButton);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.studyLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deckTitleLabel);
            this.Name = "DeckPanel";
            this.Size = new System.Drawing.Size(280, 230);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deckTitleLabel;
        private CircularButton editButton;
        private System.Windows.Forms.Label studyLabel;
        private System.Windows.Forms.Label editLabel;
        private CircularButton studyButton;
    }
}
