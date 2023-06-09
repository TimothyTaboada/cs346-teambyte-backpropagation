﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;
using CsvHelper;
using CsvHelper.Configuration;

namespace BackPropagation
{
    public partial class Form1 : Form
    {
        NeuralNet neuro = new NeuralNet(4, 10, 1);

        public Form1()
        {
            InitializeComponent();
            neuro.loadWeights("../../wei.txt");
            Console.WriteLine("loaded");
        }

        private void calcbtn_Click(object sender, EventArgs e)
        {
            neuro.setInputs(0, Convert.ToDouble(varin.Text));
            neuro.setInputs(1, Convert.ToDouble(skewin.Text));
            neuro.setInputs(2, Convert.ToDouble(curtin.Text));
            neuro.setInputs(3, Convert.ToDouble(entin.Text));

            neuro.run();
            output.Text = "" + neuro.getOuputData(0);
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            varin.Text = "";
            skewin.Text = "";
            curtin.Text = "";
            entin.Text = "";
            output.Text = "";
        }
    }
}
