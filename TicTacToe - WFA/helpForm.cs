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

namespace TicTacToe___WFA
{
    public partial class helpForm : Form
    {
        public helpForm()
        {
            InitializeComponent();
            helpTextBox.Text = "The computer is O, and you are X." + Environment.NewLine + Environment.NewLine;
            helpTextBox.Text += "Easy game:" + Environment.NewLine + "AI takes its turn randomly." + Environment.NewLine + Environment.NewLine + "Hard game:" + Environment.NewLine + "AI takes its turn strategically." + Environment.NewLine + Environment.NewLine + "Multiplayer game:" + Environment.NewLine + "Play with another player on the same computer.";
            helpTextBox.Text += Environment.NewLine + Environment.NewLine + "Scoring is based on how quickly you take your turn, how few turns you take, and on whether you win or not (if no one wins, no points are given or taken).";
            helpTextBox.Text += Environment.NewLine + Environment.NewLine + "Note: Sometimes it can take a while for the computer to take its turn. This is not a glitch! It's just calculating where it should go. Be patient.";
            helpTextBox.Text += Environment.NewLine + Environment.NewLine + "When you change your names for a multiplayer game, they will update automatically, while you're in the middle of a game. This is useful for if you want someone to take over for you, and they don't want your name.";
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
