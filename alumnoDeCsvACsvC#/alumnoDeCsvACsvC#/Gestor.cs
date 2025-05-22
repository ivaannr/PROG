using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnoDeCsvACsvC_
{
    class Gestor
    {

        private String linea = "";

        public void escribirFichero(String f, String datos) {


            using (StreamWriter sw = new StreamWriter(f, true, Encoding.UTF8))
            {
                    linea = datos;

                    sw.WriteLine(linea);

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

        private Alumno crearAlumno(String datos)
        {

            String[] alumno = datos.Split(';', (char) StringSplitOptions.RemoveEmptyEntries);
            double[] notas = new double[alumno.Length];

            for (int i = 1; i < alumno.Length; i++) 
                    notas[i - 1] = double.Parse(alumno[i], CultureInfo.InvariantCulture);
            

            return new Alumno(alumno[0], notas);

        }

	}
}
