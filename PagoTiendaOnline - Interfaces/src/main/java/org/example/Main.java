package org.example;

public class Main {
    public static void main(String[] args) {

        Pedido pedido1 = new Pedido(942.53, new PagoConCryptos("mimail@gmail.com"));
        Pedido pedido2= new Pedido(8700.64, new PagoConPayPal("mailgenerico123@gmail.com"));
        Pedido pedido3 = new Pedido(5678.21, new PagoConTarjeta("chiquitogonsales@gmail.com"));

        pedido1.pagar();
        pedido2.pagar();
        pedido3.pagar();

    }}