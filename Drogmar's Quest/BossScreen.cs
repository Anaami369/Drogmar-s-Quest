﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml;

namespace Drogmar_s_Quest
{
    public partial class BossScreen : UserControl
    {
        #region global values

        public static Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown, escKeyDown, spaceDown, gamePaused;

        // Game values
        int lives = 3;
        public static int score = 0;
        int level = 1;
        int counter = 0;

        // lists
        List<Walls> walls = new List<Walls>();
        public static List<string> scores = new List<string>();

        Players player;
        Jedi jedi1;
        Jedi jedi2;
        Jedi jedi3;
        Jedi jedi4;

        int playerSpeed = 15;
        int playerSize = 30;

        int jediSpeed = 20;
        int jediSize = 50;

        Image yoda = Properties.Resources.mainPlayer;
        Image robo1 = Properties.Resources.jedi1;
        Image robo2 = Properties.Resources.jedi2;
        Image robo3 = Properties.Resources.Player1;
        Image robo4 = Properties.Resources.Player2;

        Pen whitePen = new Pen(Color.White, 5);

        #endregion

        public BossScreen()
        {
            InitializeComponent();
            OnStart();
        }

        private void BossScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Escape:
                    escKeyDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;

                default:
                    break;
            }
        }

        private void BossScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Escape:
                    escKeyDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;

                default:
                    break;
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            gamePaused = false;
            OnEnd();
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            if (level <= 1)
            {
                gameTimer.Enabled = true;
                pauseLabel.Visible = false;
                resumeButton.Enabled = false;
                resumeButton.Visible = false;
                menuButton.Enabled = false;
                menuButton.Visible = false;
                gamePaused = false;
                this.Focus();
            }
            else
            {
                Application.Exit();
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            int pX = player.x;
            int pY = player.y;

            int j1X = jedi1.x;
            int j1Y = jedi1.y;

            int j2X = jedi2.x;
            int j2Y = jedi2.y;

            int j3X = jedi3.x;
            int j3Y = jedi3.y;

            int j4X = jedi4.x;
            int j4Y = jedi4.y;

            if (counter == 0)
            {
                jedi1.Move(jediSpeed);
                jedi2.Move(jediSpeed);
                jedi3.Move(jediSpeed);
                jedi4.Move(jediSpeed);
            }

            #region move hero
            if (leftArrowDown == true)
            {
                player.Move(playerSpeed, "left");
            }
            else if (rightArrowDown == true)
            {
                player.Move(playerSpeed, "right");
            }
            else if (upArrowDown == true)
            {
                player.Move(playerSpeed, "up");
            }
            else if (downArrowDown == true)
            {
                player.Move(playerSpeed, "down");
            }
            #endregion

            #region collision of player with walls
            foreach (Walls w in walls)
            {

                if (player.WallsCollision(w))
                {
                    player.x = pX;
                    player.y = pY;
                }
            }
            #endregion

            #region collision of jedi with walls
            foreach (Walls w in walls)
            {
                if (jedi1.WallsCollision(w))
                {
                    jedi1.x = j1X;
                    jedi1.y = j1Y;

                    Random jediGen = new Random();
                    int jediDirection = jediGen.Next(1, 5);

                    if (jediDirection == 1)
                    {
                        jedi1.direction = "left";
                    }
                    else if (jediDirection == 2)
                    {
                        jedi1.direction = "up";
                    }
                    else if (jediDirection == 3)
                    {
                        jedi1.direction = "down";
                    }
                    else if (jediDirection == 4)
                    {
                        jedi1.direction = "right";

                    }
                }
            }

            foreach (Walls w in walls)
            {
                if (jedi2.WallsCollision(w))
                {
                    //int x = 7;
                    jedi2.x = j2X;
                    jedi2.y = j2Y;

                    Random jediGen = new Random();
                    int jediDirection = jediGen.Next(1, 5);

                    if (jediDirection == 1)
                    {
                        jedi2.direction = "left";
                    }
                    else if (jediDirection == 2)
                    {
                        jedi2.direction = "up";
                    }
                    else if (jediDirection == 3)
                    {
                        jedi2.direction = "down";
                    }
                    else if (jediDirection == 4)
                    {
                        jedi2.direction = "right";
                    }
                }
                pauseScreenEnabled();
            }
            foreach (Walls w in walls)
            {
                if (jedi3.WallsCollision(w))
                {
                    jedi3.x = j3X;
                    jedi3.y = j3Y;

                    Random jediGen = new Random();
                    int jediDirection = jediGen.Next(1, 5);

                    if (jediDirection == 1)
                    {
                        jedi3.direction = "left";
                    }
                    else if (jediDirection == 2)
                    {
                        jedi3.direction = "up";
                    }
                    else if (jediDirection == 3)
                    {
                        jedi3.direction = "down";
                    }
                    else if (jediDirection == 4)
                    {
                        jedi3.direction = "right";
                    }
                }
                pauseScreenEnabled();
            }
            foreach (Walls w in walls)
            {
                if (jedi4.WallsCollision(w))
                {
                    jedi4.x = j4X;
                    jedi4.y = j4Y;

                    Random jediGen = new Random();
                    int jediDirection = jediGen.Next(1, 5);

                    if (jediDirection == 1)
                    {
                        jedi4.direction = "left";
                    }
                    else if (jediDirection == 2)
                    {
                        jedi4.direction = "up";
                    }
                    else if (jediDirection == 3)
                    {
                        jedi4.direction = "down";
                    }
                    else if (jediDirection == 4)
                    {
                        jedi4.direction = "right";
                    }
                }
                pauseScreenEnabled();
            }
            #endregion

            #region collision
            Rectangle jedi1Rec = new Rectangle(jedi1.x, jedi1.y, jediSize, jediSize);
            Rectangle jedi2Rec = new Rectangle(jedi2.x, jedi2.y, jediSize, jediSize);
            Rectangle jedi3Rec = new Rectangle(jedi3.x, jedi3.y, jediSize, jediSize);
            Rectangle jedi4Rec = new Rectangle(jedi4.x, jedi4.y, jediSize, jediSize);
            Rectangle playerRec = new Rectangle(player.x, player.y, playerSize, playerSize);

            if (jedi1Rec.IntersectsWith(playerRec))
            {
                lives -= 1;
                scoreKeeper.Text = "Lives: " + lives;
            }

            else if (jedi2Rec.IntersectsWith(playerRec))
            {
                lives -= 1;
                scoreKeeper.Text = "Lives: " + lives;
            }

            else if (jedi3Rec.IntersectsWith(playerRec))
            {
                lives -= 1;
                scoreKeeper.Text = "Lives: " + lives;
            }

            else if (jedi4Rec.IntersectsWith(playerRec))
            {
                lives -= 1;
                scoreKeeper.Text = "Lives: " + lives;
            }

            #endregion

            //game lost
            if (lives == 0)
            {
                gameTimer.Stop();

                pauseLabel.Visible = true;
                pauseLabel.Text = "You Lose!";
                menuButton.Enabled = true;
                menuButton.Visible = true;
                menuButton.Text = "Quit Game";
                playAgainButton.Enabled = true;
                playAgainButton.Visible = true;
                playAgainButton.Text = "Play again";
            }

            #region going off screen
            if (jedi1.y >= 783)
            {
                jedi1.direction = "right";
            }
            else if (jedi2.y >= 777)
            {
                jedi2.direction = "up";
            }
            else if (jedi3.y >= 777)
            {
                jedi3.direction = "up";
            }
            else if (jedi4.y >= 777)
            {
                jedi4.direction = "up";
            }
            else if (player.y >= 777)
            {
                OnWin();
            }
            #endregion

            Refresh();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            // Goes to the game screen
            LevelScreen ls = new LevelScreen();
            Form form = this.FindForm();

            form.Controls.Add(ls);
            form.Controls.Remove(this);

            ls.Location = new Point((form.Width - ls.Width) / 2, (form.Height - ls.Height) / 2);
        }

        private void LevelLoad()
        {
            XmlTextReader reader = new XmlTextReader("Resources/EasyLevel" + level + "XML.xml");

            while (reader.Read())
            {

                if (reader.NodeType == XmlNodeType.Text)
                {
                    int startX = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("startY");
                    int startY = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("endX");
                    int endX = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("endY");
                    int endY = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("hp");
                    int hp = Convert.ToInt32(reader.ReadString());


                    Walls newWall = new Walls(startX, startY, endX, endY, hp);
                    walls.Add(newWall);
                }
            }
        }

        public void OnStart()
        {
            //set all button presses to false.
            leftArrowDown = rightArrowDown = downArrowDown = upArrowDown = escKeyDown = false;

            pauseLabel.Visible = false;
            menuButton.Enabled = false;
            menuButton.Visible = false;
            resumeButton.Enabled = false;
            resumeButton.Visible = false;
            playAgainButton.Enabled = false;
            playAgainButton.Visible = false;

            LevelLoad();

            // start the game engine loop
            gameTimer.Enabled = true;

            scoreKeeper.Text = "Lives: " + lives;

            player = new Players(this.Width / 2 - playerSize / 2, 352, playerSize);
            jedi1 = new Jedi(this.Width / 2 - jediSize / 2, 610, jediSize);
            jedi2 = new Jedi(this.Width / 2 - jediSize / 2, 510, jediSize);
            jedi3 = new Jedi(this.Width / 2 - jediSize / 2, 670, jediSize);
            jedi4 = new Jedi(this.Width / 2 - jediSize / 2, 410, jediSize);

        }

        public void pauseScreenEnabled()
        {
            if (escKeyDown)
            {
                gamePaused = true;
            }
            if (gamePaused)
            {
                pauseLabel.Visible = true;
                gameTimer.Enabled = false;
                menuButton.Enabled = true;
                menuButton.Visible = true;
                resumeButton.Enabled = true;
                resumeButton.Visible = true;
            }
            else
            {
                gameTimer.Enabled = true;
            }

        }

        public void OnEnd()
        {
            Application.Exit();
        }

        public void OnWin()
        {
            gameTimer.Stop();

            pauseLabel.Visible = true;
            pauseLabel.Text = "You Win!";
            menuButton.Enabled = true;
            menuButton.Visible = true;
            menuButton.Text = "Quit Game";
        }

        private void BossScreen_Paint(object sender, PaintEventArgs e)
        {
            #region draw hero character
            e.Graphics.DrawImage(yoda, player.x, player.y, 20, 20);
            #endregion

            #region draw jedi characters
            e.Graphics.DrawImage(robo1, jedi1.x, jedi1.y, 30, 30);
            e.Graphics.DrawImage(robo2, jedi2.x, jedi2.y, 30, 30);
            e.Graphics.DrawImage(robo3, jedi3.x, jedi3.y, jediSize, jediSize);
            e.Graphics.DrawImage(robo4, jedi4.x, jedi4.y, jediSize, jediSize);
            #endregion

            #region draw walls
            foreach (Walls w in walls)
            {
                e.Graphics.DrawLine(whitePen, w.startX, w.startY, w.endX, w.endY);
            }
            #endregion
        }
    }
}
