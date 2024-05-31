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
        }


        private void btn_OpenRanking_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Ranking Iniciado");
        }

        private void btn_StartGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                        btn_StartGame_Click(null, null);
                    break;
                case Keys.X:
                    Program.addCreditos(1);
                    SSL_Credits.Text = Program.getCreditos().ToString();
                    break;
                case Keys.C:
                    Program.addCreditos(-1);
                    SSL_Credits.Text = Program.getCreditos().ToString();
                    break;
                case Keys.Down:
                    break;
                case Keys.Up:
                    break;
                default:
                    break;
            }
        }

        private void btn_OpenRanking_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    btn_OpenRanking_Click(null, null);
                    break;
                case Keys.X:
                    Program.addCreditos(1);
                    SSL_Credits.Text = Program.getCreditos().ToString();
                    break;
                case Keys.C:
                    Program.addCreditos(-1);
                    SSL_Credits.Text = Program.getCreditos().ToString();
                    break;
                case Keys.Down:
                    break;
                case Keys.Up:
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
