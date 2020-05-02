using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipoViento
    {
        Trompeta,
        Flauta,
        Saxo
    }
    class InstrumentoViento : InstrumentoMusical
    {
        ETipoViento tipoInstrumento;

        //public InstrumentoViento(int precio, string descNombre, string marca, int codigo) : base(precio, descNombre, marca, codigo)
        //{

        //}

        public override string AfinarInstrumento()
        {
            return "sadasdas";
        }



    }
}
