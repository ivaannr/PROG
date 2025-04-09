package org.example;

public class Gato extends Felino{

    public Gato() {
    }

    public Gato(String nombre, int nPatas) {
        super(nombre, nPatas);
    }

    public String getSonido() {

        return "Maullas";

    }
}
