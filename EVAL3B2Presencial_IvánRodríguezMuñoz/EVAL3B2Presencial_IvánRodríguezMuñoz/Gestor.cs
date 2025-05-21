using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVAL3B2Presencial_IvánRodríguezMuñoz
{
    internal class Gestor
    {
        private String linea = "";

        public void escribirFichero(String f, String datos)
        {

            using (StreamWriter sw = new StreamWriter(f, true, Encoding.UTF8))
            {
                linea = datos;

                sw.WriteLine(linea);

            }
        }


        public List<Luchador> leerFichero(String f) {

            List<Luchador> luchadores = new List<Luchador>();


            using (StreamReader sr = new StreamReader(f))
            {

                while ((linea = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(linea);
                    luchadores.Add(crearLuchador(linea));
                }


            }

            return luchadores;

        }

        private Luchador crearLuchador(String datos)
        {

            String[] luchador = datos.Split(',');

            List<String> cintos = new List<String>();

            for (int i = 3; i < luchador.Length; i++)
            { 
            
                cintos.Add(luchador[i]);
            
            }

            return new Luchador(luchador[0], luchador[1], int.Parse(luchador[2]), cintos);
        }




    }
}
