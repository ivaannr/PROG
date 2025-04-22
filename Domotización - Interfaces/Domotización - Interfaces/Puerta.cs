using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Domotización___Interfaces
{
    internal abstract class Puerta
    {
        private int numPuerta;
        private bool bloqueada = false;

        public int NumPuerta { get { return numPuerta; } set { numPuerta = value; } }

        public bool Bloqueada { get { return bloqueada; } set { bloqueada = value; } }

        protected Puerta(int numPuerta)
        {
            this.numPuerta = numPuerta;
            bloqueada = false;
        }

        public override string ToString()
        {
            return $"Número Puerta: {NumPuerta} Bloqueada: {(Bloqueada ? "Bloqueada" : "Desbloqueada")}";
        }

        public abstract void bloquear();

        public abstract void desbloquear();
    }
}
