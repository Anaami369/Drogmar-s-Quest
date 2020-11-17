using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drogmar_s_Quest
{
    public class Walls
    {
        public int startX;
        public int startY;
        public int endX;
        public int endY;
        public int hp;

        public Walls(int _startX, int _startY, int _endX, int _endY,int _hp)
        {
            startX = _startX;
            startY = _startY;
            endX = _endX;
            endY = _endY;
            hp = _hp;
        }
    }
}
