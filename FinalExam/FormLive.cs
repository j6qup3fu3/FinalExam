using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FinalExam
{
    public partial class FormLive : Form
    {
        public delegate void SetTextCallback(string text);
        public delegate void SetAmountCallback(int[] amountList);
        private Game game=new Game();
        private Thread thread;
        
        public FormLive(Game gamePara)
        {
            InitializeComponent();
            GameEqual(gamePara);
            game.InIt();
            game.sentMessageToForm += new Game.MessageDelegate(SetMessage);
            game.sentAmountToForm += new Game.AmountDelegate(SetAmount);
            game.sleep += new Game.SleepDelegate(ThreadSleep);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (thread == null)
            {
                btnStart.Enabled = false;
                btnPause.Enabled = true;
                btnOver.Enabled = true;
                thread = new Thread(game.Start);
                thread.Start();
            }
            else
            {
                btnStart.Enabled = false;
                btnPause.Enabled = true;
                thread.Resume();
            }
        }

        //暫停執行續
        private void btnPause_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            thread.Suspend();
        }

        //刷新message
        private void SetMessage(String msg)
        {
            if (txtLiteralLive.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetMessage); //Delegate
                Invoke(d, new object[] { msg }); //Form Method
            }
            else
            {
                txtLiteralLive.AppendText(msg + "\r\n");
            }
        }

        //刷新球數
        private void SetAmount(int[] amountList)
        {
            if (txtLiteralLive.InvokeRequired)
            {
                SetAmountCallback d = new SetAmountCallback(SetAmount); //Delegate
                Invoke(d, new object[] { amountList }); //Form Method
            }
            else
            {
                txtNoHit.Text = amountList[0].ToString();
                txtOutBall.Text = amountList[1].ToString();
                txtCatch.Text = amountList[2].ToString();
                txtSave.Text = amountList[3].ToString();
                txtHomeRun.Text = amountList[4].ToString();
            }

            //txtNoHit.Invoke(new Action(() =>
            //{
            //    txtNoHit.Text = amountList[0].ToString();
            //}));
            //txtOutBall.Invoke(new Action(() =>
            //{
            //    txtOutBall.Text = amountList[1].ToString();
            //}));
            //txtCatch.Invoke(new Action(() =>
            //{
            //    txtCatch.Text = amountList[2].ToString();
            //}));
            //txtSave.Invoke(new Action(() =>
            //{
            //    txtSave.Text = amountList[3].ToString();
            //}));
            //txtHomeRun.Invoke(new Action(() =>
            //{
            //    txtHomeRun.Text = amountList[4].ToString();
            //}));
        }

        public void ThreadSleep()
        {
            Thread.Sleep(500);
        }

        private void btnOver_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnPause.Enabled = false;
            btnOver.Enabled = false;
            thread.Suspend();
            thread.Resume();
            thread.Abort();
        }

        public void GameEqual(Game garaPara)
        {
            game.fieldSize=garaPara.fieldSize;
            game.fieldAngle=garaPara.fieldAngle;
            //打者
            game.upper=garaPara.upper;
            //投手
            game.speedHigh=garaPara.speedHigh;
            game.speedLow=garaPara.speedLow;
            game.pitcherDistanceHigh=garaPara.pitcherDistanceHigh;
            game.pitcherDistanceLow=garaPara.pitcherDistanceLow;
            game.pitcherAngleHigh=garaPara.pitcherAngleHigh;
            game.pitcherAngleLow=garaPara.secondAngleLow;
            //二壘手
            game.secondDistanceHigh = garaPara.secondDistanceHigh;
            game.secondDistanceLow = garaPara.secondDistanceLow;
            game.secondAngleHigh = garaPara.secondAngleHigh;
            game.secondAngleLow = garaPara.secondAngleLow;
            //中堅手
            game.centerDistanceHigh = garaPara.centerDistanceHigh;
            game.centerDistanceLow = garaPara.centerDistanceLow;
            game.centerAngleHigh = garaPara.centerAngleHigh;
            game.centerAngleLow = garaPara.centerAngleLow;
    }
    }
}
