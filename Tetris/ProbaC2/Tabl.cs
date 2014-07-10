using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProbaC2
{
    public partial class Tabl : Form
    {
        Form1 mainForm = new Form1();
        public Tabl(string[] names, string[] scores)
        {
            InitializeComponent();
            label1.Text = names[0];
            label2.Text = scores[0];
            label3.Text = names[1];
            label4.Text = scores[1];
            label5.Text = names[2];
            label6.Text = scores[2];
            label7.Text = names[3];
            label8.Text = scores[3];
            label9.Text = names[4];
            label10.Text = scores[4];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
