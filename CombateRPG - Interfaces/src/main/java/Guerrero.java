import org.jetbrains.annotations.NotNull;

import java.util.Random;

public class Guerrero implements Combatiente{

    Random rd = new Random();

    private final String nombre;
    private double saludBase = 1500;

    public Guerrero(String nombre) {
        this.nombre = nombre;
    }

    @Override
    public void atacar(@NotNull Combatiente objetivo) {

        double multiplicador = rd.nextDouble(0.05,0.1);
        double baseDamage = 500;
        double damageFinal = baseDamage + (baseDamage * multiplicador);
        System.out.println("El jugador " + objetivo.getNombre() + " ha recibido " + Math.round(damageFinal) + " puntos de daño " +
                "\nquedándose con "+ Math.round(objetivo.getSalud()) + " puntos de vida.");
    }

    @Override
    public void recibirDamage(double damage) {

        double dodge = rd.nextDouble(0.00,1.00), dodgeChance = 0.03;

        if (dodge <= dodgeChance) {
            System.out.println("Ataque esquivado!");
        }
        else {
            double defensa = 0.5;
            saludBase = saludBase - (damage * defensa);
        }
    }

    @Override
    public String getNombre() {
        return this.nombre;
    }

    @Override
    public double getSalud() {
        return this.saludBase;
    }

    @Override
    public String getTipo() {
        return "Guerrero";
    }


}
