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
        private TextBox[,] celdas = new TextBox[4, 4];
        private Timer timer;

        public ScreenGame()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();

            lbl_nivel.Text = "1";
            LSG_Creditos.Text = Program.getCreditos().ToString();

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

        public int tiempo = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = tiempo+"/180";
            tiempo++;
            if (tiempo >= 180)
            {
                timer.Stop();
                // gameOver
            }
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

        public int errores = 0;

        private void ganar() {
            timer.Stop();
            float pts = 0;
            float ptsExtra = 0;
            errores *= 2;

            if (this.tiempo <= 60)
            {
                pts = (60 / float.Parse(this.tiempo+"") * 2500f);
            }
            else if (this.tiempo > 60 && this.tiempo <= 120)
            {
                pts = (120 / float.Parse(this.tiempo + "")) * 1600f;
            }
            else if (this.tiempo > 120 && this.tiempo <= 600)
            {
                pts = (300 / float.Parse(this.tiempo + "")) * 600f;
            }
            else if (this.tiempo > 600)
            {
                pts = 0;
            }

            if (errores < 100)
            {
                ptsExtra = (pts * (100 - this.errores)) / 100;
            }

            using (ScreenWin winScreen = new ScreenWin(tiempo, pts, ptsExtra))
            {
                this.Hide();
                winScreen.ShowDialog();
                this.Dispose();
            }
        }

        private void ControlMagic(int posX, int posY)
        {
            int x=0,y=0;
            int iguales;
            int win = 0;
            int errores = 0;
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

                if (celdas[posX, posY].BackColor == Colores.sonIguales && celdas[posX, posY].TextLength > 0)
                {
                    errores++;
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

            if (errores >= 1) {
                this.errores++;
                lbl_fails.Text = this.errores+"/100";
                if (this.errores >= 100)
                {
                    // gameOver
                    timer.Stop();
                }
            }

            if (win == 16) {
                ganar();
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

        private void LSG_Creditos_Click(object sender, EventArgs e)
        {

        }


    }
}
