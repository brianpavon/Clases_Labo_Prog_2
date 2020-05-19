using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Entidades_Excepcion
{
    public class MiClase
    {
        //private int numeroUno;
        //private int numerdoDos;

        //public int NumeroUno
        //{
        //    set
        //    {
        //        this.numeroUno = value;
        //    }
        //    get
        //    {
        //        return this.numeroUno;
        //    }
        //}

        //public int NumeroDos
        //{
        //    set
        //    {
        //        this.numerdoDos = value;
        //    }
        //    get
        //    {
        //        return this.numerdoDos;
        //    }
        //}

        //public MiClase(int primerNumero,int segundoNumero)
        //{
        //    this.numeroUno = primerNumero;
        //    this.numerdoDos = segundoNumero;
        //}

        //public MiClase()
        //{
        //    this.numeroUno = 0;
        //    this.numerdoDos = 0;

        //}

        //public static void Lanzar(int numeroUno, int numeroDos)
        //{
        //    if(numeroDos < 0)
        //    {
        //       return throw DivideByZeroException;
        //    }

        //}

        public static void MetodoEstatico()
        {
            try
            {
                int numeroUno = 0;
                int numeroDos = 10;
                int resultado = numeroDos / numeroUno;
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }

        }
        public MiClase()
        {
            try
            {
                MiClase.MetodoEstatico();
            }
            catch(DivideByZeroException e)
            {
                throw e;
            }
        }

        public MiClase(int valor)
        {
            try
            {
                new MiClase();
            }
            catch(DivideByZeroException e)
            {
                throw new UnaException("Segundo constructor",e);
            }
            
        }

        
    }
}
