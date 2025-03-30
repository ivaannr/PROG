using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presencial_Punto
{
    internal class Punto
    {

        public int x;
        public int y;


        //Mostrar coordenadas
        public void mostrarCoords()
        {

            Console.WriteLine("x, y = ("+x+ " , "+y+")");

        }

        public void mostrarDistancia() { 
        
        double distancia = Math.Sqrt(x*x + y*y);
        
        Console.WriteLine("La distancia entre las 2 coordenadas es: "+distancia);
        
        }

        public void mostrarMayorOMenor()
        {

            if (x > y) {
                Console.WriteLine("La coordenada x es mayor.");
            }
            else if (x < y)
            {
                Console.WriteLine("La coordenada y es mayor.");
            }
        else
            {
                Console.WriteLine("La coordenadas son iguales.");
            }
        }
    }
}
