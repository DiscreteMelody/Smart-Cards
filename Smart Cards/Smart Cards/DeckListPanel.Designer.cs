namespace Smart_Cards
{
    partial class DeckListPanel
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
            this.DeckListFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // DeckListFlowLayoutPanel
            // 
            this.DeckListFlowLayoutPanel.AutoScroll = true;
            this.DeckListFlowLayoutPanel.AutoSize = true;
            this.DeckListFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeckListFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.DeckListFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DeckListFlowLayoutPanel.Name = "DeckListFlowLayoutPanel";
            this.DeckListFlowLayoutPanel.Size = new System.Drawing.Size(670, 562);
            this.DeckListFlowLayoutPanel.TabIndex = 4;
            // 
            // DeckListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeckListFlowLayoutPanel);
            this.Name = "DeckListPanel";
            this.Size = new System.Drawing.Size(670, 562);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel DeckListFlowLayoutPanel;
    }
}
