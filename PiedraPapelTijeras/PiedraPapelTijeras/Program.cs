using System.Runtime.Intrinsics.Arm;

namespace PiedraPapelTijeras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();

            Action<string> cwl = Console.WriteLine;
            Action<string> cw = Console.Write;

            string[] opciones = { "piedra", "papel", "tijeras" };

            Console.WriteLine("Hola!");

            int decision;

            int decisionJuego;

            int usuario;

            int consola;

            int victorias = 0;

            int derrotas = 0;

            int salir = 1;

           
            do { 

                cwl("¿Qué vas a hacer?" +
                        "\n[1] Jugar" +
                        "\n[2] Ver estadísticas" +
                        "\n[3] Salir");


                decisionJuego = int.Parse(Console.ReadLine());

                switch (decisionJuego)
                {


                case 1:
                do
                {

                    cwl("¿Qué vas a sacar?" +
                        "\n[1] Piedra" +
                        "\n[2] Papel" +
                        "\n[3] Tijeras");

                    usuario = int.Parse(Console.ReadLine());


                    if (usuario == 1) { cwl("Elegiste piedra."); }
                    else if (usuario == 2) { cwl("Elegiste papel."); }
                    else if (usuario == 3) { cwl("Elegiste tijeras."); }
                    else { cwl("Número no válido."); }

                } while (usuario > 3 || usuario < 1);

                consola = rd.Next(1, 4);

                if (consola == 1) { cwl("La consola eligió piedra."); }
                else if (consola == 2) { cwl("La consola eligió papel."); }
                else { cwl("La consola eligió tijeras."); }

                switch (usuario)
                {
                    case 1:

                        if (consola == 1) { cwl("Empate."); }
                        else if (consola == 2) { cwl("Perdiste"); derrotas++; }
                        else if (consola == 3) { cwl("Ganaste"); victorias++; }

                        break;
                    case 2:

                        if (consola == 2) { cwl("Empate."); }
                        else if (consola == 3) { cwl("Perdiste"); derrotas++; }
                        else if (consola == 1) { cwl("Ganaste"); victorias++; }

                        break;
                    case 3:

                        if (consola == 3) { cwl("Empate."); }
                        else if (consola == 1) { cwl("Perdiste"); derrotas++; }
                        else if (consola == 2) { cwl("Ganaste"); victorias++; }

                        break;
                }

                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    cwl("Número de victorias: "+victorias);
                        Console.ForegroundColor = ConsoleColor.Red;
                        cwl("Número de derrotas: " + derrotas);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                case 3:
                    cwl("Saliendo...");
                    salir = 0;
                    break;
        }



            } while (salir != 0);

    }

        }
    }

