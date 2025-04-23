package org.example;

public class Puerta
{

    private int numPuerta;
    private boolean bloqueada = false;

    public int getNumPuerta() {
        return numPuerta;
    }

    public void setNumPuerta(int numPuerta) {
        this.numPuerta = numPuerta;
    }

    public boolean isBloqueada() {
        return bloqueada;
    }

    public void setBloqueada(boolean bloqueada) {
        this.bloqueada = bloqueada;
    }

    protected Puerta(int numPuerta)
    {
        this.numPuerta = numPuerta;
        bloqueada = false;
    }

    @Override
    public String toString() {
        return "Número Puerta: " + numPuerta + " || Bloqueada: " + (isBloqueada() ? "Bloqueada" : "Desbloqueada");
    }

    public void bloquear() {}

    public void desbloquear() {}

}
