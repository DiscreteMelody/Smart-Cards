namespace Smart_Cards
{
    partial class StudyPanel
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
            this.deckPanel1 = new Smart_Cards.DeckPanel();
            this.deckPanel2 = new Smart_Cards.DeckPanel();
            this.deckPanel3 = new Smart_Cards.DeckPanel();
            this.deckPanel4 = new Smart_Cards.DeckPanel();
            this.deckPanel5 = new Smart_Cards.DeckPanel();
            this.SuspendLayout();
            // 
            // deckPanel1
            // 
            this.deckPanel1.BackColor = System.Drawing.Color.White;
            this.deckPanel1.Location = new System.Drawing.Point(3, 3);
            this.deckPanel1.Name = "deckPanel1";
            this.deckPanel1.Size = new System.Drawing.Size(301, 230);
            this.deckPanel1.TabIndex = 0;
            // 
            // deckPanel2
            // 
            this.deckPanel2.BackColor = System.Drawing.Color.White;
            this.deckPanel2.Location = new System.Drawing.Point(310, 3);
            this.deckPanel2.Name = "deckPanel2";
            this.deckPanel2.Size = new System.Drawing.Size(301, 230);
            this.deckPanel2.TabIndex = 1;
            // 
            // deckPanel3
            // 
            this.deckPanel3.BackColor = System.Drawing.Color.White;
            this.deckPanel3.Location = new System.Drawing.Point(3, 239);
            this.deckPanel3.Name = "deckPanel3";
            this.deckPanel3.Size = new System.Drawing.Size(301, 230);
            this.deckPanel3.TabIndex = 2;
            // 
            // deckPanel4
            // 
            this.deckPanel4.BackColor = System.Drawing.Color.White;
            this.deckPanel4.Location = new System.Drawing.Point(310, 239);
            this.deckPanel4.Name = "deckPanel4";
            this.deckPanel4.Size = new System.Drawing.Size(301, 230);
            this.deckPanel4.TabIndex = 3;
            // 
            // deckPanel5
            // 
            this.deckPanel5.BackColor = System.Drawing.Color.White;
            this.deckPanel5.Location = new System.Drawing.Point(3, 475);
            this.deckPanel5.Name = "deckPanel5";
            this.deckPanel5.Size = new System.Drawing.Size(301, 230);
            this.deckPanel5.TabIndex = 4;
            // 
            // StudyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Controls.Add(this.deckPanel5);
            this.Controls.Add(this.deckPanel4);
            this.Controls.Add(this.deckPanel3);
            this.Controls.Add(this.deckPanel2);
            this.Controls.Add(this.deckPanel1);
            this.Name = "StudyPanel";
            this.Size = new System.Drawing.Size(617, 486);
            this.ResumeLayout(false);

        }

        #endregion

        private DeckPanel deckPanel1;
        private DeckPanel deckPanel2;
        private DeckPanel deckPanel3;
        private DeckPanel deckPanel4;
        private DeckPanel deckPanel5;
    }
}
