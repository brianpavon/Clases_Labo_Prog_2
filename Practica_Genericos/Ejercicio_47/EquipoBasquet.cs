﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public class EquipoBasquet : Equipo
    {
        public EquipoBasquet(string nombre,DateTime fecha):base(nombre,fecha)
        {
            this.Nombre = nombre;
            this.FechaCreacion = fecha;
           
        }
    }
}
