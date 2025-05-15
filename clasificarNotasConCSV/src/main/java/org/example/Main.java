package org.example;

import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {


        Gestor gestor = new Gestor();

        ArrayList<Double> numeros = gestor.leerNumeros("numeros.csv");



        for (double n: numeros)
        {

            if (n < 5) {
                gestor.escribirFichero("suspensos.csv", n);
                System.out.println("Suspenso: " + n);
            }
            else {
                gestor.escribirFichero("aprobados.csv", n);
                System.out.println("Aprobado: " + n);
            }

        }


        System.out.println("Suspensos: ");
        gestor.leerFichero("suspensos.csv");

        System.out.println("\nAprobados");
        gestor.leerFichero("aprobados.csv");





    }
}