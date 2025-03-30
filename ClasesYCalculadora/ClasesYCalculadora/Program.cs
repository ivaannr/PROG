using ProgramaCalculadora;

namespace ClasesYCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.ForegroundColor = ConsoleColor.Green;

            Calculadora operar = new Calculadora();

            

            Console.WriteLine("Bienvenido a la calculadora.");

            int decision = 9;

            do
            {   
                Console.WriteLine("¿Qué deseas hacer?");
                Console.WriteLine("[1] Sumar");
                Console.WriteLine("[2] Restar");
                Console.WriteLine("[3] Multiplicar");
                Console.WriteLine("[4] Dividir");
                Console.WriteLine("[5] Módulo");
                Console.WriteLine("[6] Salir");
                Console.WriteLine();

                decision = int.Parse(Console.ReadLine());

                if (decision == 1)
                {

                    Console.WriteLine("Has elegido la operación suma. ");
                    Console.WriteLine("Dime un número. ");
                    operar.num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dime otro número. ");
                    operar.num2 = int.Parse(Console.ReadLine());
                    operar.Calcular();
                    operar.MostrarResultadosSuma();

                }
                else if (decision == 2)
                {

                    Console.WriteLine("Has elegido la operación resta. ");
                    Console.WriteLine("Dime un número. ");
                    operar.num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dime otro número. ");
                    operar.num2 = int.Parse(Console.ReadLine());
                    operar.Calcular();
                    operar.MostrarResultadosResta();

                }
                else if (decision == 3)
                {

                    Console.WriteLine("Has elegido la operación multiplicación. ");
                    Console.WriteLine("Dime un número. ");
                    operar.num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dime otro número. ");
                    operar.num2 = int.Parse(Console.ReadLine());
                    operar.Calcular();
                    operar.MostrarResultadosMult();

                }
                else if (decision == 4)
                {

                    Console.WriteLine("Has elegido la operación división. ");
                    Console.WriteLine("Dime un número. ");
                    operar.num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dime otro número. ");
                    operar.num2 = int.Parse(Console.ReadLine());
                    operar.Calcular();
                    operar.MostrarResultadosDiv();

                }
                else if (decision == 5)
                {

                    Console.WriteLine("Has elegido la operación de módulo de división. ");
                    Console.WriteLine("Dime un número. ");
                    operar.num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dime otro número. ");
                    operar.num2 = int.Parse(Console.ReadLine());
                    operar.Calcular();
                    operar.MostrarResultadosMod();

                }
                else if (decision == 6)
                {

                    Console.WriteLine("Has decidido salir del programa. ");
                    Console.WriteLine("Cerrando... ");
                    return;
                }

                else
                { 
                Console.WriteLine("Decisión no válida.");
                    Console.WriteLine("Porfavor introduce un valor adecuado");
                        Console.WriteLine();
                }



            }
            while (decision != 6);




            } } }






           
