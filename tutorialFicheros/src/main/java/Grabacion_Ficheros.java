import java.io.*;
import java.util.Scanner;

public class Grabacion_Ficheros {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        FileOutputStream fos = null;

        try {



            File mifile = new File("ciudades.dat");
            fos = new FileOutputStream(mifile, true);

            DataOutputStream dos = new DataOutputStream(fos);

           /* dos.writeUTF("oviedo");
            dos.writeUTF("aviles");
            dos.writeUTF("gijon");
            dos.writeUTF("mieres");
            dos.writeUTF("lugones");
            dos.writeUTF("siero");
            dos.writeUTF("llanera");*/


        }
        catch (FileNotFoundException ex) {
            System.out.println("No encuentro el fichero.");
        } catch (IOException ex) {
            System.out.println("Error en grabación de escritura en el fichero.");
        }
        finally {
                try {
                    fos.close();
                }
                catch (IOException ex)
                {
                    System.out.println("Problemas de I/O con el fichero");
                }
            }

        }




    }



