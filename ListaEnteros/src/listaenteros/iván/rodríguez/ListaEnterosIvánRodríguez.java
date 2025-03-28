/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package listaenteros.iván.rodríguez;

import java.util.*;

public class ListaEnterosIvánRodríguez {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        HashSet<Integer> nums = new HashSet<Integer>();
        Iterator<Integer> iterator = nums.iterator();

        int input = 0, numero = 0;

        boolean running = true;

        while (running) {

            System.out.println("Dime que quieres hacer: "
                    + "\n[1] Añadir un número entero a la colección"
                    + "\n[2] Buscar un número entero a la colección"
                    + "\n[3] Borrar un número entero de la colección"
                    + "\n[4] Mostrar la colección"
                    + "\n[0] Salir");

            try {
            
            input = sc.nextInt();
            sc.nextLine();
            }
            
            catch (Exception e) {
            
                System.out.println("Mete un numero");
                sc.nextLine();
                continue;
                
            }

            switch (input) {

                case 0:

                    System.out.println("Saliendo...");
                    running = false;

                    break;

                case 1:

                    System.out.println("Dime un numero para añadirlo: ");

                    try {

                        numero = sc.nextInt();
                        sc.nextLine();
                    } catch (InputMismatchException e) {
                        System.out.println("Mete un numero.");
                        sc.nextLine();
                        continue;
                    }

                    if (nums.contains(numero)) {

                        System.out.println("No se ha podido añadir el número."); //si el número ya está se avisa de que no ha sido añadido

                    }

                    nums.add(numero);

                    break;
                case 2:

                    System.out.println("Dime un numero para buscarlo: ");

                    try {

                        numero = sc.nextInt();
                        sc.nextLine();

                    } catch (InputMismatchException e) {
                        System.out.println("Mete un numero.");
                        sc.nextLine();
                        continue;
                    }

                    if (nums.contains(numero)) {

                        System.out.println("El numero " + numero + " esta en la coleccion.");
                    }

                    break;
                case 3:

                    System.out.println("Dime el numero a borrar: ");

                    try {

                        numero = sc.nextInt();
                        sc.nextLine();

                    } catch (InputMismatchException e) {
                        System.out.println("Mete un numero.");
                        sc.nextLine();
                        continue;
                    }

                    if (!nums.contains(numero)) {

                        System.out.println("No se ha podido borrar el número ya que no está en la coleccion.");

                    } else {
                        nums.remove(numero);
                        System.out.println("Numero borrado correctamente");
                    }
                    break;
                case 4:

                    if (nums.isEmpty()) {
                        System.out.println("La coleccion esta vacia");
                        break;
                    }

                    while (iterator.hasNext()) {
                        Integer num = iterator.next();
                        System.out.println(num);
                    }

                    break;
                default:
                    
                    System.out.println("Numero no valido.");
                    break;
            }
        }

    }

}
