namespace Tic_Tac_Toe
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.B00 = new System.Windows.Forms.Button();
            this.B01 = new System.Windows.Forms.Button();
            this.B02 = new System.Windows.Forms.Button();
            this.B12 = new System.Windows.Forms.Button();
            this.B11 = new System.Windows.Forms.Button();
            this.B10 = new System.Windows.Forms.Button();
            this.B22 = new System.Windows.Forms.Button();
            this.B21 = new System.Windows.Forms.Button();
            this.B20 = new System.Windows.Forms.Button();
            this.NG = new System.Windows.Forms.Button();
            this.R = new System.Windows.Forms.Button();
            this.Ex = new System.Windows.Forms.Button();
            this.XWins = new System.Windows.Forms.Label();
            this.YWins = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.B00.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B00.Location = new System.Drawing.Point(20, 31);
            this.B00.Name = "B00";
            this.B00.Size = new System.Drawing.Size(149, 105);
            this.B00.TabIndex = 0;
            this.B00.UseVisualStyleBackColor = false;
            this.B00.Click += new System.EventHandler(this.buttonClick);

            this.B01.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B01.Location = new System.Drawing.Point(20, 171);
            this.B01.Name = "B01";
            this.B01.Size = new System.Drawing.Size(149, 105);
            this.B01.TabIndex = 1;
            this.B01.UseVisualStyleBackColor = false;
            this.B01.Click += new System.EventHandler(this.buttonClick);

            this.B02.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B02.Location = new System.Drawing.Point(20, 313);
            this.B02.Name = "B02";
            this.B02.Size = new System.Drawing.Size(149, 105);
            this.B02.TabIndex = 2;
            this.B02.UseVisualStyleBackColor = false;
            this.B02.Click += new System.EventHandler(this.buttonClick);

            this.B12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B12.Location = new System.Drawing.Point(202, 313);
            this.B12.Name = "B12";
            this.B12.Size = new System.Drawing.Size(149, 105);
            this.B12.TabIndex = 5;
            this.B12.UseVisualStyleBackColor = false;
            this.B12.Click += new System.EventHandler(this.buttonClick);

            this.B11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B11.Location = new System.Drawing.Point(202, 171);
            this.B11.Name = "B11";
            this.B11.Size = new System.Drawing.Size(149, 105);
            this.B11.TabIndex = 4;
            this.B11.UseVisualStyleBackColor = false;
            this.B11.Click += new System.EventHandler(this.buttonClick);

            this.B10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B10.Location = new System.Drawing.Point(202, 31);
            this.B10.Name = "B10";
            this.B10.Size = new System.Drawing.Size(149, 105);
            this.B10.TabIndex = 3;
            this.B10.UseVisualStyleBackColor = false;
            this.B10.Click += new System.EventHandler(this.buttonClick);

            this.B22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B22.Location = new System.Drawing.Point(390, 313);
            this.B22.Name = "B22";
            this.B22.Size = new System.Drawing.Size(149, 105);
            this.B22.TabIndex = 8;
            this.B22.UseVisualStyleBackColor = false;
            this.B22.Click += new System.EventHandler(this.buttonClick);

            this.B21.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B21.Location = new System.Drawing.Point(390, 171);
            this.B21.Name = "B21";
            this.B21.Size = new System.Drawing.Size(149, 105);
            this.B21.TabIndex = 7;
            this.B21.UseVisualStyleBackColor = false;
            this.B21.Click += new System.EventHandler(this.buttonClick);

            this.B20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B20.Location = new System.Drawing.Point(390, 31);
            this.B20.Name = "B20";
            this.B20.Size = new System.Drawing.Size(149, 105);
            this.B20.TabIndex = 6;
            this.B20.UseVisualStyleBackColor = false;
            this.B20.Click += new System.EventHandler(this.buttonClick);

            this.NG.BackColor = System.Drawing.Color.Black;
            this.NG.ForeColor = System.Drawing.SystemColors.Control;
            this.NG.Location = new System.Drawing.Point(23, 487);
            this.NG.Name = "NG";
            this.NG.Size = new System.Drawing.Size(219, 45);
            this.NG.TabIndex = 9;
            this.NG.Text = "New Game";
            this.NG.UseVisualStyleBackColor = false;
            this.NG.Click += new System.EventHandler(this.NG_Click);

            this.R.BackColor = System.Drawing.Color.Black;
            this.R.ForeColor = System.Drawing.Color.White;
            this.R.Location = new System.Drawing.Point(278, 487);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(219, 45);
            this.R.TabIndex = 10;
            this.R.Text = "Reset";
            this.R.UseVisualStyleBackColor = false;
            this.R.Click += new System.EventHandler(this.R_Click);
   
            this.Ex.BackColor = System.Drawing.Color.Black;
            this.Ex.ForeColor = System.Drawing.Color.White;
            this.Ex.Location = new System.Drawing.Point(620, 487);
            this.Ex.Name = "Ex";
            this.Ex.Size = new System.Drawing.Size(219, 45);
            this.Ex.TabIndex = 11;
            this.Ex.Text = "Exit";
            this.Ex.UseVisualStyleBackColor = false;
            this.Ex.Click += new System.EventHandler(this.ExitApp);
 
            this.XWins.AutoSize = true;
            this.XWins.Location = new System.Drawing.Point(579, 74);
            this.XWins.Name = "XWins";
            this.XWins.Size = new System.Drawing.Size(0, 20);
            this.XWins.TabIndex = 12;

            this.YWins.AutoSize = true;
            this.YWins.Location = new System.Drawing.Point(579, 213);
            this.YWins.Name = "YWins";
            this.YWins.Size = new System.Drawing.Size(0, 20);
            this.YWins.TabIndex = 13;
 
            this.Draws.AutoSize = true;
            this.Draws.Location = new System.Drawing.Point(579, 355);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(0, 20);
            this.Draws.TabIndex = 14;
  
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(878, 570);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.YWins);
            this.Controls.Add(this.XWins);
            this.Controls.Add(this.Ex);
            this.Controls.Add(this.R);
            this.Controls.Add(this.NG);
            this.Controls.Add(this.B22);
            this.Controls.Add(this.B21);
            this.Controls.Add(this.B20);
            this.Controls.Add(this.B12);
            this.Controls.Add(this.B11);
            this.Controls.Add(this.B10);
            this.Controls.Add(this.B02);
            this.Controls.Add(this.B01);
            this.Controls.Add(this.B00);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Windows Form Designer fields

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button NGButton;
        private System.Windows.Forms.Button RButton;
        private System.Windows.Forms.Button EButton;
        private System.Windows.Forms.Label XWin;
        private System.Windows.Forms.Label OWin;
        private System.Windows.Forms.Label Ties;
        private System.Windows.Forms.Button B00;
        private System.Windows.Forms.Button B01;
        private System.Windows.Forms.Button B02;
        private System.Windows.Forms.Button B12;
        private System.Windows.Forms.Button B11;
        private System.Windows.Forms.Button B10;
        private System.Windows.Forms.Button B22;
        private System.Windows.Forms.Button B21;
        private System.Windows.Forms.Button B20;
        private System.Windows.Forms.Button NG;
        private System.Windows.Forms.Button R;
        private System.Windows.Forms.Button Ex;
        private System.Windows.Forms.Label XWins;
        private System.Windows.Forms.Label YWins;
        private System.Windows.Forms.Label Draws;

        #endregion
    }
}

