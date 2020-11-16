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

        public Jedi(int _x, int _y, int _size, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            size = _size;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }

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

        public void MoveRight(int speed, int _x)
        {
            x += speed;
        }

        public void MoveLeft(int speed, int _x)
        {
            x -= speed;
        }

        public void MoveUp(int speed, int _y)
        {
            y -= speed;
        }

        public void MoveDown(int speed, int _y)
        {
            y += speed;
        }

        public bool WallCollision(Walls w)
        {
            Rectangle LWallRec = new Rectangle(w.x, w.y, 27, 2);
            Rectangle TWallRec = new Rectangle(w.x, w.y, 2, 27);
            Rectangle jedi1Rec = new Rectangle(x, y, size, size);

            if (LWallRec.IntersectsWith(jedi1Rec))
            {

                wallBounce.Play();
            }

            return LWallRec.IntersectsWith(jedi1Rec) || TWallRec.IntersectsWith(jedi1Rec);
        }
    }
}
