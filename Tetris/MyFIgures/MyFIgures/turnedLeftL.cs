using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MyFIgures
{
    public class turnedLeftL : L
    {
        public override Figure Turn(Label[,] _Labels, int[] posI, int[] posJ)
        {
            Figure name = new turnedLeftL();
            int positionI = posI[1], positionJ = posJ[1];
            if (positionI - 1 >= 0)
            {
                if (name.CanMoveLeft(_Labels, posI, posJ))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        _Labels[posI[i], posJ[i]].Tag = "0";
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        posI[i] = positionI - 1 + i;
                        posJ[i] = positionJ;
                    }
                    posI[3] = positionI - 1;
                    posJ[3] = positionJ + 1;
                    name = new L();
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
            for (int i = 2; i < 4; i++)
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
            for (int i = 0; i < 3; i++)
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
                if (i == 2) continue;
                if (_Labels[posI[i] + 1, posJ[i]].Tag == "0")
                {

                    key = true;
                }
                else return false;
            }
            return key;
        }
    }
}
