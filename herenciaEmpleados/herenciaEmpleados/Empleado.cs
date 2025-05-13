using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaEmpleados
{
    internal abstract class Empleado
    {

        private String nombre;
        private int edad;

        public Empleado(String nombre, int edad) 
        { 
        
        this.nombre = nombre;
        this.edad = edad;
        
        }

        virtual public void mostrarInformacion() {

            Console.WriteLine($"{this.nombre} tiene {this.edad} años.");
        
        }

        public String Nombre { get { return nombre; } set { nombre = value; } }

        public int Edad { get { return edad; } set { edad = value; } }

        

    }
}
