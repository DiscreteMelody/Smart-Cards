namespace Smart_Cards
{
    partial class AddNewDeckPanel
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
			this.CancelButton = new System.Windows.Forms.Button();
			this.CreateDeckButton = new System.Windows.Forms.Button();
			this.DeckDescription = new Smart_Cards.CustomizedTextBox();
			this.DeckTitle = new Smart_Cards.CustomizedTextBox();
			this.SuspendLayout();
			// 
			// CancelButton
			// 
			this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.CancelButton.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CancelButton.FlatAppearance.BorderSize = 0;
			this.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
			this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
			this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CancelButton.ForeColor = System.Drawing.Color.White;
			this.CancelButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.CancelButton.Location = new System.Drawing.Point(77, 281);
			this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(160, 74);
			this.CancelButton.TabIndex = 17;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.CancelButton.UseVisualStyleBackColor = false;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// CreateDeckButton
			// 
			this.CreateDeckButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.CreateDeckButton.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.CreateDeckButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CreateDeckButton.FlatAppearance.BorderSize = 0;
			this.CreateDeckButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
			this.CreateDeckButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
			this.CreateDeckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CreateDeckButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CreateDeckButton.ForeColor = System.Drawing.Color.White;
			this.CreateDeckButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.CreateDeckButton.Location = new System.Drawing.Point(544, 281);
			this.CreateDeckButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CreateDeckButton.Name = "CreateDeckButton";
			this.CreateDeckButton.Size = new System.Drawing.Size(239, 74);
			this.CreateDeckButton.TabIndex = 18;
			this.CreateDeckButton.Text = "Create Deck";
			this.CreateDeckButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.CreateDeckButton.UseVisualStyleBackColor = false;
			this.CreateDeckButton.Click += new System.EventHandler(this.CreateDeckButton_Click);
			// 
			// DeckDescription
			// 
			this.DeckDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.DeckDescription.BackColor = System.Drawing.Color.Transparent;
			this.DeckDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
			this.DeckDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.DeckDescription.ForeColor = System.Drawing.Color.Transparent;
			this.DeckDescription.Location = new System.Drawing.Point(77, 215);
			this.DeckDescription.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.DeckDescription.Name = "DeckDescription";
			this.DeckDescription.Padding = new System.Windows.Forms.Padding(7, 9, 7, 6);
			this.DeckDescription.Size = new System.Drawing.Size(705, 58);
			this.DeckDescription.TabIndex = 19;
			this.DeckDescription.TogglesBorder = true;
			this.DeckDescription.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.DeckDescription.WatermarkText = "Deck Description";
			// 
			// DeckTitle
			// 
			this.DeckTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.DeckTitle.BackColor = System.Drawing.Color.Transparent;
			this.DeckTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
			this.DeckTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.DeckTitle.ForeColor = System.Drawing.Color.Transparent;
			this.DeckTitle.Location = new System.Drawing.Point(77, 97);
			this.DeckTitle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.DeckTitle.Name = "DeckTitle";
			this.DeckTitle.Padding = new System.Windows.Forms.Padding(7, 9, 7, 6);
			this.DeckTitle.Size = new System.Drawing.Size(705, 58);
			this.DeckTitle.TabIndex = 0;
			this.DeckTitle.TogglesBorder = true;
			this.DeckTitle.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.DeckTitle.WatermarkText = "Deck Title";
			// 
			// AddNewDeckPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.DeckDescription);
			this.Controls.Add(this.CreateDeckButton);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.DeckTitle);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "AddNewDeckPanel";
			this.Size = new System.Drawing.Size(840, 678);
			this.ResumeLayout(false);

        }

        #endregion

        private CustomizedTextBox DeckTitle;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CreateDeckButton;
        private CustomizedTextBox DeckDescription;
    }
}
