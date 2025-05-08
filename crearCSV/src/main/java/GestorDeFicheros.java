import java.io.*;
import java.util.Scanner;

public class GestorDeFicheros {

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

    public void escribirFichero(String fichero) {

        Scanner sc = new Scanner(System.in);
        FileWriter fw = null;
        String linea = " ";

        try {
            fw = new FileWriter(fichero);
            BufferedWriter fbw = new BufferedWriter(fw);
            System.out.println("Escribe \\\\ Enter para salir");
            while (true) {


                linea = sc.nextLine();
                System.out.println(linea);

                if (linea.isEmpty()) {
                    System.out.println("Cerrando fichero.");
                    break;
                }


            }

            for (int i = 0; i < 5; i++) {

                String cadena = "cadena " + i + "\r\n";
                fbw.write(cadena);

            }

        } catch (IOException e) {
            System.out.println("Excepcion de I/O");
        } finally {

            try {

                if (fw != null) {
                    fw.close();
                }

            } catch (IOException e) {
                System.out.println("Excepcion de IO");
            }


        }


    }

}
