namespace BlackJack
{
    partial class BlackjackTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackjackTable));
            this.pbDealer1 = new System.Windows.Forms.PictureBox();
            this.pbDealer2 = new System.Windows.Forms.PictureBox();
            this.pbPlayer1 = new System.Windows.Forms.PictureBox();
            this.pbPlayer2 = new System.Windows.Forms.PictureBox();
            this.pbEasterEgg = new System.Windows.Forms.PictureBox();
            this.pEasterEggTimer = new System.Windows.Forms.Timer(this.components);
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.lblBet = new System.Windows.Forms.Label();
            this.btnBet_Decrease = new System.Windows.Forms.Button();
            this.btnBet_Increase = new System.Windows.Forms.Button();
            this.lblBank = new System.Windows.Forms.Label();
            this.pWinTimer = new System.Windows.Forms.Timer(this.components);
            this.lblWinner = new System.Windows.Forms.Label();
            this.pShuffleTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEasterEgg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDealer1
            // 
            this.pbDealer1.BackColor = System.Drawing.Color.Transparent;
            this.pbDealer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDealer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDealer1.Location = new System.Drawing.Point(66, 28);
            this.pbDealer1.Margin = new System.Windows.Forms.Padding(15);
            this.pbDealer1.Name = "pbDealer1";
            this.pbDealer1.Size = new System.Drawing.Size(184, 254);
            this.pbDealer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDealer1.TabIndex = 1;
            this.pbDealer1.TabStop = false;
            // 
            // pbDealer2
            // 
            this.pbDealer2.BackColor = System.Drawing.Color.Transparent;
            this.pbDealer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDealer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDealer2.Location = new System.Drawing.Point(282, 28);
            this.pbDealer2.Margin = new System.Windows.Forms.Padding(15);
            this.pbDealer2.Name = "pbDealer2";
            this.pbDealer2.Size = new System.Drawing.Size(184, 254);
            this.pbDealer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDealer2.TabIndex = 2;
            this.pbDealer2.TabStop = false;
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPlayer1.Location = new System.Drawing.Point(66, 536);
            this.pbPlayer1.Margin = new System.Windows.Forms.Padding(15);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.Size = new System.Drawing.Size(184, 254);
            this.pbPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer1.TabIndex = 7;
            this.pbPlayer1.TabStop = false;
            // 
            // pbPlayer2
            // 
            this.pbPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPlayer2.Location = new System.Drawing.Point(282, 536);
            this.pbPlayer2.Margin = new System.Windows.Forms.Padding(15);
            this.pbPlayer2.Name = "pbPlayer2";
            this.pbPlayer2.Size = new System.Drawing.Size(184, 254);
            this.pbPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer2.TabIndex = 8;
            this.pbPlayer2.TabStop = false;
            // 
            // pbEasterEgg
            // 
            this.pbEasterEgg.BackColor = System.Drawing.Color.Transparent;
            this.pbEasterEgg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbEasterEgg.Location = new System.Drawing.Point(15, 28);
            this.pbEasterEgg.Margin = new System.Windows.Forms.Padding(15);
            this.pbEasterEgg.Name = "pbEasterEgg";
            this.pbEasterEgg.Size = new System.Drawing.Size(36, 35);
            this.pbEasterEgg.TabIndex = 13;
            this.pbEasterEgg.TabStop = false;
            this.pbEasterEgg.Click += new System.EventHandler(this.pbEasterEgg_Click);
            // 
            // pEasterEggTimer
            // 
            this.pEasterEggTimer.Tick += new System.EventHandler(this.pEasterEggTimer_Tick);
            // 
            // btnDeal
            // 
            this.btnDeal.Font = new System.Drawing.Font("Harrington", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.Image = ((System.Drawing.Image)(resources.GetObject("btnDeal.Image")));
            this.btnDeal.Location = new System.Drawing.Point(66, 317);
            this.btnDeal.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(186, 73);
            this.btnDeal.TabIndex = 26;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // btnHit
            // 
            this.btnHit.Enabled = false;
            this.btnHit.Font = new System.Drawing.Font("Harrington", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Image = ((System.Drawing.Image)(resources.GetObject("btnHit.Image")));
            this.btnHit.Location = new System.Drawing.Point(66, 422);
            this.btnHit.Margin = new System.Windows.Forms.Padding(4);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(186, 73);
            this.btnHit.TabIndex = 27;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.Enabled = false;
            this.btnStay.Font = new System.Drawing.Font("Harrington", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Image = ((System.Drawing.Image)(resources.GetObject("btnStay.Image")));
            this.btnStay.Location = new System.Drawing.Point(282, 422);
            this.btnStay.Margin = new System.Windows.Forms.Padding(4);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(186, 73);
            this.btnStay.TabIndex = 28;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Font = new System.Drawing.Font("Harrington", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplit.Image = ((System.Drawing.Image)(resources.GetObject("btnSplit.Image")));
            this.btnSplit.Location = new System.Drawing.Point(498, 422);
            this.btnSplit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(186, 73);
            this.btnSplit.TabIndex = 29;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Visible = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // lblBet
            // 
            this.lblBet.Font = new System.Drawing.Font("Harrington", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Image = ((System.Drawing.Image)(resources.GetObject("lblBet.Image")));
            this.lblBet.Location = new System.Drawing.Point(846, 422);
            this.lblBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(211, 73);
            this.lblBet.TabIndex = 30;
            this.lblBet.Text = "Bet";
            this.lblBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBet_Decrease
            // 
            this.btnBet_Decrease.Font = new System.Drawing.Font("Harrington", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet_Decrease.Image = ((System.Drawing.Image)(resources.GetObject("btnBet_Decrease.Image")));
            this.btnBet_Decrease.Location = new System.Drawing.Point(762, 422);
            this.btnBet_Decrease.Margin = new System.Windows.Forms.Padding(4);
            this.btnBet_Decrease.Name = "btnBet_Decrease";
            this.btnBet_Decrease.Size = new System.Drawing.Size(75, 73);
            this.btnBet_Decrease.TabIndex = 32;
            this.btnBet_Decrease.Text = "-";
            this.btnBet_Decrease.UseVisualStyleBackColor = true;
            this.btnBet_Decrease.Click += new System.EventHandler(this.btnBet_Decrease_Click);
            // 
            // btnBet_Increase
            // 
            this.btnBet_Increase.Font = new System.Drawing.Font("Harrington", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet_Increase.Image = ((System.Drawing.Image)(resources.GetObject("btnBet_Increase.Image")));
            this.btnBet_Increase.Location = new System.Drawing.Point(1065, 422);
            this.btnBet_Increase.Margin = new System.Windows.Forms.Padding(4);
            this.btnBet_Increase.Name = "btnBet_Increase";
            this.btnBet_Increase.Size = new System.Drawing.Size(75, 73);
            this.btnBet_Increase.TabIndex = 33;
            this.btnBet_Increase.Text = "+";
            this.btnBet_Increase.UseVisualStyleBackColor = true;
            this.btnBet_Increase.Click += new System.EventHandler(this.btnBet_Increase_Click);
            // 
            // lblBank
            // 
            this.lblBank.BackColor = System.Drawing.Color.Transparent;
            this.lblBank.Font = new System.Drawing.Font("Harrington", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.Image = global::BlackJack.Properties.Resources.RedFelt_Background;
            this.lblBank.Location = new System.Drawing.Point(762, 317);
            this.lblBank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(378, 73);
            this.lblBank.TabIndex = 31;
            this.lblBank.Text = "Bank";
            this.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pWinTimer
            // 
            this.pWinTimer.Interval = 350;
            this.pWinTimer.Tick += new System.EventHandler(this.pWinTimer_Tick);
            // 
            // lblWinner
            // 
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Harrington", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(282, 317);
            this.lblWinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(402, 73);
            this.lblWinner.TabIndex = 34;
            this.lblWinner.Text = "Winner";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWinner.Visible = false;
            // 
            // pShuffleTimer
            // 
            this.pShuffleTimer.Interval = 500;
            this.pShuffleTimer.Tick += new System.EventHandler(this.pShuffleTimer_Tick);
            // 
            // BlackjackTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1401, 820);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnBet_Increase);
            this.Controls.Add(this.btnBet_Decrease);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.pbEasterEgg);
            this.Controls.Add(this.pbPlayer2);
            this.Controls.Add(this.pbPlayer1);
            this.Controls.Add(this.pbDealer2);
            this.Controls.Add(this.pbDealer1);
            this.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BlackjackTable";
            this.Text = "Geoff\'s Blackjack";
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEasterEgg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDealer1;
        private System.Windows.Forms.PictureBox pbDealer2;
        private System.Windows.Forms.PictureBox pbPlayer1;
        private System.Windows.Forms.PictureBox pbPlayer2;
        private System.Windows.Forms.PictureBox pbEasterEgg;
        private System.Windows.Forms.Timer pEasterEggTimer;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Button btnBet_Decrease;
        private System.Windows.Forms.Button btnBet_Increase;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Timer pWinTimer;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Timer pShuffleTimer;
    }
}

