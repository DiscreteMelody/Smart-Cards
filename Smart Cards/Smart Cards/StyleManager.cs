﻿using System;
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
        private static Color _primaryColor = new Color();

        public static Color PrimaryColor
        {
            get { return _primaryColor; }
        }
    }
}
