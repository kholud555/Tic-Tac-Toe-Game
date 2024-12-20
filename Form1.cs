using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Player1Score = 0;
        int Player2Score = 0;
        
        //Draw Game Outline
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255);
            Pen pen = new Pen(white);
            pen.Width = 10;

            //line 
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //Horizontal lines
            e.Graphics.DrawLine(pen, 540, 490, 540, 150);
            e.Graphics.DrawLine(pen, 670, 490, 670, 150);

          
            //vertically lines
            e.Graphics.DrawLine(pen, 400, 390, 800, 390);
            e.Graphics.DrawLine(pen, 400, 270, 810, 270);
        }

        enum enWinPossibilities : int
        {
            Horizontal1 = 7, Horizontal2 = 56, Horizontal3 = 448,
            Vertical1 = 73, Vertical2 = 146, Vertical3 = 292,
            Diagonal1 = 273, Diagonal2 = 84
        };

        void GameStatus()
        {
            if (lbPlayer.Text == "Player1")
            {
                lbGameStatus.Text = "Winner";
                lbGameResult.Text = "Player2";
            }
            else
            {
                lbGameStatus.Text = "Winner";
                lbGameResult.Text = "Player1";
            }
        }
        void EndGame()
        {
            GameStatus();
            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK,MessageBoxIcon.Information);

            //Enable buttons
            pbQuestion1.Enabled = false;
            pbQuestion2.Enabled = false;
            pbQuestion4.Enabled = false;
            pbQuestion8.Enabled = false;

            pbQuestion16.Enabled = false;
            pbQuestion32.Enabled = false;
            pbQuestion64.Enabled = false;

            pbQuestion128.Enabled = false;
            pbQuestion256.Enabled = false;
        }
        void CheckWinner(int PlayerScore)
        {
            if((PlayerScore & Convert.ToInt32(enWinPossibilities.Horizontal1)) == Convert.ToInt32(enWinPossibilities.Horizontal1))
            {
                pbQuestion1.BackColor = Color.Yellow;
                pbQuestion2.BackColor = Color.Yellow;
                pbQuestion4.BackColor = Color.Yellow;
                EndGame();
                return;
            }

            if ((PlayerScore & Convert.ToInt32(enWinPossibilities.Horizontal2)) == Convert.ToInt32(enWinPossibilities.Horizontal2))
            {
                pbQuestion8.BackColor = Color.Yellow;
                pbQuestion16.BackColor = Color.Yellow;
                pbQuestion32.BackColor = Color.Yellow;
                EndGame();
                return;
            }

            if ((PlayerScore & Convert.ToInt32(enWinPossibilities.Horizontal3)) == Convert.ToInt32(enWinPossibilities.Horizontal3))
            {
                pbQuestion64.BackColor = Color.Yellow;
                pbQuestion128.BackColor = Color.Yellow;
                pbQuestion256.BackColor = Color.Yellow;
                EndGame();
                return;
            }

            if ((PlayerScore & Convert.ToInt32(enWinPossibilities.Vertical1)) == Convert.ToInt32(enWinPossibilities.Vertical1))
            {
                pbQuestion1.BackColor = Color.Yellow;
                pbQuestion8.BackColor = Color.Yellow;
                pbQuestion64.BackColor = Color.Yellow;
                EndGame();
                return;
            }

            if ((PlayerScore & Convert.ToInt32(enWinPossibilities.Vertical2)) == Convert.ToInt32(enWinPossibilities.Vertical2))
            {
                pbQuestion2.BackColor = Color.Yellow;
                pbQuestion16.BackColor = Color.Yellow;
                pbQuestion128.BackColor = Color.Yellow;
                EndGame();
                return;
            }

            if ((PlayerScore & Convert.ToInt32(enWinPossibilities.Vertical3)) == Convert.ToInt32(enWinPossibilities.Vertical3))
            {
                pbQuestion4.BackColor = Color.Yellow;
                pbQuestion32.BackColor = Color.Yellow;
                pbQuestion256.BackColor = Color.Yellow;
                EndGame();
                return;
            }

            if ((PlayerScore & Convert.ToInt32(enWinPossibilities.Diagonal1)) == Convert.ToInt32(enWinPossibilities.Diagonal1))
            {
                pbQuestion1.BackColor = Color.Yellow;
                pbQuestion16.BackColor = Color.Yellow;
                pbQuestion256.BackColor = Color.Yellow;
                EndGame();
                return;
            }

            if ((PlayerScore & Convert.ToInt32(enWinPossibilities.Diagonal2)) == Convert.ToInt32(enWinPossibilities.Diagonal2))
            {
                pbQuestion4.BackColor = Color.Yellow;
                pbQuestion16.BackColor = Color.Yellow;
                pbQuestion64.BackColor = Color.Yellow;
                EndGame();
                return;
            }

            if((Player1Score + Player2Score) == 511)
            {
                lbGameStatus.Text = "Winner";
                lbGameResult.Text = "Draw";
                MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
   
        void PlayGame(object sender)
        {
              if (lbPlayer.Text == "Player1")
              {
                ((PictureBox)sender).Image = Properties.Resources.x;
                ((PictureBox)sender).Enabled = false;
                Player1Score += Convert.ToInt32(((PictureBox)sender).Tag);
                lbPlayer.Text = "Player2";
                CheckWinner(Player1Score);

              }
              else
              {
                ((PictureBox)sender).Image = Properties.Resources.o;
                ((PictureBox)sender).Enabled = false;
                Player2Score += Convert.ToInt32(((PictureBox)sender).Tag);
                lbPlayer.Text = "Player1";
                CheckWinner(Player2Score);
              }

        }
        void RestGame()
        {
            Player1Score = 0;
            Player2Score = 0;

            //Rest labels
            lbGameStatus.Text = "Game Status";
            lbGameResult.Text = "In Progress";
            lbPlayer.Text = "Player1";

            //Rest buttons Picture
            pbQuestion1.Image = Properties.Resources.question;
            pbQuestion2.Image = Properties.Resources.question;
            pbQuestion4.Image = Properties.Resources.question;
            pbQuestion8.Image = Properties.Resources.question;
            pbQuestion16.Image = Properties.Resources.question;
            pbQuestion32.Image = Properties.Resources.question;
            pbQuestion64.Image = Properties.Resources.question;
            pbQuestion128.Image = Properties.Resources.question;
            pbQuestion256.Image = Properties.Resources.question;

            //Rest Background
            pbQuestion1.BackColor = Color.Transparent;
            pbQuestion2.BackColor = Color.Transparent;
            pbQuestion4.BackColor = Color.Transparent;
            pbQuestion8.BackColor = Color.Transparent;
            pbQuestion16.BackColor = Color.Transparent;
            pbQuestion32.BackColor = Color.Transparent;
            pbQuestion64.BackColor = Color.Transparent;
            pbQuestion128.BackColor = Color.Transparent;
            pbQuestion256.BackColor = Color.Transparent;


            //Enable buttons
            pbQuestion1.Enabled = true;
            pbQuestion2.Enabled = true;
            pbQuestion4.Enabled = true;
            pbQuestion8.Enabled = true;
            pbQuestion16.Enabled = true;
            pbQuestion32.Enabled = true;
            pbQuestion64.Enabled = true;
            pbQuestion128.Enabled = true;
            pbQuestion256.Enabled = true;

        }
       
        //Game X O Click Controllers 
        private void pbQuestion_Click(object sender, EventArgs e)
        {
                PlayGame(sender);
        }

        //Reset button
        private void btnRest_Click(object sender, EventArgs e)
        {
            RestGame();
        }

    }
}
