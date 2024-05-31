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
    public partial class Selector : Form
    {
        /* Bueno, te recuerdo que este es un codigo de ejemplo, tu debes modificarlo a tu
         * gusto. Eso mismo aplica para el diseño. Si quieres hacerlo desde cero, bienvenido
         * sea.
         */

        // Definición de variables
        private TextBox[] iniciales = new TextBox[3];
        private int posSeleccionados = 0;
        private int posicion = 0;
        private char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'S' };
        public Selector()
        {
            InitializeComponent();
            // Meto los textBox en variables para poder acceder a ellas mejor
            iniciales[0] = textBox1;
            iniciales[1] = textBox2;
            iniciales[2] = textBox3;
            for (int i = 0; i < 3; i++)
            {
                iniciales[i].ReadOnly = true;
                iniciales[i].KeyDown += PruebaSelector_KeyDown;
            }            
        }
       
        private void PruebaSelector_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    btnLeft_Click(null, null);
                    break;
                case Keys.Right:
                    btnRight_Click(null, null);
                    break;
                case Keys.Z:
                    btnAdd_Click(null, null);
                    break;
                case Keys.X:
                    btnRemove_Click(null, null);
                    break;
                default:
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /* Verifico el valor de posSeleccionados, la cual es una variable que 
             * corresponde a iniciales
             * Si es menor que 3, sigue asignando letras, en caso contrario,
             *  el jugador ya ha escrito todas sus letras.
            */
            if (posSeleccionados < 3)
            {
                iniciales[posSeleccionados].Text = letras[posicion].ToString();
                posSeleccionados++;
                if (posSeleccionados == 3)
                {
                    btn_Add.Text = "Aceptar";
                }
            }
            else
            {
                // Este codigo es solo de prueba, editalo a tu gusto
                Console.Write("Nombre listo");
                foreach (TextBox x in iniciales)
                {
                    Console.Write(" " + x.Text);
                }
                Console.WriteLine("");
            }
        }

        
        private void btnRight_Click(object sender, EventArgs e)
        {
            /* Aca verifica que posicion sea menor que el tamaño de las letras.
             * Sí es menor, le añade uno, y sino, lo restablece en 0
            */
            if (posicion < letras.Length - 1)
            {
                posicion++;
            }
            else
            {
                posicion = 0;
            }
            label1.Text = letras[posicion].ToString();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            /* En este caso, el codigo realiza lo contrario a btnRight_Click
             * Verifica que posicion sea mayor o igual que uno, y le resta 1.
             * Si no es así, posicion es igual al tamaño del arreglo
            */
            if (posicion >= 1)
            {
                posicion--;
            }
            else
            {
                posicion = letras.Length - 1;
            }
            label1.Text = letras[posicion].ToString();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            /*
             * Este metodo se encarga de eliminar los datos contenidos en el textBox...
             */
            if (posSeleccionados >= 1)
            {
                posSeleccionados--;
                iniciales[posSeleccionados].Text = string.Empty;
            }
        }


    }
}
