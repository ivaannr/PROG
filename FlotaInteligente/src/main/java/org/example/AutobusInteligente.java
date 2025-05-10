package org.example;

import java.util.Objects;

public class AutobusInteligente extends VehiculoInteligente implements Eficiente {

    VehiculoInteligente tipo;

    /**
     * Constructor de la clase
     * @param id Id del vehículo
     * @param marca marca del vehículo
     * @param modelo modelo del vehículo
     * @param datoExtra Detalles extra sobre el vehículo
     * @param tipo Tipo del vehículo
     */
    public AutobusInteligente(String id, String marca, String modelo, String datoExtra, VehiculoInteligente tipo) {
        super(id, marca, modelo, datoExtra);
        this.tipo = tipo;
    }

    public AutobusInteligente() {
    }

    public VehiculoInteligente getTipo() {
        return tipo;
    }

    public void setTipo(VehiculoInteligente tipo) {
        this.tipo = tipo;
    }

    /**
     * Compara dos objetos y determina si son iguales
     * @param o Objeto a comparar
     * @return True si los objetos son iguales, false si no lo son
     */
    @Override
    public boolean equals(Object o) {
        if (o == null || getClass() != o.getClass()) return false;
        if (!super.equals(o)) return false;
        AutobusInteligente that = (AutobusInteligente) o;
        return Objects.equals(tipo, that.tipo);
    }

    /**
     * @return El código hash de un objeto vehículo
     */
    @Override
    public int hashCode() {
        return Objects.hash(super.hashCode(), tipo);
    }

    /**
     * Muestra info sobre un objeto vehículo
     * @return Info sobre objeto vehículo
     */
    @Override
    public String toString() {
        return "AutobusInteligente [ Tipo: " + tipo + "/ ID: " + id + " / Marca: "
                + marca + "/ Modelo: " + modelo + " / Datos Extra: " + datoExtra + "]";
    }


    /**
     * Calcula la eficiencia de un vehículo
     *
     * @return Un entero que representa la eficiencia del vehículo
     */
    @Override
    public int calcularEficiencia() {
        return 0;
    }
}
