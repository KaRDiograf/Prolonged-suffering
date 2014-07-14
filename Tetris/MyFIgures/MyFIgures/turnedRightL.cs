using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MyFIgures
{
    public class turnedRightL : L
    {
        public override Figure Turn(Label[,] _Labels, int[] posI, int[] posJ)
        {
            Figure name = new turnedRightL();

            int positionI = posI[2], positionJ = posJ[2];
            if (positionI + 1 < 10)
            {
                if (name.CanMoveRight(_Labels, posI, posJ))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        _Labels[posI[i], posJ[i]].Tag = "0";
                    }
                    for (int i = 1; i < 4; i++)
                    {
                        posI[i] = positionI - 2 + i;
                        posJ[i] = positionJ;
                    }
                    posI[0] = positionI + 1;
                    posJ[0] = positionJ - 1;
                    name = new turnedOverL();
                    for (int i = 0; i < 4; i++)
                    {
                        _Labels[posI[i], posJ[i]].Tag = "3";
                    }
                }
            }
            return name;
        }

        public override bool CanMoveDown(Label[,] _Labels, int[] posI, int[] posJ)
        {
            bool key = true;
            for (int i = 0; i < 4; i++)
            {
                if (i == 1 || i == 2) continue;
                if (_Labels[posI[i], posJ[i] + 1].Tag == "0")
                    key = true;
                else return false;
            }
            return key;
        }

        public override bool CanMoveLeft(Label[,] _Labels, int[] posI, int[] posJ)
        {
            bool key = true;
            for (int i = 0; i < 4; i++)
            {
                if (i == 1) continue;
                if (_Labels[posI[i] - 1, posJ[i]].Tag == "0")
                    key = true;
                else return false;
            }
            return key;
        }

        public override bool CanMoveRight(Label[,] _Labels, int[] posI, int[] posJ)
        {
            bool key = true;
            for (int i = 1; i < 4; i++)
            {
                if (_Labels[posI[i] + 1, posJ[i]].Tag == "0")
                    key = true;
                else return false;
            }
            return key;
        }
    }
}
