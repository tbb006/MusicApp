using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MusicApp
{
    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }

        public static List<string> ColorList = new List<string>
        {
            "#1E88E5",
            "#FD8153",
            "#7CB342",
            "#AB5DB2",
            "#273248",
            "#EA9E25",
            "#AF4F41",
            "#005DA9",
            "#C72C41",
            "#276221",
            "#FC7643",
        };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            if(correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
    
        }

    }

}
