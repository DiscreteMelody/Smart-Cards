namespace Smart_Cards
{
    partial class PrimaryForm
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.highlightPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.addDeckButton = new System.Windows.Forms.Button();
            this.decksButton = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.PrimaryHelpPanel = new Smart_Cards.HelpPanel();
            this.PrimaryStudyPanel = new Smart_Cards.StudyPanel();
            this.PrimaryEditPanel = new Smart_Cards.EditPanel();
            this.PrimaryDeckListPanel = new Smart_Cards.DeckListPanel();
            this.menuPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.menuPanel.Controls.Add(this.highlightPanel);
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Controls.Add(this.helpButton);
            this.menuPanel.Controls.Add(this.addDeckButton);
            this.menuPanel.Controls.Add(this.decksButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(150, 561);
            this.menuPanel.TabIndex = 0;
            // 
            // highlightPanel
            // 
            this.highlightPanel.BackColor = System.Drawing.Color.White;
            this.highlightPanel.Location = new System.Drawing.Point(130, 75);
            this.highlightPanel.Name = "highlightPanel";
            this.highlightPanel.Size = new System.Drawing.Size(20, 110);
            this.highlightPanel.TabIndex = 3;
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
            this.exitButton.Location = new System.Drawing.Point(0, 451);
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
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(150, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(634, 75);
            this.headerPanel.TabIndex = 2;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(6, 18);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(205, 38);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Smart Cards";
            // 
            // HelpPanelLayout
            // 
            this.PrimaryHelpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimaryHelpPanel.Location = new System.Drawing.Point(150, 75);
            this.PrimaryHelpPanel.Margin = new System.Windows.Forms.Padding(2);
            this.PrimaryHelpPanel.Name = "HelpPanelLayout";
            this.PrimaryHelpPanel.Size = new System.Drawing.Size(634, 486);
            this.PrimaryHelpPanel.TabIndex = 0;
            // 
            // StudyPanelLayout
            // 
            this.PrimaryStudyPanel.AutoSize = true;
            this.PrimaryStudyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimaryStudyPanel.Location = new System.Drawing.Point(150, 75);
            this.PrimaryStudyPanel.Name = "StudyPanelLayout";
            this.PrimaryStudyPanel.Size = new System.Drawing.Size(634, 486);
            this.PrimaryStudyPanel.TabIndex = 0;
            // 
            // EditPanelLayout
            // 
            this.PrimaryEditPanel.AutoSize = true;
            this.PrimaryEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimaryEditPanel.Location = new System.Drawing.Point(150, 75);
            this.PrimaryEditPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PrimaryEditPanel.Name = "EditPanelLayout";
            this.PrimaryEditPanel.Size = new System.Drawing.Size(634, 486);
            this.PrimaryEditPanel.TabIndex = 4;
            // 
            // PrimaryDeckListPanel
            // 
            this.PrimaryDeckListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimaryDeckListPanel.Location = new System.Drawing.Point(150, 75);
            this.PrimaryDeckListPanel.Name = "PrimaryDeckListPanel";
            this.PrimaryDeckListPanel.Size = new System.Drawing.Size(634, 486);
            this.PrimaryDeckListPanel.TabIndex = 5;
            // 
            // PrimaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PrimaryDeckListPanel);
            this.Controls.Add(this.PrimaryHelpPanel);
            this.Controls.Add(this.PrimaryStudyPanel);
            this.Controls.Add(this.PrimaryEditPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.menuPanel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "PrimaryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrimaryForm_FormClosing);
            this.Load += new System.EventHandler(this.PrimaryForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button decksButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button addDeckButton;
        private System.Windows.Forms.Panel highlightPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private EditPanel PrimaryEditPanel;
        private StudyPanel PrimaryStudyPanel;
        private HelpPanel PrimaryHelpPanel;
        private DeckListPanel PrimaryDeckListPanel;
    }
}

