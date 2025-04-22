using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotización___Interfaces
{
    internal class VentanaAutomatica : Ventana
    {
        public VentanaAutomatica(int numVentana) : base(numVentana)
        {
        }

        public override void bloquear()
        {
            Bloqueada = true;
            Console.WriteLine($"Ventana número {NumVentana} bloqueada automaticamente.");
        }

        public override void desbloquear()
        {
            Bloqueada = false;
            Console.WriteLine($"Ventana número {NumVentana} desbloqueada automaticamente.");
        }
    }
}
