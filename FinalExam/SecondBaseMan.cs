using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class SecondBaseMan:Fielder
    {
        public SecondBaseMan(int distanceLow, int distanceHigh, int angleLow, int angleHigh)
            : base(distanceLow, distanceHigh, angleLow, angleHigh)
        {
            DistanceLow = distanceLow;
            DistancHigh = distanceHigh;
            AngleLow = angleLow;
            AngleHigh = angleHigh;
        }

        protected override string Say()
        {
            return "二壘手";
        }
    }
}
