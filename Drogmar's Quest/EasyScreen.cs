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

    public partial class EasyScreen : UserControl
    {
        #region global values

        public static Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown, escKeyDown, spaceDown, gamePaused;

        // Game values
        int lives = 1;
        public static int score = 0;
        int level = 1;
        int counter = 0;

        // lists
        List<Walls> walls = new List<Walls>();
        List<Jedi> jedi = new List<Jedi>();
        public static List<string> scores = new List<string>();

        Players player;
        Jedi jedi1;
        Jedi jedi2;

        int playerSpeed = 10;
        int playerSize = 20;

        int jediSpeed = 10;
        int jediSize = 20;

        Image yoda = Properties.Resources.mainPlayer;
        Image robo1 = Properties.Resources.jedi1;
        Image robo2 = Properties.Resources.jedi2;

        Pen whitePen = new Pen(Color.White, 5);

        SoundPlayer wallBounce = new SoundPlayer(Properties.Resources.lifeLost);
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

            int pX = player.x;
            int pY = player.y;

            int j1X = jedi1.x;
            int j1Y = jedi1.y;

            int j2X = jedi2.x;
            int j2Y = jedi2.y;

            if (counter == 0)
            {
                jedi1.Move(jediSpeed);
                jedi2.Move(jediSpeed);
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

            foreach (Walls w in walls)
            {
                #region collision of player with walls

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
                #endregion
                pauseScreenEnabled();
            }

            Rectangle jedi1Rec = new Rectangle(jedi1.x, jedi1.y, jediSize, jediSize);
            Rectangle jedi2Rec = new Rectangle(jedi2.x, jedi2.y, jediSize, jediSize);
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

            if (lives == 0)
            {
                gameTimer.Stop();

                Form f = this.FindForm();
                f.Controls.Remove(this);

                GameOverScreen gos = new GameOverScreen();
                f.Controls.Add(gos);

                gos.Location = new Point((f.Width - gos.Width) / 2, (f.Height - gos.Height) / 2);

                gos.Focus();
            }

            if (jedi1.y >= 783)
            {
                jedi1.direction = "right";
            }
            else if (jedi2.y >= 777)
            {
                jedi2.direction = "up";
            }
            else if (player.y >= 777)
            {
                OnWin();
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
            menuButton.Text = "Quit Game";
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

            scoreKeeper.Text = "Lives: " + lives;

            player = new Players(this.Width / 2 - playerSize / 2, 352, playerSize);
            jedi1 = new Jedi(this.Width / 2 - 40 / 2, 610, 40);
            jedi2 = new Jedi(this.Width / 2 - jediSize / 2, 510, jediSize);

            jedi.Add(jedi1);
            jedi.Add(jedi2);

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
            }
            #endregion
        }
    }
}
