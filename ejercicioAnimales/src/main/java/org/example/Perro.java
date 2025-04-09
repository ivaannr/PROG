package org.example;

public class Perro extends Canino {

    public Perro() {
    }

    public Perro(String nombre, int nPatas) {
        super(nombre, nPatas);
    }

    public String getSonido() {

        return "Ladra";

    }

}
