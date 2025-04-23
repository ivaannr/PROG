package org.example;

public class Main {
    public static void main(String[] args) {

        GestionDomotica gestion = new GestionDomotica();

        Puerta puerta1 = new PuertaAutomatica(1);
        Puerta puerta2 = new PuertaManual(2);
        Ventana ventana1 = new VentanaAutomatica(1);
        Ventana ventana2 = new VentanaManual(2);

        System.out.println("Estado de las puertas y las ventanas: " +
                "\n" + puerta1.toString() +
                "\n" + puerta2.toString() +
                "\n" + ventana1.toString() +
                "\n" + ventana2.toString()
        );


        System.out.println("");

        puerta1.bloquear();
        puerta2.bloquear();

        System.out.println("");

        ventana1.bloquear();
        ventana2.bloquear();

        System.out.println("");

        System.out.println("Estado de las puertas y las ventanas: " +
                "\n" + puerta1.toString() +
                "\n" + puerta2.toString() +
                "\n" + ventana1.toString() +
                "\n" + ventana2.toString()
        );


    }
}