# Proyecto Java: Sistema de Gestión de Vehículos de Transporte

## Objetivo
Diseñar e implementar un sistema para gestionar diferentes tipos de vehículos de transporte (terrestres, aéreos, marítimos), registrarlos, realizar operaciones con ellos y guardar toda la información en ficheros.

---

## Requisitos

### 1. Herencia y Polimorfismo

Crea la clase abstracta `Vehiculo` con los siguientes atributos:

- `String matricula`
- `String modelo`
- `double capacidadCarga` (en kg)
- `double velocidadMaxima` (en km/h)

Métodos:

- `abstract String getTipo();`
- `String getResumen();` → devuelve una descripción general del vehículo.

#### Subclases concretas:

- `Camion`: añade `int numeroEjes`
- `Avion`: añade `double alturaMaxima` (en metros)
- `Barco`: añade `double eslora` (en metros)

Cada subclase debe sobrescribir `getTipo()` y `getResumen()`.

---

### 2. Interfaces

Crea una interfaz `Operable` con métodos:

```java
void arrancar();
void detener();
void realizarMantenimiento();
```

Haz que las subclases de `Vehiculo` implementen esta interfaz con comportamientos específicos en consola.

---

### 3. Gestión de Ficheros

Crea una clase `GestorVehiculos` con métodos para:

- Guardar una lista de vehículos en un fichero (`vehiculos.txt`).
- Leer el fichero y reconstruir los objetos según el tipo (Camion, Avion, Barco).

Usa delimitadores (`;` o `|`) para separar campos.

### Formato sugerido por línea en el archivo:

```text
Camion;1234ABC;Volvo FH;18000.0;120.0;3
Avion;5678XYZ;Boeing 747;40000.0;900.0;13000.0
Barco;2468DEF;Titanic;50000.0;40.0;269.0
```

---

### 4. Clase GestorGeneral

Clase principal para:

- Añadir nuevos vehículos (ingreso por consola)
- Mostrar todos los vehículos
- Guardar y cargar desde fichero
- Ejecutar operaciones comunes (`arrancar`, `detener`, etc.)

---

## Clases sugeridas

- `Vehiculo.java`
- `Camion.java`
- `Avion.java`
- `Barco.java`
- `Operable.java`
- `GestorVehiculos.java`
- `GestorGeneral.java` (con `main`)

---

## Ejemplo de ejecución

```text
===== GESTOR DE VEHÍCULOS =====
1. Añadir vehículo
2. Mostrar todos
3. Guardar en fichero
4. Cargar desde fichero
5. Ejecutar operaciones
6. Salir
```

---

## Extras (Opcionales)

- Validación de datos (números positivos, matrículas no repetidas).
- Uso de excepciones personalizadas.
- Añadir fecha de mantenimiento.

---

---

## Desafíos Opcionales

Estos retos adicionales están pensados para mejorar aún más el sistema y aplicar conceptos avanzados:

### 1. **Persistencia en JSON**
- Implementa guardado y carga de vehículos utilizando formato JSON usando `org.json` o alguna librería similar.

### 2. **Búsqueda y Filtrado**
- Permitir buscar vehículos por tipo, modelo, o matrícula.
- Filtrar por capacidad de carga mínima o velocidad máxima.

### 3. **Sistema de Logs**
- Registrar todas las acciones (creación, arranque, guardado, etc.) en un archivo de log con marcas de tiempo.

### 4. **Soporte para Plugins**
- Cargar nuevas clases de vehículos dinámicamente desde archivos `.class` externos.

### 5. **Interfaz Gráfica (Swing o JavaFX)**
- Crear una interfaz de usuario que permita interactuar con el sistema de forma visual.

### 6. **Uso de Enumeraciones**
- Usar `enum` para representar el estado del vehículo: `EN_MARCHA`, `DETENIDO`, `MANTENIMIENTO`.

### 7. **Serialización binaria**
- Guardar y cargar los objetos mediante serialización Java (`ObjectOutputStream`, `ObjectInputStream`).

---
