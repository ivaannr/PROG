using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaEmpleados
{
    internal class EmpleadoTiempoCompleto: Empleado
    {

        private double sueldo = 0;

        public EmpleadoTiempoCompleto(string nombre, int edad, double sueldo) : base(nombre, edad)
        {
            this.sueldo = sueldo;
        }

        public override void mostrarInformacion() {

            Console.WriteLine($"{this.Nombre} tiene {this.Edad} años y cobra {this.sueldo} euros.");
        
        }

        public double Sueldo {  get { return sueldo; } set { sueldo = value; } }

        
    }
}
