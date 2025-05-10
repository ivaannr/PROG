package org.example;

import java.util.Objects;

public abstract class VehiculoInteligente {

    String id, marca, modelo, datoExtra;

    /**
     * Constructor vació
     */
    public VehiculoInteligente() {}

    /**
     * Constructor de clase VehículoInteligente
     * @param id Id del vehículo
     * @param marca marca del vehículo
     * @param modelo modelo del vehículo
     * @param datoExtra Detalles extra sobre el vehículo
     */
    public VehiculoInteligente(String id, String marca, String modelo, String datoExtra) {
        this.id = id;
        this.marca = marca;
        this.modelo = modelo;
        this.datoExtra = datoExtra;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getMarca() {
        return marca;
    }

    public void setMarca(String marca) {
        this.marca = marca;
    }

    public String getModelo() {
        return modelo;
    }

    public void setModelo(String modelo) {
        this.modelo = modelo;
    }

    public String getDatoExtra() {
        return datoExtra;
    }

    public void setDatoExtra(String datoExtra) {
        this.datoExtra = datoExtra;
    }

    /**
     * Muestra info sobre un objeto vehículo
     * @return Info sobre objeto vehículo
     */
    @Override
    public String toString() {
        return "VehiculoInteligente [ ID: " + id + " / Marca: " + marca + "/ Modelo: " + modelo + " / Datos Extra: " + datoExtra + "]";
    }

    /**
     * Compara dos objetos y determina si son iguales
     * @param o Objeto a comparar
     * @return True si los objetos son iguales, false si no lo son
     */
    @Override
    public boolean equals(Object o) {
        if (o == null || getClass() != o.getClass()) return false;
        VehiculoInteligente that = (VehiculoInteligente) o;
        return Objects.equals(id, that.id) && Objects.equals(marca, that.marca) && Objects.equals(modelo, that.modelo);
    }

    /**
     * @return El código hash de un objeto vehículo
     */
    @Override
    public int hashCode() {
        return Objects.hash(id, marca, modelo);
    }
}
