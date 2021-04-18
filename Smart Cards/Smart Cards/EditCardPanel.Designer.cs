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
			this.deleteTermButton.Location = new System.Drawing.Point(604, 50);
			this.deleteTermButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.deleteTermButton.MinimumSize = new System.Drawing.Size(117, 59);
			this.deleteTermButton.Name = "deleteTermButton";
			this.deleteTermButton.Size = new System.Drawing.Size(117, 79);
			this.deleteTermButton.TabIndex = 18;
			this.deleteTermButton.Text = "Delete";
			this.deleteTermButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.deleteTermButton.UseVisualStyleBackColor = false;
			this.deleteTermButton.Click += new System.EventHandler(this.deleteTermButton_Click_1);
			// 
			// CardOutline
			// 
			this.CardOutline.Controls.Add(this.deleteTermButton);
			this.CardOutline.Controls.Add(this.AnswerMarker);
			this.CardOutline.Controls.Add(this.QuestionMarker);
			this.CardOutline.Controls.Add(this.QuestionTextbox);
			this.CardOutline.Controls.Add(this.AnswerTextbox);
			this.CardOutline.Location = new System.Drawing.Point(4, 1);
			this.CardOutline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CardOutline.Name = "CardOutline";
			this.CardOutline.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CardOutline.Size = new System.Drawing.Size(737, 162);
			this.CardOutline.TabIndex = 19;
			this.CardOutline.TabStop = false;
			// 
			// AnswerMarker
			// 
			this.AnswerMarker.AutoSize = true;
			this.AnswerMarker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AnswerMarker.Location = new System.Drawing.Point(9, 110);
			this.AnswerMarker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.AnswerMarker.Name = "AnswerMarker";
			this.AnswerMarker.Size = new System.Drawing.Size(22, 19);
			this.AnswerMarker.TabIndex = 19;
			this.AnswerMarker.Text = "A";
			// 
			// QuestionMarker
			// 
			this.QuestionMarker.AutoSize = true;
			this.QuestionMarker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.QuestionMarker.Location = new System.Drawing.Point(9, 43);
			this.QuestionMarker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.QuestionMarker.Name = "QuestionMarker";
			this.QuestionMarker.Size = new System.Drawing.Size(23, 19);
			this.QuestionMarker.TabIndex = 18;
			this.QuestionMarker.Text = "Q";
			// 
			// QuestionTextbox
			// 
			this.QuestionTextbox.BackColor = System.Drawing.Color.Transparent;
			this.QuestionTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
			this.QuestionTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.QuestionTextbox.ForeColor = System.Drawing.Color.Transparent;
			this.QuestionTextbox.Location = new System.Drawing.Point(40, 25);
			this.QuestionTextbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.QuestionTextbox.MinimumSize = new System.Drawing.Size(235, 59);
			this.QuestionTextbox.Name = "QuestionTextbox";
			this.QuestionTextbox.Padding = new System.Windows.Forms.Padding(7, 9, 7, 6);
			this.QuestionTextbox.Size = new System.Drawing.Size(555, 59);
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
			this.AnswerTextbox.Location = new System.Drawing.Point(40, 91);
			this.AnswerTextbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.AnswerTextbox.MinimumSize = new System.Drawing.Size(403, 59);
			this.AnswerTextbox.Name = "AnswerTextbox";
			this.AnswerTextbox.Padding = new System.Windows.Forms.Padding(7, 9, 7, 6);
			this.AnswerTextbox.Size = new System.Drawing.Size(555, 59);
			this.AnswerTextbox.TabIndex = 17;
			this.AnswerTextbox.TogglesBorder = true;
			this.AnswerTextbox.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.AnswerTextbox.WatermarkText = "Enter the answer here";
			// 
			// EditCardPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.CardOutline);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "EditCardPanel";
			this.Size = new System.Drawing.Size(744, 171);
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
