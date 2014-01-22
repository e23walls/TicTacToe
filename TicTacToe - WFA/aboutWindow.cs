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
    public partial class aboutWindow : Form
    {
        public aboutWindow()
        {
            InitializeComponent();
            aboutTextBox.Text = "              Program created by:" + Environment.NewLine + Environment.NewLine + "Emily Walls, Jack Davis," + Environment.NewLine + "\t        and Jordan McConkey.";
        }
    }
}
