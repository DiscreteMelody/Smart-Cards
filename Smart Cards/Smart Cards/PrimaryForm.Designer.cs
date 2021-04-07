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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.PrimaryDeckListPanel = new Smart_Cards.DeckListPanel();
            this.PrimaryAddNewDeckPanel = new Smart_Cards.AddNewDeckPanel();
            this.PrimaryEditPanel = new Smart_Cards.EditPanel();
            this.PrimaryStudyPanel = new Smart_Cards.StudyPanel();
            this.PrimaryHelpPanel = new Smart_Cards.HelpPanel();
            this.PrimaryNavMenu = new Smart_Cards.NavMenu();
            this.headerPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
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
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.PrimaryDeckListPanel);
            this.ContentPanel.Controls.Add(this.PrimaryAddNewDeckPanel);
            this.ContentPanel.Controls.Add(this.PrimaryEditPanel);
            this.ContentPanel.Controls.Add(this.PrimaryStudyPanel);
            this.ContentPanel.Controls.Add(this.PrimaryHelpPanel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(150, 75);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(634, 486);
            this.ContentPanel.TabIndex = 7;
            // 
            // PrimaryDeckListPanel
            // 
            this.PrimaryDeckListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimaryDeckListPanel.Location = new System.Drawing.Point(0, 0);
            this.PrimaryDeckListPanel.Name = "PrimaryDeckListPanel";
            this.PrimaryDeckListPanel.Size = new System.Drawing.Size(634, 486);
            this.PrimaryDeckListPanel.TabIndex = 5;
            // 
            // PrimaryAddNewDeckPanel
            // 
            this.PrimaryAddNewDeckPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimaryAddNewDeckPanel.Location = new System.Drawing.Point(0, 0);
            this.PrimaryAddNewDeckPanel.Name = "PrimaryAddNewDeckPanel";
            this.PrimaryAddNewDeckPanel.Size = new System.Drawing.Size(634, 486);
            this.PrimaryAddNewDeckPanel.TabIndex = 6;
            // 
            // PrimaryEditPanel
            // 
            this.PrimaryEditPanel.AutoSize = true;
            this.PrimaryEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimaryEditPanel.Location = new System.Drawing.Point(0, 0);
            this.PrimaryEditPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PrimaryEditPanel.Name = "PrimaryEditPanel";
            this.PrimaryEditPanel.Size = new System.Drawing.Size(634, 486);
            this.PrimaryEditPanel.TabIndex = 4;
            // 
            // PrimaryStudyPanel
            // 
            this.PrimaryStudyPanel.AutoSize = true;
            this.PrimaryStudyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimaryStudyPanel.Location = new System.Drawing.Point(0, 0);
            this.PrimaryStudyPanel.Name = "PrimaryStudyPanel";
            this.PrimaryStudyPanel.Size = new System.Drawing.Size(634, 486);
            this.PrimaryStudyPanel.TabIndex = 0;
            // 
            // PrimaryHelpPanel
            // 
            this.PrimaryHelpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimaryHelpPanel.Location = new System.Drawing.Point(0, 0);
            this.PrimaryHelpPanel.Margin = new System.Windows.Forms.Padding(2);
            this.PrimaryHelpPanel.Name = "PrimaryHelpPanel";
            this.PrimaryHelpPanel.Size = new System.Drawing.Size(634, 486);
            this.PrimaryHelpPanel.TabIndex = 0;
            // 
            // PrimaryNavMenu
            // 
            this.PrimaryNavMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PrimaryNavMenu.Location = new System.Drawing.Point(0, 0);
            this.PrimaryNavMenu.Name = "PrimaryNavMenu";
            this.PrimaryNavMenu.Size = new System.Drawing.Size(150, 561);
            this.PrimaryNavMenu.TabIndex = 6;
            // 
            // PrimaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.PrimaryNavMenu);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "PrimaryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrimaryForm_FormClosing);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private EditPanel PrimaryEditPanel;
        private StudyPanel PrimaryStudyPanel;
        private HelpPanel PrimaryHelpPanel;
        private DeckListPanel PrimaryDeckListPanel;
        private NavMenu PrimaryNavMenu;
        private System.Windows.Forms.Panel ContentPanel;
        private AddNewDeckPanel PrimaryAddNewDeckPanel;
    }
}

