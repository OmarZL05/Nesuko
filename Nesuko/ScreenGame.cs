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
    public partial class ScreenGame : Form
    {
        // Tiempo, nombre, puntuación.

        private TextBox[,] celdas = new TextBox[4, 4];
        private Timer timer;

        public ScreenGame()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();


            celdas[0, 0] = box1_1;
            celdas[0, 1] = box1_2;
            celdas[0, 2] = box1_3;
            celdas[0, 3] = box1_4;
            celdas[1, 0] = box2_1;
            celdas[1, 1] = box2_2;
            celdas[1, 2] = box2_3;
            celdas[1, 3] = box2_4;
            celdas[2, 0] = box3_1;
            celdas[2, 1] = box3_2;
            celdas[2, 2] = box3_3;
            celdas[2, 3] = box3_4;
            celdas[3, 0] = box4_1;
            celdas[3, 1] = box4_2;
            celdas[3, 2] = box4_3;
            celdas[3, 3] = box4_4;

            celdas[0, 0].ReadOnly = true;
            celdas[0, 0].BackColor = Colores.soloLectura;
            celdas[0, 0].Text = 1 + "";

            celdas[3, 3].ReadOnly = true;
            celdas[3, 3].BackColor = Colores.soloLectura;
            celdas[3, 3].Text = 4 + "";
        }

        // 1m = 2500 pts, 2m = 1600, 3m = 600, 5m = 300, 10m = 0

        // x <= 60 segundos <x<= 120 segundos <x<= 180 segundos <x<= 300 segundos <x<= 600 segundos > x
        // 60 segs/40 segs
        // resultado*porcentaje/100
        // (base/mod)
        // (60/40)*2500 = 1500 + 100%
        // (120/70)*1200 = 857
        // (180/130)*600 = 346
        // (300/400)
        // 180/599
        // (600/601)*0 = 0

        private string prueba() 
        {
            int tiempo=0;
            int puntuacion = 1;

            if (tiempo <= 60) {
                puntuacion = (60 / tiempo) * 2500;
            } 
            else if(tiempo > 60 && tiempo <= 120) { 
                puntuacion = (120 / tiempo) * 1600;
            }
            else if (tiempo > 120 && tiempo <= 600) {
                puntuacion = (300 / tiempo) * 600;
            }
            else if (tiempo > 600)
            {
                puntuacion = 0;
            }


            return tiempo.ToString();
        }


        public int tiempo = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualizar el contenido del Label con la hora actual
            lbl_Time.Text = tiempo.ToString();
            tiempo++;
        }

        private void box_KeyPress(object sender, KeyPressEventArgs e)
        {
            int value;
            int.TryParse(e.KeyChar.ToString(), out value);

            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) || (char.IsDigit(e.KeyChar) && (value < 1 || value > 4))))
            {
                e.Handled = true;
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
        }

        private void ControlMagic(int posX, int posY)
        {
            int x=0,y=0;
            int iguales;
            int win = 0;
            while (x < 4 && y < 4) 
            {
                iguales = 0;
                if (celdas[x, y].Text.Length > 0) 
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (celdas[x, y].Name != celdas[x, i].Name && celdas[x, y].Text == celdas[x, i].Text)
                        {
                            celdas[x, y].BackColor = Colores.sonIguales;
                            celdas[x, i].BackColor = Colores.sonIguales;
                            iguales += 2;
                        }

                        if (celdas[x, y].Name != celdas[i, y].Name && celdas[x, y].Text == celdas[i, y].Text)
                        {
                            celdas[x, y].BackColor = Colores.sonIguales;
                            celdas[i, y].BackColor = Colores.sonIguales;
                            iguales += 2;
                        }
                    }

                }

                if (iguales < 2 && celdas[x, y].BackColor == Colores.sonIguales && !celdas[x, y].ReadOnly) 
                {
                    celdas[x, y].BackColor = Color.White;
                }
                else if (iguales < 2 && celdas[x, y].ReadOnly)
                {
                    celdas[x, y].BackColor = Colores.soloLectura;
                }
                

                if (celdas[x, y].BackColor == Colores.sonIguales)
                {
                    win--;
                }
                else if (celdas[x, y].BackColor != Colores.sonIguales && celdas[x, y].Text.Length > 0)
                {
                    win++;

                }

                y++;
                if (y == 4) {
                    x++;
                    y = 0;
                }


            }

            Console.WriteLine(win);
            if (win == 16) {
                timer.Stop();
                int puntuacion=0;

                if (tiempo <= 60)
                {
                    puntuacion = (60 / tiempo) * 2500;
                }
                else if (tiempo > 60 && tiempo <= 120)
                {
                    puntuacion = (120 / tiempo) * 1600;
                }
                else if (tiempo > 120 && tiempo <= 600)
                {
                    puntuacion = (300 / tiempo) * 600;
                }
                else if (tiempo > 600)
                {
                    puntuacion = 0;
                }

                using (ScreenWin winScreen = new ScreenWin(tiempo, puntuacion))
                {
                    this.Hide();
                    winScreen.ShowDialog();
                    this.Dispose();
                }
            }

        }

        // Seccion 1:
        private void box1_1_TextChanged(object sender, EventArgs e)
        {
            celdas[0, 0] = box1_1;
            ControlMagic(0, 0);
        }

        private void box1_2_TextChanged(object sender, EventArgs e)
        {
            celdas[0, 1] = box1_2;
            ControlMagic(0, 1);
        }

        private void box1_3_TextChanged(object sender, EventArgs e)
        {
            celdas[0, 2] = box1_3;
            ControlMagic(0, 2);
        }

        private void box1_4_TextChanged(object sender, EventArgs e)
        {
            celdas[0, 3] = box1_4;
            ControlMagic(0, 3);
        }

        // Seccion 2:

        private void box2_1_TextChanged(object sender, EventArgs e)
        {
            celdas[1, 0] = box2_1;
            ControlMagic(1, 0);
        }

        private void box2_2_TextChanged(object sender, EventArgs e)
        {
            celdas[1, 1] = box2_2;
            ControlMagic(1, 1);
        }

        private void box2_3_TextChanged(object sender, EventArgs e)
        {
            celdas[1, 2] = box2_3;
            ControlMagic(1, 2);
        }

        private void box2_4_TextChanged(object sender, EventArgs e)
        {
            celdas[1, 3] = box2_4;
            ControlMagic(1, 3);
        }

        // Seccion 3:

        private void box3_1_TextChanged(object sender, EventArgs e)
        {
            celdas[2, 0] = box3_1;
            ControlMagic(2, 0);
        }

        private void box3_2_TextChanged(object sender, EventArgs e)
        {
            celdas[2, 1] = box3_2;
            ControlMagic(2, 1);
        }

        private void box3_3_TextChanged(object sender, EventArgs e)
        {
            celdas[2, 2] = box3_3;
            ControlMagic(2, 2);
        }

        private void box3_4_TextChanged(object sender, EventArgs e)
        {
            celdas[2, 3] = box3_4;
            ControlMagic(2, 3);
        }

        // Seccion 4:

        private void box4_1_TextChanged(object sender, EventArgs e)
        {
            celdas[3, 0] = box4_1;
            ControlMagic(3, 0);
        }

        private void box4_2_TextChanged(object sender, EventArgs e)
        {
            celdas[3, 1] = box4_2;
            ControlMagic(3,1);
        }

        private void box4_3_TextChanged(object sender, EventArgs e)
        {
            celdas[3, 2] = box4_3;
            ControlMagic(3,2);
        }

        private void box4_4_TextChanged(object sender, EventArgs e)
        {
            celdas[3, 3] = box4_4;
            ControlMagic(3,3);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
