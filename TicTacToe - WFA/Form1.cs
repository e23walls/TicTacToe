/*  Tic Tac Toe game created by Emily Walls
 * On May 9th, 2012
 * to play Tic Tac Toe, obviously
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace TicTacToe___WFA
{
    public partial class Form1 : Form
    {
        // declare variables
        public bool turn = true;  // computer starts when turn is false; user starts when turn is true
        public char winner = 'N';  // O is computer; X is user; C is cat's game; N is no one has won yet
        int playCount = 0;
        string typeOfGame = "easy";
        public int counter = 0;
        public bool canGoHere = false;
        public bool multi = false; // multiplayer is off; set to true to turn on
        public char user = 'X';
        public string[] userNames = new string[2];
        public string whowon;
        public int displayAlerts = 2;
        static int pleaseWork;
        public int score = 10000;  // make user lose points for long games or ones where lots of turns are taken
        public Stopwatch sw = new Stopwatch();
        public List<int> highScores = new List<int>();
        public int gameType = 0;
        string endEffect;
        public bool mute = false; // default is unmuted
        public System.Media.SoundPlayer effects = new System.Media.SoundPlayer(@"h:\turnTaken.wav");  // play when turn taken


        public void setValues()
        {
            pleaseWork = displayAlerts;
        }

        public Form1()
        {
            InitializeComponent();
            button1x1.SendToBack();  // send all buttons to back so that they aren't on top of lines
            button1x2.SendToBack();
            button1x3.SendToBack();
            button2x1.SendToBack();
            button2x2.SendToBack();
            button2x3.SendToBack();
            button3x1.SendToBack();
            button3x2.SendToBack();
            button3x3.SendToBack();
            muteButton.SendToBack();
        }

        public char declareWinner()
        {
            if (playCount >= 5)  // can't be a winner until after 5 turns
            {
                // make sure all buttons have been filled before declaring the cat won, but do it first so it can test to see if there's a winner
                // as well as the grid being full
                if (button1x1.Text.ToString() != "" && button2x1.Text.ToString() != "" && button3x1.Text.ToString() != "" && button1x2.Text.ToString() != "" && button2x2.Text.ToString() != "" && button3x2.Text.ToString() != "" && button1x3.Text.ToString() != "" && button2x3.Text.ToString() != "" && button3x3.Text.ToString() != "")
                    winner = 'C';

                // determine who the winner is (if any)
                if (button1x1.Text.ToString() == button2x1.Text.ToString() && button2x1.Text.ToString() == button3x1.Text.ToString() && button3x1.Text != "")
                {
                    winner = Convert.ToChar(button1x1.Text.ToString());
                    row1Line.Visible = true;
                }
                else if (button1x2.Text.ToString() == button2x2.Text.ToString() && button2x2.Text.ToString() == button3x2.Text.ToString() && button3x2.Text != "")
                {
                    winner = Convert.ToChar(button1x2.Text.ToString());
                    row2Line.Visible = true;
                }
                else if (button1x3.Text.ToString() == button2x3.Text.ToString() && button2x3.Text.ToString() == button3x3.Text.ToString() && button3x3.Text != "")
                {
                    winner = Convert.ToChar(button1x3.Text.ToString());
                    row3Line.Visible = true;
                }
                else if (button1x1.Text.ToString() == button1x2.Text.ToString() && button1x2.Text.ToString() == button1x3.Text.ToString() && button1x3.Text != "")
                {
                    winner = Convert.ToChar(button1x1.Text.ToString());
                    col1Line.Visible = true;
                }
                else if (button2x1.Text.ToString() == button2x2.Text.ToString() && button2x2.Text.ToString() == button2x3.Text.ToString() && button2x3.Text != "")
                {
                    winner = Convert.ToChar(button2x1.Text.ToString());
                    col2Line.Visible = true;
                }

                else if (button3x1.Text.ToString() == button3x2.Text.ToString() && button3x2.Text.ToString() == button3x3.Text.ToString() && button3x3.Text != "")
                {
                    winner = Convert.ToChar(button3x1.Text.ToString());
                    col3Line.Visible = true;
                }
                else if (button1x1.Text.ToString() == button2x2.Text.ToString() && button2x2.Text.ToString() == button3x3.Text.ToString() && button3x3.Text != "")
                {
                    winner = Convert.ToChar(button1x1.Text.ToString());
                    diagonal1Line.Visible = true;
                }
                else if (button1x3.Text.ToString() == button2x2.Text.ToString() && button2x2.Text.ToString() == button3x1.Text.ToString() && button3x1.Text != "")
                {
                    winner = Convert.ToChar(button1x3.Text.ToString());
                    diagonal2Line.Visible = true;
                }
            }
            else
            {
                winner = 'N';
            }
            return winner;
        }

        private void button1x1_Click(object sender, EventArgs e)
        {
            if ((button1x1.Text == "" && turn == true) || multi == true && button1x1.Text == "")
            {
                sw.Stop();
                if (mute == false)
                    effects.Play();
                score -= Convert.ToInt32(sw.ElapsedMilliseconds / 1000);
                button1x1.Text = user.ToString();
                playCount++;
                score -= 50;
                turn = false; // end turn
                if (multi == true)
                {
                    if (user == 'X')
                        whosTurnTextBox.Text = "O's turn.";
                    else
                        whosTurnTextBox.Text = "X's turn.";
                }
                else
                    whosTurnTextBox.Text = "Computer's turn.";
                if (declareWinner() != 'N')
                    whoWon();
                else
                {
                    if (multi == false)
                        nextTurn();
                    else
                        nextUserTurn();
                }
            }
        }

        private void button2x1_Click(object sender, EventArgs e)
        {
            if ((button2x1.Text == "" && turn == true) || multi == true && button2x1.Text == "")
            {
                sw.Stop();
                if (mute == false)
                    effects.Play();
                score -= Convert.ToInt32(sw.ElapsedMilliseconds / 1000);
                button2x1.Text = user.ToString();
                playCount++;
                score -= 50;
                turn = false; // end turn
                if (multi == true)
                {
                    if (user == 'X')
                        whosTurnTextBox.Text = "O's turn.";
                    else
                        whosTurnTextBox.Text = "X's turn.";
                }
                else
                    whosTurnTextBox.Text = "Computer's turn.";
                if (declareWinner() != 'N')
                    whoWon();
                else
                {
                    if (multi == false)
                        nextTurn();
                    else
                        nextUserTurn();
                }
            }
        }

        private void button3x1_Click(object sender, EventArgs e)
        {
            if ((button3x1.Text == "" && turn == true) || multi == true && button3x1.Text == "")
            {
                sw.Stop();
                if (mute == false)
                    effects.Play();
                score -= Convert.ToInt32(sw.ElapsedMilliseconds / 1000);
                button3x1.Text = user.ToString();
                playCount++;
                score -= 50;
                turn = false; // end turn
                if (multi == true)
                {
                    if (user == 'X')
                        whosTurnTextBox.Text = "O's turn.";
                    else
                        whosTurnTextBox.Text = "X's turn.";
                }
                else
                    whosTurnTextBox.Text = "Computer's turn.";
                if (declareWinner() != 'N')
                    whoWon();
                else
                {
                    if (multi == false)
                        nextTurn();
                    else
                        nextUserTurn();
                }
            }
        }

        private void button1x2_Click(object sender, EventArgs e)
        {
            if ((button1x2.Text == "" && turn == true) || multi == true && button1x2.Text == "")
            {
                sw.Stop();
                if (mute == false)
                    effects.Play();
                score -= Convert.ToInt32(sw.ElapsedMilliseconds / 1000);
                button1x2.Text = user.ToString();
                playCount++;
                score -= 50;
                turn = false; // end turn
                if (multi == true)
                {
                    if (user == 'X')
                        whosTurnTextBox.Text = "O's turn.";
                    else
                        whosTurnTextBox.Text = "X's turn.";
                }
                else
                    whosTurnTextBox.Text = "Computer's turn.";
                if (declareWinner() != 'N')
                    whoWon();
                else
                {
                    if (multi == false)
                        nextTurn();
                    else
                        nextUserTurn();
                }
            }
        }

        private void button2x2_Click(object sender, EventArgs e)
        {
            if ((button2x2.Text == "" && turn == true) || multi == true && button2x2.Text == "")
            {
                sw.Stop();
                if (mute == false)
                    effects.Play();
                score -= Convert.ToInt32(sw.ElapsedMilliseconds / 1000);
                button2x2.Text = user.ToString();
                playCount++;
                score -= 50;
                turn = false; // end turn
                if (multi == true)
                {
                    if (user == 'X')
                        whosTurnTextBox.Text = "O's turn.";
                    else
                        whosTurnTextBox.Text = "X's turn.";
                }
                else
                    whosTurnTextBox.Text = "Computer's turn.";
                if (declareWinner() != 'N')
                    whoWon();
                else
                {
                    if (multi == false)
                        nextTurn();
                    else
                        nextUserTurn();
                }
            }
        }

        private void button3x2_Click(object sender, EventArgs e)
        {
            if ((button3x2.Text == "" && turn == true) || multi == true && button3x2.Text == "")
            {
                sw.Stop();
                if (mute == false)
                    effects.Play();
                score -= Convert.ToInt32(sw.ElapsedMilliseconds / 1000);
                button3x2.Text = user.ToString();
                playCount++;
                score -= 50;
                turn = false; // end turn
                if (multi == true)
                {
                    if (user == 'X')
                        whosTurnTextBox.Text = "O's turn.";
                    else
                        whosTurnTextBox.Text = "X's turn.";
                }
                else
                    whosTurnTextBox.Text = "Computer's turn.";
                if (declareWinner() != 'N')
                    whoWon();
                else
                {
                    if (multi == false)
                        nextTurn();
                    else
                        nextUserTurn();
                }
            }
        }

        private void button1x3_Click(object sender, EventArgs e)
        {
            if ((button1x3.Text == "" && turn == true) || multi == true && button1x3.Text == "")
            {
                sw.Stop();
                if (mute == false)
                    effects.Play();
                score -= Convert.ToInt32(sw.ElapsedMilliseconds / 1000);
                button1x3.Text = user.ToString();
                playCount++;
                score -= 50;
                turn = false; // end turn
                if (multi == true)
                {
                    if (user == 'X')
                        whosTurnTextBox.Text = "O's turn.";
                    else
                        whosTurnTextBox.Text = "X's turn.";
                }
                else
                    whosTurnTextBox.Text = "Computer's turn.";
                if (declareWinner() != 'N')
                    whoWon();
                else
                {
                    if (multi == false)
                        nextTurn();
                    else
                        nextUserTurn();
                }
            }
        }

        private void button2x3_Click(object sender, EventArgs e)
        {
            if ((button2x3.Text == "" && turn == true) || multi == true && button2x3.Text == "")
            {
                sw.Stop();
                if (mute == false)
                    effects.Play();
                score -= Convert.ToInt32(sw.ElapsedMilliseconds / 1000);
                button2x3.Text = user.ToString();
                playCount++;
                score -= 50;
                turn = false; // end turn
                if (multi == true)
                {
                    if (user == 'X')
                        whosTurnTextBox.Text = "O's turn.";
                    else
                        whosTurnTextBox.Text = "X's turn.";
                }
                else
                    whosTurnTextBox.Text = "Computer's turn.";
                if (declareWinner() != 'N')
                    whoWon();
                else
                {
                    if (multi == false)
                        nextTurn();
                    else
                        nextUserTurn();
                }
            }
        }

        private void button3x3_Click(object sender, EventArgs e)
        {
            if ((button3x3.Text == "" && turn == true) || multi == true && button3x3.Text == "")
            {
                sw.Stop();
                if (mute == false)
                    effects.Play();
                score -= Convert.ToInt32(sw.ElapsedMilliseconds / 1000);
                button3x3.Text = user.ToString();
                playCount++;
                score -= 50;
                turn = false; // end turn
                if (multi == true)
                {
                    if (user == 'X')
                        whosTurnTextBox.Text = "O's turn.";
                    else
                        whosTurnTextBox.Text = "X's turn.";
                }
                else
                    whosTurnTextBox.Text = "Computer's turn.";
                if (declareWinner() != 'N')
                    whoWon();
                else
                {
                    if (multi == false)
                        nextTurn();
                    else
                        nextUserTurn();
                }
            }
        }

        private void newGame()
        {
            button1x1.Text = "";  // keep all button .Texts blank but not null so the program doesn't glitch
            button2x1.Text = "";
            button3x1.Text = "";
            button1x2.Text = "";
            button2x2.Text = "";
            button3x2.Text = "";
            button1x3.Text = "";
            button2x3.Text = "";
            button3x3.Text = "";

            button1x1.Enabled = true;  // enable the buttons so the user can play (default to not enabled so user
            button2x1.Enabled = true;  // can't press them, which would make the program glitch if the user did)
            button3x1.Enabled = true;
            button1x2.Enabled = true;
            button2x2.Enabled = true;
            button3x2.Enabled = true;
            button1x3.Enabled = true;
            button2x3.Enabled = true;
            button3x3.Enabled = true;

            // make all lines invisible
            col1Line.Visible = false;
            col2Line.Visible = false;
            col3Line.Visible = false;
            row1Line.Visible = false;
            row2Line.Visible = false;
            row3Line.Visible = false;
            diagonal1Line.Visible = false;
            diagonal2Line.Visible = false;

            playCount = 0;  // reset play count
            user = 'X'; // reset player
            if (gameType == 0)
                score = 5000;
            else if (gameType == 1)
                score = 10000; // reset score based on difficulty level
            scoreTextBox.Text = ""; // clearn score label

            if (gameType == 2)
                multi = true;
            else
                multi = false;

            Random ran = new Random();
            int whoStarts = ran.Next(1, 3);
            if (whoStarts == 1 && multi == false)
            {
                if (gameType == 0)
                {
                    turn = false;
                    whosTurnTextBox.Text = "Computer's turn.";
                    typeOfGame = "easy";
                    nextTurn();
                }
                else if (gameType == 1 && multi == false)
                {
                    turn = false;
                    whosTurnTextBox.Text = "Computer's turn.";
                    typeOfGame = "hard";
                    nextTurn();
                }
            }
            else if (whoStarts != 1 && multi == false)
            {
                turn = true;  // user starts
                sw.Start();
                whosTurnTextBox.Text = "Your turn.";
                // decide type of game based on user input
                if (gameType == 0)
                {
                    typeOfGame = "easy";
                }
                else if (gameType == 1)
                {
                    typeOfGame = "hard";
                }
            }
            if (gameType == 2)
            {
                nextPersonTurn npt = new nextPersonTurn(userNames);  // gets names of users
                if (userNames[0] == null)
                {
                    npt.Show();
                    userNames = npt.returnNames();
                }

                multiplayer();
            }
        }

        private void whoWon()
        {
            if (multi == false)
            {
                whowon = declareWinner().ToString();
            }
            else if (multi == true)  // if the usernames are blank, make the winner equal X or O (respectively)
            {
                if (user == 'X' && userNames[0] != null)
                    whowon = userNames[0];
                else if (user == 'X' && userNames[0] == null)
                    whowon = user.ToString();
                else if (user == 'O' && userNames[1] != null)
                    whowon = userNames[1];
                else if (user == 'O' && userNames[1] == null)
                    whowon = user.ToString();
            }
            switch (winner)
            {
                case 'O':
                    score -= 5000;  // subtract points for losing
                    whosTurnTextBox.Text = whowon + " won!";
                    if (multi == true)
                        endEffect = @"H:\\userWon.wav"; // based on if winner was human or not, load proper .wav file
                    else
                        endEffect = @"H:\\userLost.wav";
                    //MessageBox.Show(whowon + " won!", "Results");   // why does it show this twice during easy game?
                    break;
                case 'X':
                    score += 5000;  // add points for winning
                    endEffect = @"H:\\userWon.wav";
                    whosTurnTextBox.Text = whowon + " won!";
                    //MessageBox.Show(whowon + " won!", "Results");
                    break;
                case 'C':
                    //MessageBox.Show("Cat's game.", "Results");   // why does it show this twice during easy game?
                    endEffect = @"H:\\catsGame.wav";
                    whosTurnTextBox.Text = "Cat's game.";
                    break;
            }
            System.Media.SoundPlayer effect = new System.Media.SoundPlayer(endEffect);
            if (mute == false)
                effect.Play();
            effect.Dispose();
            this.Refresh();

            if (multi == false)
            {
                if (score < 0)
                    score = 0; // make negative scores equal to zero
                else
                    highScores.Add(score);  // add current highscore to list of highscores (unless score is zero or lower
            }
            button1x1.Enabled = false;  // disable all buttons so user must click "New Game"
            button2x1.Enabled = false;  // after winner has been determined
            button3x1.Enabled = false;
            button1x2.Enabled = false;
            button2x2.Enabled = false;
            button3x2.Enabled = false;
            button1x3.Enabled = false;
            button2x3.Enabled = false;
            button3x3.Enabled = false;

            //whosTurnTextBox.Text += " -- Game over.";
            if (multi == false)
                scoreTextBox.Text = "Score: " + score.ToString();  // only do this when user is against computer
            else
                scoreTextBox.Text = "";
            saveScores();
            this.Refresh();
        }

        public int decideStartPosition()  // computer decides where to start
        {
            Random ran = new Random();
            int pos = ran.Next(1, 10);
            return pos;
        }
        public void nextTurn()
        {
            if (typeOfGame == "easy" && multi == false)
            {
                this.Refresh();  // refresh object
                System.Threading.Thread.Sleep(200);  // make computer act like it's thinking before it takes its turn
                canGoHere = false;  // defaults to false so while loop can run

                int whereToStart = decideStartPosition();
                randomTurn();

                playCount++;  // increase value that counts number of turns

                if (declareWinner() != 'N')
                    whoWon();
                else
                {
                    turn = true;  // turn becomes user's
                    sw.Start();
                    whosTurnTextBox.Text = "Your turn.";
                }

                this.Refresh();
            }
            else if (typeOfGame == "hard" && multi == false)
            {
                counter = 0;
                this.Refresh();  // refresh object
                System.Threading.Thread.Sleep(200);  // Makes computer act like it's thinking before it takes its turn
                // The computer will sometimes take longer than this because it needs to calculate
                canGoHere = false;
                int whereToStart = decideStartPosition();
                if (playCount > 1)
                {
                    while (canGoHere == false)
                    {
                        counter++;
                        // column 1  Works? YES!!!
                        if (((button1x1.Text == button1x2.Text || button1x2.Text == button1x3.Text || button1x1.Text == button1x3.Text) && ((button1x1.Text != "" && button1x2.Text != "" && button1x3.Text == "") || (button1x2.Text != "" && button1x3.Text != "" && button1x1.Text == "") || (button1x1.Text != "" && button1x3.Text != "" && button1x2.Text == ""))))
                        {
                            if (button1x1.Text == button1x2.Text && button1x2.Text != "" && button1x3.Text == "")
                            {   // [O][ ][ ]
                                // [O][ ][ ]
                                // [ ][ ][ ]
                                button1x3.Text = "O";   // computer takes turn; user's turn begins
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;  // ends loop
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else if (button1x2.Text == button1x3.Text && button1x2.Text != "" && button1x1.Text == "")
                            {   // [ ][ ][ ]
                                // [O][ ][ ]
                                // [O][ ][ ]
                                button1x1.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else if (button1x1.Text == button1x3.Text && button1x3.Text != "" && button1x2.Text == "")
                            {   // [O][ ][ ]
                                // [ ][ ][ ]
                                // [O][ ][ ]
                                button1x2.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else
                                randomTurn();   // if the computer can't find a strategic place to go, take a random turn
                            if (declareWinner() != 'N')
                                whoWon();
                        }
                        // column 2  Works? YES!!!
                        else if (((button2x1.Text == button2x2.Text || button2x2.Text == button2x3.Text || button2x1.Text == button2x3.Text) && ((button2x1.Text != "" && button2x2.Text != "" && button2x3.Text == "") || (button2x2.Text != "" && button2x3.Text != "" && button2x1.Text == "") || (button2x1.Text != "" && button2x3.Text != "" && button2x2.Text == ""))))
                        {
                            if (button2x1.Text == button2x2.Text && button2x2.Text != "" && button2x3.Text == "")
                            {   // [ ][O][ ]
                                // [ ][O][ ]
                                // [ ][ ][ ]
                                button2x3.Text = "O";   // computer takes turn; user's turn begins
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else if (button2x2.Text == button2x3.Text && button2x3.Text != "" && button2x1.Text == "")
                            {   // [ ][ ][ ]
                                // [ ][O][ ]
                                // [ ][O][ ]
                                button2x1.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else if (button2x1.Text == button2x3.Text && button2x3.Text != "" && button2x2.Text == "")
                            {   // [ ][O][ ]
                                // [ ][ ][ ]
                                // [ ][O][ ]
                                button2x2.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else
                                randomTurn();
                            if (declareWinner() != 'N')
                                whoWon();
                        }
                        // column 3  Works? YES!!!
                        else if (((button3x1.Text == button3x2.Text || button3x2.Text == button3x3.Text || button3x1.Text == button3x3.Text) && ((button3x1.Text != "" && button3x2.Text != "" && button3x3.Text == "") || (button3x2.Text != "" && button3x3.Text != "" && button3x1.Text == "") || (button3x1.Text != "" && button3x3.Text != "" && button3x2.Text == ""))))
                        {
                            if (button3x1.Text == button3x2.Text && button3x2.Text != "" && button3x3.Text == "")
                            {   // [ ][ ][O]
                                // [ ][ ][O]
                                // [ ][ ][ ]
                                button3x3.Text = "O";   // computer takes turn; user's turn begins
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else if (button3x2.Text == button3x3.Text && button3x3.Text != "" && button3x1.Text == "")
                            {   // [ ][ ][ ]
                                // [ ][ ][O]
                                // [ ][ ][O]
                                button3x1.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else if (button3x1.Text == button3x3.Text && button3x3.Text != "" && button3x2.Text == "")
                            {   // [ ][ ][O]
                                // [ ][ ][ ]
                                // [ ][ ][O]
                                button3x2.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else
                                randomTurn();
                            if (declareWinner() != 'N')
                                whoWon();
                        }
                        // row 1  Works? YES!!!
                        else if (((button1x1.Text == button2x1.Text || button2x1.Text == button3x1.Text || button1x1.Text == button3x1.Text) && ((button1x1.Text != "" && button2x1.Text != "" && button3x1.Text == "") || (button2x1.Text != "" && button3x1.Text != "" && button1x1.Text == "") || (button1x1.Text != "" && button3x1.Text != "" && button2x1.Text == ""))))
                        {
                            if (button1x1.Text == button2x1.Text && button2x1.Text != "" && button3x1.Text == "")
                            {   // [O][O][ ]
                                // [ ][ ][ ]
                                // [ ][ ][ ]
                                button3x1.Text = "O";   // computer takes turn; user's turn begins
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else if (button2x1.Text == button3x1.Text && button3x1.Text != "" && button1x1.Text == "")
                            {   // [ ][O][O]
                                // [ ][ ][ ]
                                // [ ][ ][ ]
                                button1x1.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else if (button1x1.Text == button3x1.Text && button3x1.Text != "" && button2x1.Text == "")
                            {   // [O][ ][O]
                                // [ ][ ][ ]
                                // [ ][ ][ ]
                                button2x1.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else
                                randomTurn();
                            if (declareWinner() != 'N')
                                whoWon();
                        }
                        // row 2  Works? YES!!!
                        else if (((button1x2.Text == button2x2.Text || button2x2.Text == button3x2.Text || button1x2.Text == button3x2.Text) && ((button1x2.Text != "" && button2x2.Text != "" && button3x2.Text == "") || (button2x2.Text != "" && button3x2.Text != "" && button1x2.Text == "") || (button1x2.Text != "" && button3x2.Text != "" && button2x2.Text == ""))))
                        {
                            if (button1x2.Text == button2x2.Text && button2x2.Text != "" && button3x2.Text == "")
                            {   // [ ][ ][ ]
                                // [O][O][ ]
                                // [ ][ ][ ]
                                button3x2.Text = "O";   // computer takes turn; user's turn begins
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else if (button2x2.Text == button3x2.Text && button3x2.Text != "" && button1x2.Text == "")
                            {   // [ ][ ][ ]
                                // [ ][O][O]
                                // [ ][ ][ ]
                                button1x2.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else if (button1x2.Text == button3x2.Text && button3x2.Text != "" && button2x2.Text == "")
                            {   // [ ][ ][ ]
                                // [O][ ][O]
                                // [ ][ ][ ]
                                button2x2.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else
                                randomTurn();
                            if (declareWinner() != 'N')
                                whoWon();
                        }
                        // row 3   Works? YES!!!
                        else if (((button1x3.Text == button2x3.Text || button2x3.Text == button3x3.Text || button1x3.Text == button3x3.Text) && ((button1x3.Text != "" && button2x3.Text != "" && button3x3.Text == "") || (button2x3.Text != "" && button3x3.Text != "" && button1x3.Text == "") || (button1x3.Text != "" && button3x3.Text != "" && button2x3.Text == ""))))
                        {
                            if (button1x3.Text == button2x3.Text && button2x3.Text != "" && button3x3.Text == "")
                            {   // [ ][ ][ ]
                                // [ ][ ][ ]
                                // [O][O][ ]
                                button3x3.Text = "O";   // computer takes turn; user's turn begins
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else if (button2x3.Text == button3x3.Text && button2x3.Text != "" && button1x3.Text == "")
                            {   // [ ][ ][ ]
                                // [ ][ ][ ]
                                // [ ][O][O]
                                button1x3.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else if (button1x3.Text == button3x3.Text && button3x3.Text != "" && button2x3.Text == "")
                            {   // [ ][ ][ ]
                                // [ ][ ][ ]
                                // [O][ ][O]
                                button2x3.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else
                                randomTurn();
                            if (declareWinner() != 'N')
                                whoWon();
                        }
                        // diagonal 1   Works? YES!!!
                        else if (((button1x1.Text == button2x2.Text || button2x2.Text == button3x3.Text || button1x1.Text == button3x3.Text) && ((button1x1.Text != "" && button2x2.Text != "" && button3x3.Text == "") || (button2x2.Text != "" && button3x3.Text != "" && button1x1.Text == "") || (button1x1.Text != "" && button3x3.Text != "" && button2x2.Text == ""))))
                        {
                            if (button1x1.Text == button2x2.Text && button2x2.Text != "" && button3x3.Text == "")
                            {   // [O][ ][ ]
                                // [ ][O][ ]
                                // [ ][ ][ ]
                                button3x3.Text = "O";   // computer takes turn; user's turn begins
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else if (button2x2.Text == button3x3.Text && button3x3.Text != "" && button1x1.Text == "")
                            {   // [ ][ ][ ]
                                // [ ][O][ ]
                                // [ ][ ][O]
                                button1x1.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else if (button1x1.Text == button3x3.Text && button3x3.Text != "" && button2x2.Text == "")
                            {   // [O][ ][ ]
                                // [ ][ ][ ]
                                // [ ][ ][O]
                                button2x2.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else
                                randomTurn();
                            if (declareWinner() != 'N')
                                whoWon();
                        }
                        // diagonal 2    Works? YES!!!
                        else if (((button1x3.Text == button2x2.Text || button2x2.Text == button3x1.Text || button1x3.Text == button3x1.Text) && ((button1x3.Text != "" && button2x2.Text != "" && button3x1.Text == "") || (button2x2.Text != "" && button3x1.Text != "" && button1x3.Text == "") || (button1x3.Text != "" && button3x1.Text != "" && button2x2.Text == ""))))
                        {
                            if (button1x3.Text == button2x2.Text && button2x2.Text != "" && button3x1.Text == "")
                            {   // [ ][ ][ ]
                                // [ ][O][ ]
                                // [O][ ][ ]
                                button3x1.Text = "O";   // computer takes turn; user's turn begins
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else if (button2x2.Text == button3x1.Text && button3x1.Text != "" && button1x3.Text == "")
                            {   // [ ][ ][O]
                                // [ ][O][ ]
                                // [ ][ ][ ]
                                button1x3.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else if (button1x3.Text == button3x1.Text && button3x1.Text != "" && button2x2.Text == "")
                            {   // [ ][ ][O]
                                // [ ][ ][ ]
                                // [O][ ]
                                button2x2.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                turn = true;
                                sw.Start();
                                canGoHere = true;
                                whosTurnTextBox.Text = "Your turn.";
                            }
                            else
                                randomTurn();
                            if (declareWinner() != 'N')
                                whoWon();
                        }
                        else
                            randomTurn();   // if no good place to go, take turn randomly
                    }

                }
                else if ((playCount <= 1))  // if there isn't a good place to put an "O" (from so few turns having been taken), place "O" randomly
                {
                    randomTurn();
                }
            }
        }
        public void randomTurn()
        {
            if (multi == false)
            {
                while (canGoHere == false)
                {
                    System.Threading.Thread.Sleep(200);
                    this.Refresh();
                    int whereToStart = decideStartPosition();

                    // computer decides where to go and if computer can't go there, find a new position
                    switch (whereToStart)
                    {
                        case 1:
                            if (button1x1.Text == "")
                            {
                                button1x1.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                whosTurnTextBox.Text = "Your turn.";
                                canGoHere = true;  // change to true so loop can stop
                            }
                            else
                            {
                                canGoHere = false;  // leave false so loop runs again
                                whereToStart = decideStartPosition();  // decide new start position
                            }
                            break;
                        case 2:
                            if (button2x1.Text == "")
                            {
                                button2x1.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                whosTurnTextBox.Text = "Your turn.";
                                canGoHere = true;
                            }
                            else
                            {
                                canGoHere = false;
                                whereToStart = decideStartPosition();
                            }
                            break;
                        case 3:
                            if (button3x1.Text == "")
                            {
                                button3x1.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                whosTurnTextBox.Text = "Your turn.";
                                canGoHere = true;
                            }
                            else
                            {
                                canGoHere = false;
                                whereToStart = decideStartPosition();
                            }
                            break;
                        case 4:
                            if (button1x2.Text == "")
                            {
                                button1x2.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                whosTurnTextBox.Text = "Your turn.";
                                canGoHere = true;
                            }
                            else
                            {
                                canGoHere = false;
                                whereToStart = decideStartPosition();
                            }
                            break;
                        case 5:
                            if (button2x2.Text == "")
                            {
                                button2x2.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                whosTurnTextBox.Text = "Your turn.";
                                canGoHere = true;
                            }
                            else
                            {
                                canGoHere = false;
                                whereToStart = decideStartPosition();
                            }
                            break;
                        case 6:
                            if (button3x2.Text == "")
                            {
                                button3x2.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                whosTurnTextBox.Text = "Your turn.";
                                canGoHere = true;
                            }
                            else
                            {
                                canGoHere = false;
                                whereToStart = decideStartPosition();
                            }
                            break;
                        case 7:
                            if (button1x3.Text == "")
                            {
                                button1x3.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                whosTurnTextBox.Text = "Your turn.";
                                canGoHere = true;
                            }
                            else
                            {
                                canGoHere = false;
                                whereToStart = decideStartPosition();
                            }
                            break;
                        case 8:
                            if (button2x3.Text == "")
                            {
                                button2x3.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                whosTurnTextBox.Text = "Your turn.";
                                canGoHere = true;
                            }
                            else
                            {
                                canGoHere = false;
                                whereToStart = decideStartPosition();
                            }
                            break;
                        case 9:
                            if (button3x3.Text == "")
                            {
                                button3x3.Text = "O";
                                if (mute == false)
                                    effects.Play();
                                playCount++;
                                whosTurnTextBox.Text = "Your turn.";
                                canGoHere = true;
                            }
                            else
                            {
                                canGoHere = false;
                                whereToStart = decideStartPosition();
                            }
                            break;
                    }
                }
                if (declareWinner() != 'N')
                {
                    whoWon();
                }
                else
                {
                    turn = true; // change turns
                    sw.Start();
                }
            }
        }
        public void multiplayer()
        {
            user = 'O';
            multi = true;
            Random ran = new Random();
            int whoStarts = ran.Next(0, 2);
            if (whoStarts == 0)
            {
                turn = true;
                sw.Start();
            }
            else
                turn = false;
            if (turn == true)   // decide who goes first
                whosTurnTextBox.Text = userNames[0] + "'s turn.";
            else
                whosTurnTextBox.Text = userNames[1] + "'s turn.";
            nextUserTurn();

        }
        public void nextUserTurn()
        {
            int num = 0;
            if (declareWinner() != 'N') // if there's no winner, continue game
                whoWon();
            else
            {
                if (user == 'O')
                {
                    num = 0;
                    user = 'X';
                }
                else
                {
                    num = 1;
                    user = 'O';
                }
                if (userNames[0] != null)
                {
                    whosTurnTextBox.Text = userNames[num] + "'s turn.";
                    if (pleaseWork == 1)
                        MessageBox.Show(userNames[num] + "'s turn!", "Next turn", MessageBoxButtons.OK);  // only show messageboxes
                    this.Refresh();
                }                                                                                         // if user wants them
                else if (userNames[0] == null)
                {
                    whosTurnTextBox.Text = user + "'s turn.";
                }
            }

        }

        private void highscoresButton_Click(object sender, EventArgs e)
        {
            showScores();
        }
        private void showScores()
        {
            saveScores();  // save scores
            // display new form that lists all highscores from greatest to lowest
            highscoresForm hsf = new highscoresForm(highScores);
            hsf.Show();
            this.Refresh();
        }
        private void saveScores()
        {
            try
            {
                // read from text file (even though it's a text file, the extension will be changed to discourage changing of it with a text editor program
                using (StreamReader sr = new StreamReader("h:\\savedata.SAV"))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        highScores.Add(Convert.ToInt32(line));
                    }
                }
            }
            catch
            {
                // if  file doesn't exist, create a new, blank one
                System.IO.StreamWriter saveData = new System.IO.StreamWriter("h:\\savedata.SAV");
                saveData.Close();  // give user information about using old save files
                saveData.Dispose();
                MessageBox.Show("Save file could not be found so a new one has been created.\nTo use a different save file, delete the new one and move\nthe old one into your h-drive.\nDo not change its name from \"savedata.SAV\"!", "Warning");
                this.Refresh();
            }

            // write all scores to text file
            System.IO.StreamWriter file = new System.IO.StreamWriter("h:\\savedata.SAV");
            for (int i = 0; i < highScores.Count; i++)
            {
                file.WriteLine(highScores[i]);
            }
            file.Close();
            file.Dispose();
            highScores.Clear();  // prevents overwriting of scores
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            aboutWindow about = new aboutWindow();
            about.Show();
            //MessageBox.Show("   Program created by:\nEmily Walls, Jack Davis,\n   \t   and Jordan McConkey.", "About");
            this.Refresh();
        }

        private void highscoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showScores();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpForm hf = new helpForm();
            hf.Show();
            this.Refresh();
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameType = 0;
            newGame();
        }

        private void hardSinglePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameType = 1;
            newGame();
        }

        private void multiplayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameType = 2;
            newGame();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // exit program
        }

        private void resetSaveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("    This deletes all highscores.\nAre you sure you want to do this?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)   // if user says yes, overwrite save file with blank one
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter("h:\\savedata.SAV");
                file.Close();
                file.Dispose();
            }
            this.Refresh();
        }

        private void helpToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Help;
        }

        private void helpToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void viewHelpToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Help;
        }

        private void viewHelpToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void muteButton_Click(object sender, EventArgs e)
        {
            if (mute == false)
            {
                mute = true;
                // this.button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.img1));
                muteButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.unmuteIMG));
            }
            else
            {
                effects.Play();
                mute = false;
                muteButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.muteIMG));
            }
            this.Refresh();
        }

        private void changeNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nextPersonTurn npt = new nextPersonTurn(userNames);
            npt.Show();
            userNames = npt.returnNames();
        }
    }
}