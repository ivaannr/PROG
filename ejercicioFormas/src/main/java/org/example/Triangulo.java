package org.example;

public class Triangulo extends Forma {

    private double altura;
    private double base;

    public Triangulo(String color, String nombre, double altura, double base) {
        super(color, nombre);
        this.altura = altura;
        this.base = base;
    }

    @Override
    public void imprimir() {
        System.out.println(super.toString() + " || Base: " + this.base + " || Altura: " + this.altura+ "");
    }

    @Override
    public double calcArea() {
        return Math.round( (base * altura) / 2);
    }

    @Override
    public double calcPerimetro() {
        return Math.round(base * 3);
    }

    @Override
    public void cambiarEscala(double factorDeCrecimiento)
    {
        this.base *= factorDeCrecimiento;
        this.altura *= factorDeCrecimiento;
        System.out.println("Has aumentado el área del " + this.nombre + " x" + factorDeCrecimiento);
    }

    public double getAltura() {
        return altura;
    }

    public void setAltura(double altura) {
        this.altura = altura;
    }

    public double getBase() {
        return base;
    }

    public void setBase(double base) {
        this.base = base;
    }
}
