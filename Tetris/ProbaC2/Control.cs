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
            StreamReader streamReader = new StreamReader("Control.txt",Encoding.Default); 
            string str = ""; 

            while (!streamReader.EndOfStream) 
            {
                str += streamReader.ReadLine() + "\n";              
                richTextBox1.Text = str;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
