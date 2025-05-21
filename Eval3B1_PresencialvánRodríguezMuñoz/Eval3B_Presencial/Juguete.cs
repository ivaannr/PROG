using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval3B_Presencial
{
    internal class Juguete
    {
        private string tipo;
        public string Tipo { get => tipo; set => tipo = value; }

        public Juguete(string tipo)
        {
            Tipo = tipo;             
        }

        public void setTipo(String tipo)
        {
            this.Tipo = tipo;
        }

        public override string ToString()
        {
            return Tipo;
        }
    }
}
