using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ImagineLib
{
    public class ImageSet
    {
        public List<Image> Imgs = new List<Image>();
        public string Name = "";
        public ImageSet(string path,int cw=-1,int ch=-1)
        {
            Name = new DirectoryInfo(path).Name;
            Console.WriteLine("Reading Folder:" + Name);
            DirectoryInfo f = new DirectoryInfo(path);
            foreach(var fi in f.GetFiles())
            {
                Console.WriteLine("File:" + fi.Name);
                Console.WriteLine("Ext:" + fi.Extension);
                switch (fi.Extension)
                {
                    case ".jpg":
                    case ".bmp":
                    case ".png":
                    case ".tga":
                        Imgs.Add(new Image(fi.FullName,cw,ch));
                        Console.WriteLine("Loaded:" + fi.Name + " W:" + Imgs[Imgs.Count - 1].W + " H:" + Imgs[Imgs.Count - 1].H);
                        break;
                    default:
                        Console.WriteLine("Ignored:" + fi.Name);
                        break;
                }
            }
        }
    }
}
