using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioChristian
{
    internal class Pokemon
    {
        Random rd = new Random();

        private String nombre, color;
        private string[] pokemons = { "Pikachu", "Charmander", "Bulbasaur", "Squirtle", "Jigglypuff", "Eevee", "Snorlax", "Mewtwo", "Charizard", "Blastoise" };
        private string[] colores = { "Rojo", "Azul", "Verde", "Amarillo", "Rosa", "Naranja", "Negro", "Blanco", "Morado", "Verde claro" };

        public Pokemon() { }

        public Pokemon(String nombre, String color)
        {

            this.nombre = nombre;
            this.color = color;

        }


        public String Nombre { get { return nombre; } set { nombre = value; } }
        public String Color { get { return color; } set { color = value; } }

        public override String ToString() {

            return $"Color: {this.color}";
        
        }



        public Pokemon generarPokemon() {

            nombre = pokemons[rd.Next(0, pokemons.Length)];
            color = colores[rd.Next(0, colores.Length)];

            return new Pokemon(nombre, color);
        }


    }
}
