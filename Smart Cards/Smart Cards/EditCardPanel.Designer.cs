namespace Smart_Cards
{
    partial class EditCardPanel
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
            this.deleteTermButton = new System.Windows.Forms.Button();
            this.CardOutline = new System.Windows.Forms.GroupBox();
            this.AnswerMarker = new System.Windows.Forms.Label();
            this.QuestionMarker = new System.Windows.Forms.Label();
            this.QuestionTextbox = new Smart_Cards.CustomizedTextBox();
            this.AnswerTextbox = new Smart_Cards.CustomizedTextBox();
            this.CardOutline.SuspendLayout();
            this.SuspendLayout();
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
            this.deleteTermButton.Location = new System.Drawing.Point(455, 40);
            this.deleteTermButton.MinimumSize = new System.Drawing.Size(88, 48);
            this.deleteTermButton.Name = "deleteTermButton";
            this.deleteTermButton.Size = new System.Drawing.Size(88, 64);
            this.deleteTermButton.TabIndex = 18;
            this.deleteTermButton.Text = "Delete";
            this.deleteTermButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteTermButton.UseVisualStyleBackColor = false;
            this.deleteTermButton.Click += new System.EventHandler(this.deleteTermButton_Click_1);
            // 
            // CardOutline
            // 
            this.CardOutline.Controls.Add(this.AnswerMarker);
            this.CardOutline.Controls.Add(this.QuestionMarker);
            this.CardOutline.Controls.Add(this.QuestionTextbox);
            this.CardOutline.Controls.Add(this.AnswerTextbox);
            this.CardOutline.Location = new System.Drawing.Point(3, 1);
            this.CardOutline.Name = "CardOutline";
            this.CardOutline.Size = new System.Drawing.Size(553, 132);
            this.CardOutline.TabIndex = 19;
            this.CardOutline.TabStop = false;
            // 
            // AnswerMarker
            // 
            this.AnswerMarker.AutoSize = true;
            this.AnswerMarker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerMarker.Location = new System.Drawing.Point(7, 89);
            this.AnswerMarker.Name = "AnswerMarker";
            this.AnswerMarker.Size = new System.Drawing.Size(18, 16);
            this.AnswerMarker.TabIndex = 19;
            this.AnswerMarker.Text = "A";
            // 
            // QuestionMarker
            // 
            this.QuestionMarker.AutoSize = true;
            this.QuestionMarker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionMarker.Location = new System.Drawing.Point(7, 35);
            this.QuestionMarker.Name = "QuestionMarker";
            this.QuestionMarker.Size = new System.Drawing.Size(19, 16);
            this.QuestionMarker.TabIndex = 18;
            this.QuestionMarker.Text = "Q";
            // 
            // QuestionTextbox
            // 
            this.QuestionTextbox.BackColor = System.Drawing.Color.Transparent;
            this.QuestionTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.QuestionTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuestionTextbox.ForeColor = System.Drawing.Color.Transparent;
            this.QuestionTextbox.Location = new System.Drawing.Point(30, 20);
            this.QuestionTextbox.MinimumSize = new System.Drawing.Size(176, 48);
            this.QuestionTextbox.Name = "QuestionTextbox";
            this.QuestionTextbox.Padding = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.QuestionTextbox.Size = new System.Drawing.Size(416, 48);
            this.QuestionTextbox.TabIndex = 16;
            this.QuestionTextbox.TogglesBorder = true;
            this.QuestionTextbox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.QuestionTextbox.WatermarkText = "Enter a term/question";
            // 
            // AnswerTextbox
            // 
            this.AnswerTextbox.BackColor = System.Drawing.Color.Transparent;
            this.AnswerTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.AnswerTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AnswerTextbox.ForeColor = System.Drawing.Color.Transparent;
            this.AnswerTextbox.Location = new System.Drawing.Point(30, 74);
            this.AnswerTextbox.MinimumSize = new System.Drawing.Size(302, 48);
            this.AnswerTextbox.Name = "AnswerTextbox";
            this.AnswerTextbox.Padding = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.AnswerTextbox.Size = new System.Drawing.Size(416, 48);
            this.AnswerTextbox.TabIndex = 17;
            this.AnswerTextbox.TogglesBorder = true;
            this.AnswerTextbox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AnswerTextbox.WatermarkText = "Enter the answer here";
            // 
            // EditCardPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteTermButton);
            this.Controls.Add(this.CardOutline);
            this.Name = "EditCardPanel";
            this.Size = new System.Drawing.Size(558, 139);
            this.CardOutline.ResumeLayout(false);
            this.CardOutline.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomizedTextBox QuestionTextbox;
        private System.Windows.Forms.Button deleteTermButton;
        private CustomizedTextBox AnswerTextbox;
        private System.Windows.Forms.GroupBox CardOutline;
        private System.Windows.Forms.Label QuestionMarker;
        private System.Windows.Forms.Label AnswerMarker;
    }
}
