using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesuko
{

    public partial class Ranking : Form
    {
    
        public Ranking()
        {
            InitializeComponent();
            label1.Text = RankingManager.jugadores[0] + " - - - " + RankingManager.ptsJugadores[0];
            label2.Text = RankingManager.jugadores[1] + " - - - " + RankingManager.ptsJugadores[1];
            label3.Text = RankingManager.jugadores[2] + " - - - " + RankingManager.ptsJugadores[2];
            label4.Text = RankingManager.jugadores[3] + " - - - " + RankingManager.ptsJugadores[3];
            label5.Text = RankingManager.jugadores[4] + " - - - " + RankingManager.ptsJugadores[4];
            label6.Text = RankingManager.jugadores[5] + " - - - " + RankingManager.ptsJugadores[5];
            label7.Text = RankingManager.jugadores[6] + " - - - " + RankingManager.ptsJugadores[6];
            label8.Text = RankingManager.jugadores[7] + " - - - " + RankingManager.ptsJugadores[7];
            label9.Text = RankingManager.jugadores[8] + " - - - " + RankingManager.ptsJugadores[8];
            label10.Text = RankingManager.jugadores[9] + " - - - " + RankingManager.ptsJugadores[9];


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Palabra_Click(object sender, EventArgs e)
        {

        }

        private void Ranking_Load(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            ScreenStart start = new ScreenStart();
            start.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
