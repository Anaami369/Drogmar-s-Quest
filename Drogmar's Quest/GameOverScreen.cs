using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drogmar_s_Quest
{
    public partial class GameOverScreen : UserControl
    {
        #region global values
        //Boolean UpArrowDown, DownArrowDown, RightArrowDown, LeftArrowDown;
        int index1, index2, index3 = 0;



        public static string nameKeeper;


        string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        #endregion

        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            storeScore();

            #region change screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            LevelScreen ls = new LevelScreen();
            f.Controls.Add(ls);

            ls.Focus();
            #endregion
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            storeScore();
            Application.Exit();
        }

        public void storeScore()
        {
            ////Need to add existing scores to the list in scores to keep them from being deleted on write(complete this action on reading the xml)
            //string playerName = letter1Output.Text + letter2Output.Text + letter3Output.Text;
            //int score = GameScreen.score;

            //Scores newScores = new Scores(playerName, score + "");

            //Scores.scores.Add(newScores);

        }

        private void playAgainButton_Enter(object sender, EventArgs e)
        {
            playAgainButton.BackColor = Color.LightSalmon;
            exitButton.BackColor = Color.LightGray;
        }

        private void exitButton_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    playAgainButton.Enabled = true;
                    playAgainButton.Focus();
                    exitButton.Enabled = false;
                    break;

                case Keys.Left:
                    exitButton.Enabled = false;

                   exitButton.BackColor = Color.Silver;
                    break;

                default:
                    break;
            }
        }

        private void playAgainButton_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:

                    playAgainButton.Enabled = false;
                    break;

                case Keys.Left:
                    //LeftArrowDown = true;

                    exitButton.Enabled = true;
                    exitButton.Focus();
                    playAgainButton.Enabled = false;
                    playAgainButton.BackColor = Color.Silver;
                    break;

                default:
                    break;
            }
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            playAgainButton.BackColor = Color.LightGray;
            exitButton.BackColor = Color.LightSalmon;
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
