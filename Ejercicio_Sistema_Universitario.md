# 🎓 Sistema Universitario – Gestión de Personas, Cursos y Méritos

## 🎯 Objetivo

Diseñar una aplicación en Java que permita gestionar personas en una universidad: estudiantes, profesores y personal administrativo. Se deben poder:

- Leer desde CSVs.
- Calcular promedios y méritos.
- Usar polimorfismo para ejecutar acciones comunes sobre clases distintas.
- Implementar una jerarquía profunda y clara.

---

## 🧬 Árbol de Herencia y Jerarquía

```
                 Persona (abstract)
                      |
        ---------------------------------
        |               |               |
   Estudiante       Profesor     Administrativo
        |
  Cursable (interface)        Evaluador (interface)
```

---

## 📘 Clases

### 🔹 `Persona` (abstracta)

- `String id`
- `String nombre`
- `int edad`

### 🔹 `Estudiante`

- `List<Curso>`
- Implementa `Cursable`
- `double calcularPromedio()`

### 🔹 `Profesor`

- `List<Curso>`
- Implementa `Evaluador`
- `int calcularCargaDocente()`

### 🔹 `Administrativo`

- `String departamento`

---

## 📂 Clase `Curso`

```java
public class Curso {
    private String codigo;
    private String nombre;
    private int creditos;
    private double nota; // solo si lo cursa un estudiante
}
```

---

## 🧠 Interfaces

### `Cursable`

```java
public interface Cursable {
    double calcularPromedio();
}
```

### `Evaluador`

```java
public interface Evaluador {
    int calcularCargaDocente();
}
```

---

## 📂 CSV: `personas.csv`

```csv
tipo,id,nombre,edad,param1
ESTUDIANTE,1,Ana Ruiz,20,"CS101:Programación:5:8.5|CS102:Estructuras:4:9.0"
PROFESOR,2,Luis Gómez,45,"CS101:Programación:5|CS105:Algoritmos:6"
ADMINISTRATIVO,3,Laura Pérez,38,"Recursos Humanos"
```

- `param1` codifica cursos y notas separados por `|`.
- En profesores: sin nota, solo carga.
- En administrativos: solo el departamento.

---

## 🖥️ `Main.java`

Menú simple:

```
== Sistema Universitario ==
1. Ver todas las personas
2. Calcular promedio de estudiantes
3. Calcular carga docente de profesores
4. Ver administrativos por departamento
0. Salir
```

---

## ✅ Habilidades Clave

- Herencia y polimorfismo profundo
- Interfaces múltiples
- Modelado de relaciones
- Lectura de CSV con datos anidados
- Separación por paquetes
- Generación dinámica de instancias por tipo

---

## 💡 Extras opcionales

- Agregar nuevos cursos desde consola
- Exportar promedios por estudiante a un CSV
- Implementar ordenamientos por mérito o edad
