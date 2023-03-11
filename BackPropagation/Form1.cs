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
        }

        private void trainbtn_Click(object sender, EventArgs e)
        {
            // reading training data from file
            using (var reader = new StreamReader("../../../trainingset.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<TrainingData>().ToList();

                // training starts here
                for(int x = 0; x < Convert.ToInt32(trainepochin.Text); x++)
                {
                    foreach (var record in records)
                    {
                        neuro.setInputs(0, record.variance);
                        neuro.setInputs(1, record.skewness);
                        neuro.setInputs(2, record.curtosis);
                        neuro.setInputs(3, record.entropy);
                        neuro.setDesiredOutput(0, record.classification);
                        neuro.learn();
                    }
                }
                Console.WriteLine("don dokodone");
            }
        }
    }
}
