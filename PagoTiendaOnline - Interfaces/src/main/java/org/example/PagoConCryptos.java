package org.example;

public class PagoConCryptos implements MetodoPago {

    private String email;

    public PagoConCryptos(String email) {
        this.email = email;
    }

    @Override
    public void pagar(double monto) {
        System.out.println("Se han pagado " + monto + " euros con el metodo de pago '" + getNombreMetodo() + "' desde el email " + email);
    }

    @Override
    public String getNombreMetodo() {
        return "Cryptos";
    }

}
