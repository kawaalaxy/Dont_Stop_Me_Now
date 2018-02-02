using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace TinyPhotoshop
{
    public static class Basics
    {
        public static Color Grey(Color color)
        {
	        Int32 c = (color.R + color.G + color.B)/3;
	        return (Color.FromArgb(c, c, c));
		}

        public static Color Binarize(Color color)
        {
			Int32 c = (color.R + color.G + color.B)/3;
	        if (c > 127)
		        c = 255;
	        else
		        c = 000;
	        return Color.FromArgb(c,c,c);
        }
        
        public static Color BinarizeColor(Color color)
        {
	        int r,g,b = 0;
	        if (color.R > 127)
		        r = 255;
	        else
		        r = 000;
	        if (color.G > 127)
		        g = 255;
	        else
		        g = 000;
	        if (color.B > 127)
		        b = 255;
	        else
		        b = 000;
	        return Color.FromArgb(r, g, b);
        }
        
        public static Color Negative(Color color)
        {
	        return Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
        }
        
        public static Color Tinter(Color color, Color tint, int factor)
        {
			//FIXME
			throw new NotImplementedException();
		}

        public static Image Apply(Bitmap img, Func<Color, Color> func)
        {
	        int xmax = img.Width;
	        int ymax = img.Height;
	        for (int j = 0; j < ymax; j++)
	        {
		        for (int i = 0; i < xmax; i++)
		        {
			        img.SetPixel(i,j,func(img.GetPixel(i,j)));
		        }
	        }

	        return img;
        }
    }
}