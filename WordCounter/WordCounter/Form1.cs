using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCounter
{
    public partial class Form1 : Form
    {
        int count = 0;
        Char[] seperators = { ' ', '.', ',', '?', ';', '!' };
    public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] word = textBox1.Text.Split(seperators);
            listBox1.Items.Clear();

            foreach(string item in word)
            {
                if (item.Length > 0)
                {
                    listBox1.Items.Add(item);
                    count++;
                }
            }
            textBox2.Text = count.ToString();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
