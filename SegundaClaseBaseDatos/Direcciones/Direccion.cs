﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Direcciones
{
    public class Direccion
    {
        private decimal id;
        private string calle;
        private int numero;
        private decimal idLocalidad;
        private int piso;
        private string departamento;

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

        public string Calle
        {
            get
            {
                return this.calle;
            }
            set
            {
                this.calle = value;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public decimal IdLocalidad
        {
            get
            {
                return this.idLocalidad;
            }
            set
            {
                this.idLocalidad = value;
            }
        }

        public int Piso
        {
            get
            {
                return this.piso;
            }
            set
            {
                this.piso = value;
            }
        }

        public string Departamento
        {
            get
            {
                return this.departamento;
            }
            set
            {

                this.departamento = value;
            }
        }


    }
}
