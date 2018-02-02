using System;
using System.Drawing;
using System.Net.Mime;
using System.Security.Policy;


namespace TinyPhotoshop
{
    public static class Geometry
    {      
        public static Image Resize(Bitmap img, int x, int y)
        {
			//FIXME
			throw new NotImplementedException();
        }
        
        public static Image Shift(Bitmap img, int x, int y)
        {
	        
	        int xmax = img.Width;
	        int ymax = img.Height;
	        Bitmap img2 = new Bitmap(xmax, ymax);
	        for (int j = 0; j < ymax; j++)
	        {
		        for (int i = 0; i < xmax; i++)
		        {
			        img2.SetPixel(((i + x) % xmax + xmax) % xmax,((j + y) % ymax + ymax) % ymax,(img.GetPixel(i,j)));
		        }
	        }

	        return img2;
        }

        public static Image SymmetryHorizontal(Bitmap img)
        {
	        int xmax = img.Width;
	        int ymax = img.Height;
	        Bitmap img2 = new Bitmap(xmax, ymax);
	        for (int j = 0; j < ymax; j++)
	        {
		        for (int i = 0; i < xmax; i++)
		        {
			        img2.SetPixel(i,(ymax -1 - j),(img.GetPixel(i,j)));
		        }
	        }

	        return img2;
		}
	    
        public static Image SymmetryVertical(Bitmap img)
        {
	        int xmax = img.Width;
	        int ymax = img.Height;
	        Bitmap img2 = new Bitmap(xmax, ymax);
	        for (int j = 0; j < ymax; j++)
	        {
		        for (int i = 0; i < xmax; i++)
		        {
			        img2.SetPixel((xmax - 1 -i),j,(img.GetPixel(i,j)));
		        }
	        }

	        return img2;
		}
        
        public static Image SymmetryPoint(Bitmap img, int x, int y)
        {
	        int xmax = img.Width;
	        int ymax = img.Height;
	        Bitmap img2 = new Bitmap(xmax, ymax);
	        for (int j = 0; j < ymax; j++)
	        {
		        for (int i = 0; i < xmax; i++)
		        {
			        
		        }
	        }

	        return img2;
		}
        
        public static Image RotationLeft(Bitmap img)
        {
			//FIXME
			throw new NotImplementedException();
		}
        
        public static Image RotationRight(Bitmap img)
        {
			//FIXME
			throw new NotImplementedException();
		}
    }
}