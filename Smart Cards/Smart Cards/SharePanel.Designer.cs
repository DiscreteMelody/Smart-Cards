
namespace Smart_Cards {
	partial class SharePanel {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.importBtn = new System.Windows.Forms.Button();
			this.exportBtn = new System.Windows.Forms.Button();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.Controls.Add(this.importBtn, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.exportBtn, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.checkedListBox1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(609, 464);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// importBtn
			// 
			this.importBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.importBtn.Location = new System.Drawing.Point(423, 210);
			this.importBtn.Name = "importBtn";
			this.tableLayoutPanel1.SetRowSpan(this.importBtn, 2);
			this.importBtn.Size = new System.Drawing.Size(126, 43);
			this.importBtn.TabIndex = 1;
			this.importBtn.Text = "Import";
			this.importBtn.UseVisualStyleBackColor = true;
			this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
			// 
			// exportBtn
			// 
			this.exportBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.exportBtn.Location = new System.Drawing.Point(120, 401);
			this.exportBtn.Name = "exportBtn";
			this.exportBtn.Size = new System.Drawing.Size(126, 43);
			this.exportBtn.TabIndex = 0;
			this.exportBtn.Text = "Export";
			this.exportBtn.UseVisualStyleBackColor = true;
			this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new System.Drawing.Point(13, 13);
			this.checkedListBox1.Margin = new System.Windows.Forms.Padding(10);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(340, 359);
			this.checkedListBox1.TabIndex = 2;
			// 
			// SharePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "SharePanel";
			this.Size = new System.Drawing.Size(609, 464);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button exportBtn;
		private System.Windows.Forms.Button importBtn;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
	}
}
