using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval3B_Presencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CambiarEstado cambiarEstado = new CambiarEstado();

            Juguete munheca = new Munheca("muñeca");
            Juguete coche = new Coche("coche", "enciende luces");
            Lampara lampara = new Lampara("lampara feberge");

            Console.WriteLine("Estado inicial ");

            Console.WriteLine(munheca.ToString() + "\n"
                + coche.ToString() + "\n" +
                lampara.ToString());

            cambiarEstado.cambioDeEstadoInterruptor(coche);
            cambiarEstado.cambioDeEstadoInterruptor(lampara);


            Console.WriteLine(munheca.ToString() + "\n"
            + coche.ToString() + "\n" +
            lampara.ToString());

            cambiarEstado.cambioDeEstadoInterruptor(coche);
            cambiarEstado.cambioDeEstadoInterruptor(lampara);

            Console.WriteLine(munheca.ToString() + "\n"
            + coche.ToString() + "\n" +
            lampara.ToString());


        }
    }
}
