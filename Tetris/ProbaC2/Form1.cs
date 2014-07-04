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

        public string GetFigureName()
        {
            string name;
            Random rand = new Random();
            switch(rand.Next(0,6))
            {
                case 0:
                    {
                        name = "I";
                        return name;
                    }
                
                case 1:
                    {
                        name = "J";
                        return name;
                    }
               
                case 2:
                    {
                        name = "L";
                        return name;
                    }
                
                case 3:
                    {
                        name = "S";
                        return name;
                    }
                
                case 4:
                    {
                        name = "Z";
                        return name;
                    }
                
                case 5:
                    {
                        name = "O";
                        return name;
                        
                    }

                case 6:
                    {
                        name = "T";
                        return name;
                        
                    }
                default:
                    {
                        name = "";
                        return name;
                    }
            }
            
            
        }
       
        
        public void GetStartPosition(string name)
        {
            switch (name)
            {
                case "I":
                    {                       
                        for (int i = 0; i < 4; i++)
                        {
                            positionsJ[i] = 0;
                            positionsI[i] = i + 3;                            
                        }
                        break;
                    }
                
                case "J":
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            positionsJ[i] = 0;
                            positionsI[i] = i + 3;
                        }
                        positionsJ[3] = 1;
                        positionsI[3] = 5;
                        break;
                    }
                
                case "L":
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            positionsJ[i] = 0;
                            positionsI[i] = i + 3;
                            positionsJ[3] = 1;
                            positionsI[3] = 3;
                        }
                        break;
                    }
                
                case "T":
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            positionsJ[i] = 0;
                            positionsI[i] = i + 3;
                        }
                        positionsJ[3] = 1;
                        positionsI[3] = 4;
                        break;
                    }

                case "Z":
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            positionsJ[i] = 0;
                            positionsI[i] = i + 3;
                        }
                        for (int i = 2; i < 4; i++)
                        {
                            positionsJ[i] = 1;
                            positionsI[i] = i + 2;
                        }
                        break;
                    }

                case "S":
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            positionsJ[i] = 0;
                            positionsI[i] = i + 4;
                        }
                        for (int i = 2; i < 4; i++)
                        {
                            positionsJ[i] = 1;
                            positionsI[i] = i + 1;
                        }
                        break;
                    }

                case "O":
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            positionsJ[i] = 0;
                            positionsI[i] = i + 4;
                        }
                        for (int i = 2; i < 4; i++)
                        {
                            positionsJ[i] = 1;
                            positionsI[i] = i + 2;
                        }
                        break;
                    }
            }
            
            for (int i = 0; i < 4; i++)
            {
                _Labels[positionsI[i], positionsJ[i]].Tag = "1" ;
            }
            
        }

       

        public void MoveDown(Label[,] _Lab, int[] i, int[] j)
        {
            if (j[0] < 24 && j[1] < 24 && j[2] < 24 && j[3] < 24)
            {
                for (int k = 3; k >= 0; k--)
                {

                    _Lab[i[k], j[k] + 1].Tag = "1";
                    _Lab[i[k], j[k]].Tag = "0";
                    positionsJ[k]++;
                }
            }
        }

        public void MoveLeft(Label[,] _Lab, int[] i, int[] j)
        {
            if (i[0] > 0 && i[1] > 0 && i[2] > 0 && i[3] > 0)
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
            if (i[0] < 9 && i[1] < 9 && i[2] < 9 && i[3] < 9)
            {
                for (int k = 3; k >= 0; k--)
                {
                    _Lab[i[k] + 1, j[k]].Tag = "1";
                    _Lab[i[k], j[k]].Tag = "0";
                    positionsI[k]++;
                }
            }
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

            if (e.KeyData == Keys.Space)
            {
                GetStartPosition(GetFigureName()); 
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
                    _Labels[i, j].Location = new Point(_Labels[i, j].Width * i + i*3+50, _Labels[i, j].Width * j + j*3+50);
                     _Labels[i, j].Tag = "0";                                    
                    this.Controls.Add(_Labels[i, j]);
                    _Labels[i, j].BackColor = Color.White;
                    _Labels[i, j].ForeColor = Color.White;                  
                }
            }
           GetStartPosition(GetFigureName());                                  
           Draw(_Labels);
           KeyDown += new KeyEventHandler(Form1_KeyDown);         
        }

    
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

      
    }
}
