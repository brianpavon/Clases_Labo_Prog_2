using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public enum ETIpoHeroe
    {
        Guerrero,
        Mago

    }
    class Heroe<T> //<"Letra"> con esto hago que sea genericy hace que reciba otros parametros
    {                     //por convencion  se pone la letra en mayuscula y de la A a la Z
        int vida;
        int cantMana;
        ETIpoHeroe tIpoHeroe;
        //string aux;
        T aux; //con ese generico hago que lo que le pase, sea un strin

        public Heroe(int vida, int mana,ETIpoHeroe tipo,T aux)
        {
            this.vida = vida;
            this.cantMana = mana;
            this.tIpoHeroe = tipo;
            this.aux = aux;
        }

    }
}
