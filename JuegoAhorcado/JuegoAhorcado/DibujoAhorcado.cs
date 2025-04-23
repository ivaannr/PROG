using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoAhorcado
{
    internal class DibujoAhorcado
    {


        public void mostrarDibujo(int intentos) 
        {

            switch (intentos)
            {
                case 9:
                    Console.WriteLine(@"
  +---+
      |
      |
      |
     ===");
                    break;
                case 8:
                    Console.WriteLine(@"
  +---+
  O   |
      |
      |
     ===");
                    break;
                case 7:
                    Console.WriteLine(@"
  +---+
  O   |
  |   |
      |
     ===");
                    break;
                case 6:
                    Console.WriteLine(@"
  +---+
  O   |
 /|   |
      |
     ===");
                    break;
                case 5:
                    Console.WriteLine(@"
  +---+
  O   |
 /|\  |
      |
     ===");
                    break;
                case 4:
                    Console.WriteLine(@"
  +---+
  O   |
 /|\  |
 /    |
     ===");
                    break;
                case 3:
                    Console.WriteLine(@"
  +---+
  O   |
 /|\  |
 / \  |
     ===");
                    break;
                case 2:
                    Console.WriteLine(@"
  +---+
  O   |
 /|\  |
 / \  |
 x    ===");
                    break;
                case 1:
                    Console.WriteLine(@"
  +---+
  O   |
 /|\  |
 / \  |
 x_x  ===");
                    break;
                case 0:
                    Console.WriteLine(@"
  +---+
  O   |
 /|\  |
 / \  |
xxx   ===");
                    break;
                default:
                    Console.WriteLine("Estado inválido.");
                    break;
            }



        }




    }
}
