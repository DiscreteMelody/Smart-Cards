namespace Smart_Cards
{
    partial class EditPanel
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
            this.termFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.deleteTermButton = new System.Windows.Forms.Button();
            this.saveDeckLabel = new System.Windows.Forms.Label();
            this.deleteDeckLabel = new System.Windows.Forms.Label();
            this.newTermLabel = new System.Windows.Forms.Label();
            this.deleteDeckButton = new Smart_Cards.CircularButton();
            this.saveDeckButton = new Smart_Cards.CircularButton();
            this.termTextbox = new Smart_Cards.CustomizedTextBox();
            this.termAnswerTextbox = new Smart_Cards.CustomizedTextBox();
            this.addTermButton = new Smart_Cards.CircularButton();
            this.deckTitleTextbox = new Smart_Cards.CustomizedTextBox();
            this.termFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // deckTitleLabel
            // 
            this.deckTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deckTitleLabel.AutoSize = true;
            this.deckTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.deckTitleLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deckTitleLabel.Location = new System.Drawing.Point(234, 12);
            this.deckTitleLabel.Name = "deckTitleLabel";
            this.deckTitleLabel.Size = new System.Drawing.Size(140, 32);
            this.deckTitleLabel.TabIndex = 9;
            this.deckTitleLabel.Text = "Deck Title";
            // 
            // termFlowLayoutPanel
            // 
            this.termFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.termFlowLayoutPanel.AutoScroll = true;
            this.termFlowLayoutPanel.Controls.Add(this.termTextbox);
            this.termFlowLayoutPanel.Controls.Add(this.termAnswerTextbox);
            this.termFlowLayoutPanel.Controls.Add(this.deleteTermButton);
            this.termFlowLayoutPanel.Location = new System.Drawing.Point(3, 121);
            this.termFlowLayoutPanel.MinimumSize = new System.Drawing.Size(603, 221);
            this.termFlowLayoutPanel.Name = "termFlowLayoutPanel";
            this.termFlowLayoutPanel.Size = new System.Drawing.Size(603, 221);
            this.termFlowLayoutPanel.TabIndex = 15;
            // 
            // deleteTermButton
            // 
            this.deleteTermButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.deleteTermButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteTermButton.FlatAppearance.BorderSize = 0;
            this.deleteTermButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.deleteTermButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.deleteTermButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTermButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTermButton.ForeColor = System.Drawing.Color.White;
            this.deleteTermButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteTermButton.Location = new System.Drawing.Point(493, 3);
            this.deleteTermButton.MinimumSize = new System.Drawing.Size(88, 48);
            this.deleteTermButton.Name = "deleteTermButton";
            this.deleteTermButton.Size = new System.Drawing.Size(88, 48);
            this.deleteTermButton.TabIndex = 15;
            this.deleteTermButton.Text = "Delete";
            this.deleteTermButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteTermButton.UseVisualStyleBackColor = false;
            // 
            // saveDeckLabel
            // 
            this.saveDeckLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveDeckLabel.AutoSize = true;
            this.saveDeckLabel.BackColor = System.Drawing.Color.Transparent;
            this.saveDeckLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDeckLabel.Location = new System.Drawing.Point(327, 433);
            this.saveDeckLabel.Name = "saveDeckLabel";
            this.saveDeckLabel.Size = new System.Drawing.Size(121, 25);
            this.saveDeckLabel.TabIndex = 18;
            this.saveDeckLabel.Text = "Save Deck";
            // 
            // deleteDeckLabel
            // 
            this.deleteDeckLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteDeckLabel.AutoSize = true;
            this.deleteDeckLabel.BackColor = System.Drawing.Color.Transparent;
            this.deleteDeckLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDeckLabel.Location = new System.Drawing.Point(462, 434);
            this.deleteDeckLabel.Name = "deleteDeckLabel";
            this.deleteDeckLabel.Size = new System.Drawing.Size(136, 25);
            this.deleteDeckLabel.TabIndex = 20;
            this.deleteDeckLabel.Text = "Delete Deck";
            // 
            // newTermLabel
            // 
            this.newTermLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newTermLabel.AutoSize = true;
            this.newTermLabel.BackColor = System.Drawing.Color.Transparent;
            this.newTermLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTermLabel.Location = new System.Drawing.Point(3, 434);
            this.newTermLabel.Name = "newTermLabel";
            this.newTermLabel.Size = new System.Drawing.Size(113, 25);
            this.newTermLabel.TabIndex = 21;
            this.newTermLabel.Text = "New Term";
            // 
            // deleteDeckButton
            // 
            this.deleteDeckButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteDeckButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.deleteDeckButton.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteDeckButton.BorderRadius = 20;
            this.deleteDeckButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteDeckButton.FlatAppearance.BorderSize = 0;
            this.deleteDeckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteDeckButton.Image = global::Smart_Cards.Properties.Resources.trash_icon_light;
            this.deleteDeckButton.Location = new System.Drawing.Point(490, 348);
            this.deleteDeckButton.Name = "deleteDeckButton";
            this.deleteDeckButton.Size = new System.Drawing.Size(82, 82);
            this.deleteDeckButton.TabIndex = 19;
            this.deleteDeckButton.UseVisualStyleBackColor = false;
            this.deleteDeckButton.Click += new System.EventHandler(this.deleteDeckButton_Click);
            // 
            // saveDeckButton
            // 
            this.saveDeckButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveDeckButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.saveDeckButton.BorderColor = System.Drawing.Color.DarkGray;
            this.saveDeckButton.BorderRadius = 20;
            this.saveDeckButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveDeckButton.FlatAppearance.BorderSize = 0;
            this.saveDeckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveDeckButton.Image = global::Smart_Cards.Properties.Resources.save_icon_light;
            this.saveDeckButton.Location = new System.Drawing.Point(346, 348);
            this.saveDeckButton.Name = "saveDeckButton";
            this.saveDeckButton.Size = new System.Drawing.Size(82, 82);
            this.saveDeckButton.TabIndex = 17;
            this.saveDeckButton.UseVisualStyleBackColor = false;
            this.saveDeckButton.Click += new System.EventHandler(this.saveDeckButton_Click);
            // 
            // termTextbox
            // 
            this.termTextbox.BackColor = System.Drawing.Color.Transparent;
            this.termTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.termTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.termTextbox.ForeColor = System.Drawing.Color.Transparent;
            this.termTextbox.Location = new System.Drawing.Point(3, 3);
            this.termTextbox.MinimumSize = new System.Drawing.Size(176, 48);
            this.termTextbox.Name = "termTextbox";
            this.termTextbox.Padding = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.termTextbox.Size = new System.Drawing.Size(176, 48);
            this.termTextbox.TabIndex = 12;
            this.termTextbox.TogglesBorder = true;
            this.termTextbox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.termTextbox.WatermarkText = "Enter a term/question";
            // 
            // termAnswerTextbox
            // 
            this.termAnswerTextbox.BackColor = System.Drawing.Color.Transparent;
            this.termAnswerTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.termAnswerTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.termAnswerTextbox.ForeColor = System.Drawing.Color.Transparent;
            this.termAnswerTextbox.Location = new System.Drawing.Point(185, 3);
            this.termAnswerTextbox.MinimumSize = new System.Drawing.Size(302, 48);
            this.termAnswerTextbox.Name = "termAnswerTextbox";
            this.termAnswerTextbox.Padding = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.termAnswerTextbox.Size = new System.Drawing.Size(302, 48);
            this.termAnswerTextbox.TabIndex = 14;
            this.termAnswerTextbox.TogglesBorder = true;
            this.termAnswerTextbox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.termAnswerTextbox.WatermarkText = "Enter the answer here";
            // 
            // addTermButton
            // 
            this.addTermButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addTermButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addTermButton.BorderColor = System.Drawing.Color.DarkGray;
            this.addTermButton.BorderRadius = 20;
            this.addTermButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTermButton.FlatAppearance.BorderSize = 0;
            this.addTermButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTermButton.Image = global::Smart_Cards.Properties.Resources.plus_icon_light;
            this.addTermButton.Location = new System.Drawing.Point(17, 348);
            this.addTermButton.Name = "addTermButton";
            this.addTermButton.Size = new System.Drawing.Size(82, 82);
            this.addTermButton.TabIndex = 16;
            this.addTermButton.UseVisualStyleBackColor = false;
            this.addTermButton.Click += new System.EventHandler(this.addTermButton_Click);
            // 
            // deckTitleTextbox
            // 
            this.deckTitleTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deckTitleTextbox.BackColor = System.Drawing.Color.Transparent;
            this.deckTitleTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.deckTitleTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.deckTitleTextbox.ForeColor = System.Drawing.Color.Transparent;
            this.deckTitleTextbox.Location = new System.Drawing.Point(118, 63);
            this.deckTitleTextbox.Name = "deckTitleTextbox";
            this.deckTitleTextbox.Padding = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.deckTitleTextbox.Size = new System.Drawing.Size(372, 48);
            this.deckTitleTextbox.TabIndex = 10;
            this.deckTitleTextbox.TogglesBorder = true;
            this.deckTitleTextbox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deckTitleTextbox.WatermarkText = "Enter a title for your deck";
            // 
            // EditPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.Controls.Add(this.newTermLabel);
            this.Controls.Add(this.deleteDeckLabel);
            this.Controls.Add(this.deleteDeckButton);
            this.Controls.Add(this.saveDeckLabel);
            this.Controls.Add(this.saveDeckButton);
            this.Controls.Add(this.termFlowLayoutPanel);
            this.Controls.Add(this.addTermButton);
            this.Controls.Add(this.deckTitleTextbox);
            this.Controls.Add(this.deckTitleLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EditPanel";
            this.Size = new System.Drawing.Size(609, 464);
            this.Load += new System.EventHandler(this.EditPanel_Load);
            this.Resize += new System.EventHandler(this.EditPanel_Resize);
            this.termFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label deckTitleLabel;
        private CustomizedTextBox deckTitleTextbox;
        private CustomizedTextBox termTextbox;
        private System.Windows.Forms.FlowLayoutPanel termFlowLayoutPanel;
        private CustomizedTextBox termAnswerTextbox;
        private System.Windows.Forms.Button deleteTermButton;
        private CircularButton addTermButton;
        private CircularButton saveDeckButton;
        private System.Windows.Forms.Label saveDeckLabel;
        private CircularButton deleteDeckButton;
        private System.Windows.Forms.Label deleteDeckLabel;
        private System.Windows.Forms.Label newTermLabel;
    }
}
