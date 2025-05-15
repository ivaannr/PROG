package org.example;

import java.util.Random;

public class Jugador {

    private final Random rd = new Random();

    private String nombre;
    private int dado1 = rd.nextInt(1,7), dado2 = rd.nextInt(1,7);

    public Jugador() {
    }

    public Jugador(String nombre) {
        this.nombre = nombre;
    }

    public void generarNums() {
        this.dado1 = rd.nextInt(1,7);
        this.dado2 = rd.nextInt(1,7);
    }

    public boolean compararNumeros() { return this.dado1 == this.dado2; }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void mostrarDados() {

        System.out.println(nombre + ": Dado 1: " + dado1 + " - Dado 2: " + dado2);

    }
}
