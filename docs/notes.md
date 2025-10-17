# Introduccion

Este proyecto contiene los laboratorios y notaas trabajadas en el curso de platzi para dotnet

## Tipos de Datos en C#

### Tipos Numéricos

#### Enteros

| Tipo | Bits | Bytes | Descripción | Rango |
|------|------|-------|-------------|-------|
| `byte` | 8 | 1 | Entero sin signo de 8 bits | 0 a 255 |
| `sbyte` | 8 | 1 | Entero con signo de 8 bits | -128 a 127 |
| `short` | 16 | 2 | Entero con signo de 16 bits | -32,768 a 32,767 |
| `ushort` | 16 | 2 | Entero sin signo de 16 bits | 0 a 65,535 |
| `int` | 32 | 4 | Entero con signo de 32 bits | -2,147,483,648 a 2,147,483,647 |
| `uint` | 32 | 4 | Entero sin signo de 32 bits | 0 a 4,294,967,295 |
| `long` | 64 | 8 | Entero con signo de 64 bits | -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807 |
| `ulong` | 64 | 8 | Entero sin signo de 64 bits | 0 a 18,446,744,073,709,551,615 |

#### Punto Flotante (números con decimales)

| Tipo | Bits | Bytes | Descripción | Precisión |
|------|------|-------|-------------|-----------|
| `float` | 32 | 4 | Precisión simple | Aproximadamente 6-9 dígitos |
| `double` | 64 | 8 | Doble precisión | Aproximadamente 15-17 dígitos |

#### Decimal

| Tipo | Bits | Bytes | Descripción | Precisión |
|------|------|-------|-------------|-----------|
| `decimal` | 128 | 16 | Mayor precisión, ideal para cálculos financieros | 28-29 dígitos significativos |

### Otros Tipos Fundamentales

| Tipo | Bits | Bytes | Descripción |
|------|------|-------|-------------|
| `bool` | 8 | 1 | Almacena un valor verdadero (`true`) o falso (`false`) |
| `char` | 16 | 2 | Almacena un carácter Unicode de 16 bits |
| `string` | Variable | Variable | Representa una cadena de caracteres (texto) |
| `object` | Variable | Variable | Es el tipo base para todos los demás tipos en C# |

## Declaración de Variables

### Explícita vs Implícita

| Tipo | Sintaxis | Ejemplo | Descripción |
|------|----------|---------|-------------|
| **Explícita** | `tipo variable = valor;` | `int edad = 25;` | El tipo se declara explícitamente. Mayor claridad. |
| **Implícita** | `var variable = valor;` | `var edad = 25;` | El compilador infiere el tipo automáticamente. Más conciso. |

**Nota:** Con `var`, el tipo se determina en tiempo de compilación y no puede cambiar después.

