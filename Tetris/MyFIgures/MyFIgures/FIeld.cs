using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MyFIgures
{
    public class Field
    {
        public bool CanRemoveLine(Label[,] _Labels)
        {
            bool key = false;
            for (int i = 0; i <= 24; i++)
            {
                key = false;
                for (int j = 0; j < 10; j++)
                {
                    if (_Labels[j, i].Tag != "0") key = true;
                    else
                    {
                        key = false;
                        break;
                    }
                }
                if (key) return true;
            }

            return false;
        }

        public int GetNumberOfLine(Label[,] _Labels)
        {
            bool key = false;
            for (int i = 0; i <= 24; i++)
            {
                key = false;
                for (int j = 0; j < 10; j++)
                {
                    if (_Labels[j, i].Tag != "0") key = true;
                    else
                    {
                        key = false;
                        break;
                    }
                }
                if (key) return i;
            }

            return -1;
        }

        public void RemoveLine(Label[,] _Labels, int numberOfLine)
        {
            
            for (int i = numberOfLine; i > 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    _Labels[j, i].Tag = _Labels[j, i - 1].Tag;
                }
            }
            for (int j = 0; j < 10; j++)
            {
                _Labels[j, 0].Tag = "0";
            }
        }

        public void Draw(Label[,] _Lab)
        {

            for (int i = 0; i < _Lab.GetLength(0); i++)
                for (int j = 0; j < _Lab.GetLength(1); j++)
                    switch (_Lab[i, j].Tag.ToString())
                    {
                        case "0":
                            {
                                _Lab[i, j].BackColor = Color.White;
                                break;
                            }
                        case "1":
                            {
                                _Lab[i, j].BackColor = Color.Blue;
                                break;
                            }
                        case "2":
                            {
                                _Lab[i, j].BackColor = Color.LightGreen;
                                break;
                            }
                        case "3":
                            {
                                _Lab[i, j].BackColor = Color.Gold;
                                break;
                            }
                        case "4":
                            {
                                _Lab[i, j].BackColor = Color.Aqua;
                                break;
                            }
                        case "5":
                            {
                                _Lab[i, j].BackColor = Color.Violet;
                                break;
                            }
                        case "6":
                            {
                                _Lab[i, j].BackColor = Color.Green;
                                break;
                            }
                        case "7":
                            {
                                _Lab[i, j].BackColor = Color.Red;
                                break;
                            }
                        case "8":
                            {
                                _Lab[i, j].BackColor = Color.Black;
                                break;

                            }
                    }
                    /*if (_Lab[i, j].Tag == "0")
                    {
                        _Lab[i, j].BackColor = Color.White;
                    }
                    else
                    {
                        _Lab[i, j].BackColor = Color.Blue;
                    }
                      */
        }

        public void Clear(Label[,] _Lab)
        {
            for (int i = 0; i < _Lab.GetLength(0); i++)
                for (int j = 0; j < _Lab.GetLength(1); j++)
                    _Lab[i,j].Tag = "0";
        }
    }
}
