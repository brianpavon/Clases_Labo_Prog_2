using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipoPercusion
    {
        Bateria,
        CajonPeruano,
        Tambor
    }
    class InstrumentoPercusion : InstrumentoMusical
    {
        ETipoPercusion tipoInstrumento;

        //public InstrumentoPercusion(int precio,string descNombre,string marca,int codigo):base(precio,descNombre,marca,codigo)
        //{

        //}

        public override string AfinarInstrumento()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Este intrumento es un/una {this.tipoInstrumento}");
            sb.AppendLine($"Se regula el aro ");
            sb.AppendLine($"Checkear el nivel de tension");
            sb.AppendLine($"Si esta pasada, se afloja");
            sb.AppendLine($"Si esta floja, se tensa");
            sb.AppendLine($"El instrumento esta afinado");


            return sb.ToString();

        }



    }
}
