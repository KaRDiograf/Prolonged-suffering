using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MyFIgures
{
    public class O : Figure
    {
        public void GetStartPosition(Label[,] _Labels, int[] posI, int[] posJ)
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
            for (int i = 0; i < 4; i++)
            {
                _Labels[posI[i], posJ[i]].Tag = "7";
            }
        }

        public bool CanMoveDown(Label[,] _Labels, int[] posI, int[] posJ)
        {
            bool key = true;
            for (int i = 2; i < 4; i++)
            {
                if (_Labels[posI[i], posJ[i] + 1].Tag == "0")
                    key = true;
                else return false;
            }
            return key;
        }

        public bool CanMoveLeft(Label[,] _Labels, int[] posI, int[] posJ)
        {
            bool key = true;
            for (int i = 0; i < 3; i++)
            {
                if (i == 1) continue;
                if (_Labels[posI[i] - 1, posJ[i]].Tag == "0")
                    key = true;
                else return false;
            }
            return key;
        }

        public bool CanMoveRight(Label[,] _Labels, int[] posI, int[] posJ)
        {
            bool key = true;
            for (int i = 1; i < 4; i++)
            {
                if (i == 2) continue;
                if (_Labels[posI[i] + 1, posJ[i]].Tag == "0")
                    key = true;
                else return false;
            }
            return key;
        }

        public void MoveDown(Label[,] _Labels, int[] posI, int[] posJ)
        {
            for (int i = 3; i >= 0; i--)
            {

                _Labels[posI[i], posJ[i] + 1].Tag = "7";
                _Labels[posI[i], posJ[i]].Tag = "0";
                posJ[i]++;
            }
        }

        public void MoveLeft(Label[,] _Labels, int[] posI, int[] posJ)
        {
            if (posI[0] > 0 && posI[1] > 0 && posI[2] > 0 && posI[3] > 0)
            {
                for (int k = 0; k < 4; k++)
                {
                    _Labels[posI[k] - 1, posJ[k]].Tag = "7";
                    _Labels[posI[k], posJ[k]].Tag = "0";
                    posI[k]--;
                }
            }
        }

        public void MoveRight(Label[,] _Labels, int[] posI, int[] posJ)
        {
            if (posI[0] < 9 && posI[1] < 9 && posI[2] < 9 && posI[3] < 9)
            {
                for (int k = 3; k >= 0; k--)
                {
                    _Labels[posI[k] + 1, posJ[k]].Tag = "7";
                    _Labels[posI[k], posJ[k]].Tag = "0";
                    posI[k]++;
                }
            }
        }

        public virtual Figure Turn(Label[,] _Labels, int[] posI, int[] posJ)
        {
            Figure name = new O();
            return name;
        }

        public void Boom(Label[,] _Labels, int[] posI, int[] posJ)
        {
        }
    }
}
