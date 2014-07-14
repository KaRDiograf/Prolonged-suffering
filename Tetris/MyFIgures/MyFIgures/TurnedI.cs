using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MyFIgures
{
    public class turnedI: I
    {
        public override Figure Turn(Label[,] _Labels, int[] posI, int[] posJ)
        {
            Figure name = new turnedI();
            if ((posJ[1] - 1) >= 0 && posJ[1] + 2 <= 24)
                if (_Labels[posI[1], posJ[1] - 1].Tag == "0" && _Labels[posI[1], posJ[1] + 2].Tag == "0" && name.CanMoveDown(_Labels, posI, posJ))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        _Labels[posI[i], posJ[i]].Tag = "0";
                    }
                    int k = posJ[1] - 1;
                    for (int i = 0; i < 4; i++)
                    {
                        posJ[i] = i + k;
                        posI[i] = posI[2];
                    }

                    name = new I();
                    for (int i = 0; i < 4; i++)
                    {
                        _Labels[posI[i], posJ[i]].Tag = "1";
                    }

                }
            return name;
        }

        public override bool CanMoveDown(Label[,] _Labels, int[] posI, int[] posJ)
        {
            bool key = true;
            for (int i = 0; i < 4; i++)
            {
                if (_Labels[posI[i], posJ[i] + 1].Tag == "0")
                    key = true;
                else return false;
            }
            return key;
        }

        public override bool CanMoveLeft(Label[,] _Labels, int[] posI, int[] posJ)
        {
            if (_Labels[posI[0] - 1, posJ[0]].Tag == "0") return true;
            else return false;
        }

        public override bool CanMoveRight(Label[,] _Labels, int[] posI, int[] posJ)
        {
            if (_Labels[posI[3] + 1, posJ[0]].Tag == "0") return true;
            else return false;
        }
    }
}
