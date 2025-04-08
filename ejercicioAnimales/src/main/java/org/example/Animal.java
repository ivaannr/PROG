package org.example;

import java.util.Objects;

public class Animal {

    private String nombre;
    private int nPatas;

    public Animal() {}

    public Animal(String nombre, int nPatas) {
        this.nombre = nombre;
        this.nPatas = nPatas;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getnPatas() {
        return nPatas;
    }

    public void setnPatas(int nPatas) {
        this.nPatas = nPatas;
    }

    @Override
    public boolean equals(Object o) {
        if (o == null || getClass() != o.getClass()) return false;
        Animal animal = (Animal) o;
        return getnPatas() == animal.getnPatas() && Objects.equals(getNombre(), animal.getNombre());
    }

    @Override
    public int hashCode() {
        return Objects.hash(getNombre(), getnPatas());
    }

    public String getSonido() {
        
        return "";

    }
}
