namespace JuegoAhorcado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DibujoAhorcado dibujo = new DibujoAhorcado();

            int contador = 0;

            int contador2 = 0;

            int contador3 = 0;

            string firstPalabra = "";
            string palabra = "";

            int intentos;

            bool ganar = false;




            do
            {


                Console.WriteLine("Hola, dime una palabra.");

                firstPalabra = Console.ReadLine();

                palabra = firstPalabra.ToLower();

                

                if (palabra.Length > 16 || palabra.Length < 4) { Console.WriteLine("Di una palabra de una longitud adecuada."); }

                
                
                

                else
                {
                    Console.WriteLine("Elegiste la palabra " + palabra);

                    Console.WriteLine("Pulsa cualquier tecla para borrar todo y pasar a adivinar la palabra.");

                    Console.ReadKey();

                    Console.Clear();

                    Console.WriteLine("Ahora pasa a ser el turno de adivinar la palabra.");

                }

            }while (palabra.Length > 16 || palabra.Length < 4);


            char[] barras = new char[palabra.Length];

            while (contador2 != palabra.Length) //llenar el array de _
            {

            barras[contador2] = '_';
            contador2++;
            


            }


            do
            {
                if (firstPalabra[contador3] == ' ') //meter los espacios en el array
                {
                    barras[contador3] = ' ';
                }
                else
                {

                }
                contador3++;
            }
            while (contador3 != palabra.Length);

            palabra.ToCharArray();

            bool terminado = false;

            string letra = "";

            intentos = 9;

            while (terminado == false)
            {


                Console.WriteLine("Tienes " + intentos + " intentos.");
                dibujo.mostrarDibujo(intentos);
                Console.Write("Dime una letra: ");
               

                    letra = Console.ReadLine();

                letra.ToCharArray();


                if (palabra.Contains(letra))
                {

                    contador = 0;

                    while (contador != palabra.Length) 
                    {

                        if (palabra[contador] == letra[0]) 
                        {


                            barras[contador] = letra[0];
                        
                        }

                        contador++;
                    
                    }
                    Console.WriteLine("La palabra contiene la letra.");
                }

                else 
                {

                    Console.WriteLine("La letra no está en la palabra." ); intentos--;
                
                }

                    Console.WriteLine(barras);


                if (palabra.SequenceEqual(barras))
                {

                    terminado = true; ganar = true; Console.WriteLine("El juego ha terminado, ganaste!");

                }
                else if (intentos == 0) { Console.WriteLine("Se te acabaron los intentos, perdiste!!!"); terminado = true; }
                else { }





            }

            



        }
    }
}
