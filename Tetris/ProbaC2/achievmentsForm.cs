using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Achievments;

namespace ProbaC2
{
    public partial class achievmentsForm : Form
    {
        public AchievmentsFile achievmentsFile = new AchievmentsFile();
        public bool[] achArray = new bool[8];   

        public achievmentsForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (achArray[0])
            {
                label1.Text = "Достижение открыто! Не отчаивайтесь, возможно в следующий раз вы сможете набрать больше очков.";
            }
            else
            {
                label1.Text = "Достижение закрыто! Наберите 0 очков в одной игре, чтобы открыть это достижение.";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (achArray[1])
            {
                label1.Text = "Достижение открыто! Возможно стоит выбрать время посвободнее";
            }
            else
            {
                label1.Text = "Достижение закрыто! Используйте паузу пять раз в одной игре, чтобы открыть это достижение.";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (achArray[2])
            {
                label1.Text = "Достижение открыто! Пусть все знают кто прирожденный победитель!";
            }
            else
            {
                label1.Text = "Достижение закрыто! Займите первое место в таблице рекордов, чтобы открыть это достижение.";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (achArray[3])
            {
                label1.Text = "Достижение открыто! Иногда бывает очень сложно отказать себе в покупке.";
            }
            else
            {
                label1.Text = "Достижение закрыто! Купите 5 фигур в одной игре, чтобы открыть это достижение.";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (achArray[4])
            {
                label1.Text = "Достижение открыто! Когда взрываются бомбы, в этом нет ничего личного (Чак Паланик).";
            }
            else
            {
                label1.Text = "Достижение закрыто! Используйте 5 бомб в одной игре, чтобы открыть это достижение.";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (achArray[5])
            {
                label1.Text = "Достижение открыто! Многие люди зря не верят в колдовство :)";
            }
            else
            {
                label1.Text = "Достижение закрыто! Используйте замедление времени 5 раз в одной игре, чтобы открыть это достижение.";
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (achArray[6])
            {
                label1.Text = "Достижение открыто! Вы достигли максимальной скорости в этой игре.";
            }
            else
            {
                label1.Text = "Достижение закрыто! Достигните максимальной скорости, чтобы открыть это достижение.";
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (achArray[7])
            {
                label1.Text = "Достижение открыто! Люди всегда разрушают то, что любят больше всего.(Оскар Уайльд)";
            }
            else
            {
                label1.Text = "Достижение закрыто! Используйте уничтожение 2 рядов 5 раз в одной игре, чтобы открыть это достижение.";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label1.Text = "Ваши достижения были сброшены. Пожалуйста, перезайдите в игру.";
            achievmentsFile.ClearFile();     
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
