using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImagineLib;

namespace Imagination
{
    public partial class Form1 : Form
    {
        public List<ImageSet> SetImages = new List<ImageSet>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "";
            DialogResult r=FolderSelect.ShowDialog();
            switch (r)
            {
                case DialogResult.Abort:
                case DialogResult.Cancel:
                    Console.WriteLine("Load set aborted.");
                    return;
                    break;
                case DialogResult.OK:
                    Console.WriteLine("Set selected:" + FolderSelect.SelectedPath);
                    break;
            }
            
            ImageSet set = new ImageSet(FolderSelect.SelectedPath);
            SetImages.Add(set);
        }
    }
}
