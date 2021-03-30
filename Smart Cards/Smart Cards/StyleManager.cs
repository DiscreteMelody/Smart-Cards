using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Cards
{
    public static class StyleManager
    {
        public static Color primaryColor = Color.FromArgb(0, 0, 0);
        public static Color highlightColor = Color.FromArgb(92, 214, 255);
        public static Color lightTextColor = Color.FromArgb(0, 0, 0);
        public static Color darkTextColor = Color.FromArgb(255, 255, 255);
        public static Color pressedDownColor = Color.FromArgb(3, 169, 244);

        public static Cursor buttonHoverCursor = Cursors.Hand;

    }
}
