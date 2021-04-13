using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Cards
{
    public partial class DeckListPanel : UserControl
    {
        private Button clearBtn;
        public DeckListPanel()
        {
            InitializeComponent();
        }

        //takes deck panels that DeckManager creates from its DeckList
        //and adds the controls into the flow layout
        public void LoadDeckPanels()
        {
            DeckListFlowLayoutPanel.Controls.Clear();
            foreach (DeckPanel dp in DeckManager.CreateDeckPanels())
            {
                DeckListFlowLayoutPanel.Controls.Add(dp);
            }
        }

        public void LoadDeckPanels(string str) {
            DeckListFlowLayoutPanel.Controls.Clear();
            foreach (DeckPanel dp in DeckManager.CreateDeckPanels(str)) {
                DeckListFlowLayoutPanel.Controls.Add(dp);
            }
        }

        public void ResetSearch() {
            textBox1.ForeColor = Color.Gray;
            textBox1.Font = new Font(this.Font.FontFamily, 14, FontStyle.Italic);
            textBox1.Text = "Start typing a name to search for decks";
        }

		private void textBox1_Enter(object sender, EventArgs e) {
            if (textBox1.Text == "Start typing a name to search for decks") {
                textBox1.ForeColor = SystemColors.ControlText;
                textBox1.Font = new Font(this.Font.FontFamily, 14, FontStyle.Regular);
                textBox1.Text = "";
			}
		}

		private void textBox1_Leave(object sender, EventArgs e) {
            if (textBox1.Text == "") {
                textBox1.ForeColor = Color.Gray;
                textBox1.Font = new Font(this.Font.FontFamily, 14, FontStyle.Italic);
                textBox1.Text = "Start typing a name to search for decks";
            }
        }

		private void DeckListPanel_Click(object sender, EventArgs e) {
            this.ActiveControl = null;
        }

		private void tableLayoutPanel1_Click(object sender, EventArgs e) {
            this.ActiveControl = null;
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {
            if (textBox1.Text.Length>0 && textBox1.Text != "Start typing a name to search for decks") {
                clearBtn.Visible = true;
                LoadDeckPanels(textBox1.Text.ToLower());
			} else {
                clearBtn.Visible = false;
                LoadDeckPanels();
			}
		}

		private void DeckListPanel_Load(object sender, EventArgs e) {
            clearBtn = new Button();
            clearBtn.Size = new Size(32, 32);
            clearBtn.Location = new Point(textBox1.ClientSize.Width - clearBtn.Width, -1);
            clearBtn.Cursor = Cursors.Default;
            clearBtn.Image = Properties.Resources.clear_search_icon;
            clearBtn.Name = "clearBtn";
            clearBtn.Visible = false;
            clearBtn.Click += new EventHandler(clearBtn_Click);
            textBox1.Controls.Add(clearBtn);
        }

        private void clearBtn_Click(object sender, EventArgs e) {
            textBox1.Enabled = false;
            this.ActiveControl = null;
            this.Focus();
            this.ResetSearch();
            this.LoadDeckPanels();
            textBox1.Enabled = true;
        }

    }
}
