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
        int positionI = 4;
        int positionJ = 0;
        

        public void F1(Label[,] _Lab)
        {
            _Lab[4, 4].BackColor = Color.Green;
        }

        public void MoveDown(Label[,] _Lab, int i, int j)
        {
            if (j < 24)
            {
                _Lab[i, j + 1].Tag = "1";
                _Lab[i, j].Tag = "0";
                positionJ++;
            }
        }

        public void MoveLeft(Label[,] _Lab, int i, int j)
        {
            if (i > 0)
            {
                _Lab[i-1, j].Tag = "1";
                _Lab[i, j].Tag = "0";
                positionI--;
            }
        }

        public void MoveRight(Label[,] _Lab, int i, int j)
        {
            if (i < 9)
            {
                _Lab[i+1, j].Tag = "1";
                _Lab[i, j].Tag = "0";
                positionI++;
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
                MoveDown(_Labels, positionI, positionJ);
                Draw(_Labels);
            }

            if (e.KeyData == Keys.Left)
            {
                MoveLeft(_Labels, positionI, positionJ);
                Draw(_Labels);
            }

            if (e.KeyData == Keys.Right)
            {
                MoveRight(_Labels, positionI, positionJ);
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
