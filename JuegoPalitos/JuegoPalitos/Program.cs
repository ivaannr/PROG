using System.ComponentModel.Design;

namespace JuegoPalitos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Palitos palito = new Palitos();

            Jugadores jugador1 = new Jugadores();

            Jugadores jugador2 = new Jugadores();

            palito.setPalitoRandom();
            palito.getPalitoRandom();

            int numPalitos = palito.getPalitoRandom();

            int palitosQuitados;

            String nombre1 = jugador1.getJugador(); 

            String nombre2 = jugador2.getJugador();

            //Se introduce el nombre de los juagdores.
            Console.WriteLine("Dime el nombre del jugador 1");
            nombre1 = Console.ReadLine();
            Console.WriteLine("Dime el nombre del jugador 2");
            nombre2 = Console.ReadLine();



            Console.WriteLine("El número de palitos es " + numPalitos);

            string stringPalitos = new string('|', numPalitos); //muestra los palitos que quedan gráficamente 

            Console.WriteLine(stringPalitos);
            int turno = 1; //Cuando turno es igual a 1 juega el jugador 1 y cuando es 2 el jugador 2.

            do
            {

                if (turno == 2)
                {
                    
                    Console.WriteLine("El turno es de " + nombre1);
                    turno = 1;
                }
                else if (turno == 1)
                {
                    
                    Console.WriteLine("El turno es del " + nombre2);
                    turno = 2;
                }
                
                //Pide el num de palitos que el jugador quiere quitar
                Console.WriteLine("¿Cuántos palitos quieres quitar?");

                palitosQuitados = int.Parse(Console.ReadLine());



                //evalúa la decisión del jugador
               
                if (numPalitos == palitosQuitados && numPalitos == 1)  //Si el num de palitos es 1, el jugador al que le toque jugar ya perdió.
                {
                    Console.WriteLine("Juego finalizado");

                    Console.ForegroundColor = ConsoleColor.Red;

                    if (turno == 1) { Console.WriteLine("Ganó el jugador " + nombre2); }
                    else if (turno == 2) { Console.WriteLine("Ganó el jugador " + nombre1); }
                    return;

                }

                else if (palitosQuitados > 3) //Si el num de palitos es mayor que 3 le dice al jugador que elija otro número.
                {
                    Console.WriteLine("Solo puedes quitar un máximo de 3 palitos.");


                    if (turno == 1) { turno = 2; } //restablece el turno del jugador 

                    else if (turno == 2) { turno = 1; } //restablece el turno del jugador 

                    numPalitos = numPalitos;

                }
                else if (numPalitos > 1 && numPalitos == palitosQuitados) { Console.WriteLine("No puedes quitar esa cantidad de palitos."); 
                //Si el num de palitos es mayor que uno no tiene sentido que el jugador deje el num de palitos en 0 porque perdería, entonces no deja que el jugador tome esta decisión
           

                if (turno == 1) { turno = 2; } //restablece el turno del jugador 

                    else if (turno == 2) { turno = 1; } //restablece el turno del jugador 
                } 

                else
                {
                    numPalitos = numPalitos - palitosQuitados;

                    Console.WriteLine("Quedan " + numPalitos + " palitos.");

                    stringPalitos = new string('|', numPalitos); //muestra los palitos que quedan gráficamente 

                    Console.WriteLine(stringPalitos);

                    Console.WriteLine("Pulsa enter para seguir.");

                    Console.ReadKey();
                }

            } 
            while(numPalitos != 0); //mientras que el num de palitos sea distinto de 0 el juego seguirá en funcionamiento.

            Console.ForegroundColor = ConsoleColor.Red;

            if (turno == 2) { Console.WriteLine(nombre1+" perdió"); } 

            else if (turno == 1) { Console.WriteLine(nombre2 + " perdió"); }

            //FIN
        }
    }
}
