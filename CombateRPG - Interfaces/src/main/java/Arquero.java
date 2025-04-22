import org.jetbrains.annotations.NotNull;

import java.util.Random;

public class Arquero implements Combatiente {

    Random rd = new Random();

    private final String nombre;
    private double saludBase = 700;

    public Arquero(String nombre) {
        this.nombre = nombre;
    }

    @Override
    public void atacar(@NotNull Combatiente objetivo) {

        double multiplicador = rd.nextDouble(0.05,0.1);
        double baseDamage = 300;
        double damageFinal = baseDamage + (baseDamage * multiplicador);
        objetivo.recibirDamage(damageFinal);
        System.out.println("El jugador " + objetivo.getNombre() + " ha recibido " + Math.round(damageFinal) + " puntos de daño " +
                "\nquedándose con " + Math.round(objetivo.getSalud()) + " puntos de vida.");
    }

    @Override
    public void recibirDamage(double damage) {

        double dodge = rd.nextDouble(0.00,1.00);

        double dodgeChance = 0.5;
        if (dodge <= dodgeChance) {
            System.out.println("Ataque esquivado!");
        }
        else {
            double defensa = 1.5 / 10;
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
        return "Arquero";
    }

}
