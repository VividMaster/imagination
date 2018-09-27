using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuronDotNet.Core;
using NeuronDotNet.Core.Backpropagation;
namespace ImagineLib
{

    public class Imagine
    {
        private BackpropagationNetwork net;
        private double[] errorList;
        private int cycles = 5000;
        private int neuronCount = 8;
        private double learningRate = 0.12d;
        public List<Image> InImgs = new List<Image>();
        public List<Image> OutImgs = new List<Image>();
        LinearLayer iLay;
        SigmoidLayer hLay;
        SigmoidLayer oLay;
        public int Inputs;
        public int W, H;
        public BackpropagationConnector c1, c2;
        public Imagine(int w, int h)
        {
            W = w;
            H = h;
            Inputs = W * H * 3;
            iLay = new LinearLayer(Inputs);
            hLay = new SigmoidLayer(neuronCount);
            oLay = new SigmoidLayer(w * h * 3);
            c1 = new BackpropagationConnector(iLay, hLay,ConnectionMode.Complete);
            c2 = new BackpropagationConnector(hLay, oLay,ConnectionMode.Complete);
            net = new BackpropagationNetwork(iLay, oLay);
            net.SetLearningRate(learningRate);
            


        }
        public void Train(int cpi,int cs=5, int seed = -1)
        {
            if (seed == -1)
            {
                seed = Environment.TickCount;

            }
            Random r = new Random(seed);
            int ai = 0;
            TrainingSet ts = new TrainingSet(Inputs, W * H * 3);
            foreach (var i in InImgs)
            {

                double[] iv = new double[Inputs];
                double[] ov = new double[W * H * 3];
               
                int ic = 0;
                for(int y =0; y < i.H; y++)
                {
                    for(int x = 0; x < i.W; x++)
                    {

                        iv[ic] = GV(i.Dat[ic++]);
                        iv[ic] = GV(i.Dat[ic++]);
                        iv[ic] = GV(i.Dat[ic++]);
                    }
                }
                Image oi = OutImgs[ai];
                int vv = 0;
                for (int y = 0; y < i.H; y++)
                {
                    for (int x = 0; x < i.W; x++)
                    {
                        //int l = (i.H * y * 3) + (x * 3);
                        ov[vv] = GV(i.Dat[vv++]);
                        ov[vv] = GV(i.Dat[vv++]);
                        ov[vv] = GV(i.Dat[vv++]);
                    }
                }

                ai++;

                TrainingSample s = new TrainingSample(iv, ov);
                for(int xc=0;xc<cpi;xc++)
                {
                    ts.Add(s);
                }
            }
            Ready = false;
            //for(int t = 0; t < cs; t++)
            //{
            //            net.BeginEpochEvent += TrainE;
            net.EndEpochEvent += EndE;

            net.Learn(ts, cs);
            net.StopLearning();
            Console.WriteLine("Done training mind.");    
            
        }
        public bool Ready = false;
        public Image ImagineImage(Image from)
        {

            int il = 0;
            //Random r = new Random(seed);
            double[] iv = new double[from.W * from.H * 3];
            for (int y = 0; y < from.H; y++)
            {
                for(int x = 0; x < from.W; x++)
                {
                    iv[il] = GV(from.Dat[il++]);
                    iv[il] = GV(from.Dat[il++]);
                    iv[il] = GV(from.Dat[il++]);
                    
                }
            }
            Image ni = new Image(W, H);
            double[] ov = net.Run(iv);
            for (int y = 0; y < H; y++)
            {
                for (int x = 0; x < W; x++)
                {
                    int l = (y * W * 3) + (x * 3);
                    // ni.Dat[l] = tb(ov[l]);
                    //ni.Dat[l+1] = tb(ov[l+1]));
                 //   ni.Dat[l] = TB(ov[l]);
                //    ni.Dat[l + 1] = TB(ov[l + 1]);
               //     ni.Dat[l + 2] = TB(ov[l + 2]);
                    System.Drawing.Color col = System.Drawing.Color.FromArgb(255, TB(ov[l]), TB(ov[l + 1]), TB(ov[l + 2]));
                        ni.BP.SetPixel(x, y, col);
                }
            }
            return ni;
        }
        public byte TB(double v)
        {
            return (byte)(v * 255.0d);
        }
        //public double td()

        private void EndE(object sender, TrainingEpochEventArgs e)
        {
            Console.WriteLine("Trained:" + e.TrainingIteration + " Err:" + net.MeanSquaredError);
            //throw new NotImplementedException();
        }

        private void TrainE(object sender, TrainingSampleEventArgs e)
        {
           // Console.WriteLine("Training:" + e.TrainingIteration);
            //Console.WriteLine("Err:" + net.MeanSquaredError);
        }

        public double GV(byte v)
        {
            return ((double)v) / 255.0d;
        }
    }
}
