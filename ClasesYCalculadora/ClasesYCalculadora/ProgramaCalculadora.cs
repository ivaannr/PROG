using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaCalculadora
{
    internal class Calculadora
    {
        public int num1;
        public int num2;
        public int sumar;
        public int restar;
        public int mult;
        public int div;
        public int mod;


        public void Calcular()
        {
            sumar = num1 + num2;

            restar = num1 - num2;

            mult = num1 * num2;

            div = num1 / num2;

            mod = restar % num2;

        }

        public void MostrarResultadosSuma()
        {
           Console.WriteLine("El resultado de la suma es: "+sumar);

        }

        public void MostrarResultadosResta()
        {
            Console.WriteLine("El resultado de la resta es: " + restar);

        }
        public void MostrarResultadosMult()
        {
            Console.WriteLine("El resultado de la multiplicación es: " + mult);

        }

        public void MostrarResultadosDiv()
        {
            Console.WriteLine("El resultado de la división es: " + div);

        }

        public void MostrarResultadosMod()
        {
            Console.WriteLine("El resultado del módulo es: " + mod);

        }
    }
}
