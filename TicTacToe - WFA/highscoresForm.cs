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
using System.IO;

namespace TicTacToe___WFA
{
    public partial class highscoresForm : Form
    {
        public List<int> allScores = new List<int>();
        public highscoresForm(List<int> scores)
        {
            InitializeComponent();
            for (int i = 0; i < scores.Count; i++)
            {
                allScores.Add(scores[i]);  // add scores of current game (currently not in file) to list
            }
        }

        private void highscoresForm_Load(object sender, EventArgs e)
        {
            readFromFile();
        }
        private List<int> bubbleSort(List<int> templist, int s, int o)  // puts values in ascending order
        {
            int temp, j;
            for (int n = 0; n <= s; n++)
            {
                temp = templist[n];
                j = n - 1;
                if (o == 1)
                {
                    while (j >= 0 && templist[j] > temp)
                    {
                        templist[j + 1] = templist[j];
                        j--;
                    }
                }
                else
                {
                    while (j >= 0 && templist[j] < temp)
                    {
                        templist[j + 1] = templist[j];
                        j--;
                    }
                }
                templist[j + 1] = temp;
            }
            return templist;
        }

        private void readFromFile()
        {
            // read from text file
            using (StreamReader sr = new StreamReader("h:\\savedata.SAV"))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    allScores.Add(Convert.ToInt32(line));
                }
            }
            // sort allScores from greatest to least

            bubbleSort(allScores, allScores.Count - 1, 0);

            // display these scores to textbox
            for (int j = 0; j < allScores.Count; j++)
            {
                highscoresTextBox.AppendText(allScores[j].ToString() + Environment.NewLine); // "\n" doens't work as new line
            }
        }
        
    }
}
