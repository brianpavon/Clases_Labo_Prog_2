using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipoCuerda
    {
        GuitarraElectrica,
        GuitarraAcustica,
        Bajo,
        Violin,
        Piano
    }

    class InstrumentoCuerda : InstrumentoMusical
    {

        ETipoCuerda tipoInstrumento;
        //public InstrumentoCuerda(int precio, string descNombre, string marca, int codigo) : base(precio, descNombre, marca, codigo)
        //{
        //    //en este cuerpo no tengo que decirle donde cargar los datos, porque ya se hizo en el constructor 
        //    //de la clase padre
        //}

        public override string AfinarInstrumento()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Este intrumento es un/una {this.tipoInstrumento}");
            sb.AppendLine($"Checkear que la cuerda este afinadda");
            sb.AppendLine($"Si esta un tono abajo, se ajusta");
            sb.AppendLine($"Si esta un tono arriba, se afloja");
            sb.AppendLine($"El instrumento esta afinado");

            return sb.ToString();
        }


    }
}
