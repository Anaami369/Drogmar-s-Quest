using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drogmar_s_Quest
{
    class Jedi
    {
        public Color color;
        public int x, y, size;

        public Jedi(int _x, int _y, int _size)
        {
            x = _x;
            y = _y;
            size = _size;
        }

        public Jedi(int _x, int _y, int _size, Color _color)
        {
            x = _x;
            y = _y;
            size = _size;
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
    }
}
