using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaInstrumentos
{
    internal class Percusion: Instrumento
    {

        public Percusion(String nombre) : base(nombre) { this.Nombre = nombre; }

        public override void tocar()
        {
            Console.WriteLine($"Tocando el instrumento de percusión {this.Nombre}.");
        }

    }
}
