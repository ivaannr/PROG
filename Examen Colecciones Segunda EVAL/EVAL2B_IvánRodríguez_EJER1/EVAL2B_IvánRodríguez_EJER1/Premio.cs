using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVAL2B_IvánRodríguez_EJER1
{
    internal class Premio : IComparable<Premio>
    {
        //atributos
        private String descripcion = null;

        //Constructor vacío y con atributos
        public Premio() { }

        public Premio(String descripcion)
        {

            this.descripcion = descripcion;

        }

        //Get y set
        public String Descripcion { get { return descripcion; } set { descripcion = value; } }


        //métodos
        public int CompareTo(Premio other)
        {
            if (other == null) return 1;
            return this.descripcion.CompareTo(other.descripcion);
        }

        public override string ToString()
        {
            return $"Premio: {this.descripcion}";
        }

        public override int GetHashCode()
        {
            return this.descripcion.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Premio otro)
            {

                return descripcion == otro.descripcion;

            }

            return false;
        }


    }
}
