using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval3B_Presencial
{
    internal class Munheca : Juguete
    {
        public Munheca(string tipo) : base(tipo)
        {
        }

        public override string ToString()
        {
            return Tipo;
        }
                
    }
}
