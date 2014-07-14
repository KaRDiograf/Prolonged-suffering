using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MyFIgures
{
    public class turnedOverT : T
    {
        public override Figure Turn(Label[,] _Labels, int[] posI, int[] posJ)
        {
            Figure name = new turnedOverT();
            int positionI = posI[2], positionJ = posJ[2];
            if (positionJ - 1 >= 0)
            {
                if (name.CanMoveDown(_Labels, posI, posJ))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        _Labels[posI[i], posJ[i]].Tag = "0";
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        posJ[i] = positionJ - 1 + i;
                        posI[i] = positionI;
                    }
                    posJ[3] = positionJ;
                    posI[3] = positionI + 1;
                    name = new turnedLeftT();
                    for (int i = 0; i < 4; i++)
                    {
                        _Labels[posI[i], posJ[i]].Tag = "6";
                    }
                }
            }
            return name;
        }

        public override bool CanMoveDown(Label[,] _Labels, int[] posI, int[] posJ)
        {
            bool key = true;
            for (int i = 1; i < 4; i++)
            {
                if (_Labels[posI[i], posJ[i] + 1].Tag == "0")
                    key = true;
                else return false;
            }
            return key;
        }

        public override bool CanMoveLeft(Label[,] _Labels, int[] posI, int[] posJ)
        {
            bool key = true;
            for (int i = 0; i < 2; i++)
            {
                if (_Labels[posI[i] - 1, posJ[i]].Tag == "0")
                    key = true;
                else return false;
            }
            return key;
        }

        public override bool CanMoveRight(Label[,] _Labels, int[] posI, int[] posJ)
        {
            bool key = true;
            for (int i = 0; i < 4; i++)
            {
                if (i == 1 || i == 2) continue;
                if (_Labels[posI[i] + 1, posJ[i]].Tag == "0")
                    key = true;
                else return false;
            }
            return key;
        }
    }
}
