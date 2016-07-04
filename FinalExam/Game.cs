using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class Game
    {
        //跟FormLive間的委託
        public delegate void MessageDelegate(string message);
        public MessageDelegate sentMessageToForm;
        public delegate void AmountDelegate(int[] amountList);
        public AmountDelegate sentAmountToForm;
        public delegate void SleepDelegate();
        public SleepDelegate sleep;

        public string name;
        //球場
        public int fieldSize;
        public int fieldAngle;
        //打者
        public int upper;
        //投手
        public int speedHigh;
        public int speedLow;
        public int pitcherDistanceHigh;
        public int pitcherDistanceLow;
        public int pitcherAngleHigh;
        public int pitcherAngleLow;
        //二壘手
        public int secondDistanceHigh;
        public int secondDistanceLow;
        public int secondAngleHigh;
        public int secondAngleLow;
        //中堅手
        public int centerDistanceHigh;
        public int centerDistanceLow;
        public int centerAngleHigh;
        public int centerAngleLow;

        public string message;
        int[] amountList = new int[5];


        Ball ball = new Ball();
        Pitcher pitcher;
        BaseballField ballField;
        Umpire umpire = new Umpire();
        Batter batter;
        CenterFielder center;
        SecondBaseMan second;

        public void InIt()
        {
            //new出比賽物件
            pitcher = new Pitcher(speedHigh, speedLow, pitcherDistanceLow, pitcherDistanceHigh, pitcherAngleLow, pitcherAngleHigh);
            ballField = new BaseballField(fieldSize, fieldAngle);
            batter = new Batter(upper);
            center = new CenterFielder(centerDistanceLow, centerDistanceHigh, centerAngleLow, centerAngleHigh);
            second = new SecondBaseMan(secondDistanceLow, secondDistanceHigh, secondAngleLow, secondAngleHigh);

            //委託
            pitcher.pitch += new Pitcher.PitchBallDelegate(ball.OnPitch);  //投球委託
            ball.hitOut += new Ball.HitOutDelegate(umpire.hitOut);  //界外球
            ball.homeRun += new Ball.HomeRunDelegate(umpire.homeRun);  //全壘打
            ball.batterOut = new Ball.BatterOutDelegate(umpire.BatterOut);  //說出局
            ball.bat += new Ball.BatDelegate(batter.Bat);  //有沒有打出去
            ball.hitResult += new Ball.BallDelegate(ballField.BallInfor);
            ball.catchOrNot += new Ball.CatchOrNotDelegate(umpire.CatchOrNot);
            ball.catchBall += new Ball.CatchDelegate(pitcher.CatchShout);
            ball.catchBall += new Ball.CatchDelegate(second.CatchShout);
            ball.catchBall += new Ball.CatchDelegate(center.CatchShout);

            pitcher.message = ShowMessage;
            umpire.message = ShowMessage;
            center.message = ShowMessage;
            second.message = ShowMessage;
            ball.message = ShowMessage;
        }

        public void ShowMessage(string str)
        {
            message += str;
            message += "\r\n";
        }

        public void Start()
        {
            for (int i = 0; i < 100; i++)
            {
                ShowMessage("==============");
                pitcher.Pitch();
                Amount();
                sentMessageToForm(message);
                sentAmountToForm(amountList);
                sleep();
            }
        }

        public void Amount()
        {
            amountList[0] = umpire.amountNoHit;
            amountList[1] = umpire.amountBallOut;
            amountList[2] = umpire.amountCatch;
            amountList[3] = umpire.amountSave;
            amountList[4] = umpire.amountHomeRun;
        }
    }
}
