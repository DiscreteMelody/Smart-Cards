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
			this.termFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.saveDeckLabel = new System.Windows.Forms.Label();
			this.deleteDeckLabel = new System.Windows.Forms.Label();
			this.newTermLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.searchButton = new System.Windows.Forms.Button();
			this.deleteDeckButton = new Smart_Cards.CircularButton();
			this.saveDeckButton = new Smart_Cards.CircularButton();
			this.addTermButton = new Smart_Cards.CircularButton();
			this.deckTitleTextbox = new Smart_Cards.CustomizedTextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// termFlowLayoutPanel
			// 
			this.termFlowLayoutPanel.AutoScroll = true;
			this.termFlowLayoutPanel.AutoSize = true;
			this.termFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.termFlowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel1.SetColumnSpan(this.termFlowLayoutPanel, 2);
			this.termFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.termFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.termFlowLayoutPanel.Location = new System.Drawing.Point(3, 43);
			this.termFlowLayoutPanel.Name = "termFlowLayoutPanel";
			this.termFlowLayoutPanel.Size = new System.Drawing.Size(594, 298);
			this.termFlowLayoutPanel.TabIndex = 15;
			this.termFlowLayoutPanel.WrapContents = false;
			// 
			// saveDeckLabel
			// 
			this.saveDeckLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveDeckLabel.AutoSize = true;
			this.saveDeckLabel.BackColor = System.Drawing.Color.Transparent;
			this.saveDeckLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveDeckLabel.Location = new System.Drawing.Point(720, 505);
			this.saveDeckLabel.Name = "saveDeckLabel";
			this.saveDeckLabel.Size = new System.Drawing.Size(156, 32);
			this.saveDeckLabel.TabIndex = 18;
			this.saveDeckLabel.Text = "Save Deck";
			// 
			// deleteDeckLabel
			// 
			this.deleteDeckLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteDeckLabel.AutoSize = true;
			this.deleteDeckLabel.BackColor = System.Drawing.Color.Transparent;
			this.deleteDeckLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteDeckLabel.Location = new System.Drawing.Point(855, 506);
			this.deleteDeckLabel.Name = "deleteDeckLabel";
			this.deleteDeckLabel.Size = new System.Drawing.Size(176, 32);
			this.deleteDeckLabel.TabIndex = 20;
			this.deleteDeckLabel.Text = "Delete Deck";
			// 
			// newTermLabel
			// 
			this.newTermLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.newTermLabel.AutoSize = true;
			this.newTermLabel.BackColor = System.Drawing.Color.Transparent;
			this.newTermLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newTermLabel.Location = new System.Drawing.Point(3, 506);
			this.newTermLabel.Name = "newTermLabel";
			this.newTermLabel.Size = new System.Drawing.Size(144, 32);
			this.newTermLabel.TabIndex = 21;
			this.newTermLabel.Text = "New Term";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.searchButton, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.termFlowLayoutPanel, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(207, 70);
			this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(600, 10000);
			this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(600, 344);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 344);
			this.tableLayoutPanel1.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Right;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cards";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// searchButton
			// 
			this.searchButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.searchButton.FlatAppearance.BorderSize = 0;
			this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.searchButton.Image = global::Smart_Cards.Properties.Resources.clear_search_icon;
			this.searchButton.Location = new System.Drawing.Point(108, 3);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(34, 34);
			this.searchButton.TabIndex = 1;
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
			this.deleteDeckButton.Location = new System.Drawing.Point(883, 420);
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
			this.saveDeckButton.Location = new System.Drawing.Point(739, 420);
			this.saveDeckButton.Name = "saveDeckButton";
			this.saveDeckButton.Size = new System.Drawing.Size(82, 82);
			this.saveDeckButton.TabIndex = 17;
			this.saveDeckButton.UseVisualStyleBackColor = false;
			this.saveDeckButton.Click += new System.EventHandler(this.saveDeckButton_Click);
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
			this.addTermButton.Location = new System.Drawing.Point(17, 420);
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
			this.deckTitleTextbox.Location = new System.Drawing.Point(316, 15);
			this.deckTitleTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.newTermLabel);
			this.Controls.Add(this.deleteDeckLabel);
			this.Controls.Add(this.deleteDeckButton);
			this.Controls.Add(this.saveDeckLabel);
			this.Controls.Add(this.saveDeckButton);
			this.Controls.Add(this.addTermButton);
			this.Controls.Add(this.deckTitleTextbox);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "EditPanel";
			this.Size = new System.Drawing.Size(1002, 536);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private CustomizedTextBox deckTitleTextbox;
        private System.Windows.Forms.FlowLayoutPanel termFlowLayoutPanel;
        private CircularButton addTermButton;
        private CircularButton saveDeckButton;
        private System.Windows.Forms.Label saveDeckLabel;
        private CircularButton deleteDeckButton;
        private System.Windows.Forms.Label deleteDeckLabel;
        private System.Windows.Forms.Label newTermLabel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button searchButton;
	}
}
