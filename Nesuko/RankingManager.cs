using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesuko
{
    public static class RankingManager
    {
        public static string[] jugadores = new string[10];
        public static float[] ptsJugadores = new float[10];

        public static void declarar()
        {
            for (int i = 0; i < 10 ;i++)
            {
                jugadores[i] = "AAA";
                ptsJugadores[i] = 0;
            }
        }
        

        public static void PosicionRanking(string jugador, float puntuacion)
        {
            float ptsAux;
            string nombreAux;
            for (int i = 0; i < 10; i++)
            {
                if (puntuacion > ptsJugadores[i])
                {
                    ptsAux = ptsJugadores[i];
                    nombreAux = jugadores[i];

                    ptsJugadores[i] = puntuacion;
                    jugadores[i] = jugador;

                    puntuacion = ptsAux;
                    jugador = nombreAux;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (ptsJugadores[j] < ptsJugadores[j + 1])
                    {
                        ptsAux = ptsJugadores[j + 1];
                        nombreAux = jugadores[j + 1];

                        ptsJugadores[j + 1] = ptsJugadores[j];
                        jugadores[j + 1] = jugadores[j];

                        ptsJugadores[j] = ptsAux;
                        jugadores[j] = nombreAux;
                    }
                }
            }

        }
    }
}
