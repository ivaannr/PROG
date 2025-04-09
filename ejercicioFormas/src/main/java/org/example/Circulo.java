package org.example;


public class Circulo extends Forma {

    private double radio;

    public Circulo(String color, String nombre, double radio) {
        super(color, nombre);
        this.radio = radio;
    }

    @Override
    public double calcArea() {
        return Math.round(Math.PI * Math.pow(radio, 2));
    }

    @Override
    public double calcPerimetro() {
        return Math.round(2 * Math.PI * radio);
    }

    @Override
    public void imprimir() {

        System.out.println(super.toString() + " || Radio: " + this.radio);

    }

    @Override
    public void cambiarEscala(double factorDeCrecimiento)
    {
        this.radio *= factorDeCrecimiento;
        System.out.println("Has aumentado el área del " + this.nombre + " x" + factorDeCrecimiento);
    }

    public double getRadio() {
        return radio;
    }

    public void setRadio(double radio) {
        this.radio = radio;
    }

}
