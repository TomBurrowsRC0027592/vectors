using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vectors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox2.Text);
                double f = double.Parse(textBox1.Text);
                double Fx = f * Cos(a);
                double Fy = f * Sin(a);
                label3.Text = "Fy = " + Fy + " N";
                label4.Text = "Fx = " + Fx + " N";
            }
            catch
            {
                MessageBox.Show("Enter a number ");
            }
        }
        double Sin(double a)
        {
            double rad = a / 180.0 / Math.PI;
            return Math.Sin(rad);
        }

        double Inversesin(double a)
        {
            return Math.Asin(a / 180.0 * Math.PI);
        }

        double Cos(double a)
        {
            return Math.Cos(a / 180.0 * Math.PI);
        }
    }
}        