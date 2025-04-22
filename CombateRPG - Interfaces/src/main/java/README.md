# 🥊 Ejercicio: Sistema de Combate por Turnos en Java

## **Objetivo:**
***Crear un sistema de combate que permita luchar con diferentes tipos de personajes (Guerrero, Arquero, Mago) usando interfaces y polimorfismo.***

---

## 🧩 Requisitos:
```
1- Crea una interfaz Combatiente con:

    void atacar(Combatiente objetivo)

    void recibirDamage(double damage)

    String getNombre()

    double getSalud()

    String getTipo()

2- Implementa al menos tres clases que representen tipos de personajes:

    - Guerrero

    - Arquero

    - Mago

3- Cada clase debe tener atributos únicos como salud base, defensa, esquiva y daño base.

4- Crea una clase Arena que:

    - Permita crear dos personajes por consola.

    - Simule un combate por turnos hasta que uno de los personajes pierda toda su salud.

5- Usa polimorfismo para que cada personaje tenga un comportamiento diferente al atacar y defender, pero pueda ser tratado como un Combatiente.
```

---

## 💥 Detalles del combate

- **El jugador atacante inflige daño** usando una fórmula basada en su clase.
- **El jugador defensor puede esquivar** el golpe (probabilidad diferente por clase).
- Si no esquiva, **recibe daño reducido** por su defensa.
- El combate continúa por turnos hasta que un jugador queda con 0 o menos puntos de vida.

---

## 📊 Stats de cada clase

| Clase    | Salud     | Daño Base | Esquiva     | Defensa     |
|----------|-----------|-----------|-------------|-------------|
| Guerrero | Muy Alta  | Alta      | Muy Baja    | Alta        |
| Arquero  | Media     | Media     | Muy Alta    | Baja/Media  |
| Mago     | Baja      | Muy Alta  | Media       | Baja        |

---

## 🧪 Comportamiento esperado

```
Dime el nombre de tu personaje:
> Conan

Ahora dime qué clase quieres:
[1] Guerrero
[2] Arquero
[3] Mago
> 1

Guerrero creado correctamente con nombre Conan
```

Durante el combate:

```
Es el turno de Gandalf
El jugador Conan ha recibido 823 puntos de daño
quedándose con 677 puntos de vida.
```

---



