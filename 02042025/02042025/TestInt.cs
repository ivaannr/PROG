using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02042025
{
    internal class TestInt: IComparable<TestInt>
    {

        private int id;

        // Constructor
        public TestInt(int id)
        {
            this.id = id;
        }

        // Implementación de la interfaz IComparable<Test>


        public int CompareTo(TestInt other)
        {
            if (other == null)
            {
                return 1; // Si el objeto "other" es null, esta instancia es considerada mayor.
            }

            // Comparar los IDs
            return this.id.CompareTo(other.id);
            // Devuelve:
            // - Un valor negativo si this.id es menor que other.id
            // - 0 si los IDs son iguales
            // - Un valor positivo si this.id es mayor que other.id
        }

        // Propiedad para acceder al id
        public int Id
        {
            get { return id; }
        }

    }
}
