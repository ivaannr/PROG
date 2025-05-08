import java.io.*;
import java.util.Scanner;

public class ficheroTxT {
    public static void main(String[] args) {

        File mifichero = new File("mifichero.txt");
        Scanner sc = new Scanner(System.in);

        FileReader fr = null;
        try {

            fr = new FileReader(mifichero);
            BufferedReader br = new BufferedReader(fr);
            String linea = "";


            while(
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

        FileWriter fw = null;
        String linea = " ";

        try {
            fw = new FileWriter(mifichero);
            BufferedWriter fbw =  new BufferedWriter(fw);

            while(true) {

                System.out.println("Escribe \\\\ Enter para salir");
                linea = sc.nextLine();

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

                if (fr != null) {
                    fr.close();
                }

            } catch (IOException e) {
                System.out.println("Excepcion de IO");
            }


        }







    }
}
