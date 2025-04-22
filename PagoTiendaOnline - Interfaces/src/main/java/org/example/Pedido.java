package org.example;

public class Pedido {

    private double montoTotal;

    private MetodoPago metodo;

    public Pedido(double montoTotal, MetodoPago metodo) {
        this.montoTotal = montoTotal;
        this.metodo = metodo;
    }

    public void pagar() {
        System.out.println("Procesando pedido...");
        System.out.println("Método seleccionado: " + metodo.getNombreMetodo());
        metodo.pagar(montoTotal);
        System.out.println("Pago completado.\n");
    }

}
