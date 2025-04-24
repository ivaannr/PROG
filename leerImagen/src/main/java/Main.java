import java.io.*;
import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {

        FileInputStream fis = null;
        byte infoImagen = 0;
        ArrayList<Byte> bytes = new ArrayList<>();

        try {
            File mifile = new File("nose.jpg");
            fis = new FileInputStream(mifile);

            DataInputStream dis = new DataInputStream(fis);

            while (true) {
                infoImagen = dis.readByte();
                bytes.add(infoImagen);
            }
        }
        catch (FileNotFoundException e)
        {
            System.out.println("\nFichero no encontrado.");
        } catch (EOFException ex) {
            System.out.println("\nFIN DEL ARCHIVO");
        } catch (IOException e) {
            System.out.println("\nExcepcion de IO");
        } finally {
            try {
                if (fis != null) {
                    fis.close();
                }
            } catch (IOException e) {
                System.out.println("Excepcion de IO");
            }

        }

        for (byte b: bytes)
            System.out.println(b);


        FileOutputStream fos = null;


       try {

            File mifile = new File("miNuevaImagen.png");
            fos = new FileOutputStream(mifile, true);

            DataOutputStream dos = new DataOutputStream(fos);

           for (byte b: bytes)
               dos.writeByte(b);

        }
        catch (FileNotFoundException ex) {
            System.out.println("No encuentro el fichero.");
        } catch (IOException e) {
            System.out.println("Excepcion de I/O");
        } finally {
            try {
                if (fos != null) {
                    fos.close();
                }
            }
            catch (IOException ex)
            {
                System.out.println("Problemas de I/O con el fichero");
            }
        }

    }
}
