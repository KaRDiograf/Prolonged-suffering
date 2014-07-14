using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MyFIgures
{
    public class turnedS : S
    {
        public override Figure Turn(Label[,] _Labels, int[] posI, int[] posJ)
        {
            Figure name = new turnedS();
            int positionI = posI[2], positionJ = posJ[2];
            if (positionI + 1 <= 9 && name.CanMoveRight(_Labels, posI, posJ))
            {
                for (int i = 0; i < 4; i++)
                {
                    _Labels[posI[i], posJ[i]].Tag = "0";
                }
                for (int i = 0; i < 2; i++)
                {
                    posJ[i] = positionJ;
                    posI[i] = i + positionI;
                }
                for (int i = 2; i < 4; i++)
                {
                    posJ[i] = 1 + positionJ;
                    posI[i] = i + positionI - 3;
                }
                for (int i = 0; i < 4; i++)
                {
                    _Labels[posI[i], posJ[i]].Tag = "4";
                }
                name = new S();
            }
            return name;
        }


        public override bool CanMoveDown(Label[,] _Labels, int[] posI, int[] posJ)
        {
            bool key = true;
            for (int i = 0; i < 4; i++)
            {
                if (i == 0 || i == 2) continue;
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
                if (i == 2) continue;
                if (_Labels[posI[i] - 1, posJ[i]].Tag == "0")
                {

                    key = true;
                }
                else return false;
            }
            return key;
        }

        public override bool CanMoveRight(Label[,] _Labels, int[] posI, int[] posJ)
        {
            bool key = true;
            for (int i = 0; i < 4; i++)
            {
                if (i == 1) continue;
                if (_Labels[posI[i] + 1, posJ[i]].Tag == "0")
                    key = true;
                else return false;
            }
            return key;
        }
    }
}
