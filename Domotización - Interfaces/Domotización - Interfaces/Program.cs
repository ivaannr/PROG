using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotización___Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {


            GestionDomotica gestion = new GestionDomotica();
            
            Puerta puerta1 = new PuertaAutomatica(1);
            Puerta puerta2 = new PuertaManual(2);
            Ventana ventana1 = new VentanaAutomatica(1);
            Ventana ventana2 = new VentanaManual(2);

            Console.WriteLine($"Estado de las puertas y las ventanas: " +
                $"\n{puerta1.ToString()}" +
                $"\n{puerta2.ToString()}" +
                $"\n{ventana1.ToString()}" +
                $"\n{ventana2.ToString()}" +
                $"\n");

            puerta1.bloquear();
            puerta2.bloquear();

            Console.WriteLine();

            ventana1.bloquear();
            ventana2.bloquear();

            Console.WriteLine();

            Console.WriteLine($"Estado de las puertas y las ventanas: " +
                $"\n{puerta1.ToString()}" +
                $"\n{puerta2.ToString()}" +
                $"\n{ventana1.ToString()}" +
                $"\n{ventana2.ToString()}" +
                $"\n");
        }
    }
}
