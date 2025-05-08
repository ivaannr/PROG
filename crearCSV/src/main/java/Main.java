
import org.jetbrains.annotations.Contract;
import org.jetbrains.annotations.NotNull;
import org.jetbrains.annotations.Nullable;

import java.io.*;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.InputMismatchException;
import java.util.Scanner;

public class Main {

    private static int id = 1;

    public static void main(String[] args) {

        ArrayList<Alumno> alumnos = new ArrayList<>();
        File mifichero = new File("alumnos.csv");


        try (Scanner sc = new Scanner(System.in);
             BufferedWriter bw = new BufferedWriter(new FileWriter(mifichero))) {

            System.out.println("Escribe en el archivo (Enter para salir):");

            while (true) {
                System.out.print("> ");
                String entrada = formatear(sc.nextLine());

                if (entrada.isEmpty()) {
                    System.out.println("Cerrando archivo.");
                    break;
                }

                bw.write(entrada);
                bw.newLine();
            }

        } catch (IOException e) {
            System.out.println("Excepción de IO en el archivo.");
        }


        System.out.println("\nContenido del fichero:");
        try (BufferedReader br = new BufferedReader(new FileReader(mifichero))) {
            String linea;
            while ((linea = br.readLine()) != null) {
                if (crearAlumno(linea, ";") == null) {
                    System.out.println("Alumno nulo"); } else {
                    alumnos.add(crearAlumno(linea, ";"));
                }

                System.out.println(linea);
            }
        } catch (FileNotFoundException e) {
            System.out.println("No se encontró el fichero.");
        } catch (IOException e) {
            System.out.println("Excepción de IO al leer el archivo.");
        }


        for (Alumno a: alumnos)
            System.out.println(a.toString() + "\n");


    }

    public static @NotNull String formatear(@NotNull String linea) {
        return linea.trim().replaceAll(" +", ";").replaceAll(",", ".");
    }

    @Contract("_, _ -> new")
    public static @Nullable Alumno crearAlumno(@NotNull String datos, String separador) {

        String[] mdatos = datos.split(separador);

        try {

            return new Alumno(id++, mdatos[0],
                    Double.parseDouble(mdatos[1]),
                    Double.parseDouble(mdatos[2]),
                    Double.parseDouble(mdatos[3]));

        } catch (NumberFormatException nfe) {

            System.out.println("Error al parsear las nota del alumno " + mdatos[0]);
            return null;
        }

    }

}




