using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotización___Interfaces
{
    internal class PuertaManual : Puerta
    {
        public PuertaManual(int numPuerta) : base(numPuerta)
        {
        }

        public override void bloquear()
        {
            Bloqueada = true;
            Console.WriteLine($"Puerta número {NumPuerta} desbloqueada manualmente.");
        }

        public override void desbloquear()
        {
             Bloqueada = false;
            Console.WriteLine($"Puerta número {NumPuerta} desbloqueada manualmente.");
        }
    }
}
