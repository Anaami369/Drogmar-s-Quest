using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Drogmar_s_Quest
{
    class Jedi
    {
        public int x, y, size, xSpeed, ySpeed, jediSize;
        public Color color;

        SoundPlayer wallBounce = new SoundPlayer(Properties.Resources.lifeLost);

        public Jedi(int _x, int _y, int _size, int _xSpeed, int _ySpeed, Color _color)
        {
            x = _x;
            y = _y;
            size = _size;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            color = _color;
        }

        public Jedi(int _x, int _y, int _jediSize)
        {
            x = _x;
            y = _y;
            jediSize = _jediSize;
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

        public bool WallCollision(Walls w)
        {
            Rectangle wallsRec = new Rectangle(w.startX, w.startY, w.endX, w.endY);
            Rectangle robo1Rec = new Rectangle(x, y, size, size);
            Rectangle robo2Rec = new Rectangle(x, y, size, size);

            if (wallsRec.IntersectsWith(robo1Rec))
            {
                wallBounce.Play();
            }
            else if (wallsRec.IntersectsWith(robo2Rec))
            {
                wallBounce.Play();
            }
            return wallsRec.IntersectsWith(robo1Rec) || wallsRec.IntersectsWith(robo2Rec);
        }
    }
}
