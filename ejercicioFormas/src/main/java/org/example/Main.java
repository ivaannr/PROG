package org.example;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {

    Forma rectangulo = new Rectangulo("Rojo", new Punto(0,1), "Rectángulo", 4 , 2);
    Forma circulo = new Circulo("Azul", "Círculo", 3);
    Forma triangulo = new Triangulo("Verde", "Triángulo", 3, 2);

        rectangulo.imprimir();

        System.out.println("Tiene un área de: " + rectangulo.calcArea() );
        System.out.println("Tiene un perímetro de: " + rectangulo.calcPerimetro());

        System.out.println();

        circulo.imprimir();

        System.out.println("Tiene un área de: " + circulo.calcArea() );
        System.out.println("Tiene un perímetro de: " + circulo.calcPerimetro());

        System.out.println();

        triangulo.imprimir();

        System.out.println("Tiene un área de: " + triangulo.calcArea() );
        System.out.println("Tiene un perímetro de: " + triangulo.calcPerimetro());


    }
}
