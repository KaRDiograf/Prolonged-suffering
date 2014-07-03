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
    public partial class Form1 : Form


    {
        Label[,] _Labels = new Label[10, 25];
        int[] positionsI = new int[4];
        int[] positionsJ= new int[4];

        public void GetStartPosition(string name)
        {
            switch (name)
            {
                case "Palka":
                    {
                        
                        for (int i = 0; i < 4; i++)
                        {
                            positionsJ[i] = 0;
                            positionsI[i] = i + 3;
                            
                        }

                        break;
                    }
            }
        }

        public void F1(Label[,] _Lab)
        {
            _Lab[4, 4].BackColor = Color.Green;
        }

        public void MoveDown(Label[,] _Lab, int[] i, int[] j)
        {
            if (j[0] < 24)
            {
                for (int k = 0; k < 4; k++)
                {

                    _Lab[i[k], j[k] + 1].Tag = "1";
                    _Lab[i[k], j[k]].Tag = "0";
                    positionsJ[k]++;
                }
            }
        }

        public void MoveLeft(Label[,] _Lab, int[] i, int[] j)
        {
            if (i[0] > 0)
            {               
               for (int k = 0; k < 4; k++)
                {
                    _Lab[i[k]-1, j[k]].Tag = "1";
                    _Lab[i[k], j[k]].Tag = "0";
                    positionsI[k]--;
                }
            }
        }

        public void MoveRight(Label[,] _Lab, int[] i, int[] j)
        {
            if (i[3] < 9)
            {
                for (int k = 3; k >= 0; k--)
                {
                    _Lab[i[k] + 1, j[k]].Tag = "1";
                    _Lab[i[k], j[k]].Tag = "0";
                    positionsI[k]++;
                }
            }
        }

        public void Start(Label[,] _Lab)
        {
            
            _Lab[4, 0].Tag = "1";
        }
        
        public void Draw( Label[,] _Lab)
        {
            for (int i = 0; i < _Lab.GetLength(0); i++)
                for (int j = 0; j < _Lab.GetLength(1); j++)
                    if (_Lab[i,j].Tag == "0")
                    {
                        _Lab[i, j].BackColor = Color.White;
                        

                    }
                    else
                    {
                        _Lab[i, j].BackColor = Color.Blue;
                       

                    }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
            {
                MoveDown(_Labels, positionsI, positionsJ);
                Draw(_Labels);
            }

            if (e.KeyData == Keys.Left)
            {
                MoveLeft(_Labels, positionsI, positionsJ);
                Draw(_Labels);
            }

            if (e.KeyData == Keys.Right)
            {
                MoveRight(_Labels, positionsI, positionsJ);
                Draw(_Labels);
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
                    //_Labels[i, j].Location = new Point(_Labels[i, j].Width * i + i * 3, _Labels[i, j].Width *  j/2);
                    _Labels[i, j].Location = new Point(_Labels[i, j].Width * i + i*3+50, _Labels[i, j].Width * j + j*3+50);
                    //_Labels[i, j].Text = "Label " + count.ToString();
                     _Labels[i, j].Tag = "0";
                    
                    //_Labels[i, j].Name = "Label " + count.ToString();                    
                    this.Controls.Add(_Labels[i, j]);
                    _Labels[i, j].BackColor = Color.White;
                    _Labels[i, j].ForeColor = Color.White;
                   
                   
 
                   
                   
                }
            }
           GetStartPosition("Palka");
           Draw(_Labels);

            
            Start(_Labels);
            
            Draw(_Labels);
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            
           
         
        }

     

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

      
    }
}
