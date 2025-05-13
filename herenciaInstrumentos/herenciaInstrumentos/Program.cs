using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace herenciaInstrumentos
{
    internal class Program
    {

        public static void afinar(Instrumento ins)
        {

            Console.WriteLine($"Afinando {ins.Nombre}");

        }

        static void Main(string[] args)
        {

            List<Instrumento> instrumentos = new List<Instrumento>();

            instrumentos.Add(new Cuerda("Vihuela"));
            instrumentos.Add(new Viento("Clarinete"));
            instrumentos.Add(new Percusion("Marimba"));

            foreach (Instrumento instrumento in instrumentos)
            {

                afinar(instrumento);
                instrumento.tocar();
               
                Console.WriteLine();

            }

        }
    }
}
