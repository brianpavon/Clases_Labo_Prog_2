using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercitacionDelegadosEventos
{
    public partial class Form1 : Form
    {
        List<Thread> hilos;
        List<Numero> numeros;
        public Form1()
        {
            InitializeComponent();
            hilos = new List<Thread>();
            numeros = new List<Numero>();
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            lblPuntaje.Text = "0";
            btnEmpezar.Click += btnEmpezar_Click;
            

            Numero numero1 = new Numero();
            Numero numero2 = new Numero();
            Numero numero3 = new Numero();
            Numero numero4 = new Numero();

            numeros.Add(numero1);
            numeros.Add(numero2);
            numeros.Add(numero3);
            numeros.Add(numero4);

            numero1.TxtMostrado = txtJug1;
            numero2.TxtMostrado = txtJug2;
            numero3.TxtMostrado = txtJug3;
            numero4.TxtMostrado = txtJug4;

            numero1.LlegueACero += this.Perdiste;//asigno un manejador
            numero2.LlegueACero += this.Perdiste;
            numero3.LlegueACero += this.Perdiste;
            numero4.LlegueACero += this.Perdiste;


            hilos.Add(new Thread(numero1.Descontar));//creo hilos porque hacen un bucle hasta 0, que es un while que no termina
            hilos.Add(new Thread(numero2.Descontar));
            hilos.Add(new Thread(numero3.Descontar));
            hilos.Add(new Thread(numero4.Descontar));
            hilos.Add(new Thread(SumarPuntos));

            btnJug1.Click += numero1.Reset;
            btnJug1.Click += btnJug1_Click;

            btnJug2.Click += numero2.Reset;
            btnJug2.Click += btnJug2_Click;

            btnJug3.Click += numero3.Reset;
            btnJug3.Click += btnJug3_Click;

            btnJug4.Click += numero4.Reset;
            btnJug4.Click += btnJug1_Click;

            foreach (var item in hilos)
            {
                if (!(item.IsAlive))
                {
                    item.Start();
                }
            }

        }

        private void btnJug1_Click(object sender, EventArgs e)
        {
            hilos[0].Abort();
            hilos[0] = new Thread(numeros[0].Descontar);
            hilos[0].Start();
        }
        private void btnJug2_Click(object sender, EventArgs e)
        {
            hilos[1].Abort();
            hilos[1] = new Thread(numeros[1].Descontar);
            hilos[1].Start();

        }
        private void btnJug3_Click(object sender, EventArgs e)
        {
            hilos[2].Abort();
            hilos[2] = new Thread(numeros[2].Descontar);
            hilos[3].Start();
        }
        private void btnJug4_Click(object sender, EventArgs e)
        {
            hilos[3].Abort();
            hilos[3] = new Thread(numeros[3].Descontar);
            hilos[3].Start();
        }

        private void Perdiste(object obj)
        {
            this.EliminarHilos(obj);
            MessageBox.Show("Perdiste");
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            EliminarHilos(null);
        }

        private void EliminarHilos(object obj)
        {
            /*foreach (var item in hilos)
            {
                if (item.IsAlive && ((Numero)obj).TxtMostrado.Name.Substring(6,1) != item.ToString())
                {
                    item.Abort();
                }
            }*/
            for (int i = 0; i < hilos.Count; i++)
            {
                if (hilos[i].IsAlive && (obj is null || ((Numero)obj).TxtMostrado.Name.Substring(6, 1) != (i+1).ToString()))
                {
                    hilos[i].Abort();
                }
            }
        }

        private void SumarPuntos()
        {
            while (true)
            {
                if (lblPuntaje.InvokeRequired)
                {
                    lblPuntaje.BeginInvoke((MethodInvoker)delegate ()
                   {
                       lblPuntaje.Text = (int.Parse(lblPuntaje.Text) + 1).ToString();
                   });
                }
                else
                {
                    lblPuntaje.Text = (int.Parse(lblPuntaje.Text) + 1).ToString();
                }
                Thread.Sleep(15);
            }
        }
    }
}
