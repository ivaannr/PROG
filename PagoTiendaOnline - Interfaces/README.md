# Ejercicio 2: Sistema de Pago para una Tienda Online
## **Objetivo:**
***Crear un sistema de tienda que permita realizar pagos con diferentes métodos (tarjeta, PayPal, criptomonedas, etc.) usando interfaces.***

## Requisitos:
```
1- Crea una interfaz MetodoPago con:

void pagar(double monto)

String getNombreMetodo()

2- Implementa al menos tres métodos de pago:

- PagoConTarjeta

- PagoConPayPal

- PagoConCripto

3- Crea una clase Pedido que:

Tenga un total a pagar (double montoTotal)

Reciba un objeto MetodoPago y ejecute el pago.

4- Usa polimorfismo para que puedas cambiar el método de pago sin cambiar el resto del sistema.
```
