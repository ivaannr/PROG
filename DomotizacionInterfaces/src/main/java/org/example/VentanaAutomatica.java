package org.example;

public class VentanaAutomatica  extends Ventana{

    protected VentanaAutomatica(int numPuerta) {
        super(numPuerta);
    }

    public void bloquear()
    {
        setBloqueada(true);
        System.out.println("Ventana número " + getNumVentana() + " bloqueada automáticamente");
    }

    public void desbloquear()
    {
        setBloqueada(false);
        System.out.println("Ventana número " + getNumVentana() + " desbloqueada automáticamente.");
    }

    public void Timeout()
    {
        if (!isBloqueada())
        {
            desbloquear();
        }
        else { bloquear(); }
    }

}
