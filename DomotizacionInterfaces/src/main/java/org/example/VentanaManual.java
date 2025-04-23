package org.example;

public class VentanaManual extends Ventana{

    protected VentanaManual(int numPuerta) {
        super(numPuerta);
    }

    public void bloquear()
    {
        setBloqueada(true);
        System.out.println("Ventana número " + getNumVentana() + " bloqueada manualmente");
    }

    public void desbloquear()
    {
        setBloqueada(false);
        System.out.println("Ventana número " + getNumVentana() + " desbloqueada manualmente.");
    }


}
