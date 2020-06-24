using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio64
{
    public class Caja
    {
        private List<string> filaClientes;

        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }

        public Caja()
        {
            filaClientes = new List<string>();
        }

        public void AtenderClientes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string item in this.filaClientes)
            {
                sb.AppendLine(this.filaClientes.ToString());
            }

        }





    }
}
