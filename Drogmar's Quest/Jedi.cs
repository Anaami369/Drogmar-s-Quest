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
        public int x, y, jediSize;
        public string direction = "right";

        public Jedi(int _x, int _y, int _jediSize)
        {
            x = _x;
            y = _y;
            jediSize = _jediSize;
        }

        public void Move(int speed)
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
            Rectangle jediRec = new Rectangle(x, y, jediSize, jediSize);

            if (w.startX == w.endX)
            {
                wallsRec.Width = 5;
            }
            else if (w.startY == w.endY)
            {
                wallsRec.Height = 5;
            }

            return wallsRec.IntersectsWith(jediRec);
        }
    }
}
