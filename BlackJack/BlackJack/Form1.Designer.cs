namespace BlackJack
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerCard1 = new System.Windows.Forms.PictureBox();
            this.playerCard2 = new System.Windows.Forms.PictureBox();
            this.compCard1 = new System.Windows.Forms.PictureBox();
            this.compCard2 = new System.Windows.Forms.PictureBox();
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnBetMinus = new System.Windows.Forms.Button();
            this.btnBetPlus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playerCard3 = new System.Windows.Forms.PictureBox();
            this.playerCard4 = new System.Windows.Forms.PictureBox();
            this.playerCard5 = new System.Windows.Forms.PictureBox();
            this.compCard3 = new System.Windows.Forms.PictureBox();
            this.compCard4 = new System.Windows.Forms.PictureBox();
            this.compCard5 = new System.Windows.Forms.PictureBox();
            this.lblPot = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compCard5)).BeginInit();
            this.SuspendLayout();
            // 
            // playerCard1
            // 
            this.playerCard1.BackColor = System.Drawing.Color.Transparent;
            this.playerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCard1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerCard1.Location = new System.Drawing.Point(38, 350);
            this.playerCard1.Name = "playerCard1";
            this.playerCard1.Size = new System.Drawing.Size(145, 201);
            this.playerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard1.TabIndex = 0;
            this.playerCard1.TabStop = false;
            // 
            // playerCard2
            // 
            this.playerCard2.BackColor = System.Drawing.Color.Transparent;
            this.playerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCard2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerCard2.Location = new System.Drawing.Point(206, 350);
            this.playerCard2.Name = "playerCard2";
            this.playerCard2.Size = new System.Drawing.Size(145, 201);
            this.playerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard2.TabIndex = 1;
            this.playerCard2.TabStop = false;
            // 
            // compCard1
            // 
            this.compCard1.BackColor = System.Drawing.Color.Transparent;
            this.compCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.compCard1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.compCard1.Location = new System.Drawing.Point(38, 21);
            this.compCard1.Name = "compCard1";
            this.compCard1.Size = new System.Drawing.Size(145, 201);
            this.compCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.compCard1.TabIndex = 2;
            this.compCard1.TabStop = false;
            // 
            // compCard2
            // 
            this.compCard2.BackColor = System.Drawing.Color.Transparent;
            this.compCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.compCard2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.compCard2.Location = new System.Drawing.Point(206, 21);
            this.compCard2.Name = "compCard2";
            this.compCard2.Size = new System.Drawing.Size(145, 201);
            this.compCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.compCard2.TabIndex = 3;
            this.compCard2.TabStop = false;
            // 
            // btnDeal
            // 
            this.btnDeal.BackColor = System.Drawing.Color.Maroon;
            this.btnDeal.Font = new System.Drawing.Font("Broadway", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.Location = new System.Drawing.Point(38, 252);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(162, 69);
            this.btnDeal.TabIndex = 4;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = false;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.Maroon;
            this.btnHit.Font = new System.Drawing.Font("Broadway", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(206, 252);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(145, 69);
            this.btnHit.TabIndex = 5;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnBetMinus
            // 
            this.btnBetMinus.BackColor = System.Drawing.Color.Maroon;
            this.btnBetMinus.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetMinus.Location = new System.Drawing.Point(357, 252);
            this.btnBetMinus.Name = "btnBetMinus";
            this.btnBetMinus.Size = new System.Drawing.Size(65, 69);
            this.btnBetMinus.TabIndex = 6;
            this.btnBetMinus.Text = "-";
            this.btnBetMinus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBetMinus.UseVisualStyleBackColor = false;
            this.btnBetMinus.Click += new System.EventHandler(this.btnBetMinus_Click);
            // 
            // btnBetPlus
            // 
            this.btnBetPlus.BackColor = System.Drawing.Color.Maroon;
            this.btnBetPlus.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetPlus.Location = new System.Drawing.Point(561, 252);
            this.btnBetPlus.Name = "btnBetPlus";
            this.btnBetPlus.Size = new System.Drawing.Size(69, 69);
            this.btnBetPlus.TabIndex = 7;
            this.btnBetPlus.Text = "+";
            this.btnBetPlus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBetPlus.UseVisualStyleBackColor = false;
            this.btnBetPlus.Click += new System.EventHandler(this.btnBetPlus_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Broadway", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 69);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerCard3
            // 
            this.playerCard3.BackColor = System.Drawing.Color.Transparent;
            this.playerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCard3.Location = new System.Drawing.Point(386, 350);
            this.playerCard3.Name = "playerCard3";
            this.playerCard3.Size = new System.Drawing.Size(145, 201);
            this.playerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard3.TabIndex = 9;
            this.playerCard3.TabStop = false;
            // 
            // playerCard4
            // 
            this.playerCard4.BackColor = System.Drawing.Color.Transparent;
            this.playerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCard4.Location = new System.Drawing.Point(561, 350);
            this.playerCard4.Name = "playerCard4";
            this.playerCard4.Size = new System.Drawing.Size(145, 201);
            this.playerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard4.TabIndex = 10;
            this.playerCard4.TabStop = false;
            // 
            // playerCard5
            // 
            this.playerCard5.BackColor = System.Drawing.Color.Transparent;
            this.playerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerCard5.Location = new System.Drawing.Point(739, 350);
            this.playerCard5.Name = "playerCard5";
            this.playerCard5.Size = new System.Drawing.Size(145, 201);
            this.playerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard5.TabIndex = 11;
            this.playerCard5.TabStop = false;
            // 
            // compCard3
            // 
            this.compCard3.BackColor = System.Drawing.Color.Transparent;
            this.compCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.compCard3.Location = new System.Drawing.Point(386, 21);
            this.compCard3.Name = "compCard3";
            this.compCard3.Size = new System.Drawing.Size(145, 201);
            this.compCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.compCard3.TabIndex = 12;
            this.compCard3.TabStop = false;
            // 
            // compCard4
            // 
            this.compCard4.BackColor = System.Drawing.Color.Transparent;
            this.compCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.compCard4.Location = new System.Drawing.Point(561, 21);
            this.compCard4.Name = "compCard4";
            this.compCard4.Size = new System.Drawing.Size(145, 201);
            this.compCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.compCard4.TabIndex = 13;
            this.compCard4.TabStop = false;
            // 
            // compCard5
            // 
            this.compCard5.BackColor = System.Drawing.Color.Transparent;
            this.compCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.compCard5.Location = new System.Drawing.Point(739, 21);
            this.compCard5.Name = "compCard5";
            this.compCard5.Size = new System.Drawing.Size(145, 201);
            this.compCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.compCard5.TabIndex = 14;
            this.compCard5.TabStop = false;
            this.compCard5.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // lblPot
            // 
            this.lblPot.BackColor = System.Drawing.Color.Maroon;
            this.lblPot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPot.Font = new System.Drawing.Font("Broadway", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPot.Location = new System.Drawing.Point(655, 252);
            this.lblPot.Name = "lblPot";
            this.lblPot.Size = new System.Drawing.Size(229, 69);
            this.lblPot.TabIndex = 15;
            this.lblPot.Text = "Pot";
            this.lblPot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBank
            // 
            this.lblBank.BackColor = System.Drawing.Color.Maroon;
            this.lblBank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBank.Font = new System.Drawing.Font("Broadway", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.Location = new System.Drawing.Point(38, 581);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(493, 66);
            this.lblBank.TabIndex = 16;
            this.lblBank.Text = "Bank";
            this.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWinner
            // 
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Broadway", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(131, 565);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(846, 99);
            this.lblWinner.TabIndex = 17;
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWinner.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 677);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.lblPot);
            this.Controls.Add(this.compCard5);
            this.Controls.Add(this.compCard4);
            this.Controls.Add(this.compCard3);
            this.Controls.Add(this.playerCard5);
            this.Controls.Add(this.playerCard4);
            this.Controls.Add(this.playerCard3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBetPlus);
            this.Controls.Add(this.btnBetMinus);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.compCard2);
            this.Controls.Add(this.compCard1);
            this.Controls.Add(this.playerCard2);
            this.Controls.Add(this.playerCard1);
            this.Name = "Form1";
            this.Text = "Black Jack";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compCard5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerCard1;
        private System.Windows.Forms.PictureBox playerCard2;
        private System.Windows.Forms.PictureBox compCard1;
        private System.Windows.Forms.PictureBox compCard2;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnBetMinus;
        private System.Windows.Forms.Button btnBetPlus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox playerCard3;
        private System.Windows.Forms.PictureBox playerCard4;
        private System.Windows.Forms.PictureBox playerCard5;
        private System.Windows.Forms.PictureBox compCard3;
        private System.Windows.Forms.PictureBox compCard4;
        private System.Windows.Forms.PictureBox compCard5;
        private System.Windows.Forms.Label lblPot;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblWinner;
    }
}

