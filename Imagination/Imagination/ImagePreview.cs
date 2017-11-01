using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imagination
{
    public partial class ImagePreview : UserControl
    {
        public Bitmap Img = null;
        public ImagePreview()
        {
            InitializeComponent();
        }

        private void ImagePreview_Paint(object sender, PaintEventArgs e)
        {
            if(Img == null)
            {
                e.Graphics.DrawString("No Image to render.", DefaultFont, Brushes.Black, 5, 5);

            }
            else
            {
                e.Graphics.DrawImage(Img, new Rectangle(0, 0, Width, Height));
            }
        }
    }
}
