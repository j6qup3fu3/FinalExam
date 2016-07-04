using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam
{
    public partial class FormParameter : Form
    {
        public delegate void GameDelegate(object sender, Game game);
        public event GameDelegate gamePara;
        Game game = new Game();
        private String name;
        public FormParameter(String name)
        {
            this.name = name;
            InitializeComponent();
        }

        public FormParameter(Game game,String name)
        {
            InitializeComponent();
            this.name = name;
            UpdateGame(game);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            game.name = name;
            game.fieldSize = int.Parse(txtFieldSize.Text);
            game.fieldAngle = int.Parse(txtFieldAngle.Text);
            game.upper = int.Parse(txtBatterSpeed.Text);
            game.speedHigh = int.Parse(txtPitcherHigh.Text);
            game.speedLow = int.Parse(txtPitcherLow.Text);
            game.pitcherDistanceHigh = int.Parse(txtPitcherDistanceHigh.Text);
            game.pitcherDistanceLow = int.Parse(txtPitcherDistanceLow.Text);
            game.pitcherAngleHigh = int.Parse(txtPitcherAngleHigh.Text);
            game.pitcherAngleLow = int.Parse(txtPitcherAngleLow.Text);
            game.secondDistanceHigh = int.Parse(txtSecondDistanceHigh.Text);
            game.secondDistanceLow = int.Parse(txtSecondDistanceLow.Text);
            game.secondAngleHigh = int.Parse(txtSecondAngleHigh.Text);
            game.secondAngleLow = int.Parse(txtSecondAngleLow.Text);
            game.centerDistanceHigh = int.Parse(txtCenterDistanceHigh.Text);
            game.centerDistanceLow = int.Parse(txtCenterDistanceLow.Text);
            game.centerAngleHigh = int.Parse(txtCenterAngleHigh.Text);
            game.centerAngleLow = int.Parse(txtCenterAngleLow.Text);
            gamePara(this, game);
        }

        public void UpdateGame(Game gamePara)
        {
            txtFieldSize.Text= gamePara.fieldSize.ToString();
            txtFieldAngle.Text = gamePara.fieldAngle.ToString();
            txtBatterSpeed.Text = gamePara.upper.ToString();
            txtPitcherHigh.Text = gamePara.speedHigh.ToString();
            txtPitcherLow.Text = gamePara.speedLow.ToString();
            txtPitcherDistanceHigh.Text = gamePara.pitcherDistanceHigh.ToString();
            txtPitcherDistanceLow.Text = gamePara.pitcherDistanceLow.ToString();
            txtPitcherAngleHigh.Text = gamePara.pitcherAngleHigh.ToString();
            txtPitcherAngleLow.Text = gamePara.pitcherAngleLow.ToString();
            txtSecondDistanceHigh.Text = gamePara.secondDistanceHigh.ToString();
            txtSecondDistanceLow.Text = gamePara.secondDistanceLow.ToString();
            txtSecondAngleHigh.Text = gamePara.secondAngleHigh.ToString();
            txtSecondAngleLow.Text = gamePara.secondAngleLow.ToString();
            txtCenterDistanceHigh.Text = gamePara.centerDistanceHigh.ToString();
            txtCenterDistanceLow.Text = gamePara.centerDistanceLow.ToString();
            txtCenterAngleHigh.Text = gamePara.centerAngleHigh.ToString();
            txtCenterAngleLow.Text = gamePara.centerAngleLow.ToString();
        }
    }
}
