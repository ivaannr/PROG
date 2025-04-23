using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVAL2B_IvánRodríguez_EJER1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rd = new Random();
            Dictionary<int, Premio> premios = new Dictionary<int, Premio>();

            bool running = true;
            int nPremio = 0;
            String input = null;

            //añado premios

            premios.Add(1, new Premio("Viaje a Malibú"));
            premios.Add(14, new Premio("Viaje a Hawaii"));
            premios.Add(19, new Premio("Tableta Apple"));
            premios.Add(4, new Premio("Viaje a París"));
            premios.Add(10, new Premio("Caja de bombones"));
            premios.Add(6, new Premio("Suscripción gratis a Netflix"));
            premios.Add(8, new Premio("Cupón de 100 euros para Amazon"));
            premios.Add(9, new Premio("Suscripción gratis a Amazon Prime"));
            premios.Add(17, new Premio("Kit de diseño gráfico"));
            premios.Add(15, new Premio("Viaje a Canarias"));

            while (running)
            {

                Console.WriteLine("Pulsa enter para rifar un premio: ");
                input = Console.ReadLine();
                
                nPremio = rd.Next(1, 21); // nº random

                if (premios.ContainsKey(nPremio)) //si la colección tiene el nº muestra el premio y lo saca de la coleccion
                {

                    Console.WriteLine("Has ganado un premio!");
                    Console.WriteLine("x");
                    Console.WriteLine(premios[nPremio].ToString());
                    
                    premios.Remove(nPremio);

                    

                    Console.WriteLine("\nEstos son los demás premios que te podrían haber tocado ==> \n");
                    
                    foreach (KeyValuePair<int, Premio> p in premios) { Console.WriteLine(p.ToString()); } // muestra los demás premios

                    Console.WriteLine("\nPulsa cualquier tecla para salir: ");
                    Console.ReadLine();

                    return;


                }

                Console.WriteLine("No ganaste nada, más suerte en la próxima.");

            }



        }
    }
}