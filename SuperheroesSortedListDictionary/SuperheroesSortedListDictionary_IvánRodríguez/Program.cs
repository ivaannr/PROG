using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroesSortedListDictionary_IvánRodríguez
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Superheroe superheroe = null;

            String[] siNo = { "s", "n"};

            bool running = true, tieneCapa;
            int input = 0;
            String capa, nombre, descripcion;

            SortedList<String, Superheroe> superheroes = new SortedList<string, Superheroe>();

            while (running) {

                Console.WriteLine(@"[1] Añadir un superheroe
[2] Buscar un superheroe
[3] Mostrar coleccion superheroes
[4] Eliminar un superheroe
[5] Borrar consola
[6] Salir
Dime que quieres hacer:");
            
                if (!int.TryParse(Console.ReadLine(), out input)) {

                    Console.Write("Introduce un número.\n");
                    continue;
                
                }

                switch (input) {

                    case 1:

                        Console.WriteLine("Dime el nombre del superhéroe: ");
                        nombre = Console.ReadLine();

                        if (superheroes.ContainsKey(nombre)) {

                            Console.WriteLine("Ese superhéroe ya está en la lista.");
                            break;

                        }

                        Console.WriteLine("Describe lo que hace: ");
                        descripcion = Console.ReadLine();

                        Console.WriteLine("¿Tiene capa? (s/n)");
                        capa = Console.ReadLine();

                        if (!siNo.Contains(capa)) { 
                        
                        Console.WriteLine("Opción invalida.");
                            break;

                        }

                        if (capa.Equals("s")) tieneCapa = true;
                        else tieneCapa = false;

                        superheroes.Add(nombre, new Superheroe(nombre, descripcion, tieneCapa));

                        Console.WriteLine($"Perfecto, el superhéroe {superheroes[nombre].Nombre} ha sido añadido correctamente.");
                        
                        break;
                    case 2:

                        Console.Write("Dime el nombre del superhéroe a buscar: ");
                        nombre = Console.ReadLine();

                        if (!superheroes.ContainsKey(nombre)) {

                            Console.WriteLine("Ese superhéroe no existe.");
                            break;

                        }

                        Console.WriteLine($"El superhéroe {nombre} está en la lista.");
                        Console.WriteLine($"Y sus atributos son los siguientes: {superheroes[nombre].ToString()}");

                        break;
                    case 3:

                        if (superheroes.Count == 0)
                        {

                            Console.WriteLine("La lista está vacía.");
                            break;

                        }

                        foreach (var sHeroe in superheroes) {

                            Console.WriteLine(sHeroe.Value.ToString());
                        
                        }


                        break;
                    case 4:

                        Console.Write("Dime el nombre del superhéroe a eliminar: ");
                        nombre = Console.ReadLine();

                        if (!superheroes.ContainsKey(nombre))
                        {

                            Console.WriteLine("Ese superhéroe no existe.");
                            break;

                        }

                        superheroes.Remove(nombre);

                        Console.WriteLine($"El superhéroe {nombre} fue eliminado la lista.");


                        break;
                    case 5:

                        Console.Clear();

                        break;
                    case 6:

                        Console.WriteLine("Saliendo...");
                        running = false;

                        break;
                }
            
            
            }


        }
    }
}
