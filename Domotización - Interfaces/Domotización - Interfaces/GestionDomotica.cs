using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotización___Interfaces
{
    internal class GestionDomotica
    {

        public void controlRemoto(IElementoDomotizado el) {

            el.Timeout();

        }

    }
}
