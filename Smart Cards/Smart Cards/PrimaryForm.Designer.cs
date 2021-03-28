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
            this.exitButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.addDeckButton = new System.Windows.Forms.Button();
            this.highlightPanel = new System.Windows.Forms.Panel();
            this.studyButton = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.studyPanel1 = new Smart_Cards.StudyPanel();
            this.menuPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Controls.Add(this.helpButton);
            this.menuPanel.Controls.Add(this.addDeckButton);
            this.menuPanel.Controls.Add(this.highlightPanel);
            this.menuPanel.Controls.Add(this.studyButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(150, 561);
            this.menuPanel.TabIndex = 0;
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
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitButton.Location = new System.Drawing.Point(0, 451);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 110);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitButton.UseVisualStyleBackColor = false;
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
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.helpButton.Location = new System.Drawing.Point(0, 295);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(150, 110);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Help";
            this.helpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.helpButton.UseVisualStyleBackColor = false;
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
            this.addDeckButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addDeckButton.Location = new System.Drawing.Point(0, 185);
            this.addDeckButton.Name = "addDeckButton";
            this.addDeckButton.Size = new System.Drawing.Size(150, 110);
            this.addDeckButton.TabIndex = 4;
            this.addDeckButton.Text = "Add New";
            this.addDeckButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addDeckButton.UseVisualStyleBackColor = false;
            this.addDeckButton.Click += new System.EventHandler(this.addDeckButton_Click);
            // 
            // highlightPanel
            // 
            this.highlightPanel.BackColor = System.Drawing.Color.White;
            this.highlightPanel.Location = new System.Drawing.Point(130, 75);
            this.highlightPanel.Name = "highlightPanel";
            this.highlightPanel.Size = new System.Drawing.Size(20, 110);
            this.highlightPanel.TabIndex = 3;
            // 
            // studyButton
            // 
            this.studyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.studyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studyButton.FlatAppearance.BorderSize = 0;
            this.studyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.studyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.studyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studyButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studyButton.ForeColor = System.Drawing.Color.White;
            this.studyButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.studyButton.Location = new System.Drawing.Point(0, 75);
            this.studyButton.Name = "studyButton";
            this.studyButton.Size = new System.Drawing.Size(150, 110);
            this.studyButton.TabIndex = 3;
            this.studyButton.Text = "Study";
            this.studyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.studyButton.UseVisualStyleBackColor = false;
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
            // studyPanel1
            // 
            this.studyPanel1.AutoScroll = true;
            this.studyPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.studyPanel1.Location = new System.Drawing.Point(156, 81);
            this.studyPanel1.Name = "studyPanel1";
            this.studyPanel1.Size = new System.Drawing.Size(628, 480);
            this.studyPanel1.TabIndex = 3;
            this.studyPanel1.Load += new System.EventHandler(this.studyPanel1_Load);
            // 
            // PrimaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.studyPanel1);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "PrimaryForm";
            this.Text = "Form1";
            this.menuPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button studyButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button addDeckButton;
        private System.Windows.Forms.Panel highlightPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private StudyPanel studyPanel1;
    }
}

