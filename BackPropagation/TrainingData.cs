using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPropagation
{
    internal class TrainingData
    {
        public double variance { get; set; }
        public double skewness { get; set; }
        public double curtosis { get; set; }
        public double entropy { get; set; }
        public int classification { get; set; }
    }
}
