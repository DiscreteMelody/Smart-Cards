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
            this.termAnswerLabel = new System.Windows.Forms.Label();
            this.nextTermButton = new System.Windows.Forms.Button();
            this.termAnswerTextbox = new Smart_Cards.CustomizedTextBox();
            this.SuspendLayout();
            // 
            // termTitleLabel
            // 
            this.termTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.termTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.termTitleLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.termTitleLabel.Name = "termTitleLabel";
            this.termTitleLabel.Padding = new System.Windows.Forms.Padding(20);
            this.termTitleLabel.Size = new System.Drawing.Size(609, 122);
            this.termTitleLabel.TabIndex = 10;
            this.termTitleLabel.Text = "Sample Term/Question";
            this.termTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitAnswerButton
            // 
            this.submitAnswerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitAnswerButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.submitAnswerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitAnswerButton.FlatAppearance.BorderSize = 0;
            this.submitAnswerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.submitAnswerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.submitAnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitAnswerButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitAnswerButton.ForeColor = System.Drawing.Color.White;
            this.submitAnswerButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.submitAnswerButton.Location = new System.Drawing.Point(240, 196);
            this.submitAnswerButton.Name = "submitAnswerButton";
            this.submitAnswerButton.Size = new System.Drawing.Size(128, 49);
            this.submitAnswerButton.TabIndex = 16;
            this.submitAnswerButton.Text = "Submit";
            this.submitAnswerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.submitAnswerButton.UseVisualStyleBackColor = false;
            this.submitAnswerButton.Click += new System.EventHandler(this.submitAnswerButton_Click);
            // 
            // termAnswerLabel
            // 
            this.termAnswerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.termAnswerLabel.BackColor = System.Drawing.Color.Transparent;
            this.termAnswerLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termAnswerLabel.Location = new System.Drawing.Point(0, 248);
            this.termAnswerLabel.Name = "termAnswerLabel";
            this.termAnswerLabel.Padding = new System.Windows.Forms.Padding(20);
            this.termAnswerLabel.Size = new System.Drawing.Size(609, 129);
            this.termAnswerLabel.TabIndex = 17;
            this.termAnswerLabel.Text = "Sample Term Answer (invisible until answer submitted)";
            this.termAnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextTermButton
            // 
            this.nextTermButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextTermButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.nextTermButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextTermButton.FlatAppearance.BorderSize = 0;
            this.nextTermButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.nextTermButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.nextTermButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextTermButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextTermButton.ForeColor = System.Drawing.Color.White;
            this.nextTermButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nextTermButton.Location = new System.Drawing.Point(240, 380);
            this.nextTermButton.Name = "nextTermButton";
            this.nextTermButton.Size = new System.Drawing.Size(128, 49);
            this.nextTermButton.TabIndex = 18;
            this.nextTermButton.Text = "Next";
            this.nextTermButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.nextTermButton.UseVisualStyleBackColor = false;
            this.nextTermButton.Click += new System.EventHandler(this.nextTermButton_Click);
            // 
            // termAnswerTextbox
            // 
            this.termAnswerTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.termAnswerTextbox.BackColor = System.Drawing.Color.Transparent;
            this.termAnswerTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.termAnswerTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.termAnswerTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termAnswerTextbox.ForeColor = System.Drawing.Color.Transparent;
            this.termAnswerTextbox.Location = new System.Drawing.Point(137, 127);
            this.termAnswerTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.termAnswerTextbox.Name = "termAnswerTextbox";
            this.termAnswerTextbox.Padding = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.termAnswerTextbox.Size = new System.Drawing.Size(360, 46);
            this.termAnswerTextbox.TabIndex = 15;
            this.termAnswerTextbox.TogglesBorder = true;
            this.termAnswerTextbox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.termAnswerTextbox.WatermarkText = "Enter the answer here";
            // 
            // StudyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nextTermButton);
            this.Controls.Add(this.termAnswerLabel);
            this.Controls.Add(this.submitAnswerButton);
            this.Controls.Add(this.termAnswerTextbox);
            this.Controls.Add(this.termTitleLabel);
            this.Name = "StudyPanel";
            this.Size = new System.Drawing.Size(609, 464);
            this.Load += new System.EventHandler(this.StudyPanel_Load);
            this.Resize += new System.EventHandler(this.StudyPanel_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label termTitleLabel;
        private CustomizedTextBox termAnswerTextbox;
        private System.Windows.Forms.Button submitAnswerButton;
        private System.Windows.Forms.Label termAnswerLabel;
        private System.Windows.Forms.Button nextTermButton;
    }
}
