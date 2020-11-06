using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drogmar_s_Quest
{
    class Scores
    {
        public static List<Scores> scores = new List<Scores>();

        public string name;

        public string score;
        public Scores(string _name, string _score)

        {
            name = _name;
            score = _score;
        }
    }
}
