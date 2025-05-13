using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    internal class Padre {

        private int x;

        public Padre(int x) { this.x = x; }

        public void metodo() { }
    
    }

    internal class Hijo: Padre
    {
        private int y;
        public Hijo(int x, int y) : base(x) { this.y = y; }
        new public void metodo() { }

        public void metodoHijo() { }

    }



}
