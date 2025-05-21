using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval3B_Presencial
{
    internal class Lampara: ImodificarInterruptor
    {
        protected String descripcion;
        protected bool interruptor;

        public Lampara(string descripcion)
        {
            this.descripcion = descripcion;
            this.interruptor = false;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Interruptor { get => interruptor; set => interruptor = value; }

        public Lampara(string tipo, string descripcion) 
        {
            this.Descripcion = descripcion;
            this.Interruptor = interruptor;
            this.interruptor = false;
        }

        public override string ToString() {
            return $"Lampara: [Descripcion: {this.descripcion}], [Interruptor: {(Interruptor ? "Encendido": "Apagado")}]";
        }

        public void desactivar()
        {
            if (!this.Interruptor)
            {
                Console.WriteLine("La lámpara ya está apagado.");
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
                Console.WriteLine("La lámpara ya está activado.");
            }
            else
            {
                Interruptor = true;
                Console.WriteLine("Activando...");
            }
        }



    }
}

