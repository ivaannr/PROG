import java.util.InputMismatchException;
import java.util.*;

public class Arena {

    private final Scanner sc = new Scanner(System.in);
    private final Random rd = new Random();

    public Combatiente meterDatos() {

        Combatiente jugador;
        System.out.println("Dime el nombre de tu personaje: ");
        int input;
        String nombre = sc.nextLine();

        while(true) {

        System.out.println("""
                Ahora dime que clase quieres:\s
                [1] Guerrero
                [2] Arquero
                [3] Mago""");

            try {
                input = sc.nextInt();
                sc.nextLine();
            } catch (InputMismatchException e) {
                System.out.println("Mete un número");
                sc.nextLine();
                continue; }

        switch (input) {
            case 1:
                jugador = new Guerrero(nombre);
                System.out.println("Guerrero creado correctamente con nombre " + nombre);
                return jugador;
            case 2:
                jugador = new Arquero(nombre);
                System.out.println("Arquero creado correctamente con nombre " + nombre);
                return jugador;
            case 3:
                jugador = new Mago(nombre);
                System.out.println("Mago creado correctamente con nombre " + nombre);
                return jugador;
            default:
                System.out.println("Número no válido.");
                break;
            }
        }
    }

    public void empezarCombate() {

        int turno = rd.nextInt(1,3);
        Combatiente jugador1 = meterDatos();
        Combatiente jugador2 = meterDatos();

        while(true) {

            switch (turno) {
                case 1:
                    System.out.println("Es el turno de " + jugador1.getNombre());

                    jugador1.atacar(jugador2);
                    if (jugador2.getSalud() < 1.00) {
                        System.out.println(jugador2.getNombre() + " se ha quedado sin vida, por lo tanto, gana " + jugador1.getNombre());
                        return;
                    }
                    turno = 2;
                    System.out.println("Pulsa Enter para continuar");
                    sc.nextLine();

                    break;
                case 2:
                    System.out.println("Es el turno de " + jugador2.getNombre());
                    jugador2.atacar(jugador1);
                    if (jugador1.getSalud() < 1.00) {
                        System.out.println(jugador1.getNombre() + " se ha quedado sin vida, por lo tanto, gana " + jugador2.getNombre());
                        return;
                    }
                    turno = 1;
                    System.out.println("Pulsa Enter para continuar");
                    sc.nextLine();
                    break;
                default:
                    System.out.println("que");
                    break;

            }

        }



    }

}
