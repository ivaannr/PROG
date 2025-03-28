/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */

package actividadmapatletas_ivánrodríguez;

import java.util.*;
public class ActividadMapAtletas_IvánRodríguez {
    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        Map<Integer, String> atletas = new HashMap<>();

        boolean running = true;
        int input = 0, nDorsal = 1;
        String nombre;

        while (running) {

            System.out.println("Dime que quieres hacer: "
                    + "\n[1] Añadir atleta"
                    + "\n[2] Ver atletas"
                    + "\n[3] Buscar atleta"
                    + "\n[4] Descalificar atleta"
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

                    System.out.println("Dime el nombre para el atleta: ");

                    nombre = sc.next();

                    atletas.put(nDorsal, nombre);

                    System.out.println("Atleta introducido correctamente con el numero de dorsal " + nDorsal);
                    
                    nDorsal++;

                    break;
                case 2:

                    if (atletas.isEmpty()) {

                        System.out.println("No hay atletas");
                        break;

                    }

                    mostrarAtletas(atletas);

                    break;
                case 3:

                    System.out.println("Dime el atleta a buscar: ");
                    nombre = sc.next();

                    if (!atletas.containsValue(nombre)) {

                        System.out.println("Ese atleta no esta en la lista");
                        break;

                    }

                    System.out.println("El atleta " + nombre + " esta en la coleccion con numero de dorsal " + getKey(atletas, nombre));

                    break;
                case 4:
                    
                    System.out.println("Dime el atleta que quieres eliminar: ");
                    nombre = sc.next();

                    if (!atletas.containsValue(nombre)) {

                        System.out.println("Ese atleta no está en la lista");
                        break;

                    }
                    
                    atletas.remove(getKey(atletas, nombre));
                    
                    System.out.println(nombre + " ha sido eliminada del diccionario.");
                    
                    break;
                default:
                    
                    System.out.println("Numero invalido");
                    
                    break;

            }
        }
        
        

    }
    
    public static void mostrarAtletas(Map<Integer, String> atletas) {
        Iterator<Integer> iterator = atletas.keySet().iterator();
        while (iterator.hasNext()) {
            int nDorsal = iterator.next(); 
            System.out.println("Numero de dorsal: " + nDorsal + ", Nombre: " + atletas.get(nDorsal));
        }
    }
    
    public static int getKey(Map<Integer, String> atletas, String nombre) {
    
        for (Map.Entry<Integer, String> entry : atletas.entrySet()) {
            if (entry.getValue().equals(nombre)) {
                return entry.getKey();
            }
        }
        return 0;
    }
    
}



