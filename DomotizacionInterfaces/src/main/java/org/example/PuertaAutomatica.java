package org.example;

public class PuertaAutomatica extends Puerta{

    protected PuertaAutomatica(int numPuerta) {
        super(numPuerta);
    }

    public void bloquear()
    {
        setBloqueada(true);
        System.out.println("Puerta número " + getNumPuerta() + " bloqueada automáticamente");
    }

    public void desbloquear()
    {
        setBloqueada(false);
        System.out.println("Puerta número " + getNumPuerta() + " desbloqueada automáticamente.");
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
