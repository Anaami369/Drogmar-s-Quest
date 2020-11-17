using System;
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
using System.Drawing.Configuration;

namespace Drogmar_s_Quest
{
    //hp = 1 (up)
    //hp = 2 (down)
    //hp = 3 (left)
    //hp = 4 (right)
    //difference = 76

    public partial class EasyScreen : UserControl
    {
        #region global values

        public static Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown, escKeyDown, spaceDown, gamePaused;

        // Game values
        int lives = 3;
        public static int score = 0;
        int level = 1;
        int counter = 1;

        // lists
        List<Walls> walls = new List<Walls>();
        List<Jedi> jedi = new List<Jedi>(0);
        public static List<string> scores = new List<string>();

        Players player;
        Jedi jedi1;
        Jedi jedi2;

        Walls wall;

        int playerSpeed = 10;
        int playerSize = 20;

        int jediSpeed = 7;
        int jediSize = 20;

        Image yoda = Properties.Resources.mainPlayer;
        Image robo1 = Properties.Resources.jedi1;
        Image robo2 = Properties.Resources.jedi2;

        Pen whitePen = new Pen(Color.White, 5);
        #endregion

        public EasyScreen()
        {
            InitializeComponent();
            OnStart();
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

        private void EasyScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void EasyScreen_KeyUp(object sender, KeyEventArgs e)
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

        private void gameTimer_Tick(object sender, EventArgs e)
        {
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

            //Rectangle playerRec = new Rectangle(player.x, player.y, playerSize, playerSize);

            foreach (Walls w in walls)
            {
                //Rectangle wallsRec = new Rectangle(w.startX, w.startY, w.endX - w.startX, w.endY - w.startY);

                if (player.WallsCollision(w))
                {
                    int x = 7;

                    #region collision of player with walls
                    //not working

                    //if (playerRec.IntersectsWith(wallsRec))
                    //{
                    //    if (player.y == w.startY - player.size)
                    //    {
                    //        player.y = w.startY + playerSize;
                    //    }
                    //    else if (player.y == w.startY - player.size)
                    //    {
                    //        player.y = w.startY - playerSize;
                    //    }
                    //    else if (player.x == w.startX - player.size)
                    //    {
                    //        player.x = w.startX + playerSize;
                    //    }
                    //    else if (player.x == w.startX - player.size)
                    //    {
                    //        player.x = w.startX - playerSize;
                    //    }
                    //}
                    #endregion

                    #region collision of jedi with walls
                    //Rectangle robo1Rec = new Rectangle(jedi1.x, jedi1.y, jedi1.size, jedi1.size);

                    //if (robo1Rec.IntersectsWith(wallsRec))
                    //{
                    //    if (jedi1.y > w.startY - jedi1.size)
                    //    {
                    //        jedi1.Move(jediSpeed, "right");
                    //    }
                    //    else if (jedi1.y < w.startY - jedi1.size)
                    //    {
                    //        jedi1.Move(jediSpeed, "left");
                    //    }
                    //    else if (jedi1.x < w.startX - jedi1.size)
                    //    {
                    //        jedi1.Move(jediSpeed, "up");
                    //    }
                    //    else if (jedi1.x > w.startX - jedi1.size)
                    //    {
                    //        jedi1.Move(jediSpeed, "down");
                    //    }

                    //    SoundPlayer brickPlayer = new SoundPlayer(Properties.Resources.lifeLost);
                    //    brickPlayer.Play();
                    //}

                    #endregion

                    pauseScreenEnabled();
                }
            }
            Refresh();
        }
        private void LevelLoad()
        {

            XmlTextReader reader = new XmlTextReader("Resources/EasyLevel" + level + "XML.xml");
            //XmlTextReader reader = new XmlTextReader("Resources/test.xml");

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
            gameTimer.Stop();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameOverScreen gos = new GameOverScreen();
            f.Controls.Add(gos);

            gos.Location = new Point((f.Width - gos.Width) / 2, (f.Height - gos.Height) / 2);

            gos.Focus();
        }

        public void OnWin()
        {
            gameTimer.Stop();

            pauseLabel.Visible = true;
            pauseLabel.Text = "You Win!";
            menuButton.Enabled = true;
            menuButton.Visible = true;
            resumeButton.Enabled = true;
            resumeButton.Visible = true;
            resumeButton.Text = "Quit Game";
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

            LevelLoad();

            // start the game engine loop
            gameTimer.Enabled = true;

            scoreKeeper.Text = "Lives: " + score;

            player = new Players(this.Width / 2 - playerSize / 2, 352, playerSize);
            jedi1 = new Jedi(this.Width / 2 - jediSize / 2, 372, jediSize);
            jedi2 = new Jedi(this.Width / 2 - jediSize / 2, 392, jediSize);

            //JediMove();
        }

        public void JediMove()
        {
            Random jediGen = new Random();

            foreach (Jedi j in jedi)
            {
                int randJedi = jediGen.Next(1, 6);

                if (randJedi == 1)
                {
                    jedi1.Move(jediSpeed, "right");
                    jedi2.Move(jediSpeed, "down");
                }
                else if (randJedi == 2)
                {
                    jedi1.Move(jediSpeed, "left");
                    jedi2.Move(jediSpeed, "up");
                }
                else if (randJedi == 3)
                {
                    jedi1.Move(jediSpeed, "right");
                    jedi2.Move(jediSpeed, "left");
                }
                else if (randJedi == 4)
                {
                    jedi1.Move(jediSpeed, "left");
                    jedi2.Move(jediSpeed, "Down");
                }
                else if (randJedi == 5)
                {
                    jedi1.Move(jediSpeed, "right");
                    jedi2.Move(jediSpeed, "up");
                }
            }
        }
        private void EasyScreen_Paint(object sender, PaintEventArgs e)
        {
            #region draw hero character
            e.Graphics.DrawImage(yoda, player.x, player.y, 20, 20);
            #endregion

            #region draw jedi characters
            e.Graphics.DrawImage(robo1, jedi1.x, jedi1.y, 30, 30);
            e.Graphics.DrawImage(robo2, jedi2.x, jedi2.y, 30, 30);
            #endregion

            #region draw walls
            foreach (Walls w in walls)
            {
                e.Graphics.DrawLine(whitePen, w.startX, w.startY, w.endX, w.endY);
                #endregion
            }
        }
    }
}
