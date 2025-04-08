package org.example;

public class Hombre extends Humano {

    public Hombre() {
    }

    public Hombre(String nombre, int nPatas) {
        super(nombre, nPatas);
    }

    public String getSonido() {

        return "Habla";

    }
}
