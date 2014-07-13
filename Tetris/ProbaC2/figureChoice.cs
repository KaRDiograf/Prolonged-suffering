using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyFIgures;

namespace ProbaC2
{
    public partial class figureChoice : Form
    {
        public Figure chosenFigure;
        public bool isChanged = false;
        public int price, purchaseCount = 0;
        public int scoresCount;

        public figureChoice()
        {
            InitializeComponent();
        }

        private void figureChoice_Load(object sender, EventArgs e)
        {
            label6.Text = scoresCount.ToString();
            label6.Text += " очков"; 
        }


 
        private void label2_Click(object sender, EventArgs e)
        {
            isChanged = true;
            purchaseCount++;
            Close();
        }

        private void pictureBoxI_Click(object sender, EventArgs e)
        {
            chosenFigure = new I();
            Scores.Text = "6000 очков";
            price = 6000;
            chosenFigureName.Text = "I";
            if (scoresCount >= price)
            {
                label2.Enabled = true;
            }
            else
            {
                label2.Enabled = false;
            }
        
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            chosenFigure = new J();
            Scores.Text = "5000 очков";
            price = 5000;
            chosenFigureName.Text = "J";
            if (scoresCount >= price)
            {
                label2.Enabled = true;
            }
            else
            {
                label2.Enabled = false;
            }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            chosenFigure = new L();
            Scores.Text = "5000 очков";
            price = 5000;
            chosenFigureName.Text = "L";
            if (scoresCount >= price)
            {
                label2.Enabled = true;
            }
            else
            {
                label2.Enabled = false;
            }
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            chosenFigure = new O();
            Scores.Text = "5000 очков";
            price = 5000;
            chosenFigureName.Text = "O";
            if (scoresCount >= price)
            {
                label2.Enabled = true;
            }
            else
            {
                label2.Enabled = false;
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            chosenFigure = new S();
            Scores.Text = "4000 очков";
            price = 4000;
            chosenFigureName.Text = "S";
            if (scoresCount >= price)
            {
                label2.Enabled = true;
            }
            else
            {
                label2.Enabled = false;
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            chosenFigure = new Z();
            Scores.Text = "4000 очков";
            price = 4000;
            chosenFigureName.Text = "Z";
            if (scoresCount >= price)
            {
                label2.Enabled = true;
            }
            else
            {
                label2.Enabled = false;
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            chosenFigure = new T();
            Scores.Text = "5000 очков";
            price = 5000;
            chosenFigureName.Text = "T";
            if (scoresCount >= price)
            {
                label2.Enabled = true;
            }
            else
            {
                label2.Enabled = false;
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            isChanged = false;
            Close();
        }

    }
}
