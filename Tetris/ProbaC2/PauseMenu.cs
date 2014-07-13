using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProbaC2
{
    public partial class PauseMenu : Form
    {
        public figureChoice choice = new figureChoice();
        public achievmentsForm achForm = new achievmentsForm();
        Control control = new Control();

        public PauseMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            choice.ShowDialog(); 
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            achForm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            control.ShowDialog();
        }
    }
}
