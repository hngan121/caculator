using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bnCong_Click(object sender, EventArgs e)
        {

            int a = int.Parse(txtsoa.Text.ToString());
            int b = int.Parse(txtsob.Text.ToString());
            Calculation c = new Calculation(a, b);


            txtkq.Text = c.Execute("+").ToString();
            //if (txtsoa.Text != String.Empty)

            //if (txtsoa.Text != String.Empty && txtsob.Text != String.Empty)
            //{

            //    double a = double.Parse(txtsoa.Text);
            //    double b = double.Parse(txtsob.Text);
            //    double c = a + b;

            //    txtkq.Text = c.ToString();
            //}
        }

        private void bnTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtsoa.Text);
            double b = double.Parse(txtsob.Text);
            double c = a - b;
            txtkq.Text = c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
