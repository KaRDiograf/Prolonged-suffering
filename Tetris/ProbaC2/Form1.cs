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
        int[] posI = new int[4];
        int[] posJ= new int[4];
        string name = "";

        public string GetFigureName()
        {
            string name;
            Random rand = new Random();
            switch(rand.Next(0,7))
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
                            posJ[i] = i;
                            posI[i] = 4;                            
                        }
                        break;
                    }
                
                case "J":
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            posJ[i] = 0;
                            posI[i] = i + 3;
                        }
                        posJ[3] = 1;
                        posI[3] = 5;
                        break;
                    }
                
                case "L":
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            posJ[i] = 0;
                            posI[i] = i + 3;
                            posJ[3] = 1;
                            posI[3] = 3;
                        }
                        break;
                    }
                
                case "T":
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            posJ[i] = 0;
                            posI[i] = i + 3;
                        }
                        posJ[3] = 1;
                        posI[3] = 4;
                        break;
                    }

                case "Z":
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            posJ[i] = 0;
                            posI[i] = i + 3;
                        }
                        for (int i = 2; i < 4; i++)
                        {
                            posJ[i] = 1;
                            posI[i] = i + 2;
                        }
                        break;
                    }

                case "S":
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            posJ[i] = 0;
                            posI[i] = i + 4;
                        }
                        for (int i = 2; i < 4; i++)
                        {
                            posJ[i] = 1;
                            posI[i] = i + 1;
                        }
                        break;
                    }

                case "O":
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            posJ[i] = 0;
                            posI[i] = i + 4;
                        }
                        for (int i = 2; i < 4; i++)
                        {
                            posJ[i] = 1;
                            posI[i] = i + 2;
                        }
                        break;
                    }
            }
            
            for (int i = 0; i < 4; i++)
            {
                _Labels[posI[i], posJ[i]].Tag = "1" ;
            }
            
        }

        public bool CanRemoveLine()
        {
            bool key = false;
            for(int i=0; i<=24; i++)
            {
                key = false;
                for(int j=0; j<10; j++)
                {
                    if (_Labels[j, i].Tag != "0") key = true;
                    else
                    {
                        key = false;
                        break;
                    }
                }
                if (key) return true;
            }
            
            return false;
        }

        
        public int GetNumberOfLine()
        {
            bool key = false;
            for (int i = 0; i <= 24; i++)
            {
                key = false;
                for (int j = 0; j < 10; j++)
                {
                    if (_Labels[j, i].Tag != "0") key = true;
                    else
                    {
                        key = false;
                        break;
                    }
                }
                if (key) return i;
            }

            return -1;
        }

        public void RemoveLine(int numberOfLine)
        {
            for(int i=numberOfLine; i>0; i--)
            {
                for(int j=0; j<10; j++)
                {
                    _Labels[j, i].Tag = _Labels[j, i - 1].Tag;
                }
            }
            for(int j=0; j<10; j++)
                {
                    _Labels[j, 0].Tag = "0";
                }
        }
    

    
    


        public bool CanMoveDown(string name)
        {
            bool key = true;
            switch (name)
            {

                case "I": 
                    {
                        
                        if (_Labels[posI[3], posJ[3] + 1].Tag == "0") return true;
                        else return false;
                    }

                case "J":
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (i == 2) continue;
                            if (_Labels[posI[i], posJ[i] + 1].Tag == "0")
                            {
                                
                                key = true;
                            }
                            else return false;
                        }
                        return key;
                        
                    }

                case "L":
                case "S":
                    {
                        for (int i = 1; i < 4; i++)
                        {
                            if (_Labels[posI[i], posJ[i] + 1].Tag == "0" )
                                key = true;
                            else return false;
                        }
                        return key;
                    }

                case "T": 
                case "Z":
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (i == 1) continue;
                            if (_Labels[posI[i], posJ[i] + 1].Tag == "0")
                                key = true;
                            else return false;
                        }
                        return key;

                    }

                case "O":
                    {
                        for (int i = 2; i < 4; i++)
                        {
                            if (_Labels[posI[i], posJ[i] + 1].Tag == "0")
                                key = true;
                            else return false;
                        }
                        return key; 
                    }

                case "turnedI":
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (_Labels[posI[i], posJ[i] + 1].Tag == "0")
                                key = true;
                            else return false;
                        }
                        return key;
                    }
                case "turnedS":
                case "turnedZ":
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (i == 0 || i==2) continue;
                            if (_Labels[posI[i], posJ[i] + 1].Tag == "0")
                                key = true;
                            else return false;
                        }
                        return key;
                    }
                default: return true;
                
            }

            

        }

       

        public void MoveDown(Label[,] _Lab, int[] i, int[] j)
        {
                for (int k = 3; k >= 0; k--)
                {

                    _Lab[i[k], j[k] + 1].Tag = "1";
                    _Lab[i[k], j[k]].Tag = "0";
                    posJ[k]++;
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
                    posI[k]--;
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
                    posI[k]++;
                }
            }
        }

        public void Turn(Label[,] _Lab,  ref string name, int[] posI, int[] posJ)
        {
            for (int i = 0; i < 4; i++)
            {
                _Labels[posI[i], posJ[i]].Tag = "0";
            }

            switch (name)
            {
                case "I":
                    {
                        if ((posI[1] - 2) >= 0 && posI[1] + 1 <= 9)
                        {
                            int k = posI[1] - 2;
                            for (int i = 0; i < 4; i++)
                            {
                                posI[i] = i + k;
                                posJ[i] = posJ[1];

                            }
                            name = "turnedI";
                        }
                        break;
                    }

                case "turnedI":
                    {
                        if ((posJ[1] - 1) >= 0 && posJ[1] + 2 <= 24)
                        {
                            int k = posJ[1] - 1;
                            for (int i = 0; i < 4; i++)
                            {
                                posJ[i] = i + k;
                                posI[i] = posI[2];
                            }
                            name = "I";
                        }
                        break;
                    }


                case "S":
                    {
                        int positionI = posI[1]-2, positionJ = posJ[1]- 2;
                        for (int i = 0; i < 2; i++)
                        {
                            posI[i] = positionI + 1;
                            posJ[i] = i + positionJ + 3;
                        }
                        for (int i = 2; i < 4; i++)
                        {
                            posI[i] =  positionI;
                            posJ[i] = i + positionJ ;
                        }
                        name = "turnedS";
                        break;
                    }

                case "turnedS":
                    {
                        int positionI = posI[1] - 4, positionJ = posJ[1] - 2;
                        for (int i = 0; i < 2; i++)
                        {
                            posJ[i] = positionJ;
                            posI[i] = i + positionI + 4;
                        }
                        for (int i = 2; i < 4; i++)
                        {
                            posJ[i] = 1 + positionJ;
                            posI[i] = i + 1 + positionI;
                        }
                        name = "S";
                        break;
                    }

                case "Z":
                    {
                        int positionI = posI[1] , positionJ = posJ[1] - 2;
                        for (int i = 0; i < 2; i++)
                        {
                            posI[i] = positionI ;
                            posJ[i] = i + positionJ + 3;
                        }
                        for (int i = 2; i < 4; i++)
                        {
                            posI[i] = positionI + 1;
                            posJ[i] = i + positionJ;
                        }
                        name = "turnedZ";
                        break;
                    }

                case "turnedZ":
                    {
                        int positionI = posI[1] - 4, positionJ = posJ[1] - 2;
                        for (int i = 0; i < 2; i++)
                        {
                            posJ[i] = 0 + positionJ;
                            posI[i] = i + 3 + positionI;
                        }
                        for (int i = 2; i < 4; i++)
                        {
                            posJ[i] = 1 + positionJ;
                            posI[i] = i + 2 + positionI;
                        }
                        name = "Z";
                        break;
                    }
            }
                   
                        
                        
                        

                    
            
            for (int i = 0; i < 4; i++)
            {
                _Labels[posI[i], posJ[i]].Tag = "1";
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
                MoveDown(_Labels, posI, posJ);
                Draw(_Labels);
 
            }

            if (e.KeyData == Keys.Left)
            {
                MoveLeft(_Labels, posI, posJ);
                Draw(_Labels);
            }

            if (e.KeyData == Keys.Right)
            {
                MoveRight(_Labels, posI, posJ);
                Draw(_Labels);
            }

            if (e.KeyData == Keys.Space)
            {
                
                Turn(_Labels, ref name, posI, posJ);
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
            //name = GetFigureName();
            name = "Z";
            
            
            
            GetStartPosition(name);
            Draw(_Labels);
            timer1.Enabled = true;
            KeyDown += new KeyEventHandler(Form1_KeyDown);         
        }

    
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {





            if (posJ[0] < 24 && posJ[1] < 24 && posJ[2] < 24 && posJ[3] < 24 && CanMoveDown(name))
                {
                    MoveDown(_Labels, posI, posJ);
                    Draw(_Labels);
                    
                }
             else
                {
                    label1.Text = GetNumberOfLine().ToString();

                    while (CanRemoveLine())
                    {
                        
                        RemoveLine(GetNumberOfLine());
                        Draw(_Labels);
                    }
                    //name = GetFigureName();
                    name = "Z";
                    

                    
                    GetStartPosition(name);
                    if (!CanMoveDown(name))
                    {
                        Draw(_Labels);
                        timer1.Enabled = false;
                        Form2 secondForm = new Form2();
                        secondForm.ShowDialog();
                        
                        
                    }
                    Draw(_Labels);
                }
        }

       

       

      
    }
}
