/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package diccionarioespañolngles_ivánrodríguez;

import java.util.*;

public class DiccionarioEspañolngles_IvánRodríguez {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        Map<String, String> diccionario = new HashMap<String, String>();
        Iterator<String> iterator = diccionario.keySet().iterator();

        boolean running = true;
        String palabra, traduccion;
        int input = 0;

        while (running) {

            System.out.println("Dime que quieres hacer: "
                    + "\n[1] Añadir palabra al diccionario"
                    + "\n[2] Ver diccionario"
                    + "\n[3] Buscar palabra en español"
                    + "\n[4] Buscar palabra en ingles"
                    + "\n[5] Eliminar palabra del diccionario"
                    + "\n[0] Salir");

            try {

                input = sc.nextInt();
                sc.nextLine();

            } catch (Exception e) {
                System.out.println("Mete un número.");
                sc.nextLine();
                continue;
            }

            switch (input) {

                case 0:
                    
                    System.out.println("Saliendo...");
                    running = false;
                    
                    break;
                case 1:

                    System.out.println("Dime una palabra: ");

                    palabra = sc.next();

                    if (diccionario.containsValue(palabra)) {

                        System.out.println("La palabra ya se encuentra en el diccionario");

                        break;

                    }

                    System.out.println("Dime su traduccion al ingles: ");
                    traduccion = sc.next();

                    diccionario.put(palabra, traduccion);

                    System.out.println("Palabra introducida correctamente.");

                    break;
                case 2:

                    if (diccionario.isEmpty()) {

                        System.out.println("El diccionario está vacio");
                        break;

                    }

                    mostrarDiccionario(diccionario);

                    break;
                case 3:

                    System.out.println("Dime la palabra de la que quieres buscar la traduccion: ");
                    palabra = sc.next();

                    if (!diccionario.containsKey(palabra)) {

                        System.out.println("El diccionario no contiene esa palabra");
                        break;

                    }

                    System.out.println("La traduccion de " + palabra + " es " + diccionario.get(palabra));

                    break;
                case 4:

                    System.out.println("Dime la palabra inglesa para buscar su traduccion.");
                    traduccion = sc.next();

                    if (!diccionario.containsValue(traduccion)) {

                        System.out.println("La palabra no se encuentra en el diccionario");
                        break;

                    }
                    
                    palabra = getKey(diccionario, traduccion);
                    
                    System.out.println("Su traduccion al español es: " + palabra);

                    break;
                case 5:
                    
                    System.out.println("Dime la palabra que quieres eliminar: ");
                    palabra = sc.next();

                    if (!diccionario.containsKey(palabra)) {

                        System.out.println("El diccionario no contiene esa palabra");
                        break;

                    }
                    
                    diccionario.remove(palabra);
                    
                    System.out.println(palabra + " ha sido eliminada del diccionario.");
                    
                    break;
                default:
                    
                    System.out.println("Numero invalido");
                    
                    break;

            }
        }

    }

    public static void mostrarDiccionario(Map<String, String> diccionario) {
        Iterator<String> iterator = diccionario.keySet().iterator();
        while (iterator.hasNext()) {
            String clave = iterator.next();
            System.out.println("Palabra: " + clave + ", Traduccion: " + diccionario.get(clave));
        }
    }

    public static String getKey(Map<String, String> diccionario, String palabra) {

        for (Map.Entry<String, String> entry : diccionario.entrySet()) {
            if (entry.getValue().equals(palabra)) {
                return entry.getKey();
            }
        }
        return null;
    }

}
