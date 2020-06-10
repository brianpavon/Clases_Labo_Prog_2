using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Direcciones
{
    public class Localidad
    {
        private decimal id;
        private decimal idProvincia;
        private string descripcion;

        public Localidad(decimal id, decimal idProvincia, string descripcion)
        {
            this.id = id;
            this.idProvincia = idProvincia;
            this.descripcion = descripcion;
        }

        public decimal Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public decimal IdProvincia
        {
            get
            {
                return this.idProvincia;
            }
            set
            {
                this.idProvincia = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        public override string ToString()
        {
            return this.descripcion.ToString();
        }
    }
}
