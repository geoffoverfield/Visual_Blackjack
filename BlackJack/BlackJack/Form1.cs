using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        public int bet = 0;
        public int bank = 300;
        int[] card = new int[52];
        string location = Directory.GetCurrentDirectory() + "/Cards/";
        static int [] cardNum = new int[52];
        int [] cardVal = new int[52];
        int mry1;
        int handVal1, handVal2;
        int rn1, rn2;
        Random rand = new Random();
        Image[] images = new Image[52];


        public Form1()
        {
            InitializeComponent();
        }

        void SwapImages(Image a, Image b)
        {
            Image temp;
            temp = a;
            a = b;
            b = temp;
        }

        void Shuffle()
        {
            for (int i = 0; i <= 52; i++)
            {
                int tmp;
                rn1 = rand.Next(52);
                rn2 = rand.Next(52);
                SwapImages(images[rn1], images[rn2]);
                tmp = cardNum[rn1];
                cardNum[rn1] = cardNum[rn2];
                cardNum[rn2] = cardNum[tmp];
            }

        }

        public void getCard()
        {
            for (int c = 0; c < 1; c++)
            {
                card[c] = rand.Next(0, 51);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            compCard1.Image = Image.FromFile(location + "0.png");
            compCard2.Image = Image.FromFile(location + "0.png");
            playerCard1.Image = Image.FromFile(location + "0.png");
            playerCard2.Image = Image.FromFile(location + "0.png");
            Shuffle();
            //playerCard3.Enabled = false;
            //playerCard4.Enabled = false;
            //playerCard5.Enabled = false;
            if (handVal2 >= 16)
            {
                compCard3.Enabled = false;
                compCard4.Enabled = false;
                compCard5.Enabled = false;
            }
        }

        private void btnBetPlus_Click(object sender, EventArgs e)
        {
            bet = bet + 15;
        }

        private void btnBetMinus_Click(object sender, EventArgs e)
        {
            bet = bet - 15;
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            bank = bank - bet;
            lblPot.Text = bank.ToString();
            lblBank.Text = bank.ToString();
            for (int i = 0; i < 4; i++)
            {
                card[i] = cardNum[rand.Next(1,52)];
            }
            playerCard1.Image = Image.FromFile(location + card[0] + ".png");
            playerCard2.Image = Image.FromFile(location + card[1] + ".png");
            playerCard3.Enabled = true;

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            compCard5.Image = Image.FromFile(location + "egg.jpg");
            MessageBox.Show("You found the Black Jack Easter Egg!!  Congrats on spending too much time in this game!!  Here's a little reward...");
            bank = bank + 500;
            lblBank.Text = bank.ToString();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            

        }
    }
}
