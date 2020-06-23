using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercitacionDelegadosEventos;
namespace MetodoExtension
{
    public static class NumeroExtension
    {
        public static void main()
        {
            EjercitacionDelegadosEventos.Numero numero = new EjercitacionDelegadosEventos.Numero();

            numero.MiMetodoExt();
            
        }

        public static void MiMetodoExt(this EjercitacionDelegadosEventos.Numero num)
        {
            num.MiMetodoExt();
        }
    }
}
