using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Umpire
    {
        public delegate void MessageDelegate(string str);
        public MessageDelegate message;
        public int amountNoHit=0;
        public int amountBallOut=0;
        public int amountHomeRun=0;
        public int amountCatch = 0;
        public int amountSave = 0;

        //揮棒落空
        public void BatterOut()
        {
            message("主審:揮棒落空!");
            amountNoHit++;
        }

        //界外球
        public void hitOut()
        {
            message("主審:界外球!");
            amountBallOut++;
        }

        //全壘打
        public void homeRun()
        {
            message("主審:全壘打!");
            amountHomeRun++;
        }

        //接殺or安打
        public void CatchOrNot(bool isCatch)
        {
            if (isCatch)
            {
                message("主審:接殺出局!");
                amountCatch++;
            }
            else
            {
                message("主審:安打!");
                amountSave++;
            }
        }
    }
}
