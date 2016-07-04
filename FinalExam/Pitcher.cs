using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Pitcher:Fielder
    {
        private int _speedLow;
        private int _speedHigh;
        public delegate void PitchBallDelegate(int arg);
        public PitchBallDelegate pitch;

        public Pitcher(int speedHigh, int speedLow, int distanceLow, int distanceHigh, int angleLow, int angleHigh)
            : base(distanceLow, distanceHigh, angleLow, angleHigh)
        {
            SpeedLow = speedLow;
            SpeedHigh = speedHigh;
            DistanceLow = distanceLow;
            DistancHigh = distanceHigh;
            AngleLow = angleLow;
            AngleHigh = angleHigh;
        }

        public int SpeedLow
        {
            get { return _speedLow; }
            set
            {
                if (value < 0)
                    _speedLow = 0;
                else
                    _speedLow = value;
            }
        }

        public int SpeedHigh
        {
            get { return _speedHigh; }
            set
            {
                if (value < SpeedLow)
                    _speedHigh = SpeedLow;
                else
                    _speedHigh = value;
            }
        }

        public void Pitch()
        {
            message("投出!");
            Random random = new Random();
            int speed = random.Next(SpeedLow, SpeedHigh);
            pitch(speed);
        }

        protected override string Say()
        {
            return "投手";
        }
    }
}
