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

    public partial class EasyScreen : UserControl
    {
        #region global values

        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown, escKeyDown, spaceDown, gamePaused;

        // Game values
        int lives = 3;
        public static int score = 0;
        int level = 1;
        int counter = 1;

        // lists
        List<Walls> walls = new List<Walls>();
        public static List<string> scores = new List<string>();

        Jedi player;

        int playerSpeed = 10;
        int playerSize = 20;
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

            player = new Jedi(this.Width / 2 - playerSize / 2, 522, playerSize);
        }
        
        private void EasyScreen_Paint(object sender, PaintEventArgs e)
        {
            #region draw hero character
            e.Graphics.DrawImage(Properties.Resources.mainPlayer, player.x, player.y, 10, 10);
            #endregion

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
            }
        }
    }
}
