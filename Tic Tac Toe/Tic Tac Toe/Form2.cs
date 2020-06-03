using System;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int players = 2;
        public int turns = 0;
        public int xWinCounter = 0;
        public int oWinCounter = 0;
        public int drawCounter = 0;
        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (players % 2 == 0) button.Text = "X";
                else button.Text = "O";
                players++;
                turns++;
                if (CheckWinner())
                {
                    if (button.Text == "X")
                    {
                        xWinCounter++;
                        MessageBox.Show("X Wins!");
                    }
                    else
                    {
                        oWinCounter++;
                        MessageBox.Show("O Wins!");
                    }
                    NewGame();
                }
                if (CheckDraw() && !CheckWinner())
                {
                    drawCounter++;
                    MessageBox.Show("Tie Game!");
                    NewGame();
                }
            }
        }
        private void ExitApp(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            XWins.Text = $"X Wins: {xWinCounter}";
            YWins.Text = $"O Wins: {oWinCounter}";
            Draws.Text = $"Ties: {drawCounter}";
        }
        void NewGame()
        {
            players = 2;
            turns = 0;
            B00.Text = B01.Text = B02.Text = B10.Text = B11.Text = B12.Text = B20.Text = B21.Text = B22.Text = "";
            XWins.Text = $"X Wins: {xWinCounter}";
            YWins.Text = $"O Wins: {oWinCounter}";
            Draws.Text = $"Ties: {drawCounter}";
        }
        private void NG_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        bool CheckDraw()
        {
            if (turns == 9) return true;
            else return false;
        }
        bool CheckWinner()
        {
            if (B00.Text == B01.Text && B01.Text == B02.Text && B00.Text != "") return true;
            else if (B10.Text == B11.Text && B11.Text == B12.Text && B10.Text != "") return true;
            else if (B20.Text == B21.Text && B21.Text == B22.Text && B20.Text != "") return true;
            else if (B00.Text == B10.Text && B10.Text == B20.Text && B00.Text != "") return true;
            else if (B01.Text == B11.Text && B11.Text == B21.Text && B01.Text != "") return true;
            else if (B02.Text == B12.Text && B12.Text == B22.Text && B02.Text != "") return true;
            else if (B00.Text == B11.Text && B11.Text == B22.Text && B00.Text != "") return true;
            else if (B20.Text == B11.Text && B11.Text == B02.Text && B20.Text != "") return true;
            else return false;
        }
        private void R_Click(object sender, EventArgs e)
        {
            xWinCounter = oWinCounter = drawCounter = 0;
            NewGame();
        }
    }
}
