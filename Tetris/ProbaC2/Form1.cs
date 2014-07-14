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
using Achievments;

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
        Figure name;
        Figure nextFigure;
        Field field = new Field();
        Field nextFigField = new Field();
        FileInfo file = new FileInfo("Tabl.txt");
        bool[] achAreCompleted = new bool[8];
        string[] names = new string[5];
        string[] scores = new string[5];
        RecordsTable recTable = new RecordsTable();
        public string playerName;
        private PauseMenu pauseMenu = new PauseMenu();
        string figureName;
        Control control = new Control();
        Achievment[] achievments = { new Loser(), new Busy(), new Champion(), new Shopaholic(), new Bomberman(), new Mag(), new Speed(), new Destroyer() };
        bool isUnlocked = false;
        UserStat userStat = new UserStat();
        AchievmentsFile achFile = new AchievmentsFile();
       
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

        public int GetSpeed(int k)
        {
            if (userStat.scoresCount< 200000)
            {
                return 250 - userStat.scoresCount/ 1000;
            }
            else return 50;
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
                if (timer1.Enabled == true)
                {
                    if (posJ[0] < 24 && posJ[1] < 24 && posJ[2] < 24 && posJ[3] < 24 && name.CanMoveDown(_Labels, posI, posJ))
                    {
                        name.MoveDown(_Labels, posI, posJ);
                        field.Draw(_Labels);
                    }
                }
            }

            if (e.KeyData == Keys.Left)
            {
                if (timer1.Enabled == true)
                {
                    if (posI[0] > 0 && posI[1] > 0 && posI[2] > 0 && posI[3] > 0 && name.CanMoveLeft(_Labels, posI, posJ))
                    {
                        name.MoveLeft(_Labels, posI, posJ);
                        field.Draw(_Labels);
                    }
                }
            }

            if (e.KeyData == Keys.Right)
            {
                if (timer1.Enabled == true)
                {
                    if (posI[0] < 9 && posI[1] < 9 && posI[2] < 9 && posI[3] < 9 && name.CanMoveRight(_Labels, posI, posJ))
                    {
                        name.MoveRight(_Labels, posI, posJ);
                        field.Draw(_Labels);
                    }
                }
            }

            if (e.KeyData == Keys.Space)
            {
                if (timer1.Enabled == true)
                {
                    name = name.Turn(_Labels, posI, posJ);
                    field.Draw(_Labels);
                }
            }

            if (e.KeyData == Keys.D1)
            {
                if (timer1.Enabled == true)
                {
                    if (userStat.scoresCount >= 3000)
                    {
                        userStat.scoresCount -= 3000;
                        for (int i = 0; i < 4; i++)
                        {
                            posJ[i] = posJ[i] + 2;
                        }
                        field.RemoveLine(_Labels, 24);
                        field.RemoveLine(_Labels, 24);
                        userStat.removingCount++;
                    }
                }
                
            }

            if (e.KeyData == Keys.D2)
            {
                if (timer1.Enabled == true)
                {
                    if (userStat.scoresCount >= 3000)
                    {
                        nextFigure = new Bomb();
                        figureName = "Bomb";
                        userStat.scoresCount -= 3000;
                        nextFigField.Clear(nextFig);
                        nextFigure.GetStartPosition(nextFig, nextFigPosI, nextFigPosJ);
                        if (nextFigPosJ[3] != 3)
                        {
                            nextFigure.MoveDown(nextFig, nextFigPosI, nextFigPosJ);
                        }
                        nextFigField.Draw(nextFig);
                        userStat.bombsCount++;
                    }
                }
            }

            if (e.KeyData == Keys.D3)
            {
                if (timer1.Enabled == true)
                {
                    if (userStat.scoresCount >= 3000)
                    {
                        pictureBox1.Visible = true;
                        userStat.scoresCount -= 3000;
                        slowTime.Enabled = true;
                        timer1.Interval = 500;
                        userStat.slowTimeCount++;
                    }
                }
            }

            if (e.KeyData == Keys.D4)
            {
                if (timer1.Enabled == true)
                {
                    userStat.scoresCount += 100000;
                }
            }

            if (e.KeyData == Keys.Escape)
            {
                if (timer1.Enabled == true)
                {
                    timer1.Enabled = false;
                    pauseMenu.choice.scoresCount = userStat.scoresCount;
                    pauseMenu.achForm.achArray = achAreCompleted;
                    pauseMenu.achForm.achievmentsFile = achFile;
                    pauseMenu.ShowDialog();
                    if (pauseMenu.choice.isChanged)
                    {
                        userStat.scoresCount -= pauseMenu.choice.price;
                        userStat.purchaseCount++;
                        nextFigure = pauseMenu.choice.chosenFigure;
                        nextFigField.Clear(nextFig);
                        nextFigure.GetStartPosition(nextFig, nextFigPosI, nextFigPosJ);
                        if (nextFigPosJ[3] != 3)
                        {
                            nextFigure.MoveDown(nextFig, nextFigPosI, nextFigPosJ);
                        }
                        nextFigField.Draw(nextFig);
                        pauseMenu.choice.isChanged = false;
                    }
                    timer1.Enabled = true;
                    userStat.pausesCount++;
                }
            }
        }

        public void UnlockAchievments(bool[] achAreCompleted)
        {
            if (achAreCompleted[0]) pauseMenu.achForm.pictureBox1.Image = Properties.Resources.Rak2;
            else pauseMenu.achForm.pictureBox1.Image = Properties.Resources.Zamok;
            if (achAreCompleted[1]) pauseMenu.achForm.pictureBox2.Image = Properties.Resources.business;
            else pauseMenu.achForm.pictureBox2.Image = Properties.Resources.Zamok;
            if (achAreCompleted[2]) pauseMenu.achForm.pictureBox3.Image = Properties.Resources.Champion;
            else pauseMenu.achForm.pictureBox3.Image = Properties.Resources.Zamok;
            if (achAreCompleted[3]) pauseMenu.achForm.pictureBox4.Image = Properties.Resources.Shop;
            else pauseMenu.achForm.pictureBox4.Image = Properties.Resources.Zamok;
            if (achAreCompleted[4]) pauseMenu.achForm.pictureBox5.Image = Properties.Resources.bomberman;
            else pauseMenu.achForm.pictureBox5.Image = Properties.Resources.Zamok;
            if (achAreCompleted[5]) pauseMenu.achForm.pictureBox6.Image = Properties.Resources.Mag;
            else pauseMenu.achForm.pictureBox6.Image = Properties.Resources.Zamok;
            if (achAreCompleted[6]) pauseMenu.achForm.pictureBox7.Image = Properties.Resources.Sonic;
            else pauseMenu.achForm.pictureBox7.Image = Properties.Resources.Zamok;
            if (achAreCompleted[7]) pauseMenu.achForm.pictureBox8.Image = Properties.Resources.Destroyer;
            else pauseMenu.achForm.pictureBox8.Image = Properties.Resources.Zamok;
        }

        public Form1()
        {
            InitializeComponent();
            this.AutoSize = true;
            int count = 0;
            userStat.playerPosition = -1;
            achFile.ReadAchievments(achAreCompleted);
            UnlockAchievments(achAreCompleted);
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
            if (!slowTime.Enabled)
            {
                timer1.Interval = GetSpeed(userStat.scoresCount);
            }
            else timer1.Interval = 500;
            label1.Text = userStat.scoresCount.ToString();
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
                    userStat.scoresCount += 1000;
                }
                if (figureName == "Bomb")
                {
                    name.Boom(_Labels, posI, posJ);
                }
                name = nextFigure;
                name.GetStartPosition(_Labels, posI, posJ);
                nextFigure = GetFigure();
                nextFigField.Clear(nextFig);
                nextFigure.GetStartPosition(nextFig, nextFigPosI, nextFigPosJ);
                if (nextFigPosJ[3] != 3)
                {
                    nextFigure.MoveDown(nextFig, nextFigPosI, nextFigPosJ);
                }
                nextFigField.Draw(nextFig);
                if (!name.CanMoveDown(_Labels, posI, posJ))
                {
                    timer1.Enabled = false;

                    if (recTable.CanChangeTabl(scores, userStat.scoresCount))
                    {
                        userStat.playerPosition = recTable.GetPlayerPosition(scores, userStat.scoresCount);                       
                        Form2 yourName = new Form2();
                        yourName.ShowDialog();
                        playerName = yourName.textBox1.Text;
                        recTable.ChangeTabl(names, scores, playerName, userStat.scoresCount.ToString(), userStat.playerPosition);
                        recTable.ReadTable(names, scores);
                        ShowTable(names, scores);
                    }
                    for (int i = 0; i < 8; i++)
                    {
                        if (achievments[i].isCompleted(userStat) && !achAreCompleted[i])
                        {
                            achAreCompleted[i] = true;
                            isUnlocked = true;
                        }

                    }
                    userStat.playerPosition = -1;
                    achFile.WriteAchievments(achAreCompleted);
                    UnlockAchievments(achAreCompleted);
                    if (isUnlocked)
                    {
                        newAch.Visible = true;
                    }
                    field.Draw(_Labels);
                    timer1.Enabled = false;
                    LNewGame.Enabled = true;
                    LRecords.Enabled = true;                  
                    ShowAchievments.Enabled = true;
                    label3.Enabled = true;

                }
                field.Draw(_Labels);
            }
        }


        private void LNewGame_Click(object sender, EventArgs e)
        {
            newAch.Visible = false;           
            userStat.scoresCount= 0;
            field.Clear(_Labels);
            nextFigure = GetFigure();
            name = new S();
            name.GetStartPosition(_Labels, posI, posJ);
            field.Draw(_Labels);
            nextFigure = GetFigure();           
            nextFigure.GetStartPosition(nextFig, nextFigPosI, nextFigPosJ);
            if (nextFigPosJ[3] != 3)
            {
                nextFigure.MoveDown(nextFig, nextFigPosI, nextFigPosJ);
            }
            nextFigField.Draw(nextFig);
            field.Draw(_Labels);
            timer1.Enabled = true;
            LNewGame.Enabled = false;
            LRecords.Enabled = false;
            ShowAchievments.Enabled = false;
            label3.Enabled = false;

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

        private void label3_Click(object sender, EventArgs e)
        {
            control.ShowDialog();                              
        }

        private void newAch_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            achFile.ReadAchievments(achAreCompleted);
            UnlockAchievments(achAreCompleted);
            pauseMenu.achForm.achArray = achAreCompleted;
            pauseMenu.achForm.ShowDialog();
        }

        private void ShowAchievments_Click(object sender, EventArgs e)
        {
            achFile.ReadAchievments(achAreCompleted);
            UnlockAchievments(achAreCompleted);
            pauseMenu.achForm.achArray = achAreCompleted;
            pauseMenu.achForm.ShowDialog();
        }

        private void slowTime_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            timer1.Interval = GetSpeed(userStat.scoresCount);
            slowTime.Enabled = false;
        } 
    }
}
