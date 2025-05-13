using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ficherosDeCharacteres
{
    internal class Program
    {

        static void Main(string[] args)
        {

            GestorDeFicheros gestor = new GestorDeFicheros();   

            List<int> nums = new List<int>();

            WriteLine("Ficheros de caracteres.");

            String linea, fichero = @"C:\Users\iván\Documents\Ficheros\archivo.txt";

            gestor.escribirFichero(fichero);

            StreamReader sr = null;

            try
            {
                sr = new StreamReader(fichero);
                linea = sr.ReadLine();
                while (linea != null)
                {
                    Console.WriteLine(linea);
                    linea = sr.ReadLine();

                    if (int.TryParse(linea, out int num))
                    {
                        nums.Add(num);
                    }
                    else
                    {
                        WriteLine("Debes meter un número, calculando media con el resto de números.");
                    }

                    nums.Add(num);


                }
            }
            catch (Exception mensaje)
            {
                Console.WriteLine(mensaje.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }

            Console.WriteLine("Media: " + gestor.calcularMedia(fichero, nums, true));

        }
    }
}
