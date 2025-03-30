namespace juegoBaraja
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Hola!");

            Cartas carta = new Cartas();

            int decision;

            do
            {

                Console.WriteLine("¿Qué quieres hacer?" +
                    "\n[1] Tirar Carta" +
                    "\n[2] Salir");

                decision = int.Parse(Console.ReadLine());

                Console.Clear();

                if (decision == 1)
                {

                    carta.setCarta();

                    carta.getCarta();

                    carta.evaluarCarta();

                }

                else if (decision == 2) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Saliendo..."); 
                return;


                }
            }
            while (decision != 2);
        }
    }
}
