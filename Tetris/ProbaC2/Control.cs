using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ProbaC2
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();           
        }

        private void Control_Load(object sender, EventArgs e)
        {         
            FileInfo file = new FileInfo("Control.txt");
            if (!file.Exists)
            {
                file.Create();
            }
            StreamReader streamReader = new StreamReader("Control.txt",Encoding.Default); //Открываем файл для чтения
            string str = ""; //Объявляем переменную, в которую будем записывать текст из файла

            while (!streamReader.EndOfStream) //Цикл длиться пока не будет достигнут конец файла
            {
                str += streamReader.ReadLine() + "\n"; //В переменную str по строчно записываем содержимое файла             
                richTextBox1.Text = str;
            }
        }

       
    }
}
