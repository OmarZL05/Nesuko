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
        public void generarTablero()
        {
            int posX = 0, posY = 0;
            int numero;
            Random rand = new Random();
            bool sinRepetir = false;
            int tamaño = rand.Next(1, 5);
            int[,] usados = new int[3, tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                int y = 0;
                posX = rand.Next(0, 4);
                posY = rand.Next(0, 4);
                numero = rand.Next(1, 5);

                sinRepetir = false;
                while (!sinRepetir)
                {
                    if (posX == usados[0, y])
                    {
                        posX = rand.Next(0, 4);
                        sinRepetir = false;
                    }
                    else if (usados[0, y] <= 0)
                    {
                        usados[0, y] = posX;
                        sinRepetir = true;
                    }
                    else
                    {
                        y++;
                    }

                    if (y == tamaño)
                    {
                        y = 0;
                    }
                }

                y = 0;
                sinRepetir = false;
                while (!sinRepetir)
                {
                    if (posY == usados[1, y])
                    {
                        posY = rand.Next(0, 4);
                        sinRepetir = false;
                    }
                    else if (usados[1, y] <= 0)
                    {
                        usados[1, y] = posY;
                        sinRepetir = true;
                    }
                    else
                    {
                        y++;
                    }

                    if (y == tamaño)
                    {
                        y = 0;
                    }
                }

                y = 0;
                sinRepetir = false;
                while (!sinRepetir)
                {
                    // 1 2 3 0 <-- [1]
                    if (numero == usados[2, y])
                    {
                        numero = rand.Next(1, 5);
                        y = 0;
                        sinRepetir = false;
                    }
                    else if (usados[2, y] <= 0)
                    {
                        usados[2, y] = numero;
                        sinRepetir = true;
                    }
                    else
                    {
                        y++;
                    }

                    if (y == tamaño)
                    {
                        y = 0;
                    }

                }

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
