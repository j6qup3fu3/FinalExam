using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Ball
    {
        private int _speed;
        private int _flyDistance;
        private int _flyAngle;
        public delegate bool BatDelegate(int ar);
        public BatDelegate bat;
        public delegate int BallDelegate(int flyDistance, int flyAngle);
        public BallDelegate hitResult;
        public delegate bool CatchDelegate(int FlyDistance, int FlyAngle);
        public CatchDelegate catchBall;
        public delegate void BatterOutDelegate();
        public BatterOutDelegate batterOut;
        public delegate void HitOutDelegate();
        public HitOutDelegate hitOut;
        public delegate void HomeRunDelegate();
        public HomeRunDelegate homeRun;
        public delegate void CatchOrNotDelegate(bool isCatch);
        public CatchOrNotDelegate catchOrNot;
        public delegate void MessageDelegate(string str);
        public MessageDelegate message;

        public int Speed
        {
            get { return _speed; }
            set
            {
                if (_speed < 0)
                    _speed = 0;
                else
                    _speed = value;
            }
        }

        public int FlyDistance
        {
            get { return _flyDistance; }
            set
            {
                if (_flyDistance < 0)
                    _flyDistance = 0;
                else
                    _flyDistance = value;
            }
        }

        public int FlyAngle
        {
            get { return _flyAngle; }
            set
            {
                if (_flyAngle < 0)
                    _flyAngle = 0;
                else
                    _flyAngle = value;
            }
        }

        public void Random()
        {
            Random random = new System.Random();
            FlyDistance = random.Next(0, 450);
            FlyAngle = random.Next(-90, 90);
        }

        public void Position()
        {
            message( "飛行距離 " + FlyDistance + "   角度 " + FlyAngle);
        }

        public void OnPitch(int speed)
        {
            Speed = speed;
            message("球速 " + Speed);
            bool isHit = bat(speed);
            if (!isHit)
            {
                batterOut();
            }
            else
            {
                message("打擊出去!");
                OnHit();
            }
            
        }

        public void OnHit()
        {
            //random angle and distance
            Random();
            Position();
            int res = hitResult(FlyAngle, FlyDistance);
            switch (res)
            {
                case 0: //界外
                    hitOut();
                    break;
                case 1: //全壘打
                    homeRun();
                    break;
                case 2:  //打擊出去
                    bool isCatch = false;
                    foreach(CatchDelegate single in catchBall.GetInvocationList())
                    {
                        isCatch = single(FlyAngle, FlyDistance);
                        if (isCatch)
                            break;
                    }
                    catchOrNot(isCatch);
                    break;
            }
        }
    }
}
