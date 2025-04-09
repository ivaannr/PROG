package org.example;

public class Rectangulo extends Forma{

    private double ladoMayor = 0, ladoMenor = 0;

    public Rectangulo(String color, Punto punto, String nombre, double ladoMayor, double ladoMenor) {
        super(color, nombre);
        this.ladoMayor = ladoMayor;
        this.ladoMenor = ladoMenor;
    }



    @Override
    public double calcArea() {
        return this.ladoMayor * this.ladoMenor;
    }

    @Override
    public double calcPerimetro() {
        return 2 * ladoMayor + 2 * ladoMenor;
    }

    @Override
    public void cambiarEscala(double factorDeCrecimiento)
    {
        this.ladoMayor *= factorDeCrecimiento;
        this.ladoMenor *= factorDeCrecimiento;
        System.out.println("Has aumentado el área del " + this.nombre + " x" + factorDeCrecimiento);
    }

    @Override
    public void imprimir() {

        System.out.println(super.toString() + " || Lado mayor: " + this.ladoMayor + " || Lado menor: " + this.ladoMenor);

    }

    public double getLadoMayor() {
        return ladoMayor;
    }

    public void setLadoMayor(int ladoMayor) {
        this.ladoMayor = ladoMayor;
    }

    public double getLadoMenor() {
        return ladoMenor;
    }

    public void setLadoMenor(int ladoMenor) {
        this.ladoMenor = ladoMenor;
    }

}
