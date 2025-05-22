using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnoDeCsvACsvC_
{
    internal class Alumno
    {
        String nombre = "";
        double[] notas;
        double media = 0;

        public Alumno() { }

        public Alumno(String nombre, double[] notas)
        {
            this.nombre = nombre;
            this.notas = notas;
        }

        public String Nombre { get { return nombre; } set { nombre = value; } }
        public double Media { get { return media; } set { media = value; } }

       

        public double calcMedia()
        {           
            double suma = 0;

            foreach (double d in notas) 
                    suma += d;

            return Math.Round((suma / notas.Length), 2);
        }

        public String getNotas() {
            return string.Join(", ", notas);
        }

        public String notasToCSV() {
            return string.Join(";", notas.Where(n => n != 0)).Replace(",",".");
        }

        public override string ToString()
        {
            return $"El alumno {this.nombre} con notas {getNotas()} tiene una media de {calcMedia()}.";
        }

        public String toCSV() {

            return $"{nombre};{notasToCSV()}";
        
        }

    }
}
