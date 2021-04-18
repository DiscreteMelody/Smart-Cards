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
	public partial class SharePanel : UserControl {
		private Dictionary<int, string> Decks = new Dictionary<int, string>();
		private List<ListItem> checkedItems = new List<ListItem>();
		private List<int> ids = new List<int>();
		public SharePanel() {
			InitializeComponent();
		}

		public void SetDeckList() {
			Decks = DeckManager.getDeckNames();
			checkedListBox1.Items.Clear();
			foreach (KeyValuePair<int, string> kvp in Decks.OrderBy(pair => pair.Value)) {
				checkedListBox1.Items.Add(new ListItem { DisplayValue = kvp.Value, RealValue = kvp.Key });
			}
			checkedListBox1.DisplayMember = "DisplayValue";
			checkedListBox1.ValueMember = "RealValue";
		}

		private void button1_Click(object sender, EventArgs e) {
			if (checkedListBox1.CheckedItems.Count>0) {
				foreach (ListItem li in checkedListBox1.CheckedItems) {
					ids.Add(li.RealValue);
				}

				DeckManager.ShareDecks(ids);
				checkedListBox1.ClearSelected();
			}
		}

		private void button2_Click(object sender, EventArgs e) {
			DeckManager.ImportDecks();
		}
	}

	public class ListItem {
		public string DisplayValue { get; set; }
		public int RealValue { get; set; }
	}
}
