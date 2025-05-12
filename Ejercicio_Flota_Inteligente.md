
# 🏙️ Ejercicio Avanzado: Simulación de Flota Inteligente de Transporte Urbano

## 🧾 Descripción

Vas a desarrollar una aplicación que simule el comportamiento de una **flota de transporte urbano inteligente**, donde los vehículos (autobuses, tranvías y bicicletas eléctricas) reportan su estado y se evalúa su **nivel de eficiencia** con base en distintos criterios.

## 🎯 Requisitos funcionales

1. Definir una **superclase abstracta** `VehiculoInteligente` con atributos comunes y métodos compartidos.
2. Implementar múltiples interfaces:
   - `Mantenible` con `calcularCosteMantenimiento()`
   - `Eficiente` con `calcularEficiencia()`
   - `Reportable` con `generarReporte()`
3. Crear subclases:
   - `AutobusInteligente`
   - `TranviaInteligente`
   - `BicicletaElectricaInteligente`
4. Leer la información de vehículos desde varios CSV:
   - `vehiculos.csv`: información base
   - `uso.csv`: registros de uso (km recorridos, energía consumida)
   - `mantenimientos.csv`: historial de mantenimiento
5. Usar **polimorfismo** para procesar los objetos de forma unificada.
6. Generar un **reporte en consola** con:
   - Identificador del vehículo
   - Tipo
   - Eficiencia calculada
   - Estado de mantenimiento
   - Recomendación de renovación si la eficiencia está por debajo de un umbral.

## 🧬 Estructura sugerida

```
src/
├── modelo/
│   ├── VehiculoInteligente.java
│   ├── AutobusInteligente.java
│   ├── TranviaInteligente.java
│   ├── BicicletaElectricaInteligente.java
│   ├── interfaces/
│   │   ├── Mantenible.java
│   │   ├── Eficiente.java
│   │   └── Reportable.java
├── datos/
│   ├── CSVLoader.java
├── servicio/
│   └── SimuladorFlota.java
└── Main.java
```

## 📄 Archivos CSV esperados

### `vehiculos.csv`

```
tipo,id,marca,modelo,datoExtra
Autobus,AU01,Volvo,7700,50
Tranvia,TR10,CAF,Urbos,3
BicicletaElectrica,BI23,Xiaomi,M365,2
```

### `uso.csv`

```
id,kilometros,energiaConsumida
AU01,12000,8000
TR10,15000,12000
BI23,2500,400
```

### `mantenimientos.csv`

```
id,numMantenimientos,costeTotal
AU01,3,1500
TR10,2,2000
BI23,1,150
```

## 🧠 Lógica avanzada

- **Eficiencia** se calcula según el tipo:
  - Autobús: pasajeros/km / energía consumida
  - Tranvía: km/vagón / energía
  - Bicicleta: km / número de baterías / energía
- Si la eficiencia cae por debajo de cierto umbral (diferente por tipo), se sugiere renovación.
- `generarReporte()` debe devolver una cadena detallada que resuma el estado del vehículo.
- Usa estructuras como `Map<String, VehiculoInteligente>` para vincular datos por ID.

## ✨ Características especiales

- No hay menú: el programa simula automáticamente todo al iniciar.
- Usa múltiples archivos y relaciones entre ellos.
- Hay procesamiento de datos y toma de decisiones automática.
- El código debe ser **modular, extensible y orientado a objetos**.
