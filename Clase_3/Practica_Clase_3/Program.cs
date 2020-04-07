using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Practica_Clase_3
{
    class Program
    {
        const int DERECHA = 1;
        const int IZQUIERDA = 2;
        const int ABAJO = 3;
        const int ARRIBA = 4;
        static void Main(string[] args)
        {
            //si declaramos una constante que usaremos en todo el programa se declara asi, solo existe en el scoop que se declare
            //const int LIMITEDERECHA = 80;

            //seguimos con el ejemplo de un jueguito
            
            Jugador.numeroJugadores = 0;
            //Jugador jugador1;

            //jugador1 = new Jugador("Panchito",true);
            Jugador[] jugadores = new Jugador[4];//declaro un array de jugadores


            //Jugador jugador2;
            //jugador2 = new Jugador("Cachita",true);

            ConsoleKeyInfo consoleKeyInfo;//me guarda lo que se apreto
            #region
            //si pongo # y mas abajo #endregio, me permite minizar todo ese codigo entre los #
            // el rectangulo se hace con alt+219

            for (int i = 0; i < 20; i++)//verticales
            {
                Console.CursorLeft = 1;//ubica al cursor en la izquierda al numero que le asigno
                Console.CursorTop = i;
                Console.Write("█");
                Console.CursorLeft = 80;//ubica al cursor en la izquierda al numero que le asigno
                Console.CursorTop = i;
                Console.Write("█");
            }
            for (int i = 1; i <= 80; i++)//verticales
            {
                Console.CursorLeft = i;//ubica al cursor en la izquierda al numero que le asigno
                Console.CursorTop = 1;
                Console.Write("█");
                Console.CursorLeft = i;//ubica al cursor en la izquierda al numero que le asigno
                Console.CursorTop = 20;
                Console.Write("█");
            }
            #endregion//hacerCancha  //hacerCancha HACER CANCHA
            do
            {             
                while(!Console.KeyAvailable)
                {
                    //jugador1.mover();
                    foreach(Jugador jugador in jugadores)
                    {
                        if(jugador!=null)
                            jugador.mover();
                    }                    
                    Thread.Sleep(100);
                }
                //Console.WriteLine();
                consoleKeyInfo = Console.ReadKey();
                if(consoleKeyInfo.Key == ConsoleKey.N)
                {
                    if(Jugador.numeroJugadores < jugadores.Length)
                    {
                        jugadores[Jugador.numeroJugadores] = new Jugador("Jugador " + (Jugador.numeroJugadores + 1, false));
                    }
                    /*for (int i = 0; i < jugadores.Length; i++)
                    {                   
                        if(jugadores[i] is null)
                        {
                            jugadores[i] = new Jugador("Jugador " + Jugador.numeroJugadores, false);
                            break;
                        }                            
                    }*/
                }

                foreach (Jugador jugador in jugadores)
                {
                    if(jugador != null)
                    {
                        switch (consoleKeyInfo.Key)//con esto hago el movimiento del jugador
                        {
                            case ConsoleKey.UpArrow:
                                jugador.movimiento = ARRIBA;
                                break;

                            case ConsoleKey.DownArrow:
                                jugador.movimiento = ABAJO;
                                break;

                            case ConsoleKey.LeftArrow:
                                jugador.movimiento = IZQUIERDA;
                                break;

                            case ConsoleKey.RightArrow:
                                jugador.movimiento = DERECHA;
                                break;
                        }
                    }
                    
                }                

            } while (consoleKeyInfo.KeyChar != 27);
        }
    }
}
