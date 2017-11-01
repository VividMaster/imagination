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
        private int neuronCount = 12;
        private double learningRate = 0.02d;
        public List<Image> Imgs = new List<Image>();
        LinearLayer iLay;
        SigmoidLayer hLay;
        SigmoidLayer oLay;
        public int Inputs;
        public int W, H;
        public BackpropagationConnector c1, c2;
        public Imagine(int w, int h, int inputs = 4)
        {
            W = w;
            H = h;
            Inputs = inputs;
            iLay = new LinearLayer(Inputs);
            hLay = new SigmoidLayer(neuronCount);
            oLay = new SigmoidLayer(w * h * 3);
            c1 = new BackpropagationConnector(iLay, hLay);
            c2 = new BackpropagationConnector(hLay, oLay);
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

            TrainingSet ts = new TrainingSet(Inputs, W * H * 3);
            foreach (var i in Imgs)
            {
                double[] iv = new double[Inputs];
                double[] ov = new double[W * H * 3];
                for (int ic = 0; ic < Inputs; ic+=2)
                {
                    iv[ic] = r.NextDouble();
                    iv[ic + 1] = 1.0d - iv[ic];
                }
                for (int y = 0; y < i.H; y++)
                {
                    for (int x = 0; x < i.W; x++)
                    {
                        int l = (i.H * y * 3) + (x * 3);
                        ov[l] = GV(i.Dat[l++]);
                        ov[l] = GV(i.Dat[l++]);
                        ov[l] = GV(i.Dat[l++]);
                    }
                }
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
        public Image ImagineImage(int seed=-1)
        {
            if(seed==-1)
            {
                seed = Environment.TickCount;
            }
            Random r = new Random(seed);
            double[] iv = new double[Inputs];
            for(int i = 0; i < Inputs; i++)
            {
                iv[i] = r.NextDouble();
                Console.WriteLine("TS:" + i + " V:" + iv[i]);
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
