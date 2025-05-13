using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficherosDeCharacteres
{
    internal class GestorDeFicheros
    {

        /// <summary>
        /// Escribe líneas de texto en un fichero hasta que se introduce una línea vacía.
        /// </summary>
        /// <param name="fichero">Ruta del fichero donde se escribirán las líneas.</param>
        public void escribirFichero(String fichero)
        {

            String linea;

            using (StreamWriter sw = new StreamWriter(fichero))
            {
                while (true)
                {
                    Console.WriteLine("Introduce la línea de texto a grabar -INTRO sale-: ");
                    linea = Console.ReadLine();
                    if (linea.Equals(""))
                    {
                        Console.WriteLine("Saliendo...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Grabando la línea: " + linea);
                        sw.WriteLine(linea);
                    }
                }
            }
        }

        /// <summary>
        /// Lee y muestra en consola el contenido de un fichero línea por línea.
        /// </summary>
        /// <param name="fichero">Ruta del fichero a leer.</param>
        public void leerFichero(String fichero)
        {

            String linea;

            StreamReader sr = null;

            try
            {
                sr = new StreamReader(fichero);
                linea = sr.ReadLine();
                while (linea != null)
                {
                    Console.WriteLine(linea);
                    linea = sr.ReadLine();

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
        }
        /// <summary>
        /// Cuenta el número de líneas en un fichero.
        /// </summary>
        /// <param name="fichero">Ruta del fichero a procesar.</param>
        /// <returns>El número de líneas en el fichero.</returns>
        public int contarLineas(String fichero)
        {

            String linea;
            int cont = 0;
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(fichero);
                linea = sr.ReadLine();
                while (linea != null)
                {
                    Console.WriteLine(linea);
                    linea = sr.ReadLine();
                    cont++;
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

            return cont;
        }




        /// <summary>
        /// Calcula la media de los números contenidos en un fichero.
        /// </summary>
        /// <param name="fichero">Ruta del fichero a procesar.</param>
        /// <param name="nums">Lista donde se almacenarán los números leídos.</param>
        /// <param name="round">Indica si la media debe redondearse al entero más cercano.</param>
        /// <returns>La media de los números en el fichero.</returns>
        public double calcularMedia(String fichero, List<int> nums, bool round)
        {

            String linea;
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
                        Console.WriteLine("Debes meter un número, calculando media con el resto de números.");
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

            int suma = 0;
            foreach (int i in nums)
            {
                suma += i;
            }

            if (!round)
                return nums.Count > 0 ? (double)suma / nums.Count : 0;
            else
                return nums.Count > 0 ? Math.Round((double)suma / nums.Count) : 0;
        }

}}
