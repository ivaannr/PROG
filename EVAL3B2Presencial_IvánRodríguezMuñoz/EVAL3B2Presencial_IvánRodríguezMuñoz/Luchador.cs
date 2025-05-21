using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVAL3B2Presencial_IvánRodríguezMuñoz
{
    internal class Luchador
    {

        private String nombre, apellido;
        private List<String> cintos;
        private int edad, nCinturones;

        public Luchador(string nombre, string apellido, int edad, List<String> cintos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.cintos = cintos;
            nCinturones = cintos.Count;
        }

        public String Nombre { get { return nombre; } }
        public String Apellido { get { return apellido; } }
        public int Edad { get { return edad; } }

        public int NCinturones { get { return nCinturones; } }


        public bool buscarCinturon(String color) {
            
            for (int i = 0; i < cintos.Count; i++)
            {
                if (cintos[i].Equals(color))
                {
                    return true;
                }
            }

            return false;
        }

        public String getCinturones() { 
            return string.Join(",", cintos);
        }

        public override string ToString() {
            return $"Luchador: [Nombre: {this.nombre}], [Apellidos: {this.apellido}], [Edad: {this.edad}], [Cinturones: {getCinturones()}]";
        }

        public String getDatos() { 
            return $"Luchador: [Nombre: {this.nombre}], [Apellidos: {this.apellido}], [Edad: {this.edad}], [Nº Cinturones: {nCinturones}]"; 
        }

        public String parseCintos() { 
        
        return string.Join (",", cintos);
        
        }

        public bool myEquals(String nombre)
        {
                return this.nombre == nombre;
        }


        public override int GetHashCode()
        {
            int hashCode = 1828497705;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(apellido);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<string>>.Default.GetHashCode(cintos);
            hashCode = hashCode * -1521134295 + edad.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
            return hashCode;
        }
    }
}
