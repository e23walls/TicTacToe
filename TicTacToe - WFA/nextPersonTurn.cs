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
    public partial class nextPersonTurn : Form
    {
        private string[] usernames = new string[2];
        public nextPersonTurn(string[] originalNames)  // accepts previous names so they show up in textboxes (if there were any)
        {
            InitializeComponent();
            if (originalNames[0] != null)
            {
                user1TextBox.Text = originalNames[0];
                user2TextBox.Text = originalNames[1];
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            usernames[0] = user1TextBox.Text;
            usernames[1] = user2TextBox.Text;

            if (yesRadioButton.Checked == true)
            {
                Form1 fm = new Form1();
                fm.displayAlerts = 1;
                fm.setValues();
                fm.Close();
            }
            Close();
        }
        public string[] returnNames()
        {
            return usernames;
        }

        private void user1TextBox_Click(object sender, EventArgs e)
        {
            if (user1TextBox.Text == "(This User is 'X')")
                user1TextBox.Text = "";
            else
                user1TextBox.SelectAll();
        }

        private void user2TextBox_Click(object sender, EventArgs e)
        {
            if (user2TextBox.Text == "(This User is 'O')")
                user2TextBox.Text = "";
            else
                user2TextBox.SelectAll();
        }

        private void user1TextBox_Leave(object sender, EventArgs e)
        {
            if (user1TextBox.Text == "")
                user1TextBox.Text = "(This User is 'X')";
        }

        private void user2TextBox_Leave(object sender, EventArgs e)
        {
            if (user2TextBox.Text == "")
                user2TextBox.Text = "(This User is 'O')";
        }

        private void nextPersonTurn_FormClosed(object sender, FormClosedEventArgs e)  // closing form instead
        {                                                                             // of clicking done has
            usernames[0] = user1TextBox.Text;                                         // same effect
            usernames[1] = user2TextBox.Text;
        }
    }
}