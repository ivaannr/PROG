using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVAL3B2Presencial_IvánRodríguezMuñoz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Luchador> luchadores;

            bool datosCargados = false;

            Gestor gestor = new Gestor();

            String path = "Luchadores.csv",
                    path2 = "LuchadoresConNCintos.csv";
            luchadores = gestor.leerFichero(path);

            

            int input = 0;

            while (true)
            {

                Console.WriteLine("[1] Cargar fichero" +
                                "\n[2] Mostrar jugadores" +
                                "\n[3] Buscar luchador" +
                                "\n[4] Mostrar nº de luchadores" +
                                "\n[5] Mostrar luchadores con que tengan un color de cinturon determinado" +
                                "\n[6] Guardar luchadores con menos de X cinturones en CSV" +
                                "\n[7] Salir");


                if (int.TryParse(Console.ReadLine(), out input)) { }
                

                            switch (input)
                            {

                                case 1:

                                    Console.WriteLine("Cargando fichero...");
                                    luchadores = gestor.leerFichero(path);
                                    Console.WriteLine("Fichero cargado...");

                        datosCargados = true;

                                    break;
                                case 2:

                        if (datosCargados)
                        {

                            Console.WriteLine("Mostrando luchadores: ");
                            foreach (Luchador l in luchadores)
                            {
                                Console.WriteLine(l.ToString());
                            }
                        }

                        else
                        {
                            Console.WriteLine("No hay jugadores en la lista.");
                        }

                                    break;
                                case 3:

                        if (!datosCargados) {

                            Console.WriteLine("No has cargado los datos aún.");
                            break;
                        
                        }

                        

                            Console.WriteLine("Dime el luchador a buscar: ");
                            String newNombre = Console.ReadLine();


                            foreach (Luchador l in luchadores)
                            {
                                if (l.myEquals(newNombre))
                                {
                                    Console.WriteLine(l.getDatos());
                                    break;
                                }
                            }

                            Console.WriteLine("No se encontró el luchador");
                        

                        

                                    break;

                                case 4:

                                    if (luchadores.Count == 0)
                                        Console.WriteLine("La lista está vacía.");
                                    else
                                        Console.WriteLine($"Hay {luchadores.Count} luchadores.");

                                    break;
                                case 5:

                        if (luchadores.Count == 0)
                            Console.WriteLine("La lista está vacía.");
                        else
                        {

                            Console.WriteLine("Dime el color del cinturón: ");
                            String color = Console.ReadLine();

                            foreach (Luchador l in luchadores)
                            {

                                if (l.buscarCinturon(color))
                                    Console.WriteLine($"{l.Nombre} tiene el cinturon {color}");
                            }
                        }

                                    break;
                                case 6:

                                    if (luchadores.Count == 0)
                                    {
                                        Console.WriteLine("La lista está vacía.");
                                        break;
                                    }

                                    Console.WriteLine("Dime el nº de cinturones: ");
                                    if (int.TryParse(Console.ReadLine(), out int nCinturones)) {

                                        foreach (Luchador l in luchadores)
                                        {

                                            if (l.NCinturones >= nCinturones)
                                            {
                                                String datosParseados = $"{l.Nombre},{l.Apellido},{l.Edad},{l.parseCintos()}";

                                                gestor.escribirFichero(path2, datosParseados);

                                                Console.WriteLine(l.getDatos());
                                            }

                                        }

                                        Console.WriteLine("Datos exportados exitosamente.");



                                    }
                                    else
                                        Console.WriteLine("Introduce un número porfavor.");

                                    break;
                                case 7:

                                    Console.WriteLine("Saliendo...");
                                    return;


                                default: Console.WriteLine("Mete un número adecuado."); break;
                            } //switch

            } // while


        } //main
    }//program
}//namespace
