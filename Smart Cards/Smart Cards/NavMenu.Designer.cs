namespace Smart_Cards
{
    partial class NavMenu
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.HighlightPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.addDeckButton = new System.Windows.Forms.Button();
            this.decksButton = new System.Windows.Forms.Button();
            this.shareButton = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.menuPanel.Controls.Add(this.shareButton);
            this.menuPanel.Controls.Add(this.HighlightPanel);
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Controls.Add(this.helpButton);
            this.menuPanel.Controls.Add(this.addDeckButton);
            this.menuPanel.Controls.Add(this.decksButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(150, 681);
            this.menuPanel.TabIndex = 1;
            // 
            // HighlightPanel
            // 
            this.HighlightPanel.BackColor = System.Drawing.Color.White;
            this.HighlightPanel.Location = new System.Drawing.Point(130, 75);
            this.HighlightPanel.Name = "HighlightPanel";
            this.HighlightPanel.Size = new System.Drawing.Size(20, 110);
            this.HighlightPanel.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = global::Smart_Cards.Properties.Resources.power_icon_light;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitButton.Location = new System.Drawing.Point(0, 571);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 110);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.helpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Image = global::Smart_Cards.Properties.Resources.help_icon_light;
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.helpButton.Location = new System.Drawing.Point(0, 295);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(150, 110);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Help";
            this.helpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // addDeckButton
            // 
            this.addDeckButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.addDeckButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDeckButton.FlatAppearance.BorderSize = 0;
            this.addDeckButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.addDeckButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.addDeckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDeckButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDeckButton.ForeColor = System.Drawing.Color.White;
            this.addDeckButton.Image = global::Smart_Cards.Properties.Resources.add_icon_light;
            this.addDeckButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addDeckButton.Location = new System.Drawing.Point(0, 185);
            this.addDeckButton.Name = "addDeckButton";
            this.addDeckButton.Size = new System.Drawing.Size(150, 110);
            this.addDeckButton.TabIndex = 4;
            this.addDeckButton.Text = "Add New";
            this.addDeckButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addDeckButton.UseVisualStyleBackColor = false;
            this.addDeckButton.Click += new System.EventHandler(this.addDeckButton_Click);
            // 
            // decksButton
            // 
            this.decksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.decksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decksButton.FlatAppearance.BorderSize = 0;
            this.decksButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.decksButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.decksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decksButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decksButton.ForeColor = System.Drawing.Color.White;
            this.decksButton.Image = global::Smart_Cards.Properties.Resources.flashcard_icon_light;
            this.decksButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.decksButton.Location = new System.Drawing.Point(0, 75);
            this.decksButton.Name = "decksButton";
            this.decksButton.Size = new System.Drawing.Size(150, 110);
            this.decksButton.TabIndex = 3;
            this.decksButton.Text = "Decks";
            this.decksButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.decksButton.UseVisualStyleBackColor = false;
            this.decksButton.Click += new System.EventHandler(this.decksButton_Click);
            // 
            // shareButton
            // 
            this.shareButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.shareButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shareButton.FlatAppearance.BorderSize = 0;
            this.shareButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.shareButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.shareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shareButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareButton.ForeColor = System.Drawing.Color.White;
            this.shareButton.Image = global::Smart_Cards.Properties.Resources.box_icon_light;
            this.shareButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.shareButton.Location = new System.Drawing.Point(0, 405);
            this.shareButton.Name = "shareButton";
            this.shareButton.Size = new System.Drawing.Size(150, 110);
            this.shareButton.TabIndex = 7;
            this.shareButton.Text = "Share Decks";
            this.shareButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.shareButton.UseVisualStyleBackColor = false;
            // 
            // NavMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuPanel);
            this.Name = "NavMenu";
            this.Size = new System.Drawing.Size(150, 681);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel HighlightPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button addDeckButton;
        private System.Windows.Forms.Button decksButton;
        private System.Windows.Forms.Button shareButton;
    }
}
