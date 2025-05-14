using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficherosDeCaracteresCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String f = @"C:\Users\iván\Documents\Ficheros\archivo.txt";

            String linea = "";


            using (StreamWriter sw = new StreamWriter(f, false, Encoding.UTF8))
            {
                while (true)
                {
                    Console.WriteLine("Escribe una línea (fin para terminar): ");
                    linea = Console.ReadLine();

                    if (linea.Equals("fin"))
                    {
                        break;
                    }

                    sw.WriteLine(linea);
                }   

            }

            Console.WriteLine("\nLeyendo fichero: ");

            using (StreamReader sr = new StreamReader(f)) {

                while ((linea = sr.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }

            }


            

        }
    }
}
