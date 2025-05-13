using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaInstrumentos
{
    internal class Cuerda: Instrumento 
    {

        public Cuerda(String nombre): base(nombre) { this.Nombre = nombre; }
        
        public override void tocar()
        {
            Console.WriteLine($"Tocando el instrumento de cuerda {this.Nombre}.");
        }
    }
}
