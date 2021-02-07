using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONVERTER_APP
{
    public partial class Form1 : Form
    {
        double pound;
        double kilogram;
        double answer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            kilogram = Double.Parse(textBox1.Text); ;
            answer = kilogram * 2.204;
            textBox3.Text = answer.ToString() + " lb";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pound = Double.Parse(textBox2.Text); ;
            answer = pound * 0.454;
            textBox3.Text = answer.ToString() + " kg";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
        
}
