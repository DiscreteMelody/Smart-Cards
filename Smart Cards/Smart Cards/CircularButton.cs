using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Cards
{
    //a round shaped button that inherits the same functionality from the built in Button class - LS
    public class CircularButton : Button
    {
        private Color borderColor;
        private int borderRadius;
        private SolidBrush brush;
        private Pen pen;

        //code to make fields visible in the designer - LS
        [Description("The color of the round border"), Category("Data")]
        public Color BorderColor
        {
            get { return this.borderColor; }
            set { this.borderColor = value; }
        }
        [Description("The radius of the button's border"), Category("Data")]
        public int BorderRadius
        {
            get { return this.borderRadius; }
            set { this.borderRadius = value; }
        }
        public Pen Pen
        {
            get { return this.pen; }
        }

        //draw the border around the button - LS
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);

            Pen borderPen = new Pen(Color.Black, borderRadius);
            Rectangle location = new Rectangle(this.PointToScreen(Point.Empty), new Size(this.Width, this.Height));

            // Draw circular border around the button
            e.Graphics.DrawEllipse(borderPen, location);
        }

        //project generated code
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
