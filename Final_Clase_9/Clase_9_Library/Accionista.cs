using Clase_8_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9_Library
{
    public class Accionista : Persona
    {
        private int _porcionAccionaria;

        public Accionista(string nombre,string apellido,int _porcionAccionaria):base(nombre,apellido)
        {
            this._porcionAccionaria = _porcionAccionaria;
        }


        public int PorcionAccionaria
        {
            get { return this._porcionAccionaria; }
            set 
            {
                if(value > 0 && value < 100)
                {
                    this._porcionAccionaria = value;
                }
            }
        }

        public override string PosicionSocietaria()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Accionista con el {this._porcionAccionaria}%");
            return sb.ToString();
        }

        public static bool operator == (Accionista accionistaUno, Accionista accionistaDos)
        {
            if(!(accionistaUno is null) && !(accionistaDos is null))
            {
                if(accionistaUno._nombre == accionistaDos._nombre && 
                    accionistaUno._apellido==accionistaDos._apellido &&
                    accionistaUno._porcionAccionaria == accionistaDos._porcionAccionaria)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator != (Accionista accionistaUno, Accionista accionistaDos)
        {
            return !(accionistaUno == accionistaDos);
        }

    }
}
