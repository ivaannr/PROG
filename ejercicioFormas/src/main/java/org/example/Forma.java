package org.example;

public abstract class Forma {

    protected String color;
    protected String nombre;

    public Forma(String color,  String nombre) {
        this.color = color;
        this.nombre = nombre;
    }

    public void imprimir() { }

    public double calcArea() {
        return 0;
    }

    public double calcPerimetro() {
        return 0;
    }

    public void cambiarEscala(double factorDeCrecimiento) { }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }

    @Override
    public String toString() {
        return "Nombre: " + this.nombre + " || Color: " + this.color;
    }


}
