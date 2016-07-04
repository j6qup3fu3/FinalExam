using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Batter
    {
        private int _speed;

        public Batter(int speed)
        {
            Speed = speed;
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public bool Bat(int ballSpeed)
        {
            if (ballSpeed > Speed)
               return false;
            else
               return true;
        }
    }
}
