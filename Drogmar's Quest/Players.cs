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
        public int x, y, size, xSpeed, ySpeed;
        public Color color;

        SoundPlayer wallBounce = new SoundPlayer(Properties.Resources.lifeLost);

        public Players(int _x, int _y, int _size, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            size = _size;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
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

        public void Move(int speed)
        {
            x += speed;
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
            Rectangle LWallsRec = new Rectangle(w.x, w.y, 27, 2);
            Rectangle TWallsRec = new Rectangle(w.x, w.y, 2, 27);
            Rectangle playerRec = new Rectangle(x, y, size, size);

            if (playerRec.IntersectsWith(LWallsRec))
            {
                wallBounce.Play();
            }
            else if (playerRec.IntersectsWith(LWallsRec))
            {
                wallBounce.Play();
            }
            else if (playerRec.IntersectsWith(TWallsRec))
            {
                wallBounce.Play();
            }
            else if (playerRec.IntersectsWith(TWallsRec))
            {
                wallBounce.Play();
            }
            return LWallsRec.IntersectsWith(playerRec) || TWallsRec.IntersectsWith(playerRec);
        }
    }
}
