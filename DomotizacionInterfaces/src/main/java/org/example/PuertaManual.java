package org.example;

public class PuertaManual extends Puerta {


    protected PuertaManual(int numPuerta) {
        super(numPuerta);
    }

    public void bloquear()
    {
        setBloqueada(true);
        System.out.println("Puerta número " + getNumPuerta() + " bloqueada manualmente");
    }

    public void desbloquear()
    {
        setBloqueada(false);
        System.out.println("Puerta número " + getNumPuerta() + " desbloqueada manualmente");
    }


}
