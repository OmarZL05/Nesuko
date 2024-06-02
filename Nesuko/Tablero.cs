using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesuko
{
    public class Tablero
    {
        private int[,] matriz = new int[4, 4]; // Esta variable representa el tablero.
        public void generar()
        {
            int posX = 0, posY = 0;
            int numero;
            int[] repetidos = new int[4];
            bool sinRepetir;
            Random rand = new Random();


            for (int i = 0; i < rand.Next(1, 5); i++)
            {
                posX = rand.Next(0, 4);
                posY = rand.Next(0, 4);

                numero = rand.Next(1,5);
                matriz[posX, posY] = numero;
            }

        }

        public void mostrar()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }

    }
}
