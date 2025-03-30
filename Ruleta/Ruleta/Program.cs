namespace Ruleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            ClaseRuleta rule = new ClaseRuleta();

            rule.setNumero();

            rule.getNumero();

            rule.jugarJuego();

        }
    }
}
