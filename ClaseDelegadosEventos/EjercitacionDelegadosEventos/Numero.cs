using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercitacionDelegadosEventos
{
    public delegate void EnCero(object sender);
    public class Numero
    {
		public event EnCero LlegueACero;
		private TextBox txtMostrado;//un control

		private int valor;
		private int velocidad;

		public int Velocidad
		{
			get { return velocidad; }
			set 
			{
				if (value < 1)
					throw new Exception("No se puede asignar velocidad menor a 0");
				velocidad = value; 
			}
		}


		public int Valor
		{
			get { return valor; }
			set 
			{
				if(value == 0 && LlegueACero.GetInvocationList() != null)//si yo pongo valor = 0 ahi llama al evento
				{
					valor = value; 

				}
			}
		}

		public TextBox TxtMostrado
		{
			get { return txtMostrado; }
			set { txtMostrado = value; }
		}

		public Numero()
		{
			Velocidad = 100;
			Valor = 100;
		}


		public void Reset(object sender, EventArgs e)
		{
			Valor = 100;
			Velocidad = Velocidad - 5;
		}

		public void Descontar()
		{
			while(Valor > 0)
			{
				
				Valor--;
				if (this.txtMostrado.InvokeRequired)
				{
					this.txtMostrado.BeginInvoke((MethodInvoker) delegate()
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
	}
}
