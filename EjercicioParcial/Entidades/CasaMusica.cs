using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   
    public class CasaMusica
    {
        private int espacioDeposito;
        private List<InstrumentoMusical> inventarioInstrumentos;
        
        string nombreCasaMusica;
        string direccion;


        public int EspacioDeposito
        {
            get { return espacioDeposito; }
            set { this.espacioDeposito = value; }
        }




    }
}
