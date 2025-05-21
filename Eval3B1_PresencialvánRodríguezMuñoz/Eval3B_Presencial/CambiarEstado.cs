using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval3B_Presencial
{
    internal class CambiarEstado
    {

        /// <summary>
        /// Este método cambia el estado de un objeto que se le pasa por parámetro 
        /// dependiendo de si está encendido o no
        /// </summary>
        /// <param name="obj">Objeto a cambiar el estado del interruptor.</param>
        public void cambioDeEstadoInterruptor(Object obj)
        {

            if (obj is null) {
                Console.WriteLine("El objeto es null");
            }

            if (obj is Coche) {

                Coche coche = (Coche) obj;
                coche.modificarInterruptor();

                obj = coche;

            }
            else if (obj is Lampara) {
                
                Lampara lampara = (Lampara) obj;
                lampara.modificarInterruptor();

                obj = lampara;

            }
            else Console.WriteLine("El objeto es inválido");
            

        }




    }
}
