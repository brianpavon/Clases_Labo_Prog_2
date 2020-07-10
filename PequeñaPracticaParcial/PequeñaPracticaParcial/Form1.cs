using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PequeñaPracticaParcial
{
    public partial class Form1 : Form
    {
        delegate void AnalizarPersona(Persona p);
        delegate void AtenderProximo();

        event AnalizarPersona TieneTemperatura;
        event AtenderProximo SiguienteAtender;
        
        //List<Persona> personas;
        Queue<Persona> personas;
        Queue<Persona> contagiados;
        Random temperatura;
        Thread t1;
        Thread t2;
        Thread t3;
        Thread t4;
        Thread t5;
        List<Thread> hilos;

        public Form1()
        {
            InitializeComponent();
            //personas = new List<Persona>();
            
            personas = new Queue<Persona>();
            contagiados = new Queue<Persona>();
            temperatura =  new Random();
            this.LlenarCola();
            hilos = new List<Thread>();
            TieneTemperatura += SepararContagiado;
            SiguienteAtender += Proximo;
            
            t1 = new Thread(Proximo);
            t2 = new Thread(Proximo);
            t3 = new Thread(Proximo);
            t4 = new Thread(Proximo);
            t5 = new Thread(Proximo);

            this.IniciarHilos();
            hilos.Add(t1);
            hilos.Add(t2);
            hilos.Add(t3);
            hilos.Add(t4);
            hilos.Add(t5);

        }
        private void LlenarCola()
        {
            personas.Enqueue(new Persona("Prangnell", 321321231));
            personas.Enqueue(new Persona("Spinks", 14244242424));
            personas.Enqueue(new Persona("Emblin", 155555555));
            personas.Enqueue(new Persona("Janzen", 16666516));
            personas.Enqueue(new Persona("Percy", 133131457));
            personas.Enqueue(new Persona("Dewan", 1512318));
            personas.Enqueue(new Persona("Sacaze", 16532429));
            personas.Enqueue(new Persona("Belleny", 2654540));
            personas.Enqueue(new Persona("Beckson", 2653532));
            personas.Enqueue(new Persona("Stitt", 23213213212));
            personas.Enqueue(new Persona("Conlon", 243262623));
            personas.Enqueue(new Persona("Fishbie", 3132132));
            personas.Enqueue(new Persona("Iveagh", 5674543));
            personas.Enqueue(new Persona("Robez", 22311136));
            personas.Enqueue(new Persona("Le Sarr", 267845437));
            personas.Enqueue(new Persona("Gheorghie", 286234242));
            personas.Enqueue(new Persona("Kopfer", 22132132149));
            personas.Enqueue(new Persona("Weeke", 332131560));
            personas.Enqueue(new Persona("Hamon", 316546542));
            personas.Enqueue(new Persona("Seif", 328653));
            personas.Enqueue(new Persona("Mussalli", 338638653));
            personas.Enqueue(new Persona("Kleinsmuntz", 33567254));
            personas.Enqueue(new Persona("Guymer", 1543534678));
            personas.Enqueue(new Persona("Bogaert", 42342366623));
            personas.Enqueue(new Persona("Carletto", 5434643543));
            personas.Enqueue(new Persona("Grishukov", 35640179));
            personas.Enqueue(new Persona("Grishukov", 364363212));
            personas.Enqueue(new Persona("Moggan", 111333355));
            personas.Enqueue(new Persona("Emlin", 43215678));
            personas.Enqueue(new Persona("Kinnock", 477658561));
            personas.Enqueue(new Persona("Newcomb", 908768768));

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            personas.Enqueue(new Persona(txtNombre.Text, long.Parse(txtDni.Text)));
            
        }

        private void Proximo()
        {
            if(personas.Count > 0)
            {
                this.Atender(personas.Dequeue());
            }
        }

        private void SepararContagiado(Persona p)
        {
            Thread.Sleep(20000);
            contagiados.Enqueue(p);
            MessageBox.Show("Sera Trasladado", "ALERTA POSIBLE POSITIVO", MessageBoxButtons.OK);
        }


        private void Atender(Persona persona)
        {
            persona.Temperatura = temperatura.Next(35, 39);
            Thread.Sleep(5000);            
            if(persona.Temperatura > 37.5)
            {
                TieneTemperatura.Invoke(persona);//para invocar tengo que asociarle otro evento
            }
            SiguienteAtender();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarHilos();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //this.IniciarHilos();
        }


        private void IniciarHilos()
        {
            btnCargar.Click -= btnCargar_Click;//le saco el evento
            do
            {
                t1.Start();
                Thread.Sleep(1000);
                t2.Start();
                Thread.Sleep(1000);
                t3.Start();
                Thread.Sleep(1000);
                t4.Start();
                Thread.Sleep(1000);
                t5.Start();
                Thread.Sleep(1000);
            } while (personas.Count > 0);//while (true);
            
        }

        private void FinalizarHilos()
        {
            foreach (Thread item in hilos)
            {
                if (item.IsAlive)
                    item.Abort();
            }
        }
    }
}
