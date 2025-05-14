using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaAlumnosConCSV
{
    internal class Gestor
    {

        private String linea = "";

        public void escribirFichero(String f) {


            using (StreamWriter sw = new StreamWriter(f, false, Encoding.UTF8))
            {
                while (true)
                {
                    Console.WriteLine("Escribe una línea (fin para terminar): ");
                    linea = Console.ReadLine();

                    if (linea.Equals("fin"))
                    {
                        Console.Clear();
                        break;
                    }

                    sw.WriteLine(linea);
                }

            }

        }


        public List<Alumno> leerFichero(String f) {

            List<Alumno> alumnos = new List<Alumno>();
            

            using (StreamReader sr = new StreamReader(f))
            {

                while ((linea = sr.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    alumnos.Add(crearAlumno(linea));
                }


            }

            return alumnos;

        }

        private Alumno crearAlumno(String datos) {
        
               try {

                String[] alumno = datos.Replace(".", ",").Replace(";", " ").Split(' ');
                String nombre = alumno[0];
                double nota1 = double.Parse(alumno[1]),
                        nota2 = double.Parse(alumno[2]), 
                        nota3 = double.Parse(alumno[3]);

                return new Alumno(nombre, nota1, nota2, nota3);

            } catch (IndexOutOfRangeException) {
                Console.WriteLine("Datos de más introducidos."); }

            return new Alumno();
        }


    }
}
