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
    public partial class Form1 : Form
    {   
        Label[,] _Labels = new Label[10, 25];
        Label[,] _LabelsM = new Label[4, 4];
        int[] posI = new int[4];
        int[] posJ = new int[4];
        int k = 0;
        Figure name;
        Field field = new Field();

        public Figure GetFigure()
        {
            Random rand = new Random();
            switch (rand.Next(0, 7))
            {
                case 0:
                    {
                        name = new I();
                        return name;
                    }

                case 1:
                    {
                        name = new J();
                        return name;
                    }

                case 2:
                    {
                        name = new L();

                        return name;
                    }

                case 3:
                    {
                        name = new S();
                        return name;
                    }

                case 4:
                    {
                        name = new Z();
                        return name;
                    }

                case 5:
                    {
                        name = new O();
                        return name;

                    }

                case 6:
                    {
                        name = new T();
                        return name;

                    }
                default:
                    {
                        name = new I();
                        return name;
                    }
            }
        }
       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyData == Keys.Down)
            {
                if (posJ[0] < 24 && posJ[1] < 24 && posJ[2] < 24 && posJ[3] < 24 && name.CanMoveDown(_Labels, posI, posJ))
                {
                    name.MoveDown(_Labels, posI, posJ);
                    field.Draw(_Labels);
                }
 
            }

            if (e.KeyData == Keys.Left)
            {
                if (posI[0] > 0 && posI[1] > 0 && posI[2] > 0 && posI[3] > 0 && name.CanMoveLeft(_Labels, posI, posJ))
                {
                    name.MoveLeft(_Labels, posI, posJ);
                    field.Draw(_Labels);
                }
            }

            if (e.KeyData == Keys.Right)
            {
                if (posI[0] < 9 && posI[1] < 9 && posI[2] < 9 && posI[3] < 9 && name.CanMoveRight(_Labels, posI, posJ))
                {
                    name.MoveRight(_Labels, posI, posJ);
                    field.Draw(_Labels);
                }
            }

            if (e.KeyData == Keys.Space)
            {

                name = name.Turn(_Labels, posI, posJ);
                field.Draw(_Labels);
            }

            if (e.KeyData == Keys.D1)
            {
                if (k >= 2000)
                {
                    for (int i = 0; i < 4; i++)
                        posJ[i] = posJ[i] + 2;
                    field.RemoveLine(_Labels, 24);
                    field.RemoveLine(_Labels, 24);
                    k -= 2000;
                }
            }
            
        }

        public Form1()
        {
            InitializeComponent();
            this.AutoSize = true;
            int count = 0;            
            for (int i = 0; i < _Labels.GetLength(0); i++)
            {
                for (int j = 0; j < _Labels.GetLength(1); j++)
                {
                    count++;
                    _Labels[i, j] = new Label();
                    _Labels[i, j].Width = 15;
                    _Labels[i, j].Height = 15;                   
                    _Labels[i, j].Location = new Point(_Labels[i, j].Width * i + i*3+50, _Labels[i, j].Width * j + j*3+50);
                    _Labels[i, j].Tag = "0";                                    
                    this.Controls.Add(_Labels[i, j]);
                    _Labels[i, j].BackColor = Color.White;
                    _Labels[i, j].ForeColor = Color.White;                  
                }
            }

            count = 0;
            for (int i = 0; i < _LabelsM.GetLength(0); i++)
            {
                for (int j = 0; j < _LabelsM.GetLength(1); j++)
                {
                    count++;
                    _LabelsM[i, j] = new Label();
                    _LabelsM[i, j].Width = 15;
                    _LabelsM[i, j].Height = 15;
                    _LabelsM[i, j].Location = new Point(_LabelsM[i, j].Width * i + i * 3 + 300, _LabelsM[i, j].Width * j + j * 3 + 50);
                    _LabelsM[i, j].Tag = "0";
                    this.Controls.Add(_LabelsM[i, j]);
                    _LabelsM[i, j].BackColor = Color.White;
                    _LabelsM[i, j].ForeColor = Color.White;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label1.Text = k.ToString();
            label1.BackColor = Color.Khaki;
            if (posJ[0] < 24 && posJ[1] < 24 && posJ[2] < 24 && posJ[3] < 24 && name.CanMoveDown(_Labels, posI, posJ))
                {
                    name.MoveDown(_Labels, posI, posJ);
                    field.Draw(_Labels);  
                }
             else
                {
                    while (field.CanRemoveLine(_Labels))
                    {

                        field.RemoveLine(_Labels, field.GetNumberOfLine(_Labels));
                        field.Draw(_Labels);
                        k += 1000;
                        
                    }
                    name = GetFigure();
                    name.GetStartPosition(_Labels, posI, posJ);
                    if (!name.CanMoveDown(_Labels, posI, posJ))
                    {
                        field.Draw(_Labels);
                        timer1.Enabled = false;
                        Form2 secondForm = new Form2();
                        secondForm.ShowDialog(); 
                    }
                    field.Draw(_Labels);
                }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (k >= 2000)
            {
                for (int i = 0; i < 4; i++)
                   posJ[i] = posJ[i] + 2;
                field.RemoveLine(_Labels, 24);
                field.RemoveLine(_Labels, 24);
                k -= 2000;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = GetFigure();
            name.GetStartPosition(_Labels, posI, posJ);
            field.Draw(_Labels);
            timer1.Enabled = true;
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            button1.Enabled = false;
        }
    }
}
