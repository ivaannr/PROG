using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotización___Interfaces
{
    internal abstract class Ventana
    {
        private int numVentana;
        private bool bloqueada = false;

        public int NumVentana { get { return numVentana; } set { numVentana = value; } }

        public bool Bloqueada { get { return bloqueada; } set { bloqueada = value; } }

        protected Ventana(int numVentana)
        {
            this.numVentana = numVentana;
            bloqueada = false;
        }

        public override string ToString()
        {
            return $"Número Ventana: {NumVentana} Bloqueada: {(Bloqueada ? "Bloqueada" : "Desbloqueada")}";
        }

        public abstract void bloquear();

        public abstract void desbloquear();

    }
}
