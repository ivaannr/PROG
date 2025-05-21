using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval3B_Presencial
{
    internal class Coche:Juguete, ImodificarInterruptor
    {
        protected String descripcion;
        protected bool interruptor;

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Interruptor { get => interruptor; set => interruptor = value; }

        public Coche(string tipo,string descripcion):base(tipo)
        {
            this.Descripcion = descripcion;
            this.Interruptor = interruptor;
            this.interruptor = false;
        }

        public override string ToString() {
            return $"Coche de juguete: [Descripcion: {this.descripcion}], [Interruptor: {(Interruptor ? "Encendido" : "Apagado")}]";
        }

        public void desactivar()
        {
            if (!this.Interruptor)
            {
                Console.WriteLine("El coche ya está apagado.");
            }
            else
            {
                Interruptor = false;
                Console.WriteLine("Apagando...");
            }
        }

        public void modificarInterruptor()
        {
            if (!this.Interruptor)
                activar();
            else
                desactivar();
        }

        public void activar()
        {
            if (this.Interruptor)
            {
                Console.WriteLine("El coche ya está activado.");
            }
            else
            {
                Interruptor = true;
                Console.WriteLine("Activando...");
            }
        }

    }
}
