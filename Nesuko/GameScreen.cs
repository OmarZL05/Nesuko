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
    public partial class GameScreen : Form
    {

        private static System.Drawing.Color RedColor = System.Drawing.Color.Red;
        private static System.Drawing.Color WhiteColor = System.Drawing.Color.White;

        private int[,] cells;

        private TextBox[,] celdas = new TextBox[4,4];

        public GameScreen()
        {
            InitializeComponent();
            cells = new int[4, 4];
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

        public void isUnique(TextBox box)
        {

        }

        private void GameScreen_Load(object sender, EventArgs e) {
            celdas[0, 0] = box1_1;
            celdas[0, 1] = box1_2;
            celdas[0, 2] = box1_3;
            celdas[0, 3] = box1_4;
            celdas[1, 0] = box2_1;
            celdas[1, 1] = box2_2;
            celdas[1, 2] = box2_3;
            celdas[1, 3] = box2_4;
        }

        private void fila_1(TextBox caja)
        {

            caja.BackColor = System.Drawing.Color.White;

            if (caja.Text.Length < 1)
            {
                return;
            }

            if (caja.Text == box1_1.Text && caja.Name != box1_1.Name)
            {
                caja.BackColor = System.Drawing.Color.Red;
                box1_1.BackColor = System.Drawing.Color.Red;
            }
            
            if (caja.Text == box1_2.Text && caja.Name != box1_2.Name)
            {
                caja.BackColor = System.Drawing.Color.Red;
                box1_2.BackColor = System.Drawing.Color.Red;
            } 

            if (caja.Text == box1_3.Text && caja.Name != box1_3.Name)
            {
                caja.BackColor = System.Drawing.Color.Red;
                box1_3.BackColor = System.Drawing.Color.Red;
            }

            if (caja.Text == box1_4.Text && caja.Name != box1_4.Name)
            {
                caja.BackColor = System.Drawing.Color.Red;
                box1_4.BackColor = System.Drawing.Color.Red;
            }
        }

        /*private void nuevaFuncion(TextBox caja)
        {
            caja.BackColor = System.Drawing.Color.White;
            for (int i = 0; i < 4; i++)
            {
                if (celdas[0, i].Name != caja.Name && celdas[0, i].Text.Length > 0 && caja.Text.Length > 0 && celdas[0, i].Text == caja.Text)
                {
                    celdas[0, i].BackColor = System.Drawing.Color.Red;
                    caja.BackColor = System.Drawing.Color.Red;
                }
                else if (celdas[0, i].Text.Length > 0 && caja.Text.Length > 0 && celdas[0, i].Name != caja.Name && i<3 && celdas[0, i] != celdas[0, i+1])
                {
                    celdas[0, i].BackColor = System.Drawing.Color.White;
                }
            }
            
        }*/

        private int cantidadIguales(int posX, TextBox caja, TextBox[,] cajas)
        {
            int iguales = 0;
            for (int i = 0; i < 4; i++)
            {
                if (caja != cajas[posX, i] && caja.Text.Length > 0 && cajas[posX, i].Text == caja.Text)
                {
                    iguales++;
                    caja.BackColor = RedColor;
                }
            }
            return iguales;
        }


        private void verificarIgualdades(int posX, TextBox[,] cajas)
        {

            for (int i = 0; i < 4; i++) {
                if (cantidadIguales(posX, cajas[posX, i], cajas) < 1) 
                {
                    cajas[posX, i].BackColor = WhiteColor;
                }
            }
            

        }

        // Seccion 1:
        private void box1_1_TextChanged(object sender, EventArgs e)
        {
            celdas[0, 0] = box1_1;
            verificarIgualdades(0, celdas);
        }

        private void box1_2_TextChanged(object sender, EventArgs e)
        {
            celdas[0, 1] = box1_2;
            verificarIgualdades(0, celdas);
        }

        private void box1_3_TextChanged(object sender, EventArgs e)
        {
            celdas[0, 2] = box1_3;
            verificarIgualdades(0, celdas);
        }

        private void box1_4_TextChanged(object sender, EventArgs e)
        {
            celdas[0, 3] = box1_4;
            verificarIgualdades(0, celdas);
        }

        // Seccion 2:

        private void box2_1_TextChanged(object sender, EventArgs e)
        {
            celdas[1, 0] = box2_1;
            verificarIgualdades(1, celdas);
        }

        private void box2_2_TextChanged(object sender, EventArgs e)
        {
            celdas[1, 1] = box2_2;
            verificarIgualdades(1, celdas);
        }

        private void box2_3_TextChanged(object sender, EventArgs e)
        {
            celdas[1, 2] = box2_3;
            verificarIgualdades(1, celdas);
        }

        private void box2_4_TextChanged(object sender, EventArgs e)
        {
            celdas[1, 3] = box2_4;
            verificarIgualdades(1, celdas);
        }

        // Seccion 3:

        private void box3_1_TextChanged(object sender, EventArgs e)
        {
            celdas[2, 0] = box3_1;
            verificarIgualdades(2, celdas);
        }

        private void box3_2_TextChanged(object sender, EventArgs e)
        {
            celdas[2, 1] = box3_2;
            verificarIgualdades(2, celdas);
        }

        private void box3_3_TextChanged(object sender, EventArgs e)
        {
            celdas[2, 2] = box3_3;
            verificarIgualdades(2, celdas);
        }

        private void box3_4_TextChanged(object sender, EventArgs e)
        {
            celdas[2, 3] = box3_4;
            verificarIgualdades(2, celdas);
        }

        // Seccion 4:

        private void box4_1_TextChanged(object sender, EventArgs e)
        {
            celdas[3, 0] = box4_1;
            verificarIgualdades(3, celdas);
        }

        private void box4_2_TextChanged(object sender, EventArgs e)
        {
            celdas[3, 1] = box4_2;
            verificarIgualdades(3, celdas);
        }

        private void box4_3_TextChanged(object sender, EventArgs e)
        {
            celdas[3, 2] = box4_3;
            verificarIgualdades(3, celdas);
        }

        private void box4_4_TextChanged(object sender, EventArgs e)
        {
            celdas[3, 3] = box4_4;
            verificarIgualdades(3, celdas);
        }

        
    }
}
