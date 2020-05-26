namespace Hangman
{
    partial class FrmHangman
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
            this.hangImage = new System.Windows.Forms.PictureBox();
            this.cmdF = new System.Windows.Forms.Button();
            this.cmdT = new System.Windows.Forms.Button();
            this.cmdM = new System.Windows.Forms.Button();
            this.cmdU = new System.Windows.Forms.Button();
            this.cmdN = new System.Windows.Forms.Button();
            this.cmdG = new System.Windows.Forms.Button();
            this.cmdH = new System.Windows.Forms.Button();
            this.cmdO = new System.Windows.Forms.Button();
            this.cmdV = new System.Windows.Forms.Button();
            this.cmdI = new System.Windows.Forms.Button();
            this.cmdP = new System.Windows.Forms.Button();
            this.cmdW = new System.Windows.Forms.Button();
            this.cmdJ = new System.Windows.Forms.Button();
            this.cmdQ = new System.Windows.Forms.Button();
            this.cmdX = new System.Windows.Forms.Button();
            this.cmdK = new System.Windows.Forms.Button();
            this.cmdR = new System.Windows.Forms.Button();
            this.cmdY = new System.Windows.Forms.Button();
            this.cmdL = new System.Windows.Forms.Button();
            this.cmdS = new System.Windows.Forms.Button();
            this.cmdZ = new System.Windows.Forms.Button();
            this.cmdA = new System.Windows.Forms.Button();
            this.cmdB = new System.Windows.Forms.Button();
            this.cmdC = new System.Windows.Forms.Button();
            this.cmdD = new System.Windows.Forms.Button();
            this.cmdE = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.lblShowWord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).BeginInit();
            this.SuspendLayout();
            // 
            // hangImage
            // 
            this.hangImage.Image = global::Hangman.Properties.Resources._1;
            this.hangImage.Location = new System.Drawing.Point(29, 12);
            this.hangImage.Name = "hangImage";
            this.hangImage.Size = new System.Drawing.Size(260, 412);
            this.hangImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hangImage.TabIndex = 0;
            this.hangImage.TabStop = false;
            // 
            // cmdF
            // 
            this.cmdF.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdF.Location = new System.Drawing.Point(375, 277);
            this.cmdF.Name = "cmdF";
            this.cmdF.Size = new System.Drawing.Size(46, 45);
            this.cmdF.TabIndex = 1;
            this.cmdF.Text = "f";
            this.cmdF.UseVisualStyleBackColor = true;
            this.cmdF.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdT
            // 
            this.cmdT.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdT.Location = new System.Drawing.Point(375, 379);
            this.cmdT.Name = "cmdT";
            this.cmdT.Size = new System.Drawing.Size(46, 45);
            this.cmdT.TabIndex = 2;
            this.cmdT.Text = "t";
            this.cmdT.UseVisualStyleBackColor = true;
            this.cmdT.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdM
            // 
            this.cmdM.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdM.Location = new System.Drawing.Point(375, 328);
            this.cmdM.Name = "cmdM";
            this.cmdM.Size = new System.Drawing.Size(46, 45);
            this.cmdM.TabIndex = 3;
            this.cmdM.Text = "m";
            this.cmdM.UseVisualStyleBackColor = true;
            this.cmdM.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdU
            // 
            this.cmdU.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdU.Location = new System.Drawing.Point(427, 379);
            this.cmdU.Name = "cmdU";
            this.cmdU.Size = new System.Drawing.Size(46, 45);
            this.cmdU.TabIndex = 4;
            this.cmdU.Text = "u";
            this.cmdU.UseVisualStyleBackColor = true;
            this.cmdU.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdN
            // 
            this.cmdN.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdN.Location = new System.Drawing.Point(427, 328);
            this.cmdN.Name = "cmdN";
            this.cmdN.Size = new System.Drawing.Size(46, 45);
            this.cmdN.TabIndex = 5;
            this.cmdN.Text = "n";
            this.cmdN.UseVisualStyleBackColor = true;
            this.cmdN.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdG
            // 
            this.cmdG.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdG.Location = new System.Drawing.Point(427, 277);
            this.cmdG.Name = "cmdG";
            this.cmdG.Size = new System.Drawing.Size(46, 45);
            this.cmdG.TabIndex = 6;
            this.cmdG.Text = "g";
            this.cmdG.UseVisualStyleBackColor = true;
            this.cmdG.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdH
            // 
            this.cmdH.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdH.Location = new System.Drawing.Point(479, 277);
            this.cmdH.Name = "cmdH";
            this.cmdH.Size = new System.Drawing.Size(46, 45);
            this.cmdH.TabIndex = 7;
            this.cmdH.Text = "h";
            this.cmdH.UseVisualStyleBackColor = true;
            this.cmdH.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdO
            // 
            this.cmdO.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdO.Location = new System.Drawing.Point(479, 328);
            this.cmdO.Name = "cmdO";
            this.cmdO.Size = new System.Drawing.Size(46, 45);
            this.cmdO.TabIndex = 8;
            this.cmdO.Text = "o";
            this.cmdO.UseVisualStyleBackColor = true;
            this.cmdO.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdV
            // 
            this.cmdV.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdV.Location = new System.Drawing.Point(479, 379);
            this.cmdV.Name = "cmdV";
            this.cmdV.Size = new System.Drawing.Size(46, 45);
            this.cmdV.TabIndex = 9;
            this.cmdV.Text = "v";
            this.cmdV.UseVisualStyleBackColor = true;
            this.cmdV.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdI
            // 
            this.cmdI.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdI.Location = new System.Drawing.Point(531, 277);
            this.cmdI.Name = "cmdI";
            this.cmdI.Size = new System.Drawing.Size(46, 45);
            this.cmdI.TabIndex = 10;
            this.cmdI.Text = "i";
            this.cmdI.UseVisualStyleBackColor = true;
            this.cmdI.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdP
            // 
            this.cmdP.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdP.Location = new System.Drawing.Point(531, 328);
            this.cmdP.Name = "cmdP";
            this.cmdP.Size = new System.Drawing.Size(46, 45);
            this.cmdP.TabIndex = 11;
            this.cmdP.Text = "p";
            this.cmdP.UseVisualStyleBackColor = true;
            this.cmdP.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdW
            // 
            this.cmdW.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdW.Location = new System.Drawing.Point(531, 379);
            this.cmdW.Name = "cmdW";
            this.cmdW.Size = new System.Drawing.Size(46, 45);
            this.cmdW.TabIndex = 12;
            this.cmdW.Text = "w";
            this.cmdW.UseVisualStyleBackColor = true;
            this.cmdW.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdJ
            // 
            this.cmdJ.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdJ.Location = new System.Drawing.Point(583, 277);
            this.cmdJ.Name = "cmdJ";
            this.cmdJ.Size = new System.Drawing.Size(46, 45);
            this.cmdJ.TabIndex = 13;
            this.cmdJ.Text = "j";
            this.cmdJ.UseVisualStyleBackColor = true;
            this.cmdJ.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdQ
            // 
            this.cmdQ.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdQ.Location = new System.Drawing.Point(583, 328);
            this.cmdQ.Name = "cmdQ";
            this.cmdQ.Size = new System.Drawing.Size(46, 45);
            this.cmdQ.TabIndex = 14;
            this.cmdQ.Text = "q";
            this.cmdQ.UseVisualStyleBackColor = true;
            this.cmdQ.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdX
            // 
            this.cmdX.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdX.Location = new System.Drawing.Point(583, 379);
            this.cmdX.Name = "cmdX";
            this.cmdX.Size = new System.Drawing.Size(46, 45);
            this.cmdX.TabIndex = 15;
            this.cmdX.Text = "x";
            this.cmdX.UseVisualStyleBackColor = true;
            this.cmdX.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdK
            // 
            this.cmdK.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdK.Location = new System.Drawing.Point(635, 277);
            this.cmdK.Name = "cmdK";
            this.cmdK.Size = new System.Drawing.Size(46, 45);
            this.cmdK.TabIndex = 16;
            this.cmdK.Text = "k";
            this.cmdK.UseVisualStyleBackColor = true;
            this.cmdK.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdR
            // 
            this.cmdR.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdR.Location = new System.Drawing.Point(635, 328);
            this.cmdR.Name = "cmdR";
            this.cmdR.Size = new System.Drawing.Size(46, 45);
            this.cmdR.TabIndex = 17;
            this.cmdR.Text = "r";
            this.cmdR.UseVisualStyleBackColor = true;
            this.cmdR.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdY
            // 
            this.cmdY.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdY.Location = new System.Drawing.Point(635, 379);
            this.cmdY.Name = "cmdY";
            this.cmdY.Size = new System.Drawing.Size(46, 45);
            this.cmdY.TabIndex = 18;
            this.cmdY.Text = "y";
            this.cmdY.UseVisualStyleBackColor = true;
            this.cmdY.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdL
            // 
            this.cmdL.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdL.Location = new System.Drawing.Point(687, 277);
            this.cmdL.Name = "cmdL";
            this.cmdL.Size = new System.Drawing.Size(46, 45);
            this.cmdL.TabIndex = 19;
            this.cmdL.Text = "l";
            this.cmdL.UseVisualStyleBackColor = true;
            this.cmdL.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdS
            // 
            this.cmdS.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdS.Location = new System.Drawing.Point(687, 328);
            this.cmdS.Name = "cmdS";
            this.cmdS.Size = new System.Drawing.Size(46, 45);
            this.cmdS.TabIndex = 20;
            this.cmdS.Text = "s";
            this.cmdS.UseVisualStyleBackColor = true;
            this.cmdS.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdZ
            // 
            this.cmdZ.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdZ.Location = new System.Drawing.Point(687, 379);
            this.cmdZ.Name = "cmdZ";
            this.cmdZ.Size = new System.Drawing.Size(46, 45);
            this.cmdZ.TabIndex = 21;
            this.cmdZ.Text = "z";
            this.cmdZ.UseVisualStyleBackColor = true;
            this.cmdZ.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdA
            // 
            this.cmdA.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdA.Location = new System.Drawing.Point(375, 226);
            this.cmdA.Name = "cmdA";
            this.cmdA.Size = new System.Drawing.Size(46, 45);
            this.cmdA.TabIndex = 22;
            this.cmdA.Text = "a";
            this.cmdA.UseVisualStyleBackColor = true;
            this.cmdA.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdB
            // 
            this.cmdB.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdB.Location = new System.Drawing.Point(427, 226);
            this.cmdB.Name = "cmdB";
            this.cmdB.Size = new System.Drawing.Size(46, 45);
            this.cmdB.TabIndex = 23;
            this.cmdB.Text = "b";
            this.cmdB.UseVisualStyleBackColor = true;
            this.cmdB.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdC
            // 
            this.cmdC.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdC.Location = new System.Drawing.Point(479, 226);
            this.cmdC.Name = "cmdC";
            this.cmdC.Size = new System.Drawing.Size(46, 45);
            this.cmdC.TabIndex = 24;
            this.cmdC.Text = "c";
            this.cmdC.UseVisualStyleBackColor = true;
            this.cmdC.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdD
            // 
            this.cmdD.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdD.Location = new System.Drawing.Point(531, 226);
            this.cmdD.Name = "cmdD";
            this.cmdD.Size = new System.Drawing.Size(46, 45);
            this.cmdD.TabIndex = 25;
            this.cmdD.Text = "d";
            this.cmdD.UseVisualStyleBackColor = true;
            this.cmdD.Click += new System.EventHandler(this.guessClick);
            // 
            // cmdE
            // 
            this.cmdE.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdE.Location = new System.Drawing.Point(583, 226);
            this.cmdE.Name = "cmdE";
            this.cmdE.Size = new System.Drawing.Size(46, 45);
            this.cmdE.TabIndex = 26;
            this.cmdE.Text = "e";
            this.cmdE.UseVisualStyleBackColor = true;
            this.cmdE.Click += new System.EventHandler(this.guessClick);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblResult.Location = new System.Drawing.Point(545, 12);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 29);
            this.lblResult.TabIndex = 27;
            // 
            // restart
            // 
            this.restart.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.Location = new System.Drawing.Point(635, 226);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(127, 45);
            this.restart.TabIndex = 28;
            this.restart.Text = "restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // lblShowWord
            // 
            this.lblShowWord.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowWord.Location = new System.Drawing.Point(340, 85);
            this.lblShowWord.Name = "lblShowWord";
            this.lblShowWord.Size = new System.Drawing.Size(422, 78);
            this.lblShowWord.TabIndex = 30;
            this.lblShowWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblShowWord);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmdE);
            this.Controls.Add(this.cmdD);
            this.Controls.Add(this.cmdC);
            this.Controls.Add(this.cmdB);
            this.Controls.Add(this.cmdA);
            this.Controls.Add(this.cmdZ);
            this.Controls.Add(this.cmdS);
            this.Controls.Add(this.cmdL);
            this.Controls.Add(this.cmdY);
            this.Controls.Add(this.cmdR);
            this.Controls.Add(this.cmdK);
            this.Controls.Add(this.cmdX);
            this.Controls.Add(this.cmdQ);
            this.Controls.Add(this.cmdJ);
            this.Controls.Add(this.cmdW);
            this.Controls.Add(this.cmdP);
            this.Controls.Add(this.cmdI);
            this.Controls.Add(this.cmdV);
            this.Controls.Add(this.cmdO);
            this.Controls.Add(this.cmdH);
            this.Controls.Add(this.cmdG);
            this.Controls.Add(this.cmdN);
            this.Controls.Add(this.cmdU);
            this.Controls.Add(this.cmdM);
            this.Controls.Add(this.cmdT);
            this.Controls.Add(this.cmdF);
            this.Controls.Add(this.hangImage);
            this.Name = "FrmHangman";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.FrmHangman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hangImage;
        private System.Windows.Forms.Button cmdF;
        private System.Windows.Forms.Button cmdT;
        private System.Windows.Forms.Button cmdM;
        private System.Windows.Forms.Button cmdU;
        private System.Windows.Forms.Button cmdN;
        private System.Windows.Forms.Button cmdG;
        private System.Windows.Forms.Button cmdH;
        private System.Windows.Forms.Button cmdO;
        private System.Windows.Forms.Button cmdV;
        private System.Windows.Forms.Button cmdI;
        private System.Windows.Forms.Button cmdP;
        private System.Windows.Forms.Button cmdW;
        private System.Windows.Forms.Button cmdJ;
        private System.Windows.Forms.Button cmdQ;
        private System.Windows.Forms.Button cmdX;
        private System.Windows.Forms.Button cmdK;
        private System.Windows.Forms.Button cmdR;
        private System.Windows.Forms.Button cmdY;
        private System.Windows.Forms.Button cmdL;
        private System.Windows.Forms.Button cmdS;
        private System.Windows.Forms.Button cmdZ;
        private System.Windows.Forms.Button cmdA;
        private System.Windows.Forms.Button cmdB;
        private System.Windows.Forms.Button cmdC;
        private System.Windows.Forms.Button cmdD;
        private System.Windows.Forms.Button cmdE;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label lblShowWord;
    }
}

