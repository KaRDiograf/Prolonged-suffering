using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MyFIgures
{
    public interface Figure
    {
        void GetStartPosition(Label[,] _Labels, int[] posI, int[] posJ);
        bool CanMoveDown(Label[,] _Labels, int[] posI, int[] posJ);
        bool CanMoveLeft(Label[,] _Labels, int[] posI, int[] posJ);
        bool CanMoveRight(Label[,] _Labels, int[] posI, int[] posJ);
        void MoveDown(Label[,] _Labels, int[] posI, int[] posJ);
        void MoveLeft(Label[,] _Labels, int[] posI, int[] posJ);
        void MoveRight(Label[,] _Labels, int[] posI, int[] posJ);
        Figure Turn(Label[,] _Labels, int[] posI, int[] posJ);
        void Boom(Label[,] _Labels, int[] posI, int[] posJ);
    }
}
