using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoBaraja
{
    internal class Cartas
    {

        // 1-13 espadas, 14 - 26 tréboles, 27 - 39 diamantes, 40 - 52 corazones

        Random rd = new Random();

        private int carta;

        private String Palo;

        private int realTreboles;

        private int realCorazones;

        private int realDiamantes;

        public void setCarta()
        {
            this.carta = carta;
            carta = rd.Next(1, 53);
        }

        public int getCarta() { return carta; }

        public void mostrarCarta() { Console.WriteLine("La carta es "+carta); } //Clase creada por motivos de depuración

        public void evaluarCarta() {

            realTreboles = carta - 13;

            realCorazones = carta - 39; 

            realDiamantes = carta - 26;

            if (carta <= 13) { Console.WriteLine("Ha salido el número "+carta+" por lo tanto es de tipo Espadas ♠.");
                Palo = "Espadas ♠";
                if (carta <= 10) { Console.WriteLine("Tu número es el "+carta+" de "+Palo);}
                if (carta == 11) { Console.WriteLine("Tu carta es la J de " + Palo); }
                else if (carta == 12) { Console.WriteLine("Tu carta es la Q de " + Palo); }
                else if (carta == 13) { Console.WriteLine("Tu carta es la K de " + Palo); }
            }
            else if (carta >= 14 && carta <= 26) { Console.WriteLine("Ha salido el número " + carta + " por lo tanto es de tipo Tréboles ♣.");
                Palo = "Tréboles ♣";


                if (carta >= 14 && carta <= 23) { Console.WriteLine("Tu número es el " + realTreboles + " de " + Palo); }

                if (realTreboles == 11) { Console.WriteLine("Tu carta es la J de " + Palo); }
                    else if (realTreboles == 12) { Console.WriteLine("Tu carta es la Q de " + Palo); }
                    else if (realTreboles == 13) { Console.WriteLine("Tu carta es la K de " + Palo); }
            }

            else if (carta >= 27 && carta <= 39) { Console.WriteLine("Ha salido el número " + carta + " por lo tanto es de tipo Diamantes ♦.");
                Palo = "Diamantes ♦";

                if (carta >= 27 && carta <= 39) { Console.WriteLine("Tu número es el " + realDiamantes + " de " + Palo);


                    if (realDiamantes == 11) { Console.WriteLine("Tu carta es la J de " + Palo); }
                    else if (realDiamantes == 12) { Console.WriteLine("Tu carta es la Q de " + Palo); }
                    else if (realDiamantes == 13) { Console.WriteLine("Tu carta es la K de " + Palo); }
                }
                

            }
            else if (carta >= 40 && carta <= 52) { Console.WriteLine("Ha salido el número " + carta + " por lo tanto es de tipo Corazones ♥."); 
                Palo = "Corazones ♥";

                if (carta >= 40 && carta <= 52) { Console.WriteLine("Tu número es el " + realCorazones + " de " + Palo);


                    if (realCorazones == 11) { Console.WriteLine("Tu carta es la J de " + Palo); }
                    else if (realCorazones == 12) { Console.WriteLine("Tu carta es la Q de " + Palo); }
                    else if (realCorazones == 13) { Console.WriteLine("Tu carta es la K de " + Palo); }

                }

            }



        }

    }
}
