import java.io.*;

public class Lectura_Ficheros {

    public static void main(String[] args) {

        FileInputStream fis = null;
        String ciudad;

        try {
            File mifile = new File("ciudades.dat");
            fis = new FileInputStream(mifile);

            DataInputStream dis = new DataInputStream(fis);

            while (true) {
                ciudad = dis.readUTF();
                System.out.println(ciudad + " ");
            }
        }
        catch (FileNotFoundException e)
        {
            System.out.println("Fichero no encontrado.");
        } catch (EOFException ex) {
            System.out.println("FIN DEL ARCHIVO");
        } catch (IOException e) {
            System.out.println("Excepcion de IO");
        } finally {
            try {
                fis.close();
            } catch (IOException e) {
                System.out.println("Excepcion de IO");
            }

        }


    }
}
