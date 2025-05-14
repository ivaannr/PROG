using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace mediaAlumnosConCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Gestor gestor = new Gestor();

            String f = @"C:\Users\iván\Documents\Ficheros\alumnos.csv";

            gestor.escribirFichero(f);

            List<Alumno> alumnos = gestor.leerFichero(f);

            foreach (Alumno a in alumnos)
                WriteLine(a.ToString());


        }
    }
}
