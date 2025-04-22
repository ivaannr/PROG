using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotización___Interfaces
{
    internal class VentanaManual : Ventana, IElementoDomotizado
    {
        public VentanaManual(int numVentana) : base(numVentana)
        {
        }

        public override void bloquear()
        {
            Bloqueada = true;
            Console.WriteLine($"Ventana número {NumVentana} bloqueada manualmente.");
        }

        public override void desbloquear()
        {
            Bloqueada = false;
            Console.WriteLine($"Ventana número {NumVentana} desbloqueada manualmente.");
        }

        public void Timeout()
        {
            if (!Bloqueada) {  
                desbloquear();
            } else { bloquear(); }
        }
    }
}
