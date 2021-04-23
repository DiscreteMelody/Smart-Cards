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
    /*
     * Class controlling the DeckList screen
     * This screen is the primary interface of the application and is always the first thing the user will see on startup
     */
    public partial class DeckListPanel : UserControl
    {
        private Button clearBtn;
        public DeckListPanel()
        {
            InitializeComponent();
        }

        /*
         * Gets a panel representing each deck in storageDisplays those panels in the FlowPanel
         */
        public void LoadDeckPanels()
        {
            DeckListFlowLayoutPanel.Controls.Clear();
            foreach (DeckPanel dp in DeckManager.CreateDeckPanels())
            {
                DeckListFlowLayoutPanel.Controls.Add(dp);
            }
        }

        /*
         * Author: LM
         * Overload of LoadDeckPanels method that accept a string and passes that string to the overloaded CreateDeckPanels method of the DeckManager class
         * This is one of the foundations of the functionality allowing users to search for Decks by name
         * As the user's search string is built up, the DeckPanels are re-rendered with each update slowly excluding every deck that does not contain the current string in its title
         */
        public void LoadDeckPanels(string str) {
            DeckListFlowLayoutPanel.Controls.Clear();
            foreach (DeckPanel dp in DeckManager.CreateDeckPanels(str)) {
                DeckListFlowLayoutPanel.Controls.Add(dp);
            }
        }

        /*
         * Author: LM
         * Clears the DeckList search bar back to its default placeholder text
         */
        public void ResetSearch() {
            textBox1.ForeColor = Color.Gray;
            textBox1.Font = new Font(this.Font.FontFamily, 14, FontStyle.Italic);
            textBox1.Text = "Start typing a name to search for decks";
        }

        /*
         * Author: LM
         * When the user enters the searchbar textbox, clear the place holder text and change the font to make the input visually distinct from the placeholder
         * Only clear the textbox if the placeholder text is in place at the time of entering
        */
		private void textBox1_Enter(object sender, EventArgs e) {
            if (textBox1.Text == "Start typing a name to search for decks") {
                textBox1.ForeColor = SystemColors.ControlText;
                textBox1.Font = new Font(this.Font.FontFamily, 14, FontStyle.Regular);
                textBox1.Text = "";
			}
		}

	    /*
	     * Author: LM
	     * When the user leaves the textbox, reinstate the placeholder text and formatting if there's no user input currently in place
	     */
		private void textBox1_Leave(object sender, EventArgs e) {
            if (textBox1.Text == "") {
                textBox1.ForeColor = Color.Gray;
                textBox1.Font = new Font(this.Font.FontFamily, 14, FontStyle.Italic);
                textBox1.Text = "Start typing a name to search for decks";
            }
        }

        /*
         * Author: LM
         * Used to assist in getting the search bar to lose focus when the user clicks outside of it
         * Attached to both DeckListPanel and the tableLayout in an attempt to capture as much area as possible
         * Somewhat effective, but not as reliable as I'd like thanks to the limitations of the WinForms framework
         */
		private void DeckListPanel_Click(object sender, EventArgs e) {
            this.ActiveControl = null;
        }

        /*
         * Author: LM
         * Used to assist in getting the search bar to lose focus when the user clicks outside of it
         * Attached to both DeckListPanel and the tableLayout in an attempt to capture as much area as possible
         * Somewhat effective, but not as reliable as I'd like thanks to the limitations of the WinForms framework
         */
        private void tableLayoutPanel1_Click(object sender, EventArgs e) {
            this.ActiveControl = null;
		}

        /*
         * Author: LM
         * The heart of the entire deck search functionality
         * As the user's input changes, the deck list is successivly re-rendered to only show decks with titles containing the current search string
         * If input is empty, hide the clear search button, show it otherwise
         */
		private void textBox1_TextChanged(object sender, EventArgs e) {
            if (textBox1.Text.Length>0 && textBox1.Text != "Start typing a name to search for decks") {
                clearBtn.Visible = true;
                LoadDeckPanels(textBox1.Text.ToLower());
			} else {
                clearBtn.Visible = false;
                LoadDeckPanels();
			}
		}

        /*
         * Author: LM
         * Create the search bar clear button and attach it to the textbox
         */
		private void DeckListPanel_Load(object sender, EventArgs e) {
            clearBtn = new Button() { Size = new Size(32, 32), Cursor = Cursors.Default, Image = Properties.Resources.clear_search_icon, Name = "clearBtn", Visible = false };
            clearBtn.Location = new Point(textBox1.ClientSize.Width - clearBtn.Width, -1);
            clearBtn.Click += new EventHandler(clearBtn_Click);
            textBox1.Controls.Add(clearBtn);
        }

        /*
         * Author: LM
         * Something about this specific combination of commands in this order was finally successful in getting the search bar textbox to give up focus when it is cleared
         * At this point, now that it finally works I'm not going to make any attempts to weed out the unnecessary lines and risk breaking it
         */
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
