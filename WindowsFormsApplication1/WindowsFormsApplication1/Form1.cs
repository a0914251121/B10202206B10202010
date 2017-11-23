﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassA cA = new ClassA();
            ClassB cB = new ClassB();
            int n = cA.GetNumber();
            label1.Text = n.ToString();
            for (int i = 0; i <= n; ++i)
            {
                if (cB.IsPrime(i))
                {
                    comboBox1.Items.Add(i);
                }
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedIndex.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}