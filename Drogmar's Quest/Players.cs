using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace Drogmar_s_Quest
{
    class Players
    {
        public int x, y, size, xSpeed, ySpeed, playerSize;
        public Color color;

        SoundPlayer wallBounce = new SoundPlayer(Properties.Resources.lifeLost);

        public Players(int _x, int _y, int _playerSize)
        {
            x = _x;
            y = _y;
            playerSize = _playerSize;
        }

        public Players(int _x, int _y, int _size, int _xSpeed, int _ySpeed, int _playerSize)
        {
            x = _x;
            y = _y;
            size = _size;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            playerSize = _playerSize;
        }

        public Players(int _x, int _y, int _size, int _xSpeed, int _ySpeed, Color _color)
        {
            x = _x;
            y = _y;
            size = _size;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            color = _color;
        }

        public void Move(int speed, string direction)
        {
            //true represents right
            if (direction == "right")
            {
                x += speed;
            }
            else if (direction == "left")
            {
                x -= speed;
            }

            else if (direction == "up")
            {
                y -= speed;
            }
            else if (direction == "down")
            {
                y += speed;
            }
        }

        public bool WallsCollision(Walls w)
        {
            Rectangle wallsRec = new Rectangle(w.startX, w.startY, w.endX - w.startX, w.endY - w.startY);
            Rectangle playerRec = new Rectangle(x, y, size, size);

            if (w.startX == w.endX)
            {
                wallsRec.Width = 5;
            }
            else if (w.startY == w.endY)
            {
                wallsRec.Height = 5;
            }

            //if (playerRec.IntersectsWith(wallsRec))
            //{
            //    wallBounce.Play();
            //}
            return wallsRec.IntersectsWith(playerRec);
        }
    }
}
