package org.example;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {

        EmisorSonidoAnimal emisor = new EmisorSonidoAnimal();

        Animal lobo = new Lobo("Pedro", 4);
        Animal cigueña = new Cigüeña("Ana", 2);
        Animal cuervo = new Cuervo("Noe", 2);
        Animal gallina = new Gallina("Robertin", 2);
        Animal hombre = new Hombre("Andres", 5);
        Animal leon = new Leon("Iván", 4);
        Animal perro = new Perro("Arturo", 4);

        emisor.mostrarDatosAnimal(lobo);
        emisor.mostrarDatosAnimal(cigueña);
        emisor.mostrarDatosAnimal(cuervo);
        emisor.mostrarDatosAnimal(gallina);
        emisor.mostrarDatosAnimal(hombre);
        emisor.mostrarDatosAnimal(leon);
        emisor.mostrarDatosAnimal(perro);


        }
    }
