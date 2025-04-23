using System.Runtime.Intrinsics.Arm;

namespace TresEnRaya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola!");
            Console.WriteLine("Los espacios para colocar la 'X' o la 'O' están númerados del 1 al 9 de izquierda a derecha y de arriba a abajo.");
            Console.WriteLine("De manera que el de arriba a la izquierda es el 1 y el de abajo a la derecha el 9.");

            Random rd = new Random();

            int turno = rd.Next(1 , 3);

            bool terminado = false;
            int jugada1 = 0;
            int jugada2 = 0;

            string[] jugador1 = { "X" };
            string[] jugador2 = { "O" };

            int[] tab1 = { 0 ,0 ,0, 0, 0 ,0 ,0 ,0 ,0 };
            string[] tab2 = {".", ".", ".", ".", ".", ".", ".", ".", ".", };
            bool[] ocupar = { false, false, false , false , false, false , false, false, false };


            do
            {

                Console.WriteLine(tab2[0] + " " + tab2[1] + " " + tab2[2]);
                Console.WriteLine(tab2[3] + " " + tab2[4] + " " + tab2[5]);
                Console.WriteLine(tab2[6] + " " + tab2[7] + " " + tab2[8]);

                if (turno == 1) 
                {
                    do
                    {

                        do { 
                        try { 
                        Console.WriteLine("Es el turno del jugador 1." +
                            "\nDime donde quieres poner tu simbolo (X).");
                        jugada1 = int.Parse(Console.ReadLine());

                    }
                        catch (FormatException) { Console.WriteLine("Mete un número."); continue; }
                        catch (OverflowException) { Console.WriteLine("Mete un número del 1 al 9."); continue; }

                            if (jugada1 >= 10 || jugada1 < 1) { Console.WriteLine("Ese número no es válido."); }
                            else { }

                        } while (jugada1 >= 10 || jugada1 < 1);

                        if (ocupar[jugada1 - 1] == true) { Console.WriteLine("Posición no válida."); }

                        else if (ocupar[jugada1 - 1] == false)
                        {

                            if (tab1.Contains(jugada1) || jugada1 < 9 || jugada1 >= 0 || tab1[jugada2] != 2)
                            {

                                tab1[jugada1 - 1] = 1;
                                tab2[jugada1 - 1] = "X";
                                ocupar[jugada1 - 1] = true;
                                turno = 2;
                                Console.WriteLine("Has puesto una X la posicion " + jugada1);
                                
                            }
                            else { Console.WriteLine("No has elegido una posicion adecuada."); }


                        }

                    } while (turno != 2);

                    Console.WriteLine(tab2[0] + " " + tab2[1] + " " + tab2[2]);
                    Console.WriteLine(tab2[3] + " " + tab2[4] + " " + tab2[5]);
                    Console.WriteLine(tab2[6] + " " + tab2[7] + " " + tab2[8]);
                    //combinaciones ganadoras
                    //  0 1 2 // 3 4 5 // 6 7 8 // 0 3 6 // 1 4 7 // 2 5 8 // 0 4 8 // 6 4 2

                }



                else 
                {

                    do
                    {

                        
                        do{ 
                        Console.WriteLine("Es el turno del jugador 2." +
                            "\nDime donde quieres poner tu simbolo (O).");

                        try { 
                        jugada2 = int.Parse(Console.ReadLine());

                    }
                        catch (FormatException) { Console.WriteLine("Mete un número."); continue; }
                        catch (OverflowException) { Console.WriteLine("Mete un número del 1 al 9."); continue; }

                            if (jugada2 >= 10 || jugada2 < 1) { Console.WriteLine("Ese número no es válido."); }
                            else { }

                        } while (jugada2 >= 10 || jugada2 < 1);


                        if (ocupar[jugada2 - 1] == true) { Console.WriteLine("Posición no válida."); }

                        else if (ocupar[jugada2 - 1] == false)
                        {


                            if (tab1.Contains(jugada2) || jugada2 < 9 || jugada2 >= 0 || tab1[jugada2] != 1)
                            {
                                tab1[jugada2 - 1] = 2;
                                tab2[jugada2 - 1] = "O";
                                ocupar[jugada2 - 1] = true;
                                Console.WriteLine("Has puesto una O la posicion " + jugada2);
                                turno = 1;
                            }
                            else { Console.WriteLine("No has elegido una posicion adecuada."); }




                        }







                    } while (turno != 1);

                    Console.WriteLine(tab2[0] + " " + tab2[1] + " " + tab2[2]);
                    Console.WriteLine(tab2[3] + " " + tab2[4] + " " + tab2[5]);
                    Console.WriteLine(tab2[6] + " " + tab2[7] + " " + tab2[8]);

                }

                var total = tab1.Sum();


                if (tab1[0] == 1 && tab1[1] == 1 && tab1[2] == 1) { terminado = true; }
                else if (tab1[3] == 1 && tab1[4] == 1 && tab1[5] == 1) { terminado = true; }
                else if (tab1[6] == 1 && tab1[7] == 1 && tab1[8] == 1) { terminado = true; }

                else if (tab1[0] == 1 && tab1[3] == 1 && tab1[6] == 1) { terminado = true; }
                else if (tab1[1] == 1 && tab1[4] == 1 && tab1[7] == 1) { terminado = true; }
                else if (tab1[2] == 1 && tab1[5] == 1 && tab1[8] == 1) { terminado = true; }

                else if (tab1[0] == 1 && tab1[4] == 1 && tab1[8] == 1) { terminado = true; }
                else if (tab1[6] == 1 && tab1[4] == 1 && tab1[2] == 1) { terminado = true; }

                if (tab1[0] == 2 && tab1[1] == 2 && tab1[2] == 2) { terminado = true; }
                else if (tab1[3] == 2 && tab1[4] == 2 && tab1[5] == 2) { terminado = true; }
                else if (tab1[6] == 2 && tab1[7] == 2 && tab1[8] == 2) { terminado = true; }

                else if (tab1[0] == 2 && tab1[3] == 2 && tab1[6] == 2) { terminado = true; }
                else if (tab1[1] == 2 && tab1[4] == 2 && tab1[7] == 2) { terminado = true; }
                else if (tab1[2] == 2 && tab1[5] == 2 && tab1[8] == 2) { terminado = true; }

                else if (tab1[0] == 2 && tab1[4] == 2 && tab1[8] == 2) { terminado = true; }
                else if (tab1[6] == 2 && tab1[4] == 2 && tab1[2] == 2) { terminado = true; }

                else if (total == 14 && total == 13) { terminado = true; } else { }

                Console.WriteLine("Pulsa cualquier tecla para seguir.");

                Console.ReadKey();

                Console.Clear();

            } while (terminado != true); 
            Console.WriteLine("El juego ha terminado");
            if (turno == 1) { Console.WriteLine("Ganó el jugador 2"); }
            else { Console.WriteLine("Ganó el jugador 1"); }
        }
    }
}
