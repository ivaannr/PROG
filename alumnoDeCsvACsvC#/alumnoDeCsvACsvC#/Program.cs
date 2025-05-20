using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnoDeCsvACsvC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String path1 = "alumnos.csv",
                   path2 = "alumnosFinal.csv";

            String linea = "";

            List<Alumno> alumnos = new List<Alumno>();

            Gestor gestor = new Gestor();

            alumnos = gestor.leerFichero(path1);

            foreach (Alumno a in alumnos)
                Console.WriteLine(a.ToString());







        }
    }
}
