using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaAlumnosConCSV
{
    internal class Alumno
    {
        String nombre = "Robertín Steve";
        double nota1 = 0, nota2 = 0, nota3 = 0;


        public Alumno() { }

        public Alumno(string nombre, double nota1, double nota2, double nota3)
        {
            this.nombre = nombre;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public String Nombre { get { return nombre; } set { nombre = value; } }

        public double Nota1 { get { return nota1; } set { nota1 = value; } }

        public double Nota2 { get { return nota2; } set { nota2 = value; } }

        public double Nota3 { get { return nota3; } set { nota3 = value; } }

        public double getMedia()
        {
            return Math.Round((nota1 + nota2 + nota3) / 3, 2);
        }

        public override string ToString()
        {
            return $"El alumno {nombre} con notas {nota1}, {nota2} y {nota3} tiene una media de {getMedia()}.";
        }

    }
}
