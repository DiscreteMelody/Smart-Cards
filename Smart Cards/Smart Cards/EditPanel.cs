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
    public partial class EditPanel : UserControl
    {
        //parrallel lists to store the added and deleted UI controls
        private List<CustomizedTextBox> termTextboxes;
        private List<CustomizedTextBox> termAnswerTextboxes;
        private List<Button> deleteTermButtons;

        public EditPanel()
        {
            InitializeComponent();
        }

        //use this to run necessary code when the EditPanel is opened
        private void EditPanel_Load(object sender, EventArgs e)
        {
            termTextboxes = new List<CustomizedTextBox>() { termTextbox };
            termAnswerTextboxes = new List<CustomizedTextBox>() { termAnswerTextbox };
            deleteTermButtons = new List<Button>() { deleteTermButton };
            deleteTermButton.Click += new EventHandler(OnDeleteButtonClicked);
            deleteTermButton.Enabled = false;
        }

        /// <summary>
        /// Executes whenever a delete button is pressed on the EditPanel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            //remove the chosen delete button, answertextbox, and termtextbox from the EditPanel
            for(int i = 0; i < deleteTermButtons.Count; i++)
            {
                if(deleteTermButtons[i] == sender)
                {
                    deleteTermButtons[i].Dispose();
                    termTextboxes[i].Dispose();
                    termAnswerTextboxes[i].Dispose();

                    deleteTermButtons.RemoveAt(i);
                    termTextboxes.RemoveAt(i);
                    termAnswerTextboxes.RemoveAt(i);
                    break;
                }
            }

            //if there is only 1 term left in the list, disable its delete button
            if(deleteTermButtons.Count == 1)
            {
                deleteTermButtons[0].Enabled = false;
            }
        }

        private void addTermButton_Click(object sender, EventArgs e)
        {
            //reenable the first term's delete button if disabled
            deleteTermButtons[0].Enabled = true;

            //add 3 new controls to the editPanel - 2 textboxes and a delete button
            CustomizedTextBox newTermTextbox = termTextboxes[0].Clone();
            CustomizedTextBox newTermAnswerTextbox = termAnswerTextboxes[0].Clone();
            Button newDeleteButton = deleteTermButtons[0].Clone();

            //give click functionality to the new Delete button
            newDeleteButton.Click += new EventHandler(OnDeleteButtonClicked);

            //add the newly created controls to the parrallel lists
            deleteTermButtons.Add(newDeleteButton);
            termTextboxes.Add(newTermTextbox);
            termAnswerTextboxes.Add(newTermAnswerTextbox);
            

            //add the controls to the UI
            termFlowLayoutPanel.Controls.Add(newTermTextbox);
            termFlowLayoutPanel.Controls.Add(newTermAnswerTextbox);
            termFlowLayoutPanel.Controls.Add(newDeleteButton);
        }

        private void saveDeckButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Save the user's deck.");
        }

        private void deleteDeckButton_Click(object sender, EventArgs e)
        {
            //create a yes/no dialog box
            var confirmResult = MessageBox.Show("Really delete the deck?", "Deck deletion", MessageBoxButtons.YesNo);

            //if the user answers yes
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("TODO: delete the user's deck.");
            }
        }
    }
}
