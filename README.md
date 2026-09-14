# Calculadora API

**Taller 2 de Diseño de Sistemas de Información**  
API REST desarrollada en C# con ASP.NET Core que implementa las operaciones básicas de una calculadora, junto con pruebas unitarias, de integración y end-to-end.

---

## 1. Operaciones disponibles

| Operación | Endpoint | Método |
| :--- | :--- | :---: |
| **Suma** | `/api/Calculadora/sumar` | `POST` |
| **Resta** | `/api/Calculadora/restar` | `POST` |
| **Multiplicación** | `/api/Calculadora/multiplicar` | `POST` |
| **División** | `/api/Calculadora/dividir` | `POST` |

### Ejemplo de petición (JSON)
{
  "number1": 10,
  "number2": 5
}

### Ejemplo de respuesta exitosa
{
  "resultado": 15
}

### Respuesta en caso de división por cero
{
  "error": "No se puede dividir entre cero."
}

---

## 2. Estructura del proyecto

Calculadora/
├── CalculadoraAPI/                  → Proyecto Web API
│   ├── Controllers/
│   │   └── CalculadoraController.cs
│   ├── Models/
│   │   └── OperacionRequest.cs
│   ├── Services/
│   │   ├── ICalculadoraServicio.cs
│   │   └── CalculadoraServicio.cs
│   └── Program.cs
│
└── CalculadoraAPI_Test/             → Proyecto de pruebas unitarias
    └── CalculadoraServicioTests.cs

---

## 3. Tecnologías utilizadas

| Tecnología | Uso |
| :--- | :--- |
| **ASP.NET Core (.NET 10)** | Framework principal de la API |
| **xUnit** | Pruebas unitarias |
| **Swagger / Swashbuckle** | Documentación y prueba interactiva de la API |
| **SOAPUI** | Pruebas de integración |
| **SpecFlow / Serenity BDD** | Pruebas End-to-End (E2E) |

---

## 4. Cómo ejecutar el proyecto

### 4.1 Restaurar paquetes
dotnet restore

### 4.2 Ejecutar las pruebas unitarias
dotnet test

### 4.3 Ejecutar la API
cd CalculadoraAPI
dotnet run

Luego abre en tu navegador la URL: http://localhost:5000/swagger

---

## 5. Pruebas unitarias (xUnit)

Se implementaron y ejecutaron las siguientes pruebas:
* Suma de números positivos y negativos
* Resta de números positivos y negativos
* Multiplicación de números positivos y negativos
* División de números positivos y negativos
* División entre cero (debe lanzar excepción DivideByZeroException)

> **Resultado:** 9 pruebas ejecutadas — 9 correctas — 0 errores

---

## 6. Niveles de prueba del taller

| Nivel | Herramienta | Estado |
| :--- | :--- | :---: |
| **Pruebas unitarias** | xUnit | `Completado` |
| **Pruebas de integración** | SOAPUI | `Pendiente` |
| **Pruebas End-to-End** | SpecFlow / Serenity | `Pendiente` |

---
*Proyecto realizado como parte del Taller 2 de Diseño de Sistemas de Información.*
