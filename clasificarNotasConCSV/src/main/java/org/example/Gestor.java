package org.example;
import org.jetbrains.annotations.NotNull;

import java.io.*;
import java.util.*;

public class Gestor {

    private String linea = "";
    public double calcularLinea(@NotNull String linea) {

        String[] milinea = linea.split(";");

        double total = 0;

        for (int i = 0; i < milinea.length; i++) {

            total += Double.parseDouble(milinea[i]);

        }

        return (double) Math.round(total / milinea.length);

    }
    public void leerFichero(String fichero) {

        File mifichero = new File(fichero);

        FileReader fr = null;
        try {

            fr = new FileReader(mifichero);
            BufferedReader br = new BufferedReader(fr);
            String linea = "";


            while (
                    (linea = br.readLine()) != null
            ) {

               System.out.println(linea);

            }


        } catch (FileNotFoundException e) {
            System.out.println("No se encontró el fichero");
        } catch (IOException e) {
            System.out.println("Excepcion de IO");
        } finally {

            try {

                if (fr != null) {
                    fr.close();
                }

            } catch (IOException e) {
                System.out.println("Excepcion de IO");
            }


        }


    }
    public ArrayList<Double> leerNumeros(String fichero) {

        ArrayList<Double> numeros = new ArrayList<>();


        File mifichero = new File(fichero);

        FileReader fr = null;
        try {

            fr = new FileReader(mifichero);
            BufferedReader br = new BufferedReader(fr);
            String linea = "";


            while (
                    (linea = br.readLine()) != null
            ) {


                numeros.add(calcularLinea(linea));

            }


        } catch (FileNotFoundException e) {
            System.out.println("No se encontró el fichero");
        } catch (IOException e) {
            System.out.println("Excepcion de IO");
        } finally {

            try {

                if (fr != null) {
                    fr.close();
                }

            } catch (IOException e) {
                System.out.println("Excepcion de IO");
            }


        }


        return numeros;
    }
    public void escribirFichero(String path, double n) {
        File mifile = new File(path);

        try (BufferedWriter fbw = new BufferedWriter(new FileWriter(mifile, true))) {
            fbw.write(Double.toString(n) + " ");
        } catch (IOException e) {
            System.out.println("Excepción de I/O: " + e.getMessage());
        }
    }



}
