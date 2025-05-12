# Proyecto Java: Sistema de Gestión de Cursos Universitarios

## Objetivo
Desarrollar una aplicación que permita gestionar cursos universitarios, profesores, estudiantes e inscripciones. Este sistema pondrá en práctica herencia, polimorfismo, interfaces y manejo de ficheros.

---

## Requisitos

### 1. Herencia y Polimorfismo

Crea una jerarquía de personas:

- Clase abstracta `Persona` con:
  - `String nombre`
  - `String dni`
  - `int edad`
  - Método abstracto `String getTipo()`

- Subclases:
  - `Profesor`: añade `String departamento`, `double salario`
  - `Estudiante`: añade `String carrera`, `int anio`

Ambas deben sobrescribir `getTipo()` y un método `toString()` que describa la persona.

---

### 2. Interfaces

Crea una interfaz `Registrable` con métodos:

```java
String serializar();
void deserializar(String linea);
```

Haz que `Profesor` y `Estudiante` la implementen.

---

### 3. Gestión de Ficheros

Implementa una clase `GestorFichero` para:

- Guardar listas de personas (profesores y estudiantes) en un archivo de texto.
- Leer los archivos y reconstruir los objetos.

Formato por línea sugerido:

```text
Profesor;12345678A;Ana Torres;45;Matemáticas;3400.0
Estudiante;87654321B;Luis Pérez;20;Ingeniería;2
```

---

### 4. Inscripciones

Crea clases:

- `Curso` con: `String nombre`, `String codigo`, `Profesor profesor`, `List<Estudiante> estudiantes`
- Métodos para inscribir estudiantes y mostrar información del curso.

Una clase `Universidad` debe permitir:

- Crear cursos
- Asignar profesor
- Inscribir estudiantes
- Listar cursos y participantes

---

## Ejemplo de ejecución

```text
===== SISTEMA UNIVERSITARIO =====
1. Crear nuevo curso
2. Registrar profesor
3. Registrar estudiante
4. Inscribir estudiante en curso
5. Mostrar cursos y participantes
6. Guardar datos
7. Cargar datos
8. Salir
```

---

## Archivos sugeridos

- `Persona.java`
- `Profesor.java`
- `Estudiante.java`
- `Curso.java`
- `Registrable.java`
- `GestorFichero.java`
- `Universidad.java`
- `Main.java`

---

## Desafíos Opcionales

### 1. Verificación de Duplicados
- Impedir que un mismo estudiante se inscriba dos veces al mismo curso.

### 2. Persistencia avanzada
- Guardar cursos y sus inscripciones usando JSON o serialización binaria.

### 3. Notas y Evaluación
- Añadir notas a estudiantes por curso y calcular promedios.

### 4. Gestión de usuarios
- Añadir un sistema de login con perfiles de administrador, profesor y estudiante.

### 5. Interfaz gráfica
- Crear una interfaz con JavaFX o Swing para manejar todo el sistema visualmente.

---