# 🧠 PROG - Tercer Trimestre

Repositorio académico que recopila ejercicios y proyectos desarrollados durante la tercera evaluación de la asignatura de Programación. Incluye prácticas tanto en **Java** como en **C#**, centradas en el paradigma de programación orientada a objetos.

---

## 💻 Tecnologías utilizadas

![Java](https://img.shields.io/badge/Java-ED8B00?style=for-the-badge&logo=openjdk&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)

---

## 🧠 Temas abordados

- Programación orientada a objetos (POO)  
- Interfaces y clases abstractas  
- Herencia y polimorfismo  
- Encapsulamiento  
- Trabajo con ficheros  
- Acceso a datos

---

## ☕ Ejemplo clásico en Java  
![Java](https://img.shields.io/badge/Java-ED8B00?style=flat&logo=openjdk&logoColor=white)

```java
public class Animal {
    public void hacerSonido() {
        System.out.println("Sonido genérico de animal");
    }
}

public class Perro extends Animal {
    @Override
    public void hacerSonido() {
        System.out.println("¡Guau!");
    }
}

// Main
Animal miPerro = new Perro();
miPerro.hacerSonido(); // Salida: ¡Guau!
```

---

## 🔷 Ejemplo rápido en C#  
![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white)

```csharp
interface ISaludable {
    void Saludar();
}

class Persona : ISaludable {
    public void Saludar() {
        Console.WriteLine("¡Hola, mundo!");
    }
}

// Main
ISaludable p = new Persona();
p.Saludar(); // Salida: ¡Hola, mundo!
```

---

## 👨‍💻 Frase motivadora del trimestre

> “Primero no entendía nada...  
> Luego entendía un poco...  
> Ahora explico a los demás.  
> — Yo, después de POO”
