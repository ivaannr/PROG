package org.example;
import java.util.*;

public class Main {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        Jugador j1 = new Jugador();
        Jugador j2 = new Jugador();

        int intentosJ1 = 1, intentosJ2 = 1;

        System.out.println("Dime el nombre del jugador 1: ");
        j1.setNombre(sc.nextLine());
        System.out.println("Dime el nombre del jugador 2: ");
        j2.setNombre(sc.nextLine());

        System.out.println("Jugadores " + j1.getNombre() + " y " + j2.getNombre() + " metidos correctamente.");

        while (true) {

            j1.generarNums();
            j2.generarNums();

            j1.mostrarDados();
            j2.mostrarDados();

            if (j1.compararNumeros()) {
                System.out.println("Ganó " + j1.getNombre() + " en " + intentosJ1 + " intentos.");
                break;
            }
            else if (j1.compararNumeros()) {
                System.out.println("Ganó " + j2.getNombre() + " en " + intentosJ2 + " intentos.");
                break;
            }
            else { intentosJ1++; intentosJ2++; }
        }

        System.out.println();



    }
}