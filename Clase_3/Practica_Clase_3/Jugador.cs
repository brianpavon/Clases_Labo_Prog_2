using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clase_3
{
    

    class Jugador
    {
        //para crear una instancia debemos crear un constructor, de todas maneras esta por defecto.
        //constructores estaticos, son publicos, se corre antes que el constructor de instancia,inicializa las clases,no puede recibir parametros
        const int DERECHA = 1;
        const int IZQUIERDA = 2;
        const int ABAJO = 3;
        const int ARRIBA = 4;


        public string nombre;
        public static int numeroJugadores;
        public int vida;
        //private KeyValuePair<int, int> posicio;//deja poner un tipo de dato con 2 valores
        private int posicionY;
        private int posicionX;
        public int movimiento;
        public bool isAlive;
        static Jugador()
        {
            numeroJugadores = 0;
        }
        

        public Jugador(string nombre, bool posicionDerecha)//:this()//este seria el constructor, con : llamo a un constructor que este privado u otro sin parametros
        {
            Jugador.numeroJugadores++;
            this.nombre = nombre;
            this.vida = 100;
            this.isAlive = true;
            posicionX = 10;
            posicionY = 10;
            movimiento = DERECHA;
            //this.movivimiento = 0;
            if (posicionDerecha )
            {
                posicionX = 70;
                movimiento = IZQUIERDA;
            }
            pintar();
        }

        private void pintar()
        {
            Console.CursorLeft = posicionX;
            Console.CursorTop = posicionY;
            Console.Write("█");
        }

        public void mover()
        {
            Console.CursorLeft = posicionX;
            Console.CursorTop = posicionY;
            Console.Write(" ");

            switch(movimiento)
            {
                case DERECHA:
                    posicionX++;
                    break;
                case IZQUIERDA:
                    posicionX--;
                    break;
                case ARRIBA:
                    posicionY--;
                    break;
                case ABAJO:
                    posicionY++;
                    break;
            }
            pintar();
                
        }
        
    }
}
