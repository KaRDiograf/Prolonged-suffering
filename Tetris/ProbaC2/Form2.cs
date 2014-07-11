using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyFIgures;
using System.IO;

namespace ProbaC2
{
    public partial class Form2 : Form
    {
        string[] names = new string[5];
        string[] scores = new string[5];
        RecordsTable recTable = new RecordsTable();

        public void ShowTable(string[] names, string[] scores)
        {
            Tabl table = new Tabl(names, scores);
            table.ShowDialog();
        }

        public Form2()
        {
            InitializeComponent();
            Form1 mainForm = new Form1();
            mainForm.playerName = textBox1.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LRecords_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("Tabl.txt");
            if (file.Exists == false)
            {
                file.Create();
            }
            recTable.ReadTable(names, scores);
            ShowTable(names, scores);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

   
    }
}
