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
            if (level < 6)
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
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.jumpSound);
                soundPlayer.Play();

                player.Move(playerSpeed, "left");
            }
            else if (rightArrowDown == true)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.jumpSound);
                soundPlayer.Play();

                player.Move(playerSpeed, "right");
            }
            else if (upArrowDown == true)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.jumpSound);
                soundPlayer.Play();

                player.Move(playerSpeed, "up");
            }
            else if (downArrowDown == true)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.jumpSound);
                soundPlayer.Play();

                player.Move(playerSpeed, "down");
            }
            #endregion

            #region collision of player with walls

            //not working
            foreach (Walls w in walls)
            {
                Rectangle LWallsRec = new Rectangle(w.x, w.y, 27, 2);
                Rectangle TWallsRec = new Rectangle(w.x, w.y, 2, 27); 
                Rectangle playerRec = new Rectangle(player.x, player.y, player.size, player.size);

                if (LWallsRec.IntersectsWith(playerRec))
                {
                    upArrowDown = false;
                }
                if (LWallsRec.IntersectsWith(playerRec))
                {
                    downArrowDown = false;
                }
                if (TWallsRec.IntersectsWith(playerRec))
                {
                    leftArrowDown = false;
                }
                if (TWallsRec.IntersectsWith(playerRec))
                {
                    rightArrowDown = false;
                }
            }
            #endregion

            #region collision of jedi with walls

            foreach (Walls w in walls)
            {
                Rectangle LWallsRec = new Rectangle(w.x, w.y, 27, 2);
                Rectangle TWallsRec = new Rectangle(w.x, w.y, 2, 27);
                Rectangle robo1Rec = new Rectangle(jedi1.x, jedi1.y, jedi1.size, jedi1.size);

                if (robo1Rec.IntersectsWith(LWallsRec))
                {
                    if (jedi1.y >= w.y - jedi1.size && jedi1.y <= w.y + 2)
                    {
                        jedi1.ySpeed = jedi1.ySpeed * -1;
                    }
                    else if (wall.x <= w.x + 27 && wall.x >= w.x)
                    {
                        jedi1.xSpeed = jedi1.xSpeed * -1;
                    }
                }
                if (robo1Rec.IntersectsWith(TWallsRec))
                {
                    if (wall.x <= w.x + 27 && wall.x >= w.x)
                    {
                        jedi1.xSpeed = jedi1.xSpeed * -1;
                    }
                    else if (jedi1.y >= w.y - jedi1.size && jedi1.y <= w.y + 2)
                    {
                        jedi1.ySpeed = jedi1.ySpeed * -1;
                    }
                }

                SoundPlayer brickPlayer = new SoundPlayer(Properties.Resources.lifeLost);
                brickPlayer.Play();
            }

            #endregion

            pauseScreenEnabled();
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
                    int x = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("y");
                    int y = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("hp");
                    int hp = Convert.ToInt32(reader.ReadString());


                    Walls newWall = new Walls(x, y, hp);
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
                if (w.hp == 1)
                {
                    e.Graphics.DrawImage(Properties.Resources.long_white_line1, w.x, w.y, 27, 2);
                }
                else if (w.hp == 2)
                {
                    e.Graphics.DrawImage(Properties.Resources.long_white_line1, w.x, w.y, 27, 2);
                }
                else if (w.hp == 3)
                {
                    e.Graphics.DrawImage(Properties.Resources.tall_white_line1, w.x, w.y, 2, 27);
                }
                else if (w.hp == 4)
                {
                    e.Graphics.DrawImage(Properties.Resources.tall_white_line1, w.x, w.y, 2, 27);
                }
                #endregion
            }
        }
    }
}
