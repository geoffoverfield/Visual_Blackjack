// Geoff Overfield
// Basic Blackjack card game

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace BlackJack
{
    public partial class BlackjackTable : Form
    {
        public enum CardValue
        {
            None = 0,
            _Ace = 1 | 11,
            _2 = 2,
            _3 = 3,
            _4 = 4,
            _5 = 5,
            _6 = 6,
            _7 = 7,
            _8 = 8,
            _9 = 9,
            _10 = 10,
            _Jack = 10,
            _Queen = 10,
            _King = 10
        }
        public enum Player { Dealer, Player };

        public enum Winner { Dealer, Player, Push };

        const int BET = 5;

        Image[] arCardImages;
        Image[] arCardStyles;
        Image pCardStyle;
        Dictionary<string, CardValue> dCardValues;
        Dictionary<string, bool> dCardUsed;
        Dictionary<string, Image> dCardImages;

        List<PictureBox> lCardsCreated;

        List<string> lCardNames;
        Player pTurn;

        Hand DealerHand;
        Hand CurrentPlayerHand;
        List<Hand> lPlayerHands;
        int iWinTimer, iShuffleCount;
        bool bChangeColorsOnWin = false;
        bool bPlayerHasSplit = false;
        bool bDealerHasGone = false;

        Random pRandom;
        int iRand1, iRand2, iBank, iBet, iTimer, iCardsUsed;

        public BlackjackTable()
        {
            InitializeComponent();
            initializeLists();
            getCards();

            pTurn = Player.Player;
            iBank = 250;

            pRandom = new Random();
            selectDeck();
            updateBank(false);
        }

        private bool blackjack(Hand pHand)
        {
            return pHand.HandValue == 21;
        }

        private bool bust(Hand pHand)
        {
            return pHand.HandValue > 21;
        }

        private void checkWinConditions()
        {
            bool bGameOver = false;
            switch (pTurn)
            {
                case Player.Player:
                    bool bFinalHand = CurrentPlayerHand == lPlayerHands.Last();

                    foreach (Hand pHand in lPlayerHands)
                    {
                        if (bust(pHand))
                        {
                            pHand.HandWinner = Winner.Dealer;
                            if (bFinalHand) bGameOver = true;
                        }
                    }

                    if (bGameOver && bDealerHasGone) gameOver();
                    else if (bFinalHand && bGameOver)
                    {
                        pTurn = Player.Dealer;
                        dealersTurn();
                    }

                    break;
                case Player.Dealer:
                    foreach (Hand pHand in lPlayerHands)
                    {
                        if (bust(DealerHand) || (pHand.HandValue > DealerHand.HandValue && !bust(pHand)))
                            pHand.HandWinner = Winner.Player;
                        else if (push(pHand, DealerHand))
                            pHand.HandWinner = Winner.Push;
                        else if (pHand.HandValue < DealerHand.HandValue || bust(pHand))
                            pHand.HandWinner = Winner.Dealer;
                    }

                    gameOver();
                    break;
            }
        }

        private PictureBox createNewCardHolder()
        {
            Padding pMargin = new Padding(15);
            Size pSize = new Size(184, 254);
            Color pBackColor = Color.Transparent;
            var fCardLoc = getCardLocation();

            PictureBox pReturn = new PictureBox()
            {
                Margin = pMargin,
                Size = pSize,
                Visible = true,
                BackColor = pBackColor,
                BackgroundImageLayout = ImageLayout.Zoom,
                BorderStyle = BorderStyle.Fixed3D,
                Location = fCardLoc,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            return pReturn;
        }

        private void deal()
        {
            if (iCardsUsed > 45) Shuffle();

            Hand pPlayerHand = new Hand(iBet);
            DealerHand = new Hand(iBet);
            // Get Player Cards
            pPlayerHand.AddCard(getNextCard());
            pPlayerHand.AddCard(getNextCard());
            CurrentPlayerHand = pPlayerHand;
            lPlayerHands.Add(pPlayerHand);
            // Get Dealer Cards
            DealerHand.AddCard(getNextCard());
            DealerHand.AddCard(getNextCard());

            pbDealer1.BackgroundImage = pCardStyle;
            pbDealer2.BackgroundImage = dCardImages[DealerHand.Cards[1].CardName];

            pbPlayer1.BackgroundImage = dCardImages[pPlayerHand.Cards[0].CardName];
            pbPlayer2.BackgroundImage = dCardImages[pPlayerHand.Cards[1].CardName];

            if (blackjack(CurrentPlayerHand))
            {
                if (push(CurrentPlayerHand, DealerHand))
                    CurrentPlayerHand.HandWinner = Winner.Push;
                else
                {
                    CurrentPlayerHand.HandWinner = Winner.Player;
                    CurrentPlayerHand.Blackjack();
                }

                gameOver();
            }

            if (splitAvailable(pPlayerHand.Cards[0].CardName, pPlayerHand.Cards[1].CardName))
                btnSplit.Visible = true;
            else btnSplit.Visible = false;
        }

        public void dealersTurn()
        {
            bDealerHasGone = true;
            while (DealerHand.HandValue < 17)
            {
                var pNewCardBox = createNewCardHolder();
                pNewCardBox.Parent = this;
                pNewCardBox.BringToFront();
                lCardsCreated.Add(pNewCardBox);

                var pCard = getNextCard();
                DealerHand.AddCard(pCard);
                pNewCardBox.BackgroundImage = pCard.CardImage;
                this.Update();
            }

            checkWinConditions();
        }

        private void displayWinner(Hand pHand)
        {
            string sWinMsg;
            iWinTimer = 15;

            switch (pHand.HandWinner)
            {
                case Winner.Player:
                    sWinMsg = "Player Wins!";
                    bChangeColorsOnWin = true;
                    break;
                case Winner.Dealer:
                    sWinMsg = "Dealer Wins";
                    break;
                case Winner.Push:
                default:
                    sWinMsg = "Push";
                    break;
            }

            lblWinner.Text = sWinMsg;
            lblWinner.Visible = true;
            pWinTimer.Enabled = true;
            pWinTimer.Start();
        }

        private void gameOver()
        {
            pbDealer1.BackgroundImage = DealerHand.Cards[0].CardImage;
            btnDeal.Enabled = btnHit.Enabled = btnStay.Enabled = false;
            this.Update();
            foreach (Hand pHand in lPlayerHands)
            {
                bChangeColorsOnWin = pHand.HandWinner == Winner.Player;
                displayWinner(pHand);
                updateBank(true, pHand);
                if (pHand == lPlayerHands.Last())
                    Task.Delay(6000);
            }
        }

        private Point getCardLocation()
        {
            int fX, fY, iCardsAfterDeal;
            fX = fY = iCardsAfterDeal = 0;

            switch (pTurn)
            {
                case Player.Player:
                    fY = 536;
                    iCardsAfterDeal = CurrentPlayerHand.Cards.Count - 1;

                    if (!bPlayerHasSplit)
                    {
                        fX = 282 + (99 * iCardsAfterDeal);
                    }
                    else
                    {
                        if (CurrentPlayerHand == lPlayerHands[0])
                            fX = 282 + (99 * iCardsAfterDeal);
                        else
                        {
                            iCardsAfterDeal += 1;
                            fX = 720 + (99 * iCardsAfterDeal);
                        }
                    }
                    break;
                case Player.Dealer:
                    fY = 28;
                    iCardsAfterDeal = DealerHand.Cards.Count - 1;
                    fX = 282 + (99 * iCardsAfterDeal);
                    break;
            }

            return new Point(fX, fY);
        }

        private void getCards()
        {
            int i = 0;

            #region Cards
            arCardImages[i++] = Properties.Resources.Clubs_Ace;
            arCardImages[i++] = Properties.Resources.Clubs_2;
            arCardImages[i++] = Properties.Resources.Clubs_3;
            arCardImages[i++] = Properties.Resources.Clubs_4;
            arCardImages[i++] = Properties.Resources.Clubs_5;
            arCardImages[i++] = Properties.Resources.Clubs_6;
            arCardImages[i++] = Properties.Resources.Clubs_7;
            arCardImages[i++] = Properties.Resources.Clubs_8;
            arCardImages[i++] = Properties.Resources.Clubs_9;
            arCardImages[i++] = Properties.Resources.Clubs_10;
            arCardImages[i++] = Properties.Resources.Clubs_Jack;
            arCardImages[i++] = Properties.Resources.Clubs_Queen;
            arCardImages[i++] = Properties.Resources.Clubs_King;
            arCardImages[i++] = Properties.Resources.Diamonds_Ace;
            arCardImages[i++] = Properties.Resources.Diamonds_2;
            arCardImages[i++] = Properties.Resources.Diamonds_3;
            arCardImages[i++] = Properties.Resources.Diamonds_4;
            arCardImages[i++] = Properties.Resources.Diamonds_5;
            arCardImages[i++] = Properties.Resources.Diamonds_6;
            arCardImages[i++] = Properties.Resources.Diamonds_7;
            arCardImages[i++] = Properties.Resources.Diamonds_8;
            arCardImages[i++] = Properties.Resources.Diamonds_9;
            arCardImages[i++] = Properties.Resources.Diamonds_10;
            arCardImages[i++] = Properties.Resources.Diamonds_Jack;
            arCardImages[i++] = Properties.Resources.Diamonds_Queen;
            arCardImages[i++] = Properties.Resources.Diamonds_King;
            arCardImages[i++] = Properties.Resources.Hearts_Ace;
            arCardImages[i++] = Properties.Resources.Hearts_2;
            arCardImages[i++] = Properties.Resources.Hearts_3;
            arCardImages[i++] = Properties.Resources.Hearts_4;
            arCardImages[i++] = Properties.Resources.Hearts_5;
            arCardImages[i++] = Properties.Resources.Hearts_6;
            arCardImages[i++] = Properties.Resources.Hearts_7;
            arCardImages[i++] = Properties.Resources.Hearts_8;
            arCardImages[i++] = Properties.Resources.Hearts_9;
            arCardImages[i++] = Properties.Resources.Hearts_10;
            arCardImages[i++] = Properties.Resources.Hearts_Jack;
            arCardImages[i++] = Properties.Resources.Hearts_Queen;
            arCardImages[i++] = Properties.Resources.Hearts_King;
            arCardImages[i++] = Properties.Resources.Spades_Ace;
            arCardImages[i++] = Properties.Resources.Spades_2;
            arCardImages[i++] = Properties.Resources.Spades_3;
            arCardImages[i++] = Properties.Resources.Spades_4;
            arCardImages[i++] = Properties.Resources.Spades_5;
            arCardImages[i++] = Properties.Resources.Spades_6;
            arCardImages[i++] = Properties.Resources.Spades_7;
            arCardImages[i++] = Properties.Resources.Spades_8;
            arCardImages[i++] = Properties.Resources.Spades_9;
            arCardImages[i++] = Properties.Resources.Spades_10;
            arCardImages[i++] = Properties.Resources.Spades_Jack;
            arCardImages[i++] = Properties.Resources.Spades_Queen;
            arCardImages[i++] = Properties.Resources.Spades_King;

            #endregion

            #region Card Styles
            i = 0;
            arCardStyles[i++] = Properties.Resources.Style_1;
            arCardStyles[i++] = Properties.Resources.Style_2;
            arCardStyles[i++] = Properties.Resources.Style_3;
            arCardStyles[i++] = Properties.Resources.Style_4;
            arCardStyles[i++] = Properties.Resources.Style_5;
            arCardStyles[i++] = Properties.Resources.Style_6;
            arCardStyles[i++] = Properties.Resources.Style_7;
            arCardStyles[i++] = Properties.Resources.Style_8;
            arCardStyles[i++] = Properties.Resources.Style_9;
            arCardStyles[i++] = Properties.Resources.Style_10;
            #endregion

            i = 0;
            foreach (var pCard in arCardImages)
            {
                string sCard = lCardNames[i++];

                pCard.Tag = sCard;
                string[] arCard = pCard.Tag.ToString().Split('_');

                CardValue eVal = CardValue.None;
                Enum.TryParse(arCard[1], out eVal);
                dCardValues.Add(sCard, eVal);
                dCardUsed.Add(sCard, false);
                dCardImages.Add(sCard, pCard);
            }

            iCardsUsed = 52;
        }

        private Card getNextCard()
        {
            bool bUsed = true;
            Card pCard = null;
            do
            {
                int iCardNum = pRandom.Next(0, lCardNames.Count);
                string sCardName = lCardNames[iCardNum];
                bUsed = dCardUsed[sCardName];

                if (!bUsed)
                {
                    pCard = new Card(dCardImages[sCardName], sCardName, dCardValues[sCardName]);
                    dCardUsed[sCardName] = true;
                }

            } while (bUsed);
            iCardsUsed++;

            return pCard;
        }

        private void initializeLists()
        {
            arCardImages = new Image[52];
            arCardStyles = new Image[10];
            dCardValues = new Dictionary<string, CardValue>();
            dCardUsed = new Dictionary<string, bool>();
            dCardImages = new Dictionary<string, Image>();
            lPlayerHands = new List<Hand>();
            lCardsCreated = new List<PictureBox>();

            lCardNames = new List<string>()
            {
                "Clubs_Ace",
                "Clubs_2",
                "Clubs_3",
                "Clubs_4",
                "Clubs_5",
                "Clubs_6",
                "Clubs_7",
                "Clubs_8",
                "Clubs_9",
                "Clubs_10",
                "Clubs_Jack",
                "Clubs_Queen",
                "Clubs_King",
                "Diamonds_Ace",
                "Diamonds_2",
                "Diamonds_3",
                "Diamonds_4",
                "Diamonds_5",
                "Diamonds_6",
                "Diamonds_7",
                "Diamonds_8",
                "Diamonds_9",
                "Diamonds_10",
                "Diamonds_Jack",
                "Diamonds_Queen",
                "Diamonds_King",
                "Hearts_Ace",
                "Hearts_2",
                "Hearts_3",
                "Hearts_4",
                "Hearts_5",
                "Hearts_6",
                "Hearts_7",
                "Hearts_8",
                "Hearts_9",
                "Hearts_10",
                "Hearts_Jack",
                "Hearts_Queen",
                "Hearts_King",
                "Spades_Ace",
                "Spades_2",
                "Spades_3",
                "Spades_4",
                "Spades_5",
                "Spades_6",
                "Spades_7",
                "Spades_8",
                "Spades_9",
                "Spades_10",
                "Spades_Jack",
                "Spades_Queen",
                "Spades_King"
            };
        }

        private void moveEasterEgg()
        {
            pbEasterEgg.Location = new Point(pRandom.Next(0, this.Width), pRandom.Next(0, this.Height));
        }

        private bool push(Hand pPlayerHand, Hand pDealerHand)
        {
            return pPlayerHand.HandValue == pDealerHand.HandValue;
        }

        private void selectDeck()
        {
            DeckSelection pDeckDlg = new DeckSelection();
            pDeckDlg.ShowDialog();

            pCardStyle = arCardStyles[pDeckDlg.iSelection];
        }

        private void Shuffle()
        {
            iShuffleCount = 0;
            lblWinner.Text = "Shuffling Cards";
            pShuffleTimer.Enabled = true;
            pShuffleTimer.Start();
            lblWinner.Visible = true;
        }

        private bool splitAvailable(string sCard1, string sCard2)
        {
            var arCard1 = sCard1.Split('_');
            var arCard2 = sCard2.Split('_');
            return arCard1[1] == arCard2[1];
        }

        private void swapCards(ref List<string> lCardNames, int iCard1, int iCard2)
        {
            string sCard1 = lCardNames[iCard1];
            string sCard2 = lCardNames[iCard2];

            lCardNames[iCard1] = sCard2;
            lCardNames[iCard2] = sCard1;
        }

        private void swapImages(ref Image a, ref Image b)
        {
            Image temp = a;
            a = b;
            b = temp;
        }

        private void updateBank(bool bEndOfGame, Hand pHand = null)
        {
            if (bEndOfGame)
            {
                if (pHand.HandWinner == Winner.Player)
                    iBank += pHand.HandBet;
                else if (pHand.HandWinner == Winner.Dealer)
                    iBank -= pHand.HandBet;
                else if (pHand.HandWinner == Winner.Push)
                { /* Do nothing */ }
            }

            lblBank.Text = "Bank: $" + iBank.ToString();
        }

        #region Event Handlers
        private void btnDeal_Click(object sender, EventArgs e)
        {
            if (iBet == 0)
            {
                MessageBox.Show("Must place bet first - $15 minimum");
                return;
            }

            pTurn = Player.Player;
            deal();

            btnHit.Enabled = btnStay.Enabled = true;
            btnBet_Increase.Enabled = btnBet_Decrease.Enabled = false;
        }

        private void btnBet_Decrease_Click(object sender, EventArgs e)
        {
            iBet -= BET;
            lblBet.Text = "Bet: $" + iBet.ToString();
        }

        private void btnBet_Increase_Click(object sender, EventArgs e)
        {
            iBet += BET;
            lblBet.Text = "Bet: $" + iBet.ToString();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            bPlayerHasSplit = true;
            pbPlayer2.Location = new Point(720, 536);
            Card[] pPlayerCards = CurrentPlayerHand.Cards.ToArray();

            CurrentPlayerHand.Cards.Remove(pPlayerCards[1]);
            Hand pPlayerHand2 = new Hand(iBet);
            pPlayerHand2.AddCard(pPlayerCards[1]);

            lPlayerHands.Add(pPlayerHand2);
            CurrentPlayerHand = lPlayerHands[0];

            btnHit_Click(sender, e);
            btnSplit.Visible = false;
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            var pNewCardBox = createNewCardHolder();
            pNewCardBox.Parent = this;
            pNewCardBox.BringToFront();
            lCardsCreated.Add(pNewCardBox);

            var pCard = getNextCard();
            CurrentPlayerHand.AddCard(pCard);
            pNewCardBox.BackgroundImage = pCard.CardImage;
            this.Update();

            checkWinConditions();
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            if (!bPlayerHasSplit)
            {
                pTurn = Player.Dealer;
                dealersTurn();
            }
            else
            {
                if (CurrentPlayerHand == lPlayerHands[0])
                {
                    CurrentPlayerHand = lPlayerHands[1];
                    btnHit_Click(sender, e);
                }
                else checkWinConditions();
            }
        }

        private void pEasterEggTimer_Tick(object sender, EventArgs e)
        {
            if (iTimer < 5)
                iTimer++;
            else
            {
                pbEasterEgg.BackgroundImage = null;
                pEasterEggTimer.Stop();
                pEasterEggTimer.Enabled = false;
                iTimer = 0;
                moveEasterEgg();
                updateBank(false);
            }
        }

        private void pWinTimer_Tick(object sender, EventArgs e)
        {
            Color pColor = Color.Black;
            if (iWinTimer > 0)
            {
                if (bChangeColorsOnWin)
                {
                    int a, r, g, b;
                    a = pRandom.Next(0, 255);
                    r = pRandom.Next(0, 255);
                    g = pRandom.Next(0, 255);
                    b = pRandom.Next(0, 255);

                    pColor = Color.FromArgb(a, r, g, b);
                    lblWinner.ForeColor = pColor;
                }
                iWinTimer--;
            }
            else
            {
                foreach (var pCard in lCardsCreated) pCard.Dispose();
                pbDealer1.BackgroundImage = pbDealer2.BackgroundImage = pbPlayer1.BackgroundImage = pbPlayer2.BackgroundImage = null;

                lblWinner.ForeColor = pColor;
                lCardsCreated.Clear();
                lPlayerHands.Clear();
                DealerHand = null;

                lblWinner.Visible = btnSplit.Visible = pWinTimer.Enabled = btnHit.Enabled = btnStay.Enabled = false;
                btnDeal.Enabled = btnBet_Decrease.Enabled = btnBet_Increase.Enabled = true;
                pWinTimer.Stop();
                this.Update();
            }
        }

        private void pShuffleTimer_Tick(object sender, EventArgs e)
        {
            int a, r, g, b;
            a = pRandom.Next(0, 255);
            r = pRandom.Next(0, 255);
            g = pRandom.Next(0, 255);
            b = pRandom.Next(0, 255);

            if (iShuffleCount < 3)
            {
                for (int i = 0; i <= 52; i++)
                {
                    iRand1 = pRandom.Next(52);
                    iRand2 = pRandom.Next(52);
                    swapImages(ref arCardImages[iRand1], ref arCardImages[iRand2]);
                    swapCards(ref lCardNames, iRand1, iRand2);
                }
                iShuffleCount++;
                Color pColor = Color.FromArgb(a, r, g, b);
                lblWinner.ForeColor = pColor;
            }
            else
            {
                foreach (var pCard in lCardNames)
                    dCardUsed[pCard] = false;
                iCardsUsed = 0;

                lblWinner.ForeColor = Color.Black;
                lblWinner.Visible = false;
                pShuffleTimer.Stop();
                pShuffleTimer.Enabled = false;
            }

        }

        private void pbEasterEgg_Click(object sender, EventArgs e)
        {
            iBank += 100;
            pbEasterEgg.BackgroundImage = Properties.Resources.EasterEgg;
            pEasterEggTimer.Enabled = true;
            pEasterEggTimer.Start();
        }

        #endregion
    }

    public class Card
    {
        public Image CardImage { get; set; }
        public string CardName { get; set; }
        public int CardValue { get; private set; }

        public Card(Image pCardImg, string sCardName, BlackjackTable.CardValue eVal)
        {
            CardImage = pCardImg;
            CardName = sCardName;
            CardValue = (int)eVal;
        }

        public void SetCardValue(BlackjackTable.CardValue eVal, int iHandVal)
        {
            if (eVal == BlackjackTable.CardValue._Ace)
            {
                if (iHandVal <= 10)
                    CardValue = 11;
                else CardValue = 1;
            }
            else CardValue = (int)eVal;
        }
    }

    public class Hand
    {
        public List<Card> Cards { get; private set; }
        public int HandValue { get; private set; }
        public int HandBet { get; private set; }
        public BlackjackTable.Winner HandWinner { get; set; }

        public Hand(int iHandBet)
        {
            Cards = new List<Card>();
            HandValue = 0;
            HandBet = iHandBet;
            HandWinner = BlackjackTable.Winner.Push;
        }

        public void Blackjack()
        {
            HandBet = (int)((double)HandBet * 1.5);
        }

        public void AddCard(Card pNewCard)
        {
            Cards.Add(pNewCard);
            updateHandValue();
        }

        private void updateHandValue()
        {
            HandValue = 0;

            List<Card> lTemp = new List<Card>();
            List<string> lCardNames = new List<string>();
            List<string> lSortedCardNames = new List<string>();

            lCardNames.AddRange(Cards.Select(p => p.CardName));
            lCardNames.Sort();

            foreach (var sCard in lCardNames)
            {
                if (sCard.EndsWith("Ace")) continue;
                lSortedCardNames.Add(sCard);
            }
            foreach (var sCard in lCardNames)
            {
                if (sCard.EndsWith("Ace"))
                    lSortedCardNames.Add(sCard);
            }

            foreach (var sCard in lSortedCardNames)
                lTemp.Add(Cards.Find(p => p.CardName == sCard));

            foreach (Card pCard in lTemp)
            {
                int iIndex = 0;
                foreach (var cChar in pCard.CardName.ToCharArray())
                {
                    if (cChar == '_') break;
                    iIndex++;
                }
                var sCard = pCard.CardName.Substring(iIndex);
                BlackjackTable.CardValue eCardVal = (BlackjackTable.CardValue)Enum.Parse(typeof(BlackjackTable.CardValue), sCard);

                pCard.SetCardValue(eCardVal, HandValue);
                HandValue += pCard.CardValue;
            }
        }
    }
}
