using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MyFIgures
{
    public class Bomb : Figure
    {
        public void GetStartPosition(Label[,] _Labels, int[] positionI, int[] positionJ)
        {
            positionJ[0] = 0;
            positionI[0] = 4;
            for (int i = 0; i < 4; i++)
            {
                positionJ[i] = 0;
                positionI[i] = i + 3;
            }
            for (int i = 1; i < 4; i++)
            {
                _Labels[positionI[i], positionJ[i]].Tag = "0";
            }
            _Labels[positionI[0], positionJ[0]].Tag = "8";
        }

        public void MoveDown(Label[,] _Labels, int[] positionI, int[] positionJ)
        {
            _Labels[positionI[0], positionJ[0]].Tag = "0";
            _Labels[positionI[0], positionJ[0] + 1].Tag = "8";
            positionJ[0]++;
        }

        public void MoveRight(Label[,] _Labels, int[] positionI, int[] positionJ)
        {
            _Labels[positionI[0] + 1, positionJ[0]].Tag = "8";
            _Labels[positionI[0], positionJ[0]].Tag = "0";
            positionI[0]++;
        }

        public void MoveLeft(Label[,] _Labels, int[] positionI, int[] positionJ)
        {
            _Labels[positionI[0] - 1, positionJ[0]].Tag = "8";
            _Labels[positionI[0], positionJ[0]].Tag = "0";
            positionI[0]--;
        }

        public bool CanMoveDown(Label[,] _Labels, int[] positionI, int[] positionJ)
        {
            if (_Labels[positionI[0], positionJ[0] + 1].Tag.ToString() == "0" && positionJ[0] < 24) return true;
            else return false;
        }

        public bool CanMoveRight(Label[,] _Labels, int[] positionI, int[] positionJ)
        {
            if (_Labels[positionI[0] + 1, positionJ[0]].Tag.ToString() == "0" && positionI[0] < 9) return true;
            else return false;
        }

        public bool CanMoveLeft(Label[,] _Labels, int[] positionI, int[] positionJ)
        {
            if (_Labels[positionI[0] - 1, positionJ[0]].Tag.ToString() == "0" && positionI[0] > 0) return true;
            else return false;
        }

        public Figure Turn(Label[,] _Labels, int[] positionI, int[] positionJ)
        {
            Figure name = new Bomb();
            return name;
        }

        public void Boom(Label[,] _Labels, int[] positionI, int[] positionJ)
        {
            if (positionJ[0] == 24 && positionI[0] == 0)
            {
                _Labels[positionI[0], positionJ[0]].Tag = "0";
                _Labels[positionI[0], positionJ[0] - 1].Tag = "0";
                _Labels[positionI[0] + 1, positionJ[0]].Tag = "0";
                _Labels[positionI[0] + 1, positionJ[0] - 1].Tag = "0";
            }
            if (positionJ[0] == 24 && positionI[0] == 9)
            {
                _Labels[positionI[0], positionJ[0]].Tag = "0";
                _Labels[positionI[0], positionJ[0] - 1].Tag = "0";
                _Labels[positionI[0] - 1, positionJ[0]].Tag = "0";
                _Labels[positionI[0] - 1, positionJ[0] - 1].Tag = "0";
            }
            if (positionJ[0] == 24 && positionI[0] != 0 && positionI[0] != 9)
            {
                _Labels[positionI[0], positionJ[0]].Tag = "0";
                _Labels[positionI[0], positionJ[0] - 1].Tag = "0";
                _Labels[positionI[0] - 1, positionJ[0]].Tag = "0";
                _Labels[positionI[0] - 1, positionJ[0] - 1].Tag = "0";
                _Labels[positionI[0] + 1, positionJ[0]].Tag = "0";
                _Labels[positionI[0] + 1, positionJ[0] - 1].Tag = "0";
            }
            if (positionJ[0] != 24 && positionI[0] == 0)
            {
                _Labels[positionI[0], positionJ[0]].Tag = "0";
                _Labels[positionI[0], positionJ[0] - 1].Tag = "0";
                _Labels[positionI[0], positionJ[0] + 1].Tag = "0";
                _Labels[positionI[0] + 1, positionJ[0]].Tag = "0";
                _Labels[positionI[0] + 1, positionJ[0] - 1].Tag = "0";
                _Labels[positionI[0] + 1, positionJ[0] + 1].Tag = "0";

            }
            if (positionJ[0] != 24 && positionI[0] == 9)
            {
                _Labels[positionI[0], positionJ[0]].Tag = "0";
                _Labels[positionI[0], positionJ[0] - 1].Tag = "0";
                _Labels[positionI[0], positionJ[0] + 1].Tag = "0";
                _Labels[positionI[0] - 1, positionJ[0]].Tag = "0";
                _Labels[positionI[0] - 1, positionJ[0] - 1].Tag = "0";
                _Labels[positionI[0] - 1, positionJ[0] + 1].Tag = "0";
            }
            if (positionJ[0] != 24 && positionI[0] != 0 && positionI[0] != 9)
            {
                _Labels[positionI[0], positionJ[0]].Tag = "0";
                _Labels[positionI[0], positionJ[0] - 1].Tag = "0";
                _Labels[positionI[0], positionJ[0] + 1].Tag = "0";
                _Labels[positionI[0] - 1, positionJ[0]].Tag = "0";
                _Labels[positionI[0] - 1, positionJ[0] - 1].Tag = "0";
                _Labels[positionI[0] - 1, positionJ[0] + 1].Tag = "0";
                _Labels[positionI[0] + 1, positionJ[0]].Tag = "0";
                _Labels[positionI[0] + 1, positionJ[0] - 1].Tag = "0";
                _Labels[positionI[0] + 1, positionJ[0] + 1].Tag = "0";
            }
        }
    }
}
