using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_2_Player
{
    public partial class MainForm : Form
    {
        //variable declaration
        bool p1 = true;
        string p1Turn = "Player One's Turn";
        string p2Turn = "Player Two's Turn";
        int p1Score = 0, p2Score = 0, drawScore = 0;
        
        public MainForm()
        {
            InitializeComponent();
            newGamePanel.Visible = false;
            turnLabel.Text = p1Turn; //player one will always start for first game
            winLabel.Visible = false;
            scoresPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (p1) //if player one clicked the button, do the following
            {
                button1.Text = "X";
                button1.Enabled = false;
                checkWin();
                p1 = false; //p2 gets to play now
                turnLabel.Text = p2Turn;
            }
            else //if player two clicked the button, do the following
            {
                button1.Text = "O";
                button1.Enabled = false;
                checkWin();
                p1 = true;
                turnLabel.Text = p1Turn;
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (p1)
            {
                button2.Text = "X";
                button2.Enabled = false;
                checkWin();
                p1 = false; //p2 gets to play now
                turnLabel.Text = p2Turn;
            }
            else
            {
                button2.Text = "O";
                button2.Enabled = false;
                checkWin();
                p1 = true;
                turnLabel.Text = p1Turn;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (p1)
            {
                button3.Text = "X";
                button3.Enabled = false;
                checkWin();
                p1 = false; //p2 gets to play now
                turnLabel.Text = p2Turn;
            }
            else
            {
                button3.Text = "O";
                button3.Enabled = false;
                checkWin();
                p1 = true;
                turnLabel.Text = p1Turn;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (p1)
            {
                button4.Text = "X";
                button4.Enabled = false;
                checkWin();
                p1 = false; //p2 gets to play now
                turnLabel.Text = p2Turn;
            }
            else
            {
                button4.Text = "O";
                button4.Enabled = false;
                checkWin();
                p1 = true;
                turnLabel.Text = p1Turn;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (p1)
            {
                button5.Text = "X";
                button5.Enabled = false;
                checkWin();
                p1 = false; //p2 gets to play now
                turnLabel.Text = p2Turn;
            }
            else
            {
                button5.Text = "O";
                button5.Enabled = false;
                checkWin();
                p1 = true;
                turnLabel.Text = p1Turn;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (p1)
            {
                button6.Text = "X";
                button6.Enabled = false;
                checkWin();
                p1 = false; //p2 gets to play now
                turnLabel.Text = p2Turn;
            }
            else
            {
                button6.Text = "O";
                button6.Enabled = false;
                checkWin();
                p1 = true;
                turnLabel.Text = p1Turn;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (p1)
            {
                button7.Text = "X";
                button7.Enabled = false;
                checkWin();
                p1 = false; //p2 gets to play now
                turnLabel.Text = p2Turn;
            }
            else
            {
                button7.Text = "O";
                button7.Enabled = false;
                checkWin();
                p1 = true;
                turnLabel.Text = p1Turn;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (p1)
            {
                button8.Text = "X";
                button8.Enabled = false;
                checkWin();
                p1 = false; //p2 gets to play now
                turnLabel.Text = p2Turn;
            }
            else
            {
                button8.Text = "O";
                button8.Enabled = false;
                checkWin();
                p1 = true;
                turnLabel.Text = p1Turn;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (p1)
            {
                button9.Text = "X";
                button9.Enabled = false;
                checkWin();
                p1 = false; //p2 gets to play now
                turnLabel.Text = p2Turn;
            }
            else
            {
                button9.Text = "O";
                button9.Enabled = false;
                checkWin();
                p1 = true;
                turnLabel.Text = p1Turn;
            }
        }

        private void checkWin()
        {
            //check for player one win
            if      ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") ||
                     (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") ||
                     (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||

                     (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") ||
                     (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") ||
                     (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") ||

                     (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") ||
                     (button3.Text == "X" && button5.Text == "X" && button7.Text == "X"))
            {
                winLabel.Text = "Player One Wins!";
                winLabel.Visible = true;
                p1Score++;
                endGame();
            }
            //check for player two win
            else if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") ||
                     (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") ||
                     (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||

                     (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") ||
                     (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") ||
                     (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") ||

                     (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") ||
                     (button3.Text == "O" && button5.Text == "O" && button7.Text == "O"))
            {
                winLabel.Text = "Player Two Wins!";
                winLabel.Visible = true;
                p2Score++;
                endGame();
            }
            //check for draw
            else if  (!button1.Enabled && !button2.Enabled && !button3.Enabled &&
                      !button4.Enabled && !button5.Enabled && !button6.Enabled &&
                      !button7.Enabled && !button8.Enabled && !button9.Enabled)
            {
                winLabel.Text = "It's a draw!";
                winLabel.Visible = true;
                drawScore++;
                endGame();
            }

           

        }

        private void endGame()
        {
            disableButtons(); //disable unclicked buttons
            turnLabel.Visible = false; //hide turn label
            //put scores in score labels
            p1ScoreLabel.Text = p1Score.ToString();
            p2ScoreLabel.Text = p2Score.ToString();
            drawScoreLabel.Text = drawScore.ToString();
            //show new game panel & scores panel
            newGamePanel.Visible = true;
            scoresPanel.Visible = true;
            //hide welcome label after first game ends
            welcomeLabel.Visible = false;

        }

        private void disableButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void resetButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //reset scores
            p1Score = 0;
            p2Score = 0;
            drawScore = 0;
            //reset labels
            p1ScoreLabel.Text = p1Score.ToString();
            p2ScoreLabel.Text = p2Score.ToString();
            drawScoreLabel.Text = drawScore.ToString();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            resetButtons(); //make buttons clickable again
            turnLabel.Visible = true; //show who's turn it is
            newGamePanel.Visible = false; //hide new/reset buttons
            winLabel.Visible = false; //hide win label
        }
    }
}
