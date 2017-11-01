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
        private BackpropagationNetwork xorNetwork;
        private double[] errorList;
        private int cycles = 5000;
        private int neuronCount = 3;
        private double learningRate = 0.25d;

    }
}
