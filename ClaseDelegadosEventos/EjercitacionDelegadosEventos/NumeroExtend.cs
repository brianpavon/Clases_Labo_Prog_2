using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitacionDelegadosEventos
{
    public static class NumeroExtend
    {
        public static int HacerTrampa(this Numero num,int valor)
        {
            int valorInicial = num.Valor;
            num.Valor = valor;
            return valorInicial;
        }
    }
}
