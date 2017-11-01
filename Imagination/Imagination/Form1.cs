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
using System.IO;
namespace Imagination
{
    public partial class Form1 : Form
    {
        public List<ImageSet> SetImages = new List<ImageSet>();
        public string LastPath = "";
        public ImagePreview IP = null;
        public int IW, IH;
        public Form1()
        {
            InitializeComponent();
            IP = new ImagePreview();
            IP.Dock = DockStyle.Fill;
            ImgS.Panel1.Controls.Add(IP);
            IW = 56;
            IH = 56;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (new FileInfo("lastPath.txt").Exists)
            {
                LoadPath();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "";
            FolderSelect.SelectedPath = LastPath;
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
            LastPath = FolderSelect.SelectedPath;
            SavePath();
            ImageSet set = new ImageSet(FolderSelect.SelectedPath, IW, IH);
            SetImages.Add(set);
            RebuildUI();
        }
        public void RebuildUI()
        {
            INodes.Clear();
            IPath.Clear();
            SetView.Nodes[0].Nodes.Clear();
            foreach(var s in SetImages)
            {
                SetView.Nodes[0].Nodes.Add(s.Name + "[" + s.Imgs.Count + "]");
                foreach (var i in s.Imgs)
                {
                    var nn = SetView.Nodes[0].Nodes[SetView.Nodes[0].Nodes.Count - 1].Nodes.Add("F:" + i.Name);
                    INodes.Add(nn);
                    IPath.Add(nn, i);
                }
            }
        }
        public Dictionary<TreeNode, ImagineLib.Image> IPath = new Dictionary<TreeNode, ImagineLib.Image>();
        public void SavePath()
        {
            FileStream fs = new FileStream("lastPath.txt", FileMode.Create, FileAccess.Write);
            BinaryWriter w = new BinaryWriter(fs);
            w.Write(LastPath);
            w.Flush();
            w.Close();
          

        }
        public List<TreeNode> INodes = new List<TreeNode>();
        public void LoadPath()
        {
            FileStream fs = new FileStream("lastPath.txt", FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);
            LastPath = r.ReadString();
            r.Close();
        }

        private void SetView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var an = e.Node;
            ImagineLib.Image img = null;
            if (IPath.ContainsKey(an))
            {
                img = IPath[an];

                Console.WriteLine("Node:" + an.Name + " Image:" + img.FullPath);
            }
            else
            {
                Console.WriteLine("No match in records.");
                return;
            }
            Console.WriteLine("SetImage:" + img.BP.Width + " H:" + img.BP.Height);
            IP.Img = img.BP;
            IP.Invalidate();
            IP.Update();
        }
        public Imagine IE = null;
        public int LInputs = 4;
        private void button2_Click(object sender, EventArgs e)
        {
            IE = new Imagine(IW, IH, 4);
            foreach(var ik in IPath.Keys)
            {
                var i = IPath[ik];
                IE.Imgs.Add(i);
            }
            Console.WriteLine("Training:" + IE.Imgs.Count + " Images.");
            IE.Train(100, 3, Environment.TickCount);
            Console.WriteLine("Trained.");
        }
        public Imagined ImgO = null;
        public int iseed = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (IE == null)
            {
                Console.WriteLine("No mind trained.");
                return;
            }
            if(ImgO!=null)
            {
                ImgO.Close();
                ImgO = null;
            }
            ImgO = new Imagined();
            ImgO.Show();

            iseed = Environment.TickCount;
                    Console.WriteLine("Imagining image.");
                    ImgO.IP.Img = IE.ImagineImage(iseed).BP;
                    Console.WriteLine("Imagined image.");

            ImgO.IP.Invalidate();
            ImgO.IP.Update();
            ImgO.Invalidate();
            ImgO.Update();
        }
    }
}
