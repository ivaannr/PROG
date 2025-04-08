package org.example;

public class Mamifero extends Animal {

    public Mamifero() {
    }

    public Mamifero(String nombre, int nPatas) {
        super(nombre, nPatas);
    }

    public static class Humano extends Mamifero {

        public Humano() {
        }

        public Humano(String nombre, int nPatas) {
            super(nombre, nPatas);
        }
    }
}
