using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace BackPropagation
{
    public partial class Form1 : Form
    {
        NeuralNet neuro = new NeuralNet(4, 10, 1);
        public Form1()
        {
            InitializeComponent();
        }
    }
}
