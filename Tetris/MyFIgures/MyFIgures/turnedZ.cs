using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MyFIgures
{
    public class turnedZ : Z
    {
        public override Figure Turn(Label[,] _Labels, int[] posI, int[] posJ)
        {
            Figure name = new turnedZ();
            int positionI = posI[1] - 4, positionJ = posJ[1] - 2;
            if (positionI + 3 >= 0 && name.CanMoveLeft(_Labels, posI, posJ))
            {
                for (int i = 0; i < 4; i++)
                {
                    _Labels[posI[i], posJ[i]].Tag = "0";
                }
                for (int i = 0; i < 2; i++)
                {
                    posJ[i] = 0 + positionJ;
                    posI[i] = i + 3 + positionI;
                }
                for (int i = 2; i < 4; i++)
                {
                    posJ[i] = 1 + positionJ;
                    posI[i] = i + 2 + positionI;
                }
                for (int i = 0; i < 4; i++)
                {
                    _Labels[posI[i], posJ[i]].Tag = "5";
                }
                name = new Z();
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
