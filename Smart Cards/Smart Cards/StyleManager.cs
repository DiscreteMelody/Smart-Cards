using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Cards
{
    //this static class is meant to be referenced by controls for styling purposes
    //it is meant to make restyling simple by editing this file - LS
    public static class StyleManager
    {
        public static Color primaryColor = Color.FromArgb(0, 191, 255);
        public static Color secondaryColor = Color.FromArgb(3, 169, 244);
        public static Color highlightColor = Color.FromArgb(92, 214, 255);
        public static Color lightTextColor = Color.FromArgb(0, 0, 0);
        public static Color darkTextColor = Color.FromArgb(255, 255, 255);
        public static Color watermarkTextColor = Color.FromArgb(128, 128, 128);

        public static Cursor buttonHoverCursor = Cursors.Hand;

        /// <summary>
        /// Clones a control and returns a new instance of an object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="controlToClone">The control to be cloned</param>
        /// <returns></returns>
        // - LS
        public static T Clone<T>(this T controlToClone)
        where T : Control
        {
            PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            T instance = Activator.CreateInstance<T>();

            foreach (PropertyInfo propInfo in controlProperties)
            {
                if (propInfo.CanWrite)
                {
                    if (propInfo.Name != "WindowTarget")
                        propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }

    }
}
