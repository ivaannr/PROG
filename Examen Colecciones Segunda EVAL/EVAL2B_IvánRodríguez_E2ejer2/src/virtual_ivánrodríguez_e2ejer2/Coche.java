/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package virtual_ivánrodríguez_e2ejer2;

import java.util.Iterator;
import java.util.Map;
import java.util.Objects;

public class Coche implements Comparable<Coche> {
    
    private String matricula = null, marca = null, modelo = null;
    
    //Constructor vacío y con atributos
    
    public Coche() {}
    
    public Coche(String matricula, String marca, String modelo) {
    
        this.matricula = matricula;
        this.marca = marca;
        this.modelo = modelo;
    
    }

    //Getter y setter
    
    public String getMatricula() {
        return matricula;
    }

    public void setMatricula(String matricula) {
        this.matricula = matricula;
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

    
    
    //ToString()
    @Override
    public String toString() {
        return "Datos del coche: [Matricula: " + this.matricula + " || Marca: " + this.marca + " ||  Modelo: " + this.modelo + "]"; 
    }

    
    //HashCode
    @Override
    public int hashCode() {
        int hash = 5;
        hash = 71 * hash + Objects.hashCode(this.matricula);
        return hash;
    }

    
    //Equals
    @Override
    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj == null) {
            return false;
        }
        if (getClass() != obj.getClass()) {
            return false;
        }
        final Coche other = (Coche) obj;
        return Objects.equals(this.matricula, other.matricula);
    }
    
    
        //Equals para saber si la marca es la misma.
        public boolean equalsMarca(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj == null) {
            return false;
        }
        if (getClass() != obj.getClass()) {
            return false;
        }
        final Coche other = (Coche) obj;
        return Objects.equals(this.marca, other.marca);
    }

        
        //CompareTo
    @Override
    public int compareTo(Coche o) {
        if (o == null) return 1;
        return this.matricula.compareTo(o.matricula);
    }
    

    
    
    
    

}
