using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace testNumeros
{
    internal class numRapido
    {

        Random rd = new Random();



        public int generador;

        public int cont = 0;

        public void setGen() { generador = rd.Next(0,36); }

        public int getGen() { return generador; }

        public void generarNumeros() {

            do
            {
                
                cont++;
                setGen();
                getGen();
                Console.WriteLine(generador);
                Thread.Sleep(50);
                Console.Clear();
            }
            while (cont < 15);


                
                }

    }
}
