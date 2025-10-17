// See https://aka.ms/new-console-template for more information
// Para ejecutar usa el comando : 
// cd 01-fundamentals/03-operadores/Operadores && dotnet run && cd ../../..

using System;
Console.WriteLine("=== Operadores Aritméticos en C# ===\n");

Console.WriteLine("Ingresa el primer número (num1), o presiona Enter para usar el valor por defecto (8): ");
int num1 = Console.ReadLine() is string input1 && int.TryParse(input1, out int parsedNum1) ? parsedNum1 : 8;
Console.WriteLine("Ingresa el segundo número (num2), o presiona Enter para usar el valor por defecto (4): ");
int num2 = Console.ReadLine() is string input2 && int.TryParse(input2, out int parsedNum2) ? parsedNum2 : 4;

Console.WriteLine($"Números: num1 = {num1}, num2 = {num2}\n");
// Suma
int suma = num1 + num2;
Console.WriteLine($"Suma: {num1} + {num2} = {suma}");
// División
try
{
    int division = num1 / num2;
    Console.WriteLine($"División (int): {num1} / {num2} = {division}");
    float divisionFloat = (float)num1 / num2;
    Console.WriteLine($"División (float): {num1} / {num2} = {divisionFloat}");
    double divisionDouble = (double)num1 / num2;
    Console.WriteLine($"División (double): {num1} / {num2} = {divisionDouble}");
    decimal divisionDecimal = (decimal)num1 / num2;
    Console.WriteLine($"División (decimal): {num1} / {num2} = {divisionDecimal}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error: División por cero no permitida.");
}

// Resta
int resta = num1 - num2;
Console.WriteLine($"Resta: {num1} - {num2} = {resta}");
// Multiplicación
int multiplicacion = num1 * num2;
Console.WriteLine($"Multiplicación: {num1} * {num2} = {multiplicacion}");
// Módulo
try
{
    int modulo = num1 % num2;
    Console.WriteLine($"Módulo: {num1} % {num2} = {modulo}");
}
catch (DivideByZeroException)
{
    // Falla si se usa num2 = 0
    Console.WriteLine("Error: Módulo por cero no permitido.");
}

// Operador de incremento y decremento
int incremento = num1;
incremento++;
Console.WriteLine($"\nIncremento: num1++ = {incremento}");
float incrementoFloat = num1 + 0.03f;
incrementoFloat++;
Console.WriteLine($"Incremento (float): num1++ = {incrementoFloat}");
double incrementoDouble = num1 + 0.03;
incrementoDouble++;
Console.WriteLine($"Incremento (double): num1++ = {incrementoDouble}");
decimal incrementoDecimal = num1 + (decimal)0.03;
incrementoDecimal++;
Console.WriteLine($"Incremento (decimal): num1++ = {incrementoDecimal}");
int decremento = num2;
decremento--;
Console.WriteLine($"Decremento: num2-- = {decremento}");

// Operadores compuestos
int compuesto = num1;
compuesto += num2;
Console.WriteLine($"\nOperador compuesto (+=): num1 += num2 => {compuesto}");
compuesto -= num2;
Console.WriteLine($"Operador compuesto (-=): num1 -= num2 => {compuesto}");
compuesto *= num2;
Console.WriteLine($"Operador compuesto (*=): num1 *= num2 => {compuesto}");
try
{
    compuesto /= num2;
    Console.WriteLine($"Operador compuesto (/=): num1 /= num2 => {compuesto}");
    compuesto %= num2;
    Console.WriteLine($"Operador compuesto (%=): num1 %= num2 => {compuesto}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error: Operador compuesto por cero no permitido.");
}
Console.WriteLine("\n=== Fin de los Operadores Aritméticos ===");

// Operadores Logicos
Console.WriteLine("\n=== Operadores Lógicos en C# ===\n");

// Tablas de verdad para operadores lógicos básicos
bool[] boolValues = { true, false };
Console.WriteLine("Tabla de Verdad para AND (&&):");
Console.WriteLine("A\tB\tA && B");
foreach (var A in boolValues)
{
    foreach (var B in boolValues)
    {
        Console.WriteLine($"{A}\t{B}\t{A && B}");
    }
}

Console.WriteLine("\nTabla de Verdad para OR (||):");
Console.WriteLine("A\tB\tA || B");
foreach (var A in boolValues)
{
    foreach (var B in boolValues)
    {
        Console.WriteLine($"{A}\t{B}\t{A || B}");
    }
}
Console.WriteLine("\nTabla de Verdad para NOT (!):");
Console.WriteLine("A\t!A");
foreach (var A in boolValues)
{
    Console.WriteLine($"{A}\t{!A}");
}
Console.WriteLine("\n=== Fin de los Operadores Lógicos ===");

// Precedencia de Operadores

