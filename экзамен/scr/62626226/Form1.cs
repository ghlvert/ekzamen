using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _62626226
{
    public partial class Form1 : Form
    {

        private string temp;

        public Form1()
        {
            InitializeComponent();
        }


        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                webBrowser1.Navigate("about:blank");
                temp = openFileDialog1.FileName;
                webBrowser1.Navigate(temp);
                label1.Visible = true;
                label2.Visible = true;
                
                textBox1.Visible = true;
                textBox2.Visible = true;
               
                button1.Visible = true;
               
                toolStripStatusLabel1.Visible = true;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
        }



        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double x, y;

            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            if (y <= (x - 3) || y >= 0 || Math.Sqrt(x) + Math.Sqrt(y) <= 36)
            {
                toolStripStatusLabel1.Text = "Точка входит";
            }
            else
            {
                toolStripStatusLabel1.Text = "Точка не входит";
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
