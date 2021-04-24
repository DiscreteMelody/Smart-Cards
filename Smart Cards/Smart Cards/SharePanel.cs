using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Cards {
	/*
	 * Author: LM
	 * Panel that allows for the control of all the deck sharing functionality, exporting and importing decks from external files
	 */
	public partial class SharePanel : UserControl {
		private Dictionary<int, string> Decks = new Dictionary<int, string>();
		public SharePanel() {
			InitializeComponent();
		}

		/*
		 * Gets a dictionary containing the id and name of every deck currently in storage and uses them to set the elements of the CheckedListBox
		 * CheckedListBox will use the deck name for the display while the actual value of the list item is the deck id
		 */
		public void SetDeckList() {
			Decks = DeckManager.getDeckNames();
			checkedListBox1.Items.Clear();
			foreach (KeyValuePair<int, string> kvp in Decks.OrderBy(pair => pair.Value)) {
				checkedListBox1.Items.Add(new ListItem { DisplayValue = kvp.Value, RealValue = kvp.Key });
			}
			checkedListBox1.DisplayMember = "DisplayValue";
			checkedListBox1.ValueMember = "RealValue";
		}

		/*
		 * When the export button is clicked, get a list of ints representing the ids of the decks selected from the list
		 * Pass that list to DeckManager.ShareDecks method then clear then uncheck all the items in the list
		 */
		private void exportBtn_Click(object sender, EventArgs e) {
			List<int> ids = new List<int>();
			if (checkedListBox1.CheckedItems.Count>0) {
				foreach (ListItem li in checkedListBox1.CheckedItems) {
					ids.Add(li.RealValue);
				}

				DeckManager.ShareDecks(ids);
				checkedListBox1.ClearSelected();
			}
		}

		/*
		 * Call the DeckManager.ImportDecks method when the import button is clicked
		 */
		private void importBtn_Click(object sender, EventArgs e) {
			DeckManager.ImportDecks();
		}
	}

	/*
	 * Simple class to represent list items
	 * populated by the Name and id of an existing deck to make a more user-friendly selectable list of decks
	 */
	public class ListItem {
		public string DisplayValue { get; set; }
		public int RealValue { get; set; }
	}
}
