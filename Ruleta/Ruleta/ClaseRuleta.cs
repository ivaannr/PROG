using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testNumeros;

namespace Ruleta
{
    internal class ClaseRuleta
    {
        Random rd = new Random();

        numRapido num = new numRapido();

        int[] Negro = {1,3,5,7,9,12,14,16,18,19,21,23,25,27,30,32,34,36}; //negro
        int[] Rojo = {2,4,6,8,10,11,13,15,17,20,22,24,26,28,29,31,33,35}; //rojo

        private int Numero = 0;
        private String decision = null;
        private bool ganar;
        private String color = null;
        private int comprobar;
        private String numparimpar = null;
        private String numrango = null;
        private int aciertos = 0;
        private int fallos = 0;

        public void setNumero() { Numero = rd.Next(1 , 37); }

        public int getNumero() { return Numero; }


        public void evaluarNumero() {

            if (Numero == 0) { Console.WriteLine("Salió 0"); }

            else if (Numero > 0) { Console.WriteLine("Salió el número "+Numero); }
           
        }

        public void jugarJuego() {

            do {


                Console.WriteLine("Hola!" +
                    "\n¿Con que deseas apostar?" +
                    "\n[1] Color (Rojo, Negro o Verde)" +
                    "\n[2] Rango de números (0-18 o 19-36)" +
                    "\n[3] Numeros (Par o Impar)" +
                    "\n[4] Stats" +
                    "\n[5] Salir");

                decision = Console.ReadLine();

                if (decision == "Color" || decision == "color")
                {

                    Console.WriteLine("¿Quieres jugar con verde, rojo o con negro?");

                    color = Console.ReadLine();

                    Console.WriteLine("Generando número...");

                    num.setGen();

                    num.getGen();

                    num.generarNumeros();

                    setNumero();
                    getNumero();

                    Console.WriteLine("Salió el número " + Numero);

                    if (Rojo.Contains(Numero))
                    {
                        Console.WriteLine("Salió Rojo");

                        if (color == "Rojo") { Console.WriteLine("Ganaste!"); ganar = true; aciertos++; }
                        else if (color == "rojo") { Console.WriteLine("Ganaste!"); ganar = true; aciertos++; }
                        else { Console.WriteLine("Perdiste!"); ganar = false; fallos++; }

                    }
                    else if (Negro.Contains(Numero))
                    {
                        Console.WriteLine("Salió Negro");

                        if (color == "Negro") { Console.WriteLine("Ganaste!"); ganar = true; aciertos++; }
                        else if (color == "negro") { Console.WriteLine("Ganaste!"); ganar = true; aciertos++; }
                        else { Console.WriteLine("Perdiste!"); ganar = false; fallos++; }
                    }
                    else if (Numero == 0)
                    {
                        if (color == "Verde") { Console.WriteLine("Ganaste!"); ganar = true; aciertos++; }
                        else if (color == "verde") { Console.WriteLine("Ganaste!"); ganar = true; aciertos++; }
                        else { Console.WriteLine("Perdiste!"); ganar = false; fallos++; }

                    }
                }

                else if (decision == "Numeros" || decision == "numeros" || decision == "números" || decision == "Números")
                {

                    Console.WriteLine("¿Quieres jugar con Par o Impar?");

                    numparimpar = Console.ReadLine();

                    Console.WriteLine("Generando número...");

                    num.setGen();

                    num.getGen();

                    num.generarNumeros();

                    setNumero();
                    getNumero();

                    Console.WriteLine("Salió el número " + Numero);

                    comprobar = Numero % 2;

                    if (comprobar == 0)
                    {
                        Console.WriteLine("Salió Par");

                        if (numparimpar == "Par") { Console.WriteLine("Ganaste!"); ganar = true; aciertos++; }
                        else if (numparimpar == "par") { Console.WriteLine("Ganaste!"); ganar = true; aciertos++; }
                        else { Console.WriteLine("Perdiste!"); ganar = false; fallos++; }

                    }
                    else if (Numero != 0)
                    {
                        Console.WriteLine("Salió Impar");

                        if (numparimpar == "impar") { Console.WriteLine("Ganaste!"); ganar = true; aciertos++; }
                        else if (numparimpar == "Impar") { Console.WriteLine("Ganaste!"); ganar = true; aciertos++; }
                        else { Console.WriteLine("Perdiste!"); ganar = false; fallos++; }
                    }

                }

                else if (decision == "Rango" || decision == "rango")
                {

                    Console.WriteLine("¿Quieres apostar 0-18 o 19-36?" +
                        "\nPara apostar porfavor introduzca 18 o 0-18 para el primer rango y 19 o 19-36");

                    numrango = Console.ReadLine();

                    Console.WriteLine("Generando número...");

                    num.setGen();

                    num.getGen();

                    num.generarNumeros();

                    setNumero();
                    getNumero();

                    Console.WriteLine("Salió el número " + Numero);

                    if (Numero >= 19)
                    {
                        Console.WriteLine("Salió de 19-36 ");

                        if (numrango == "19") { Console.WriteLine("Ganaste!"); ganar = true; aciertos++; }
                        else if (numrango == "19-36") { Console.WriteLine("Ganaste!"); ganar = true; aciertos++; }
                        else { Console.WriteLine("Perdiste!"); ganar = false; fallos++; }

                    }


                    else if (Numero <= 18)
                    {
                        Console.WriteLine("Salió de 0 a 18");

                        if (numrango == "18") { 
                            Console.WriteLine("Gfanaste!"); ganar = true; aciertos++; 
                        }
                        else if (numrango == "0-18") { 
                            Console.WriteLine("Ganaste!"); ganar = true; aciertos++; 
                        }
                        else { 
                            Console.WriteLine("Perdiste!"); ganar = false; fallos++;
                        }
                    }

                }

                else if (decision == "Stats" || decision == "stats")
                {

                    Console.WriteLine("Mostrando estadísticas...");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Aciertos: " +
                        "\n"+aciertos);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fallos: " +
                        "\n" + fallos);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                else if (decision == "salir" || decision == "Salir") { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Saliendo..."); return; }

                else { Console.WriteLine("Orden no adecuada."); }

                Console.WriteLine("Pulsa cualquier tecla para seguir");

                Console.ReadKey();

                Console.Clear();

            } while (decision != "Adios" && decision != "adios") ;
               
            }
        
        
        }



    }
