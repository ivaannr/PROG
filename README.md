# 🧠 PROG - Tercer Trimestre

Subbranch que recopila ejercicios y proyectos desarrollados durante la tercera evaluación de la asignatura de Programación.

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

## ☕ Java  
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
public static void main(String[] args) {
    Animal miPerro = new Perro();
    miPerro.hacerSonido(); // Salida: ¡Guau!
}
```

---

## 🔷 C#  
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
static void main(string[] args) {
    ISaludable p = new Persona();
    p.Saludar(); // Salida: ¡Hola, mundo!
}
```

---
