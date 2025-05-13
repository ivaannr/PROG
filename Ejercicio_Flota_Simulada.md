# 🚛 Ejercicio Java – Flota de Transporte con Simulación de Ruta

## 🎯 Objetivo

Modelar una flota de vehículos con una jerarquía de clases completa, polimorfismo y una **simulación dinámica de ruta con eventos**.

---

## 📚 Estructura del proyecto

```
FlotaTransporte/
├── README.md
├── data/
│   └── vehiculos.csv
└── src/
    ├── modelo/
    │   ├── Vehiculo.java
    │   ├── ConMotor.java
    │   ├── EventoDeViaje.java
    │   ├── Combustion.java
    │   ├── Electrico.java
    │   ├── Hibrido.java
    │   ├── Auto.java
    │   ├── Camion.java
    │   └── Moto.java
    ├── servicio/
    │   └── FlotaService.java
    └── Main.java
```

---

## 🧬 Árbol de herencia

```
            Vehiculo (abstract)
                 |
        -----------------------
        |                     |
  Combustion (abstract)    Electrico
        |
      Hibrido
        |
 -------------------
 |        |        |
Auto    Camion    Moto
```

---

## 🧩 Interfaz `ConMotor`

```java
public interface ConMotor {
    double calcularConsumo(double km);
}
```

---

## ⚙️ Clases clave

### 🔸 Vehiculo

```java
public abstract class Vehiculo {
    protected String id;
    protected String marca;
    protected String modelo;

    public abstract double estimarCostoViaje(double km);
    public abstract List<EventoDeViaje> simularViaje(double kmTotal, double pasoKm);
}
```

### 🔸 EventoDeViaje

```java
public class EventoDeViaje {
    private double kilometro;
    private String tipo;
    private String descripcion;
}
```

---

## 💽 Archivo CSV de entrada: `vehiculos.csv`

```csv
tipo,id,marca,modelo,param1,param2,param3
AUTO,1,Toyota,Corolla,6.5,,
CAMION,2,Volvo,FL,12.0,,
ELECTRICO,3,Tesla,Model 3,15,0.12,
HIBRIDO,4,Toyota,Prius,4.0,30,
MOTO,5,Yamaha,YBR125,3.5,,
```

---

## 🧠 Lógica de simulación

Cada vehículo simula su viaje dividiéndolo en pasos (ej. cada 20km):

- Electrico: lanza eventos de carga cuando se alcanza cierto consumo.
- Combustion: lanza eventos de repostaje si simula bajo nivel.
- Hibrido: combina ambos.
- Camion: puede generar alertas de sobrepeso (sólo lógica adicional).
- Moto: genera eventos de parada por mantenimiento cada cierto km.

Ejemplo de salida en consola:

```
🚗 [Toyota Corolla] Simulación de 100km:
→ 0km: Inicio del viaje
→ 20km: Consumo normal
⛽ 40km: Parada para repostar
→ 60km: Buen rendimiento
🔧 80km: Revisión de mantenimiento
✅ 100km: Fin del viaje
```

---

## 🧪 Clase `FlotaService`

- `cargarVehiculosDesdeCSV(String ruta)`
- `listarVehiculos()`
- `simularViajeParaTodos(double km, double pasoKm)`
- `filtrarPorTipo(String tipo)`

---

## 📋 Menú de consola

```
== Flota de Transporte ==
1. Ver vehículos
2. Simular ruta
3. Filtrar por tipo
0. Salir
```

---

## 🧠 Aprendizajes

- Herencia jerárquica profunda
- Interfaces funcionales
- Polimorfismo real con lógica de comportamiento
- Lectura estructurada de CSV
- Simulación paso a paso con eventos
- Diseño modular y mantenible

---

## 🧩 Ideas adicionales

- Guardar el log de eventos en un archivo.
- Hacer una interfaz gráfica básica.
- Exportar estadísticas de viaje.

