using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaInstrumentos
{
    internal abstract class Instrumento
    {

        private String nombre;
        public Instrumento(String nombre) { this.nombre = nombre; }

        public String Nombre { get { return nombre; } set { nombre = value; } }

        public abstract void tocar();



    }
}
