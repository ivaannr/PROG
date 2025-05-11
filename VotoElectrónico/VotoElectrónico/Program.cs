using System;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;

            string[] Candidatos = {"Vox", "PSOE", "TeruelExiste", "Podemos", "Ciudadados"};

            Console.WriteLine("Bienvenido a la aplicación de voto electronico.");
            Console.WriteLine("Antes de comenzar deberas contestar a unas preguntas para saber si cumples los requisitos para votar.");
            Console.WriteLine("Dime tu año de nacimiento.");
            int año = int.Parse(Console.ReadLine()); 

            if (año > 2006)
            {
            Console.WriteLine("Lo siento, no tienes la edad sufiente para votar.");
            Console.WriteLine("Pero igualmente puedes votar para que podamos como variaría el resultado.");
            }
            else if (año <= 2006)
            {
            Console.WriteLine("Perfecto, tu edad es suficiente para votar.");
            }

            Console.WriteLine("Ahora dime tu correo electrónico");
            System.String Correo = Console.ReadLine();
            Console.WriteLine("Ahora necesito tu DNI.");
            System.String DNI = Console.ReadLine();
            int NDNI = DNI.Length;

            if (NDNI != 9)
            {
                do
                {
                    Console.WriteLine("Has introducido un dato no adecuado, porfavor, intenta introducirlo de nuevo.");
                    System.String NuevoDNI = Console.ReadLine();
                    int NuevoDNINUM = NuevoDNI.Length + 1;
                }
                while (NDNI != 10);
            }
            else if (NDNI == 9)
            {
                Console.WriteLine("Perfecto, tus datos son correctos.");
            }

            Console.WriteLine("Aqui está la lista de los candidatos");

            Console.WriteLine("1.- Vox");
            Console.WriteLine("2.- Ciudadanos");
            Console.WriteLine("3.- PSOE");
            Console.WriteLine("4.- TeruelExiste");
            Console.WriteLine("5.- Podemos");

            Console.WriteLine("Ahora introduce el nombre del participante al que quieres votar.");

            System.String Voto = Console.ReadLine();



            if (Array.Exists(Candidatos, element => element == Voto))
            {
            Console.WriteLine("Has votado al cantidato " + Voto + ". Para finalizar pulsa la tecla Enter.");
            }
            else
            {
                Console.WriteLine("El candidato al que has votado no está en nuestra lista de candidatos. Porfavor, introduce otro candidato.");
                System.String Voto2 = Console.ReadLine();
            }
        }
    }}