﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8_Library
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;

        public Persona(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
        }
        public string Apellido
        {
            get
            {
                return this._apellido;
            }
        }

        public abstract string PosicionSocietaria();

        protected static string Mostrar(Persona p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {p.Nombre}");
            sb.AppendLine($"Apellido: {p.Apellido}");

            return sb.ToString();
        }
    }
}
