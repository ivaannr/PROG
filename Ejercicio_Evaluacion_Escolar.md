# 🏫 Plataforma de Evaluación Escolar Inteligente – Proyecto Java

## 🎯 Objetivo

Desarrollar un sistema de evaluación escolar en Java que utilice **herencia, interfaces, polimorfismo** y **múltiples archivos CSV**. La plataforma debe simular dinámicamente evaluaciones realizadas por profesores, generando reportes de rendimiento.

---

## 📁 Estructura del proyecto

```
EvaluacionEscolar/
├── README.md
├── data/
│   ├── alumnos.csv
│   ├── profesores.csv
│   ├── asignaturas.csv
│   └── evaluaciones.csv
└── src/
    ├── modelo/
    │   ├── Persona.java
    │   ├── Alumno.java
    │   ├── Profesor.java
    │   ├── Asignatura.java
    │   ├── Evaluacion.java
    │   ├── Evaluable.java
    ├── servicio/
    │   └── EscuelaService.java
    └── Main.java
```

---

## 🧬 Herencia y polimorfismo

### 🔸 Clase abstracta: `Persona`

```java
public abstract class Persona {
    protected String id;
    protected String nombre;
}
```

### 🔸 Subclases

- `Alumno extends Persona`
- `Profesor extends Persona implements Evaluable`

### 🔸 Interface: `Evaluable`

```java
public interface Evaluable {
    double evaluar(Alumno alumno, Asignatura asignatura);
}
```

---

## 📄 Archivos CSV

### `alumnos.csv`
```csv
id,nombre
A1,Laura Martínez
A2,Carlos Peña
A3,Ana Soto
```

### `profesores.csv`
```csv
id,nombre
P1,María Jiménez
P2,Ramón Díaz
```

### `asignaturas.csv`
```csv
codigo,nombre,profesor_id
MAT101,Matemáticas,P1
LIT202,Lengua,P2
```

### `evaluaciones.csv` (generado por el sistema)
```csv
alumno_id,asignatura_codigo,nota
A1,MAT101,8.5
A2,MAT101,6.0
A1,LIT202,9.0
```

---

## 🧠 Lógica especial: Evaluaciones polimórficas

Cada profesor evalúa de forma distinta:

- `ProfesorMatematicas`: nota aleatoria entre 5.0 y 10.0
- `ProfesorLengua`: nota proporcional a letras del nombre del alumno
- Otros: lógica basada en hora del día, letra inicial, etc.

Esto se consigue implementando distintos comportamientos en `evaluar(...)`.

---

## 🖥️ Flujo del programa

Sin menús. Al ejecutar:

```
🔍 Cargando datos...
✅ Generando evaluaciones...

📊 Resultados:
- Laura Martínez (MAT101): 8.5
- Carlos Peña (MAT101): 6.0
- Laura Martínez (LIT202): 9.0

📈 Promedios por alumno:
- Laura Martínez: 8.75
- Carlos Peña: 6.0
```

---

## 🚀 Funciones clave (`EscuelaService`)

- `cargarDatosDesdeCSV()`
- `generarEvaluaciones()`
- `mostrarResultados()`
- `guardarEvaluacionesCSV()`

---

## ✅ Qué se aprende

- Herencia y jerarquías en OOP
- Interfaces funcionales
- Polimorfismo real en lógica de negocio
- Manipulación de múltiples archivos CSV
- Simulación y generación dinámica de datos

---

## ⭐ Extras sugeridos

- Guardar gráficos en consola o JSON
- Ranking por curso
- Evaluaciones ponderadas por dificultad
