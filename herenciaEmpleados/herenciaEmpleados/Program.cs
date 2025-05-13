using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            empleados.Add(new EmpleadoPorHoras("Gentrudis", 46, 8, 15));
            empleados.Add(new EmpleadoTiempoCompleto("Gerardo", 42, 1500));
            empleados.Add(new EmpleadoPorHoras("Arturito", 18, 10000, 10));
            empleados.Add(new EmpleadoPorHoras("Andrea Kakarina", 18, -2, 25));

            foreach (var item in empleados) { 
            
                item.mostrarInformacion();
                Console.WriteLine();

            }
                        


        }
    }
}
