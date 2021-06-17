using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapeMath
{
    public partial class Form1 : Form
    {
        double pi = Math.PI;
        double ans;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cirArea(object sender, EventArgs e)
        {
            ans = pi * Convert.ToDouble(radius.Value * radius.Value);
            answer.Text = Convert.ToString(Math.Round(ans, 3));
        }

        private void cirPer(object sender, EventArgs e)
        {
            ans = pi * Convert.ToDouble(radius.Value);
            answer.Text = Convert.ToString(Math.Round(ans * 2, 3));
        }


        private void cubArea(object sender, EventArgs e)
        {
            ans = Convert.ToDouble(base1.Value * base1.Value);
            answer.Text = Convert.ToString(Math.Round(ans * 6, 3));
        }

        private void trapArea(object sender, EventArgs e)
        {
            ans = Convert.ToDouble(base1.Value + base2.Value)*Convert.ToDouble(height.Value / 2);
            answer.Text = Convert.ToString(Math.Round(ans, 3));
        }

        private void triArea(object sender, EventArgs e)
        {
            ans = Convert.ToDouble(base1.Value / 2) * Convert.ToDouble(height.Value);
            answer.Text = Convert.ToString(Math.Round(ans, 3));
        }
    }
}