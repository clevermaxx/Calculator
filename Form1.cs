﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace misoluchun
{
    public partial class Form1 : Form
    {
        double son1, son2, Natija;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            son1 = Convert.ToDouble(textBox1.Text);
            son2 = Convert.ToDouble(textBox2.Text);
            hisobla();

        }

        private void hisobla()
        {
            if (comboBox1.Text == "Qo'shish")
            {
                Natija = son1 + son2;

            }
            else if (comboBox1.Text == "Ayirish") 
            {
                Natija = son1 - son2;
            }
            else if (comboBox1.Text == "Ko'paytirish")
            {
                Natija = son1 * son2;
            }
            else if (comboBox1.Text == "Bo'lish")
            {
                Natija = son1 / son2;
            }
            label3.Text = Natija.ToString();


        }
    }
}
