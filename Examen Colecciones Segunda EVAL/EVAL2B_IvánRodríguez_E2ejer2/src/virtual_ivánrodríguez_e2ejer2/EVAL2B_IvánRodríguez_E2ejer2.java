/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */

package virtual_ivánrodríguez_e2ejer2;
import java.util.*;

public class EVAL2B_IvánRodríguez_E2ejer2 {
    public static void main(String[] args) {
        
        Coche coche = null;
        Map<String, Coche> coches = new HashMap<String, Coche>();
        Scanner sc = new Scanner(System.in);
        
        String matricula = null, marca = null, modelo = null;
        boolean running = true;
        int input = 0;
        
        while (running) {
        
            mostrarMenu(); 

            try {

                input = sc.nextInt();
                sc.nextLine();

            } catch (InputMismatchException e) {
                System.out.println("Mete un número.");
                sc.nextLine();
                continue;
            }
            catch (Exception e) {
                System.out.println("Mete un número.");
                sc.nextLine();
                continue;
            }
            
            switch(input) { 
                
                case 0: //Salir
                    
                    System.out.println("Saliendo..."); 
                    running = false;
                    
                    
                    break;
                
                case 1: //Añadir coche
                    
                    System.out.println("Dime la matricula del coche a pasar: ");
                    matricula = sc.next();
                    
                    if (coches.containsKey(matricula)) { //Si la key matricula ya esta en la lista no mete el coche
                    
                        System.out.println("Ese coche ya ha pasado.");
                        break;
                    
                    }
                    
                    System.out.println("Dime la marca: ");
                    marca = sc.next();
                    System.out.println("Dime el modelo: ");
                    modelo = sc.next();
                    coche = new Coche(matricula, marca, modelo);
                    coches.put(matricula, coche);
                    
                    System.out.println("Coche introducido correctamente.");
                    
                    break;
                case 2: //Muestra los coches que han pasado
                    
                   if (coches.isEmpty()) { // si la lista está vacia no muestra nada
                    
                        System.out.println("No ha pasado ningún coche todavía.");
                        break;
                    
                    }
                    
                    mostrarCoches(coches);
                    
                    break;
                case 3: //Muestra la cantidad de coches que han pasado
                    
                   if (coches.isEmpty()) { //si la lista está vacia no muestra nada
                    
                        System.out.println("No ha pasado ningún coche todavía.");
                        break;
                    
                    }
                    
                    System.out.println("Hay " + coches.size() + " coches.");
                    
                    
                    break;
                case 4: //busca un coche por matricula
                    
                    System.out.println("Dime la matricula del coche a buscar: ");
                    
                    matricula = sc.next();
                    
                    if (!coches.containsKey(matricula)) { // si la matricula está en la lista no muestra nada
                    
                        System.out.println("Ese coche no existe. ");
                        break;
                    }
                    
                    System.out.println("El coche que tiene como matricula " + matricula + "  es: " + coches.get(matricula));
                  
                    
                    break;
                case 5:
                    
                    if (coches.isEmpty()) { // si la lista está vacia no muestra nada
                        
                        System.out.println("No hay coches para visualizar.");
                        break;
                    
                    }
                    
                    int count = 0;
                    System.out.println("Dime la marca de los coches que quieres buscar: ");
                    marca = sc.next();
                    
                    /* Creo un nuevo objeto coche con todos los atributos en null
                     menos la marca ya que es lo que voy a comparar */
                    
                    Coche miCoche = new Coche(null, marca, null); 
                    
                        for (String clave : coches.keySet()) {
            
                            if (coche.equalsMarca(coches.get(clave))) {  // si el equals devuelve true es que la marca coincide y le suma uno al nº total de coches

                                count++;

                            }
                        }
                    
                        System.out.println("Hay " + count + " coches de esa misma marca.");
                    
                    break;
            
            }
        
            
        
        
        }
        
        
        
  
    }
    
    // método para mostrar todos los coches
    public static void mostrarCoches(Map<String, Coche> coches) { 
        Iterator<String> iterator = coches.keySet().iterator();
        while (iterator.hasNext()) {
            String clave = iterator.next();
            System.out.println("Matricula: " + clave + ", Datos Coche: " + coches.get(clave));
        }
    }
    
    // método que muestra el menu
    public static void mostrarMenu() {
                 System.out.println("Dime que quieres hacer: "
                    + "\n[1] Añadir coche"
                    + "\n[2] Mostrar coches"
                    + "\n[3] Mostrar total coches"
                    + "\n[4] Buscar coche por matricula"
                    + "\n[5] Saber cuantos coches de una marca han pasado"
                    + "\n[0] Salir");
     
     } 
    

}
