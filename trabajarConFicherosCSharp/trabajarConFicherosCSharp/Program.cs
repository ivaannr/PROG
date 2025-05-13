using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;


namespace trabajarConFicherosCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String file = @"C:\Users\iván\Documents\Ficheros";
            String ciudad;

            FileStream fs = null;

            using (fs = new FileStream(file, FileMode.Create, FileAccess.Write)) { 

                using (BinaryWriter bw = new BinaryWriter(fs))
                {

                    WriteLine("Introduce ciudad- intro sale: ");
                    ciudad = Console.ReadLine();

                    while (ciudad != "") { 

                        bw.Write(ciudad);
                        WriteLine("Dato grabado.");
                        
                
                    }
                }
            }
        }

    }
    }

