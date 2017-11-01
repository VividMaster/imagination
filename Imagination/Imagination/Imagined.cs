using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imagination
{
    public partial class Imagined : Form
    {
        public ImagePreview IP = null;
        public Imagined()
        {
            InitializeComponent();
            IP = new ImagePreview();
            Controls.Add(IP);
            IP.Dock = DockStyle.Fill;
        }
    }
}
