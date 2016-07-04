using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class BaseballField
    {
        private int _size;
        private int _angle;

        public BaseballField(int size, int angle)
        {
            Size = size;
            Angle = angle;
        }

        public int Size
        {
            get { return _size; }
            set
            {
                if (_size < 0)
                    _size = 0;
                else
                    _size = value;
            }
        }

        public int Angle
        {
            get { return _angle; }
            set
            {
                if (_angle < 0)
                    _angle = 0;
                else
                    _angle = value;
            }
        }

        public int BallInfor(int flyAngle,int flyDistance)
        {
            if (flyAngle > Angle || flyAngle < -Angle)
                return 0;
            else if (flyDistance >= Size)
                return 1;
            else
                return 2;
        }
    }
}
