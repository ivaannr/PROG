using System.Drawing;
using System.Security.Cryptography;

namespace Presencial_Punto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;

            Punto p1, p2;

            p1 = new Punto();
            p2 = new Punto();

            Console.WriteLine("Dime las coordenadas del punto 1: ");

            p1.x = int.Parse(Console.ReadLine());
            p1.y = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime las coordenadas del punto 2: ");

            p2.x = int.Parse(Console.ReadLine());
            p2.y = int.Parse(Console.ReadLine());

            p1.mostrarCoords();

            p1.mostrarDistancia();

            p1.mostrarMayorOMenor();

            p2.mostrarCoords();

            p2.mostrarDistancia();

            p2.mostrarMayorOMenor();

            Console.ReadKey();

        }
    }
}
