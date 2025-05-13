using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioChristian
{
    internal class Mochila
    {
        Random rd = new Random();
        private Dictionary<String, Pokemon> pokemons;

        public Mochila() { 
        
            pokemons = new Dictionary<String, Pokemon>();

        }

        public void verMochila() {

            foreach (var pokemon in pokemons) {

                Console.WriteLine(pokemon.ToString() + " ");
            
            }
        }

        public void addPokemon(Pokemon pokemon)
        {

            pokemons.Add(pokemon.Nombre, pokemon);
            Console.WriteLine("Pokemon añadido.");

        }

        public bool Capturar() {

            int numero = rd.Next(0, 101);

            if (numero < 75) return true;
 
            return false;
        }

    }
}
