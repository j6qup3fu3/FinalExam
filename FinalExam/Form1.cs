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
    public partial class Form1 : Form
    {
        int i = 0;
        List<Game> gameList = new List<Game>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGameChoose_Click(object sender, EventArgs e)
        {
            FormParameter formPara = new FormParameter("Game"+(i+1).ToString());
            cmbLive.Items.Add("Game"+(i+1));
            cmbUpdate.Items.Add("Game" + (i + 1));
            formPara.gamePara += new FormParameter.GameDelegate(GetGame);
            formPara.Show();
            i++;
        }

        private void btnLive_Click(object sender, EventArgs e)
        {
            for(int j=0;j<i;j++)
            {
                if (gameList[j].name == cmbLive.Text)
                {
                    FormLive gameLiveOne = new FormLive(gameList[j]);
                    gameLiveOne.Text = "Game"+(j+1);
                    gameLiveOne.Show();
                }
            }
            //switch (cmbLive.Text)
            //{
            //    case "Game1":
            //        FormLive gameLiveOne = new FormLive(gameList[0]);
            //        gameLiveOne.Text = "Game1";
            //        gameLiveOne.Show();
            //        break;
            //    case "Game2":
            //        FormLive gameLiveTwo = new FormLive(gameList[1]);
            //        gameLiveTwo.Text = "Game2";
            //        gameLiveTwo.Show();
            //        break;
            //    case "Game3":
            //        FormLive gameLiveThree = new FormLive(gameList[2]);
            //        gameLiveThree.Text = "Game3";
            //        gameLiveThree.Show();
            //        break;
            //}
        }

        public void GetGame(object sender, Game para)
        {
            gameList.Add(para);
            Form form = (Form)sender;
            form.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < i; j++)
            {
                if (gameList[j].name == cmbUpdate.Text)
                {
                    FormParameter formPara = new FormParameter(gameList[j],gameList[j].name);
                    formPara.gamePara += new FormParameter.GameDelegate(UpdateGame);
                    formPara.Show();
                }
            }
        }

        public void UpdateGame(object sender, Game para)
        {
            for (int j = 0; j < i; j++)
            {
                if (gameList[j].name == para.name)
                {
                    gameList[j] = para;
                    Form form = (Form)sender;
                    form.Close();
                }
            }
        }
    }
}
