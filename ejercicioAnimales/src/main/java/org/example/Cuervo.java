package org.example;

public class Cuervo extends Ave{

    public Cuervo() {
    }

    public Cuervo(String nombre, int nPatas) {
        super(nombre, nPatas);
    }

    public String getSonido() {

        return "Grazna";

    }

}
