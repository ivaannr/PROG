using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotización___Interfaces
{
    internal class PuertaAutomatica : Puerta, IElementoDomotizado
    {
        public PuertaAutomatica(int numPuerta) : base(numPuerta)
        {
        }

        public override void bloquear()
        {
            Bloqueada = true;
            Console.WriteLine($"Puerta número {NumPuerta} bloqueada automáticamente.");
        }

        public override void desbloquear()
        {
            Bloqueada = false;
            Console.WriteLine($"Puerta número {NumPuerta} desbloqueada automáticamente.");
        }

        public void Timeout()
        {
            if (!Bloqueada)
            {
                desbloquear();
            }
            else { bloquear(); }
        }
    }

}
