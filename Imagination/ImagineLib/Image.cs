using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
namespace ImagineLib
{
    public class Image
    {
        public byte[] Dat = null;
        public string Name = "";
        public int W, H;
        public string FullPath = "";
        public Bitmap BP = null;
        public Image(int w,int h)
        {
            W = w;
            H = h;
            Dat = new Byte[W * H * 3];
            BP = new Bitmap(w, h);
            
        }
        public Image(string p,int cw=-1,int ch=-1)
        {
            FullPath = p;
            Name = new FileInfo(p).Name;
            Bitmap b = new Bitmap(p);
           
            if(cw!=-1)
            {
                b = new Bitmap(b, cw, ch);
            }
            BP = b;
            int l = 0;
            Dat = new byte[b.Height * b.Width * 3];
            for(int y = 0; y < b.Height; y++)
            {
                for(int x=0;x<b.Width;x++)
                {
                    var pix = b.GetPixel(x, y);
                    Dat[l++] = pix.R;
                    Dat[l++] = pix.G;
                    Dat[l++] = pix.B;
                }
            }
            W = b.Width;
            H = b.Height;
        }
    }
}
