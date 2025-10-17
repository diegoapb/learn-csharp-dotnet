// Laboratorio de Tipos de Datos en C#
// ejecuta el programa con: dotnet-script 02-tipos-de-datos/Program.cs

// Tipos de datos primitivos
int numeroEntero = 42; // Entero
double numeroDecimal = 3.14; // Decimal
char caracter = 'A'; // Carácter
bool esVerdadero = true; // Booleano

// Tipo de dato cadena
string mensaje = "Hola, Mundo!"; // Cadena de texto

// Mostrar los valores en la consola
Console.WriteLine("Número Entero: " + numeroEntero);
Console.WriteLine("Número Decimal: " + numeroDecimal);
Console.WriteLine("Carácter: " + caracter);
Console.WriteLine("Booleano: " + esVerdadero);
Console.WriteLine("Mensaje: " + mensaje);


// Tipos de datos compuestos
int[] arregloEnteros = { 1, 2, 3, 4, 5 }; // Arreglo de enteros
List<string> listaCadenas = new List<string> { "Manzana", "Banana", "Cereza" }; // Lista de listaCadenas
Dictionary<string, int> diccionarioEdades = new Dictionary<string, int>
{
    { "Alice", 30 },
    { "Bob", 25 },
    { "Charlie", 35 }
}; // Diccionario de edades
// Tuple<string, int> tuplaPersona = ("David", 28); // Tupla con nombre y edad

// Mostrar los valores compuestos en la consola
Console.WriteLine("Arreglo de Enteros: " + string.Join(", ", arregloEnteros));
Console.WriteLine("Lista de Cadenas: " + string.Join(", ", listaCadenas));
Console.WriteLine("Diccionario de Edades:");
foreach (var kvp in diccionarioEdades)
{
    Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
}
// Console.WriteLine("Tupla Persona: " + tuplaPersona.Item1 + ", " + tuplaPersona.Item2);

// Tipos de datos nulos
int? numeroNulo = null; // Entero que puede ser nulo
string cadenaNula = null; // Cadena que puede ser nula
Console.WriteLine("Número Nulo: " + (numeroNulo.HasValue ? numeroNulo.Value.ToString() : "null"));
Console.WriteLine("Cadena Nula: " + (cadenaNula ?? "null"));

// Tipos de datos personalizados

Persona persona = new("Eva", 22);
Console.WriteLine("Persona: " + persona);

// Errores Comunes con Tipos de Datos
Console.WriteLine("\n=== Errores Comunes ===\n");

// 1. División por cero con enteros
try
{
    int a = 10;
    int b = 0;
    int resultado = a / b;
    Console.WriteLine("Resultado: " + resultado);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("❌ Error 1 - División por cero: " + ex.Message);
    Console.WriteLine("   Razón: No se puede dividir un entero entre cero.\n");
}

// 2. Desbordamiento (Overflow)
try
{
    checked
    {
        int maxValor = int.MaxValue;
        int overflow = maxValor + 1; // Causa overflow
        Console.WriteLine("Valor: " + overflow);
    }
}
catch (OverflowException ex)
{
    Console.WriteLine("❌ Error 2 - Desbordamiento: " + ex.Message);
    Console.WriteLine($"   Razón: El valor supera el límite de int ({int.MaxValue}).\n");
}

// 3. Acceso a índice fuera de rango
try
{
    int[] numeros = { 1, 2, 3 };
    int valor = numeros[5]; // Índice no existe
    Console.WriteLine("Valor: " + valor);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("❌ Error 3 - Índice fuera de rango: " + ex.Message);
    Console.WriteLine("   Razón: El arreglo tiene 3 elementos (índices 0-2), no existe índice 5.\n");
}

// 4. Conversión inválida (casting)
try
{
    object obj = "Hola";
    int numero = (int)obj; // No se puede convertir string a int
    Console.WriteLine("Número: " + numero);
}
catch (InvalidCastException ex)
{
    Console.WriteLine("❌ Error 4 - Conversión inválida: " + ex.Message);
    Console.WriteLine("   Razón: No se puede convertir directamente un string a int.\n");
}

// 5. NullReferenceException
try
{
    string textoNulo = null;
    int longitud = textoNulo.Length; // Intenta acceder a propiedad de null
    Console.WriteLine("Longitud: " + longitud);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("❌ Error 5 - Referencia nula: " + ex.Message);
    Console.WriteLine("   Razón: Se intenta acceder a una propiedad de un objeto null.\n");
}

// 6. FormatException al parsear
try
{
    string texto = "abc123";
    int numero = int.Parse(texto); // No es un número válido
    Console.WriteLine("Número: " + numero);
}
catch (FormatException ex)
{
    Console.WriteLine("❌ Error 6 - Formato inválido: " + ex.Message);
    Console.WriteLine("   Razón: El texto 'abc123' no se puede convertir a int.\n");
}

// 7. Operación inválida con tipos nullables
try
{
    int? numeroNulable = null;
    int resultado = numeroNulable.Value; // Intenta obtener valor de null
    Console.WriteLine("Resultado: " + resultado);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine("❌ Error 7 - Operación inválida: " + ex.Message);
    Console.WriteLine("   Razón: No se puede obtener .Value de un nullable que es null.\n");
}

Console.WriteLine("=== Fin de ejemplos de errores ===");


class Persona(string nombre, int edad)
{
    public string Nombre { get; set; } = nombre;
    public int Edad { get; set; } = edad;

    public override string ToString()
    {
        return $"{Nombre}, {Edad} años";
    }
}
