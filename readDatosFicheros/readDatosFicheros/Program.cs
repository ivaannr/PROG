using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;

namespace readDatosFicheros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> set = new HashSet<string>();

            string mifile = @"C:\Ficheros\cobaya.jpg", ciudad;

            using (FileStream fs = new FileStream(mifile, FileMode.Open, FileAccess.Read)) {

                using (BinaryReader br = new BinaryReader(fs)) {

                    try
                    {

                        while (true)
                        {

                            ciudad = br.ReadString();
                            set.Add(ciudad);

                        }

                    }
                    catch (EndOfStreamException) { WriteLine("Fin del fichero."); }
                    catch (Exception ex) { WriteLine(ex.Message); }

                }
            
            
            }

            foreach (string s in set) 
                Console.WriteLine(s);


}}}
