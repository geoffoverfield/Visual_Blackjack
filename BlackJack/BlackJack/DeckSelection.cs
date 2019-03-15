using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class DeckSelection : Form
    {
        public int iSelection;
        public DeckSelection()
        {
            InitializeComponent();
            iSelection = 0;
            loadImages();
        }

        private void loadImages()
        {
            pictureBox1.BackgroundImage = Properties.Resources.Style_1;
            pictureBox2.BackgroundImage = Properties.Resources.Style_2;
            pictureBox3.BackgroundImage = Properties.Resources.Style_3;
            pictureBox4.BackgroundImage = Properties.Resources.Style_4;
            pictureBox5.BackgroundImage = Properties.Resources.Style_5;
            pictureBox6.BackgroundImage = Properties.Resources.Style_6;
            pictureBox7.BackgroundImage = Properties.Resources.Style_7;
            pictureBox8.BackgroundImage = Properties.Resources.Style_8;
            pictureBox9.BackgroundImage = Properties.Resources.Style_9;
            pictureBox10.BackgroundImage = Properties.Resources.Style_10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) iSelection = 0;
            else if (radioButton2.Checked == true) iSelection = 1;
            else if (radioButton3.Checked == true) iSelection = 2;
            else if (radioButton4.Checked == true) iSelection = 3;
            else if (radioButton5.Checked == true) iSelection = 4;
            else if (radioButton6.Checked == true) iSelection = 5;
            else if (radioButton7.Checked == true) iSelection = 6;
            else if (radioButton8.Checked == true) iSelection = 7;
            else if (radioButton9.Checked == true) iSelection = 8;
            else if (radioButton10.Checked == true) iSelection = 9;

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            radioButton5.Checked = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            radioButton6.Checked = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            radioButton7.Checked = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            radioButton8.Checked = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            radioButton9.Checked = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            radioButton10.Checked = true;
        }
    }
}
