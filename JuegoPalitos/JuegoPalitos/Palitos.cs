using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPalitos
{
    internal class Palitos
    {


        Random palitos = new Random();

        public int palitosRandom;

        //genera el número de palitos con los que se jugaran 
        public void setPalitoRandom() { palitosRandom = palitos.Next(10, 15); 
        }

        //da el número de palitos con los que se jugaran  
        public int getPalitoRandom() { return palitosRandom; 
        }


    }
}
