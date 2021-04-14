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
            this.termTitleLabel = new System.Windows.Forms.Label();
            this.submitAnswerButton = new System.Windows.Forms.Button();
            this.nextTermButton = new System.Windows.Forms.Button();
            this.CurrentDeckTitle = new System.Windows.Forms.Label();
            this.termAnswerTextbox = new Smart_Cards.CustomizedTextBox();
            this.SuspendLayout();
            // 
            // termTitleLabel
            // 
            this.termTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.termTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.termTitleLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termTitleLabel.Location = new System.Drawing.Point(-2, 62);
            this.termTitleLabel.Name = "termTitleLabel";
            this.termTitleLabel.Padding = new System.Windows.Forms.Padding(20);
            this.termTitleLabel.Size = new System.Drawing.Size(609, 142);
            this.termTitleLabel.TabIndex = 10;
            this.termTitleLabel.Text = "Sample Term/Question";
            this.termTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitAnswerButton
            // 
            this.submitAnswerButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitAnswerButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.submitAnswerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitAnswerButton.FlatAppearance.BorderSize = 0;
            this.submitAnswerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.submitAnswerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.submitAnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitAnswerButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitAnswerButton.ForeColor = System.Drawing.Color.White;
            this.submitAnswerButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.submitAnswerButton.Location = new System.Drawing.Point(213, 341);
            this.submitAnswerButton.Name = "submitAnswerButton";
            this.submitAnswerButton.Size = new System.Drawing.Size(179, 49);
            this.submitAnswerButton.TabIndex = 16;
            this.submitAnswerButton.Text = "Submit";
            this.submitAnswerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.submitAnswerButton.UseVisualStyleBackColor = false;
            this.submitAnswerButton.Click += new System.EventHandler(this.submitAnswerButton_Click);
            // 
            // nextTermButton
            // 
            this.nextTermButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextTermButton.AutoSize = true;
            this.nextTermButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.nextTermButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextTermButton.FlatAppearance.BorderSize = 0;
            this.nextTermButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.nextTermButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.nextTermButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextTermButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextTermButton.ForeColor = System.Drawing.Color.White;
            this.nextTermButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nextTermButton.Location = new System.Drawing.Point(213, 341);
            this.nextTermButton.Name = "nextTermButton";
            this.nextTermButton.Size = new System.Drawing.Size(179, 49);
            this.nextTermButton.TabIndex = 18;
            this.nextTermButton.Text = "Next";
            this.nextTermButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.nextTermButton.UseVisualStyleBackColor = false;
            this.nextTermButton.Click += new System.EventHandler(this.nextTermButton_Click);
            // 
            // CurrentDeckTitle
            // 
            this.CurrentDeckTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentDeckTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CurrentDeckTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDeckTitle.Location = new System.Drawing.Point(0, 0);
            this.CurrentDeckTitle.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentDeckTitle.Name = "CurrentDeckTitle";
            this.CurrentDeckTitle.Padding = new System.Windows.Forms.Padding(20);
            this.CurrentDeckTitle.Size = new System.Drawing.Size(606, 62);
            this.CurrentDeckTitle.TabIndex = 19;
            this.CurrentDeckTitle.Text = "World History";
            this.CurrentDeckTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // termAnswerTextbox
            // 
            this.termAnswerTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.termAnswerTextbox.BackColor = System.Drawing.Color.Transparent;
            this.termAnswerTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.termAnswerTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.termAnswerTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termAnswerTextbox.ForeColor = System.Drawing.Color.Transparent;
            this.termAnswerTextbox.Location = new System.Drawing.Point(57, 224);
            this.termAnswerTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.termAnswerTextbox.Name = "termAnswerTextbox";
            this.termAnswerTextbox.Padding = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.termAnswerTextbox.Size = new System.Drawing.Size(498, 46);
            this.termAnswerTextbox.TabIndex = 15;
            this.termAnswerTextbox.TogglesBorder = true;
            this.termAnswerTextbox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.termAnswerTextbox.WatermarkText = "Enter the answer here";
            this.termAnswerTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.termAnswerTextbox_KeyDown);
            // 
            // StudyPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.CurrentDeckTitle);
            this.Controls.Add(this.submitAnswerButton);
            this.Controls.Add(this.nextTermButton);
            this.Controls.Add(this.termAnswerTextbox);
            this.Controls.Add(this.termTitleLabel);
            this.Name = "StudyPanel";
            this.Size = new System.Drawing.Size(609, 464);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label termTitleLabel;
        private CustomizedTextBox termAnswerTextbox;
        private System.Windows.Forms.Button submitAnswerButton;
        private System.Windows.Forms.Button nextTermButton;
        private System.Windows.Forms.Label CurrentDeckTitle;
    }
}
