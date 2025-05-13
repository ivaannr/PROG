using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilColecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedList<int, string> sortedList = new SortedList<int, string>();

            // Agregar algunos elementos a la SortedList
            sortedList.Add(3, "Tres");
            sortedList.Add(1, "Uno");
            sortedList.Add(47, "Dos");

            // Acceder a las claves y los valores
            Console.WriteLine("Iterando sobre la SortedList:");
            foreach (var fila in sortedList)
            {
                Console.WriteLine($"Clave: {fila.Key}, Valor: {fila.Value}");
            }

            // Obtener la clave de un valor específico (si la clave es conocida)
            int key = 47; // por ejemplo, buscamos el valor asociado con la clave 2
            string value = sortedList[key]; // Acceder al valor asociado con la clave
            Console.WriteLine($"\nEl valor asociado con la clave {key} es: {value}");

            // Obtener una clave específica por un índice
            int index = 1; // por ejemplo, el segundo elemento
            int keyAtIndex = sortedList.Keys[index];
            Console.WriteLine($"\nLa clave en el índice {index} es: {keyAtIndex}");


        }
    }
}
