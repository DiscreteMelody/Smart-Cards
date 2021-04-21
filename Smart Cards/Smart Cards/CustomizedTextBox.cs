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
    //a customized text box with watermark text and a border when the control is in focus - LS
    public partial class CustomizedTextBox : UserControl
    {
        private string watermarkText = "Watermark";
        private Color watermarkColor = StyleManager.watermarkTextColor;
        private Color foreColor = StyleManager.lightTextColor;
        private Color borderColor = StyleManager.primaryColor;
        private bool togglesBorder = true;
        //used when the control is meant to perform an action when enter is clicked - LS
        private Button submitButton;
        private Keys submitKey;

        //code to make the fields visible in the designer - LS
        [Browsable(true)]
        [Description("The Watermark text of the textbox"), Category("Data")]
        public string WatermarkText
        {
            get { return this.watermarkText; }
            set { this.watermarkText = value; }
        }
        [Browsable(true)]
        [Description("The color of the watermark text"), Category("Data")]
        public Color WatermarkColor
        {
            get { return this.watermarkColor; }
            set { this.watermarkColor = value; }
        }
        [Browsable(true)]
        [Description("The color of the border around the textbox"), Category("Data")]
        public Color BorderColor
        {
            get { return this.borderColor; }
            set { this.borderColor = value; }
        }
        [Description("Toggles if the border will switch between transparent and the selected border color upon selection"), Category("Data")]
        public bool TogglesBorder
        {
            get { return this.togglesBorder; }
            set { this.togglesBorder = value; }
        }

        //returns the text of the nested textbox in this custom control - LS
        public string Text
        {
            get { return this.textBox.Text; }
            set
            {
                this.onTextBoxClicked();
                this.textBox.Text = value;
                this.onTextBoxLeave();
            }
        }

        //project generated code - LS
        public CustomizedTextBox()
        {
            InitializeComponent();
            this.foreColor = textBox.ForeColor;
        }

        //when the panel around the textbox is clicked, act as if the textbox itself was clicked - LS
        private void paddingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            textBox.Focus();
            onTextBoxClicked();
        }

        //if the textbox is left blank upon leaving, the text will switch to the watermark - LS
        private void textBox_Leave(object sender, EventArgs e)
        {
            onTextBoxLeave();
        }

        //when the textbox loses focus - LS
        private void onTextBoxLeave()
        {
            if (textBox.Text == "")
            {
                textBox.Text = watermarkText;
                textBox.ForeColor = watermarkColor;
            }
            this.BackColor = Color.Transparent;
        }

        //when the textbox (or padding around it) is clicked - LS
        private void onTextBoxClicked()
        {
            //remove the watermark text if it is visible - LS
            if (textBox.Text == this.watermarkText)
            {
                textBox.Text = "";
                textBox.ForeColor = foreColor;
            }
            //draw the rectangular border if one is to be used - LS
            if (togglesBorder)
            {
                this.BackColor = borderColor;
            }
        }

        //when the textbox of this control becomes the active control (via tab or clicking),
        //act as if the textbox was clicked - LS
        private void textBox_Enter(object sender, EventArgs e)
        {
            onTextBoxClicked();
        }

        //when the padding of this control becomes the active control (via tab or clicking),
        //act as if the textbox was clicked - LS
        private void paddingPanel_Enter(object sender, EventArgs e)
        {
            onTextBoxClicked();
        }

        //when the control is clicked - LS
        private void CustomizedTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            onTextBoxClicked();
        }

        //when the control loads on screen, focus and remove focus from the control - LS
        private void CustomizedTextBox_Load(object sender, EventArgs e)
        {
            onTextBoxClicked();
            onTextBoxLeave();
        }

        /// <summary>
        /// empties the text of the text panel and resets the watermark and border as if it became inactive
        /// </summary>
        public void clearText()
        {
            this.textBox.Text = "";
            this.onTextBoxClicked();
            this.onTextBoxLeave();
        }

        //perform all of the tasks as if the control was clicked - LS
        public void PerformClick()
        {
            clearText();
            onTextBoxLeave();
            onTextBoxClicked();
        }

        /// <summary>
        /// Sets the control to perform a button click when enter is pressed
        /// </summary>
        /// <param name="submit_button">The button to be clicked</param>
        /// <param name="submit_key_press">The key to activate the button press (default is enter)</param>
        // - LS
        public void SetSubmitButton(Button submit_button, Keys submit_key_press = Keys.Enter)
        {
            this.submitButton = submit_button;
            this.submitKey = submit_key_press;

            textBox.KeyDown += new KeyEventHandler(OnKeyPressed);
        }

        //fires whenever a key is pressed - LS
        private void OnKeyPressed(object sender, KeyEventArgs e)
        {
            if (submitButton == null)
                return;

            if(e.KeyCode == submitKey)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                submitButton.PerformClick();
            }
        }
    }
}
