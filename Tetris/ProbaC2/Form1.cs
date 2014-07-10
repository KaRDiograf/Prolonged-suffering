using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyFIgures;
using System.IO;

namespace ProbaC2
{
    public partial class Form1 : Form
    {    
        Label[,] _Labels = new Label[10, 25];
        Label[,] nextFig = new Label[7, 4];
        int[] posI = new int[4];
        int[] posJ= new int[4];
        int[] nextFigPosI = new int[4];
        int[] nextFigPosJ = new int[4];
        int k = 0;
        Figure name;
        Figure nextFigure;
        Field field = new Field();
        Field nextFigField = new Field();
        FileInfo file = new FileInfo("Tabl.txt");
        string[] names = new string[5];
        string[] scores = new string[5];
        RecordsTable recTable = new RecordsTable();
       
        public Figure GetFigure()
        {
            Random rand = new Random();
            switch (rand.Next(0, 7))
            {
                case 0:
                    {
                        nextFigure = new I();                       
                        return nextFigure;               
                    }

                case 1:
                    {
                        nextFigure = new J();
                        return nextFigure;
                    }

                case 2:
                    {
                        nextFigure = new L();

                        return nextFigure;
                    }

                case 3:
                    {
                        nextFigure = new S();
                        return nextFigure;
                    }

                case 4:
                    {
                        nextFigure = new Z();
                        return nextFigure;
                    }

                case 5:
                    {
                        nextFigure = new O();
                        return nextFigure;

                    }

                case 6:
                    {
                        nextFigure = new T();
                        return nextFigure;

                    }
                default:
                    {
                        nextFigure = new I();
                        return nextFigure;
                    }
            }
        }

        public void ShowTable(string[] names, string[] scores)
        {
            Tabl table = new Tabl(names, scores);
            table.ShowDialog();
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
            {/*
                for (int i = 0; i < 4; i++ )
                {
                    posJ[i] = posJ[i] + 2;
                }
                    field.RemoveLine(_Labels, 24);
                    field.RemoveLine(_Labels, 24);
                */
                timer1.Enabled = false;
            }

            if (e.KeyData == Keys.D2)
            {
                timer1.Enabled = true;
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
                    _Labels[i, j].Width = 20;
                    _Labels[i, j].Height = 20;                   
                    _Labels[i, j].Location = new Point(_Labels[i, j].Width * i + i +80, _Labels[i, j].Width * j + j + 10);
                     _Labels[i, j].Tag = "0";                                    
                    this.Controls.Add(_Labels[i, j]);
                    _Labels[i, j].BackColor = Color.White;
                    _Labels[i, j].ForeColor = Color.White;                  
                }
            }

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    count++;
                    nextFig[i, j] = new Label();
                    nextFig[i, j].Width = 20;
                    nextFig[i, j].Height = 20;
                    nextFig[i, j].Location = new Point(_Labels[i, j].Width * i + i + 450, _Labels[i, j].Width * j + j + 50);
                    nextFig[i, j].Tag = "0";
                    this.Controls.Add(nextFig[i, j]);
                    nextFig[i, j].BackColor = Color.White;
                    nextFig[i, j].ForeColor = Color.White;
                    if (i > 1) nextFig[i, j].Visible = true;
                    else nextFig[i, j].Visible = false;
                }
            }

            recTable.ReadTable(names, scores);           
            KeyDown += new KeyEventHandler(Form1_KeyDown);         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
            label1.Text = k.ToString();
            if (posJ[0] < 24 && posJ[1] < 24 && posJ[2] < 24 && posJ[3] < 24 && name.CanMoveDown(_Labels, posI, posJ))
                {
                    name.MoveDown(_Labels, posI, posJ);
                    field.Draw(_Labels);       
                }
             else
                {
                    while (field.CanRemoveLine(_Labels))
                    {  
                        field.RemoveLine(_Labels,  field.GetNumberOfLine(_Labels));
                        field.Draw(_Labels);
                        k += 1000;           
                    }
                    name = nextFigure;
                    name.GetStartPosition(_Labels, posI, posJ);
                    nextFigure = GetFigure();
                    nextFigField.Clear(nextFig);
                    nextFigure.GetStartPosition(nextFig, nextFigPosI, nextFigPosJ);
                    if (nextFigPosJ[3]!=3)
                    {
                        nextFigure.MoveDown(nextFig, nextFigPosI, nextFigPosJ);
                    }
                    nextFigField.Draw(nextFig);
                    if (!name.CanMoveDown(_Labels, posI, posJ))
                    {
                        field.Draw(_Labels);
                        timer1.Enabled = false;
                        if (recTable.CanChangeTabl(scores, k))
                        {
                            recTable.ChangeTabl(names, scores, "Vanya", k.ToString(), recTable.GetPlayerPosition(scores, k));
                        }
   
                        timer1.Enabled = false;
                        LNewGame.Enabled = true;
                        LRecords.Enabled = true;

                    }
                    field.Draw(_Labels);
                }
        }


        private void LNewGame_Click(object sender, EventArgs e)
        {
            nextFigure = GetFigure();
            name = new I();
            name.GetStartPosition(_Labels, posI, posJ);
            field.Draw(_Labels);
            nextFigure = GetFigure();           
            nextFigure.GetStartPosition(nextFig, nextFigPosI, nextFigPosJ);
            nextFigure.MoveDown(nextFig, nextFigPosI, nextFigPosJ);
            nextFigField.Draw(nextFig);
            field.Draw(_Labels);
            timer1.Enabled = true;
            LNewGame.Enabled = false;
            LRecords.Enabled = false;
        }

        private void LRecords_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("Tabl.txt");
            if (file.Exists == false)
            {
                file.Create();
            }
            recTable.ReadTable(names, scores);
            ShowTable(names, scores);
        }

        private void LExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }     
    }
}
