# Operadores

## 📝 Descripción

Proyecto para aprender sobre los diferentes tipos de operadores en C#: aritméticos, lógicos, de comparación, de asignación, y más.

## 🎯 Conceptos Aprendidos

- Operadores aritméticos (+, -, *, /, %)
- Operadores de comparación (==, !=, <, >, <=, >=)
- Operadores lógicos (&&, ||, !)
- Operadores de asignación (=, +=, -=, *=, /=)
- Precedencia de operadores

## 🚀 Cómo Ejecutar

```bash
dotnet run
```

## 📚 Recursos

- [Enlace a documentación relevante]

## 📝 Notas

- Cuando se usa un double para almacenar el resultado de una division que da un numero periodico, el resultado se redondea al numero de decimales que soporte el tipo double. ejemplo: División (double): 10 / 3 = 3.3333333333333335 el ultimo decimal es un redondeo del 3. (5) esto es porque en memoria se almacena de forma binaria y no decimal, por lo que algunos numeros decimales no se pueden representar con exactitud.

- En el caso del operador modulo (%), si el divisor es 0, se lanza una excepción de tipo DivideByZeroException. Por lo tanto, es importante manejar este caso para evitar errores en tiempo de ejecución.

- Al usar los operadores de incremento (++) y decremento (--), se puede aplicar tanto a tipos enteros como a tipos de punto flotante (float, double, decimal). En el ejemplo se muestra cómo funcionan estos operadores con diferentes tipos numéricos.
## 🐞 Errores Comunes
- División por cero: Al intentar dividir un número por cero, se lanza una excepción DivideByZeroException.
- Uso incorrecto de tipos: Asegúrate de que los tipos de datos sean compatibles al realizar operaciones.