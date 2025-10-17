// See https://aka.ms/new-console-template for more information
// Para ejecutar usa el comando : 
// cd 02-control-flow/ControlFlow/ControlFlow && dotnet run && cd ../../..

using System;

Console.WriteLine("=== Control Flow en C# ===\n");

// ======================
// 1. IF-ELSE
// ======================
Console.WriteLine("=== 1. Estructuras IF-ELSE ===\n");

Console.WriteLine("Ingresa tu edad, o presiona Enter para usar el valor por defecto (25): ");
int edad = Console.ReadLine() is string inputEdad && int.TryParse(inputEdad, out int parsedEdad) ? parsedEdad : 25;

Console.WriteLine($"Edad ingresada: {edad}\n");

// If simple
if (edad >= 18)
{
    Console.WriteLine("✓ Eres mayor de edad");
}

// If-else
if (edad >= 65)
{
    Console.WriteLine("✓ Eres adulto mayor");
}
else
{
    Console.WriteLine("✓ No eres adulto mayor");
}

// If-else if-else
if (edad < 13)
{
    Console.WriteLine("Categoría: Niño");
}
else if (edad < 18)
{
    Console.WriteLine("Categoría: Adolescente");
}
else if (edad < 65)
{
    Console.WriteLine("Categoría: Adulto");
}
else
{
    Console.WriteLine("Categoría: Adulto Mayor");
}

// Operador ternario
Console.WriteLine("\n--- Operador Ternario ---");
string mensaje = edad >= 18 ? "Puede votar" : "No puede votar";
Console.WriteLine($"Estado electoral: {mensaje}");

// If anidado
Console.WriteLine("\n--- If Anidado (Calificaciones) ---");
Console.WriteLine("Ingresa tu puntuación (0-100), o presiona Enter para usar 85: ");
int puntuacion = Console.ReadLine() is string inputPunt && int.TryParse(inputPunt, out int parsedPunt) ? parsedPunt : 85;

if (puntuacion >= 0 && puntuacion <= 100)
{
    if (puntuacion >= 90)
    {
        Console.WriteLine($"Puntuación {puntuacion}: Excelente (A)");
    }
    else if (puntuacion >= 80)
    {
        Console.WriteLine($"Puntuación {puntuacion}: Muy Bien (B)");
    }
    else if (puntuacion >= 70)
    {
        Console.WriteLine($"Puntuación {puntuacion}: Bien (C)");
    }
    else if (puntuacion >= 60)
    {
        Console.WriteLine($"Puntuación {puntuacion}: Suficiente (D)");
    }
    else
    {
        Console.WriteLine($"Puntuación {puntuacion}: Insuficiente (F)");
    }
}
else
{
    Console.WriteLine("Puntuación inválida. Debe estar entre 0 y 100.");
}

Console.WriteLine("\n=== Fin de IF-ELSE ===");

// ======================
// 2. SWITCH
// ======================
Console.WriteLine("\n=== 2. Estructuras SWITCH ===\n");

Console.WriteLine("Ingresa un día de la semana (1-7), o presiona Enter para usar 3: ");
int dia = Console.ReadLine() is string inputDia && int.TryParse(inputDia, out int parsedDia) ? parsedDia : 3;

// Switch tradicional
Console.WriteLine("\n--- Switch Tradicional ---");
switch (dia)
{
    case 1:
        Console.WriteLine("Lunes - Inicio de semana");
        break;
    case 2:
        Console.WriteLine("Martes - Segundo día");
        break;
    case 3:
        Console.WriteLine("Miércoles - Mitad de semana");
        break;
    case 4:
        Console.WriteLine("Jueves - Casi viernes");
        break;
    case 5:
        Console.WriteLine("Viernes - Último día laboral");
        break;
    case 6:
        Console.WriteLine("Sábado - Fin de semana");
        break;
    case 7:
        Console.WriteLine("Domingo - Descanso");
        break;
    default:
        Console.WriteLine("Día inválido");
        break;
}

// Switch con múltiples casos
Console.WriteLine("\n--- Switch con Múltiples Casos ---");
Console.WriteLine("Tipo de día:");
switch (dia)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Día laboral");
        break;
    case 6:
    case 7:
        Console.WriteLine("Fin de semana");
        break;
    default:
        Console.WriteLine("Día no válido");
        break;
}

// Switch expression (C# 8.0+)
Console.WriteLine("\n--- Switch Expression (C# 8.0+) ---");
string tipoDia = dia switch
{
    1 or 2 or 3 or 4 or 5 => "Día laboral",
    6 or 7 => "Fin de semana",
    _ => "Día inválido"
};
Console.WriteLine($"Switch expression: {tipoDia}");

// Switch con strings
Console.WriteLine("\n--- Switch con Strings (Calculadora) ---");
Console.WriteLine("Ingresa una operación (suma, resta, multiplicacion, division), o presiona Enter para 'suma': ");
string operacion = Console.ReadLine() ?? "suma";
operacion = string.IsNullOrWhiteSpace(operacion) ? "suma" : operacion.ToLower();

int a = 10, b = 5;
Console.WriteLine($"\nOperandos: a = {a}, b = {b}");

switch (operacion)
{
    case "suma":
        Console.WriteLine($"Resultado: {a} + {b} = {a + b}");
        break;
    case "resta":
        Console.WriteLine($"Resultado: {a} - {b} = {a - b}");
        break;
    case "multiplicacion":
        Console.WriteLine($"Resultado: {a} * {b} = {a * b}");
        break;
    case "division":
        if (b != 0)
            Console.WriteLine($"Resultado: {a} / {b} = {a / b}");
        else
            Console.WriteLine("Error: División por cero");
        break;
    default:
        Console.WriteLine("Operación no reconocida");
        break;
}

Console.WriteLine("\n=== Fin de SWITCH ===");

// ======================
// 3. FOR LOOPS
// ======================
Console.WriteLine("\n=== 3. Bucles FOR ===\n");

// For básico
Console.WriteLine("--- For Básico ---");
Console.WriteLine("Conteo del 1 al 5:");
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"  Iteración {i}");
}

// For descendente
Console.WriteLine("\nConteo regresivo del 5 al 1:");
for (int i = 5; i >= 1; i--)
{
    Console.WriteLine($"  {i}...");
}
Console.WriteLine("  ¡Despegue! 🚀");

// For con incrementos diferentes
Console.WriteLine("\nNúmeros pares del 0 al 10:");
for (int i = 0; i <= 10; i += 2)
{
    Console.Write($"{i} ");
}
Console.WriteLine();

// For anidado - Tabla de multiplicar
Console.WriteLine("\nTabla de multiplicar del 1 al 3:");
for (int i = 1; i <= 3; i++)
{
    Console.WriteLine($"\nTabla del {i}:");
    for (int j = 1; j <= 5; j++)
    {
        Console.WriteLine($"  {i} x {j} = {i * j}");
    }
}

// For con arreglos
Console.WriteLine("\nIterando sobre un arreglo:");
string[] frutas = { "Manzana", "Banana", "Naranja", "Uva", "Fresa" };
Console.WriteLine($"Frutas disponibles (total: {frutas.Length}):");
for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine($"  {i + 1}. {frutas[i]}");
}

// Foreach
Console.WriteLine("\nUsando foreach:");
foreach (string fruta in frutas)
{
    Console.WriteLine($"  - {fruta}");
}

Console.WriteLine("\n=== Fin de FOR LOOPS ===");

// ======================
// 4. WHILE LOOPS
// ======================
Console.WriteLine("\n=== 4. Bucles WHILE ===\n");

// While básico
Console.WriteLine("While - Conteo del 1 al 5:");
int contador = 1;
while (contador <= 5)
{
    Console.WriteLine($"  Contador: {contador}");
    contador++;
}

// Do-While
Console.WriteLine("\nDo-While - Se ejecuta al menos una vez:");
int numero = 10;
do
{
    Console.WriteLine($"  Número: {numero}");
    numero--;
} while (numero > 5);

// While con condición compleja
Console.WriteLine("\nBúsqueda en arreglo:");
int[] numeros = { 5, 12, 8, 23, 15, 7, 19 };
int buscar = 23;
int indice = 0;
bool encontrado = false;

while (indice < numeros.Length && !encontrado)
{
    if (numeros[indice] == buscar)
    {
        encontrado = true;
        Console.WriteLine($"  ✓ Número {buscar} encontrado en la posición {indice}");
    }
    else
    {
        indice++;
    }
}

if (!encontrado)
{
    Console.WriteLine($"  ✗ Número {buscar} no encontrado");
}

// Simulación de un juego simple
Console.WriteLine("\nSimulación - Acumular puntos:");
int puntos = 0;
int ronda = 1;
Random random = new Random();

while (puntos < 50)
{
    int puntosGanados = random.Next(5, 16); // Entre 5 y 15 puntos
    puntos += puntosGanados;
    Console.WriteLine($"  Ronda {ronda}: +{puntosGanados} puntos (Total: {puntos})");
    ronda++;
}
Console.WriteLine($"  ¡Meta alcanzada en {ronda - 1} rondas!");

Console.WriteLine("\n=== Fin de WHILE LOOPS ===");

// ======================
// 5. BREAK y CONTINUE
// ======================
Console.WriteLine("\n=== 5. BREAK y CONTINUE ===\n");

// BREAK - Salir de un bucle
Console.WriteLine("BREAK - Buscar el primer número par mayor que 10:");
int[] numerosBreak = { 3, 7, 9, 12, 15, 18, 21 };
for (int i = 0; i < numerosBreak.Length; i++)
{
    Console.WriteLine($"  Revisando: {numerosBreak[i]}");
    if (numerosBreak[i] > 10 && numerosBreak[i] % 2 == 0)
    {
        Console.WriteLine($"  ✓ Encontrado: {numerosBreak[i]} - Saliendo del bucle");
        break;
    }
}

// CONTINUE - Saltar iteraciones
Console.WriteLine("\nCONTINUE - Mostrar solo números impares:");
int[] numerosContinue = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
for (int i = 0; i < numerosContinue.Length; i++)
{
    if (numerosContinue[i] % 2 == 0) // Si es par, saltar
    {
        continue;
    }
    Console.WriteLine($"  Número impar: {numerosContinue[i]}");
}

// BREAK en While
Console.WriteLine("\nBREAK en WHILE - Validación de entrada:");
int intentos = 0;
int maxIntentos = 5;
bool exitoso = false;

while (true)
{
    intentos++;
    Console.WriteLine($"  Intento {intentos} de {maxIntentos}");
    
    // Simulamos una validación aleatoria
    if (random.Next(0, 3) == 0) // 33% de probabilidad de éxito
    {
        Console.WriteLine("  ✓ Validación exitosa!");
        exitoso = true;
        break;
    }
    
    if (intentos >= maxIntentos)
    {
        Console.WriteLine("  ✗ Máximo de intentos alcanzado");
        break;
    }
}

Console.WriteLine($"  Resultado: {(exitoso ? "Éxito" : "Fallo")}");

// CONTINUE en bucles anidados
Console.WriteLine("\nCONTINUE en bucles anidados - Matriz sin diagonales:");
for (int fila = 1; fila <= 4; fila++)
{
    Console.Write($"  Fila {fila}: ");
    for (int col = 1; col <= 4; col++)
    {
        if (fila == col) // Saltar diagonal
        {
            continue;
        }
        Console.Write($"({fila},{col}) ");
    }
    Console.WriteLine();
}

// Combinación de BREAK y CONTINUE
Console.WriteLine("\nCombinación BREAK y CONTINUE - Procesar números:");
int[] numerosCombi = [-5, 3, -2, 8, 0, 12, -7, 15, 20, -3, 25];
int sumaPositivos = 0;
int procesados = 0;

for (int i = 0; i < numerosCombi.Length; i++)
{
    if (numerosCombi[i] < 0)
    {
        Console.WriteLine($"  Saltando número negativo: {numerosCombi[i]}");
        continue; // Saltar negativos
    }
    
    if (numerosCombi[i] == 0)
    {
        Console.WriteLine($"  Encontrado cero en posición {i} - Deteniendo");
        break; // Detener en cero
    }
    
    sumaPositivos += numerosCombi[i];
    procesados++;
    Console.WriteLine($"  Sumando: {numerosCombi[i]} (Suma acumulada: {sumaPositivos})");
}

Console.WriteLine($"  Total procesados: {procesados}, Suma: {sumaPositivos}");

Console.WriteLine("\n=== Fin de BREAK y CONTINUE ===");

// ======================
// EJERCICIO INTEGRADOR
// ======================
Console.WriteLine("\n=== EJERCICIO INTEGRADOR ===\n");
Console.WriteLine("Sistema de gestión de inventario simplificado\n");

string[] productos = { "Laptop", "Mouse", "Teclado", "Monitor", "Audífonos" };
int[] stock = { 5, 15, 8, 3, 12 };
double[] precios = { 800.00, 25.50, 45.99, 350.00, 89.99 };

bool salir = false;
int opcion = 0;

while (!salir)
{
    Console.WriteLine("\n--- MENÚ ---");
    Console.WriteLine("1. Ver inventario");
    Console.WriteLine("2. Buscar producto");
    Console.WriteLine("3. Productos con stock bajo");
    Console.WriteLine("4. Salir");
    Console.Write("Selecciona una opción (o presiona Enter para salir): ");
    
    string input = Console.ReadLine() ?? "";
    if (string.IsNullOrWhiteSpace(input))
    {
        opcion = 4;
    }
    else if (!int.TryParse(input, out opcion))
    {
        opcion = 0;
    }
    
    switch (opcion)
    {
        case 1:
            Console.WriteLine("\n--- INVENTARIO COMPLETO ---");
            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {productos[i],-15} Stock: {stock[i],-5} Precio: ${precios[i]:F2}");
            }
            break;
            
        case 2:
            Console.Write("\nIngresa el nombre del producto a buscar: ");
            string busqueda = Console.ReadLine()?.ToLower() ?? "";
            bool productoEncontrado = false;
            
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i].ToLower().Contains(busqueda))
                {
                    Console.WriteLine($"✓ Encontrado: {productos[i]} - Stock: {stock[i]} - Precio: ${precios[i]:F2}");
                    productoEncontrado = true;
                    break;
                }
            }
            
            if (!productoEncontrado)
            {
                Console.WriteLine("✗ Producto no encontrado");
            }
            break;
            
        case 3:
            Console.WriteLine("\n--- PRODUCTOS CON STOCK BAJO (< 10) ---");
            int contadorBajo = 0;
            
            for (int i = 0; i < productos.Length; i++)
            {
                if (stock[i] >= 10)
                {
                    continue; // Saltar productos con stock suficiente
                }
                
                Console.WriteLine($"⚠ {productos[i],-15} Stock: {stock[i]} unidades");
                contadorBajo++;
            }
            
            if (contadorBajo == 0)
            {
                Console.WriteLine("✓ Todos los productos tienen stock suficiente");
            }
            else
            {
                Console.WriteLine($"\nTotal de productos con stock bajo: {contadorBajo}");
            }
            break;
            
        case 4:
            Console.WriteLine("\n¡Gracias por usar el sistema!");
            salir = true;
            break;
            
        default:
            Console.WriteLine("\n✗ Opción inválida. Intenta de nuevo.");
            break;
    }
}

Console.WriteLine("\n=== FIN DEL PROGRAMA ===");
