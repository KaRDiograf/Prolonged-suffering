using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MyFIgures
{
    public class I: Figure
    {
        public void GetStartPosition(Label[,] _Labels, int[] positionI, int[] positionJ)
        {
            for (int i = 0; i < 4; i++)
            {
                positionJ[i] = i;
                positionI[i] = 4;
            }
            for (int i = 0; i < 4; i++)
            {
                _Labels[positionI[i], positionJ[i]].Tag = "1";
            }
        }

        public virtual bool CanMoveDown(Label[,] _Labels, int[] posI, int[] posJ)
        {
            if (_Labels[posI[3], posJ[3] + 1].Tag == "0") return true;
            else return false;
        }

        public virtual bool CanMoveLeft(Label[,] _Labels, int[] posI, int[] posJ)
        {
            bool key = true;
            for (int i = 0; i < 4; i++)
            {
                if (_Labels[posI[i] - 1, posJ[i]].Tag == "0")
                    key = true;
                else return false;
            }
            return key;
        }

        public virtual bool CanMoveRight(Label[,] _Labels, int[] posI, int[] posJ)
        {
            bool key = true;
            for (int i = 0; i < 4; i++)
            {
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

                _Labels[posI[i], posJ[i] + 1].Tag = "1";
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
                    _Labels[posI[k] - 1, posJ[k]].Tag = "1";
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
                    _Labels[posI[k] + 1, posJ[k]].Tag = "1";
                    _Labels[posI[k], posJ[k]].Tag = "0";
                    posI[k]++;
                }
            }
        }

        public virtual Figure Turn(Label[,] _Labels, int[] posI, int[] posJ)
        {
            Figure name = new I();
            if ((posI[1] - 2) >= 0 && posI[1] + 1 <= 9 && _Labels[posI[1] - 2, posJ[1]].Tag == "0" && name.CanMoveLeft(_Labels, posI, posJ) && name.CanMoveRight(_Labels, posI, posJ))
            {
                for (int i = 0; i < 4; i++)
                {
                    _Labels[posI[i], posJ[i]].Tag = "0";
                }
                int k = posI[1] - 2;
                for (int i = 0; i < 4; i++)
                {
                    posI[i] = i + k;
                    posJ[i] = posJ[1];

                }
                name = new turnedI();
                for (int i = 0; i < 4; i++)
                {
                    _Labels[posI[i], posJ[i]].Tag = "1";
                }

            }
            return name;
        }
        public void Boom(Label[,] _Labels, int[] posI, int[] posJ)
        {
        }
    }
}
