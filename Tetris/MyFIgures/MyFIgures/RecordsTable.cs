using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MyFIgures
{
    public class RecordsTable
    {
        public void ReadTable(string[] names, string[] scores)
        {
            StreamReader streamReader = new StreamReader("Tabl.txt");
            int i = 0, j = 0, k = 0;
            while (!streamReader.EndOfStream)
            {
                if (i % 2 == 0)
                {
                    names[j] = streamReader.ReadLine();
                    j++;
                }
                else
                {
                    scores[k] = streamReader.ReadLine();
                    k++;
                }
                i++;
            }
            streamReader.Close();

        }

        public bool CanChangeTabl(string[] scores, int playerScores)
        {
            for (int i = 0; i < 5; i++)
                if (playerScores > Convert.ToInt32(scores[i]))
                    return true;
            return false;
        }

        public int GetPlayerPosition(string[] scores, int playerScores)
        {
            for (int i = 0; i < 5; i++)
                if (playerScores > Convert.ToInt32(scores[i]))
                    return i;
            return -1;
        }

        public void WriteFile(string[] names, string[] scores)
        {
            int j = 0, k = 0;
            StreamWriter writer = new StreamWriter("Tabl.txt");
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    writer.WriteLine(names[j]);
                    j++;
                }
                else
                {
                    writer.WriteLine(scores[k]);
                    k++;
                }
            }
            writer.Close();           
        }

        public void ChangeTabl(string[] names, string[] scores, string playerName, string playerScores, int playerPosition)
        {
            for (int i = 4; i > playerPosition; i--)
            {
                names[i] = names[i - 1];
                scores[i] = scores[i - 1];
            }
            names[playerPosition] = playerName;
            scores[playerPosition] = playerScores;
            WriteFile(names, scores);
        }
    }
}
