using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaEmpleados
{
    internal class EmpleadoPorHoras: Empleado
    {

        private int horasTrabajadas;
        private double pagoPorHora;

        public EmpleadoPorHoras(string nombre, int edad, int horasTrabajadas, double pagoPorHora): base(nombre, edad)
        {
            this.horasTrabajadas = horasTrabajadas;
            this.pagoPorHora = pagoPorHora;
        }

        public override void mostrarInformacion() {

            Console.WriteLine($"{this.Nombre} tiene {this.Edad} años, tiene {this.horasTrabajadas} horas trabajadas y cobra {this.pagoPorHora} euros por hora." +
                $"\nPor lo tanto, su salario es de {calcSalario()} euros/mes.");

        }

        public double calcSalario() {

            return (double) this.horasTrabajadas * this.pagoPorHora * (30 - 8);
        
        }
    
    }
}
