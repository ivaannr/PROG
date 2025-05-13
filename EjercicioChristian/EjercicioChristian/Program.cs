using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioChristian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon(), pokemonActual;
            Mochila mochila = new Mochila();

            int input = 0;

            Console.WriteLine("Hola, bienvenido al camino pokémon.");

            while (true) {

                Console.WriteLine("Pulsa Enter para generar un pokemon.");


                Console.ReadLine();

                pokemonActual = pokemon.generarPokemon();

                Console.WriteLine("Has encontrado un pokémon!" +
                    $"\nUn {pokemonActual.Nombre} de color {pokemonActual.Color}");

                if (pokemonActual.Color.Equals("Amarillo"))
                {

                    Console.WriteLine("Es un pokémon es amarillo, los pokémons amarillos no te gustan." +
                        "\nPasas de capturar el pokémon.");

                }
                else {


                    Console.WriteLine("¿Quieres intentar capturar el pokémon?" +
                        "\n[1] - Sí" +
                        "\n[2] - No");

                    if (!int.TryParse(Console.ReadLine(), out input)) {

                        Console.WriteLine("Introduce un número válido.");
                        continue;

                    }

                    switch (input) {

                        case 1:

                            if (mochila.Capturar())
                            {

                                Console.WriteLine($"Has capturado el pokémon {pokemonActual.Nombre} exitosamente.");
                                mochila.addPokemon(pokemonActual);
                                Console.WriteLine("Pokémon añadido a tu mochila.");
                            }
                            else { 
                            
                                Console.WriteLine($"No has conseguido capturar a {pokemonActual.Nombre}" +
                                    $"\nTen mejor suerte la próxima vez.");
                                pokemonActual = pokemon.generarPokemon();
                            }


                                break;
                            case 2:

                                Console.WriteLine("Okey, sigues caminando por el camino.");

                                break;
                            default:

                                Console.WriteLine("Número inválido, pasas del pokémon y sigues por el camino.");

                                break;  

                    
                    
                    }

                    Console.WriteLine("Pulsa 1 para ver tus pokémons: ");
                    String verPokemons = Console.ReadLine();

                    if (verPokemons.Equals("1")) {

                        mochila.verMochila();
                    
                    }
                
                }

            
            
            
            }


        }
    }
}
