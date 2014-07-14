using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Achievments
{
    public class AchievmentsFile
    {
        public void CreateFile()
        {
            FileInfo file = new FileInfo("Achievments.bin");
            if (file.Exists == false)
            {
                file.Create();
                StreamWriter achWriter = new StreamWriter("Achievments.bin");
                for (int i = 0; i < 8; i++)
                {
                    achWriter.WriteLine(false);
                }
                achWriter.Close();
            }
        }

        public void ClearFile()
        {
            StreamWriter writer = new StreamWriter("Achievments.bin");
            for (int i = 0; i < 8; i++)
            {
                writer.WriteLine(false);
            }
            writer.Close();
        }

        public void WriteAchievments(bool[] achAreCompleted)
        {

            StreamWriter writer = new StreamWriter("Achievments.bin");
            for (int i = 0; i < 8; i++)
            {
                writer.WriteLine((achAreCompleted[i]));
            }
            writer.Close();
        }


        public void ReadAchievments(bool[] achAreCompleted)
        {
            StreamReader streamReader = new StreamReader("Achievments.bin");
            int i = 0;
            for (i = 0; i < 8; i++)
            {
                achAreCompleted[i] = Convert.ToBoolean(streamReader.ReadLine());
            }
            streamReader.Close();
        }

    }
}
