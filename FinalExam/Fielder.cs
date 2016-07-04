using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    abstract class Fielder
    {
        public int _distanceLow;
        public int _distanceHigh;
        public int _angleLow;
        public int _angleHigh;
        public delegate void MessageDelegate(string str);
        public MessageDelegate message;

        public Fielder(int distanceLow, int distanceHigh, int angleLow, int angleHigh)
        {
            DistanceLow = distanceLow;
            DistancHigh = distanceHigh;
            AngleLow = angleLow;
            AngleHigh = angleHigh;
        }

        public int DistanceLow
        {
            get { return _distanceLow; }
            set { _distanceLow = value; }
        }

        public int DistancHigh
        {
            get { return _distanceHigh; }
            set { _distanceHigh = value; }
        }

        public int AngleLow
        {
            get { return _angleLow; }
            set { _angleLow = value; }
        }

        public int AngleHigh
        {
            get { return _angleHigh; }
            set { _angleHigh = value; }
        }

        public bool CatchShout(int FlyAngle,int FlyDistance)
        {
            if (DistancHigh > FlyDistance && DistanceLow < FlyDistance && AngleHigh > FlyAngle && AngleLow < FlyAngle)
            {
                message(Say() + ":我接到球了");
                return true;
            }
            else
                return false;
        }

        protected abstract string Say();
    }
}
