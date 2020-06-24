using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEventos
{
	public delegate void EnciendeReserva();
	public delegate void SinCombustible();
    public class Automovil
    {
		public event EnciendeReserva EnReserva;
		public event SinCombustible NoHayNasta;
		private int litro;
		private int kilometraje;
		private int autonomia;

		public int Autonomia
		{
			get { return autonomia; }
			set { autonomia = value; }
		}


		public int Kilometraje
		{
			get { return kilometraje; }
			set { kilometraje = value; }
		}

		public int Litro
		{
			get { return litro; }
			set { litro = value; }
		}

		public void Cargar(int litros)
		{
			this.Litro += litros;
		}

		public void Andar()
		{
			while(Litro > 0)
			{
				Litro--;
				Kilometraje++;
				if (this.txtMostrado.InvokeRequired)
				{
					this.txtMostrado.BeginInvoke((MethodInvoker)delegate ()
					{
						this.txtMostrado.Text = Valor.ToString();
					});

				}
				else
				{
					this.txtMostrado.Text = Valor.ToString();
				}
				Thread.Sleep(Velocidad);
			}
		}
		
		public void 


	}
}
