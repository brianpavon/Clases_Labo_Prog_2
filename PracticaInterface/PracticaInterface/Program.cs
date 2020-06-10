using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Prueba prueba = new Prueba();

            //para acceder explicitamente a los metodos de las interfaz, necesitamos castear ((IExpilicita)prueba).
            //nos da la ventaja de usar 2 metodos que se llamen igual pero que sean de interfaz diferentes


            prueba.Implementacion();//explicita, llamo al metodo de la clase
            ((IExplicita)prueba).Implementacion();// se llama implicitamente
            ((IExplicita)prueba).Implementacion();// se llama implicitamente
            
        }
    }
}
