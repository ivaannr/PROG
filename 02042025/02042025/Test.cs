using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02042025
{
    internal class Test : IComparable<Test>
    {
        public int CompareTo(Test other)
        {
            if (other == null)
            {
                return 1;  // Si el objeto "other" es null, esta instancia es considerada mayor.
            }

            return string.Compare(this.nombre, other.nombre);
            // string.Compare compara los dos nombres alfabéticamente:
            // - Devuelve un valor negativo si this.nombre es menor que other.nombre
            // - Devuelve 0 si son iguales
            // - Devuelve un valor positivo si this.nombre es mayor que other.nombre
        }

        private String nombre;

        public Test(String nombre) {

            this.nombre = nombre;

        }



    }
}
