package org.example;

public class Ventana {

    protected Ventana(int numVentana)
    {
        this.numVentana = numVentana;
        bloqueada = false;
    }

    private int numVentana;
    private boolean bloqueada = false;

    public int getNumVentana() {
        return numVentana;
    }

    public void setNumVentana(int numVentana) {
        this.numVentana = numVentana;
    }

    public boolean isBloqueada() {
        return bloqueada;
    }

    public void setBloqueada(boolean bloqueada) {
        this.bloqueada = bloqueada;
    }

    @Override
    public String toString() {
        return "Número Ventana: " + numVentana + " || Bloqueada: " + (isBloqueada() ? "Bloqueada" : "Desbloqueada");
    }

    public void bloquear() {}

    public void desbloquear() {}

}
