package org.example;

public class Lobo extends Canino {

    public Lobo() {
    }

    public Lobo(String nombre, int nPatas) {
        super(nombre, nPatas);
    }

    public String  getSonido() {

        return "Aúlla";

    }
}
