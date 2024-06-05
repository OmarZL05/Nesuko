using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesuko
{
    public partial class ScreenStart : Form
    {
        
        public ScreenStart()
        {
            InitializeComponent();
           
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            this.Parent.Focus();
        }

        private void btn_StartGame_Click(object sender, EventArgs e)
        {
            if (Program.getCreditos() > 0)
            {
                Program.addCreditos(-1);
                SSL_Credits.Text = Program.getCreditos().ToString();
                using (ScreenGame gameScreen = new ScreenGame())
                {
                    this.Hide();
                    gameScreen.ShowDialog();
                }
                try
                {
                    this.Show();
                }
                catch (ObjectDisposedException err)
                {
                    Console.WriteLine("Error: " + err.Message);
                }
            }
            if (Program.getCreditos() <= 0)
            {
                titulo.Text = "Inserte una moneda";
            }

        }


        private void btn_OpenRanking_Click(object sender, EventArgs e)
        {
            using (Ranking Rankg = new Ranking())
            {
                Rankg.ShowDialog();
            }
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.S:
                        btn_StartGame_Click(null, null);
                    break;
                case Keys.C:
                    Program.addCreditos(1);
                    SSL_Credits.Text = Program.getCreditos().ToString();
                    titulo.Text = "Presiona S para empezar a jugar";
                    break;
                case Keys.R:
                    btn_OpenRanking_Click(null, null);
                    break;
                default:
                    break;
            }
        }

        private void btn_InsertCoin_Click(object sender, EventArgs e)
        {
            Program.addCreditos(1);
            SSL_Credits.Text = Program.getCreditos().ToString();
        }

        

    }
}
