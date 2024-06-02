
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesuko
{
    static class Program
    {

        private static int creditos = 0;

        public static int getCreditos()
        {
            return creditos;
        }

        public static void setCreditos(int entrada)
        {
            if (entrada >= 0 && entrada <= 10)
            {
                creditos = entrada;
            }
        }

        public static void addCreditos(int entrada)
        {
             creditos += entrada;
        }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ScreenStart() );

           /* int repetir = 0;
            while (repetir < 100)
            {
                Tablero tablero = new Tablero();
                tablero.generarTablero();
                tablero.mostrar();
                Console.WriteLine("");
                repetir++;
                Console.ReadLine();
            }*/

            
        }
    }

    public static class Colores
    {
        public static System.Drawing.Color soloLectura = System.Drawing.Color.Gray;
        public static System.Drawing.Color sonIguales = System.Drawing.Color.Red;

    }
}
