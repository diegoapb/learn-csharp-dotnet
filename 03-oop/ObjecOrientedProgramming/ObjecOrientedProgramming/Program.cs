// Laboratorio de Programación Orientada a Objetos en C#
// Para ejecutar: cd 03-oop/ObjecOrientedProgramming/ObjecOrientedProgramming && dotnet run

using System;

// ==============================================================================
// 1. CLASES Y OBJETOS
// ==============================================================================
Console.WriteLine("=== 1. CLASES Y OBJETOS ===\n");

var persona1 = new Persona { Nombre = "Ana", Edad = 25 };
Console.WriteLine($"Persona: {persona1.Nombre}, Edad: {persona1.Edad}");

// ==============================================================================
// 2. PROPIEDADES Y MÉTODOS
// ==============================================================================
Console.WriteLine("\n=== 2. PROPIEDADES Y MÉTODOS ===\n");

var calc = new Calculadora();
Console.WriteLine($"Suma: 5 + 3 = {calc.Sumar(5, 3)}");
Console.WriteLine($"Multiplicación: 5 * 3 = {calc.Multiplicar(5, 3)}");

// ==============================================================================
// 3. CONSTRUCTORES
// ==============================================================================
Console.WriteLine("\n=== 3. CONSTRUCTORES ===\n");

var producto1 = new Producto();
var producto2 = new Producto("Laptop", 899.99m);

producto1.MostrarInfo();
producto2.MostrarInfo();

// ==============================================================================
// 4. ENCAPSULACIÓN
// ==============================================================================
Console.WriteLine("\n=== 4. ENCAPSULACIÓN ===\n");

var cuenta = new CuentaBancaria(1000);
cuenta.Depositar(500);
cuenta.Retirar(200);
Console.WriteLine($"Saldo actual: ${cuenta.Saldo}");

// ==============================================================================
// 5. HERENCIA
// ==============================================================================
Console.WriteLine("\n=== 5. HERENCIA ===\n");

Animal miPerro = new Perro("Rex");
Animal miGato = new Gato("Michi");

miPerro.HacerSonido();
miGato.HacerSonido();

// ==============================================================================
// 6. POLIMORFISMO
// ==============================================================================
Console.WriteLine("\n=== 6. POLIMORFISMO ===\n");

Figura[] figuras = { new Circulo(5), new Rectangulo(4, 6) };

foreach (var figura in figuras)
{
    Console.WriteLine($"Área: {figura.CalcularArea():F2}");
}

// ==============================================================================
// 7. ABSTRACCIÓN (Clases Abstractas e Interfaces)
// ==============================================================================
Console.WriteLine("\n=== 7. ABSTRACCIÓN ===\n");

Empleado emp1 = new EmpleadoTiempoCompleto("Carlos", 3000);
Empleado emp2 = new EmpleadoPorHoras("Lucía", 15, 160);

Console.WriteLine($"{emp1.Nombre} - Salario: ${emp1.CalcularSalario()}");
Console.WriteLine($"{emp2.Nombre} - Salario: ${emp2.CalcularSalario()}");

INotificable usuario = new Usuario("usuario@example.com");
usuario.EnviarNotificacion("Bienvenido al sistema OOP");

Console.WriteLine("\n=== FIN DEL LABORATORIO ===");

// ==============================================================================
// DEFINICIÓN DE CLASES
// ==============================================================================

// 1. Clase simple
class Persona
{
    public string Nombre { get; set; } = "";
    public int Edad { get; set; }
}

// 2. Clase con métodos
class Calculadora
{
    public int Sumar(int a, int b) => a + b;
    public int Multiplicar(int a, int b) => a * b;
}

// 3. Clase con constructores
class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    public Producto()
    {
        Nombre = "Sin nombre";
        Precio = 0;
    }

    public Producto(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Producto: {Nombre}, Precio: ${Precio}");
    }
}

// 4. Encapsulación
class CuentaBancaria
{
    private decimal saldo;

    public decimal Saldo
    {
        get { return saldo; }
        private set { saldo = value; }
    }

    public CuentaBancaria(decimal saldoInicial)
    {
        saldo = saldoInicial;
    }

    public void Depositar(decimal cantidad)
    {
        if (cantidad > 0)
        {
            saldo += cantidad;
            Console.WriteLine($"Depósito: ${cantidad}. Nuevo saldo: ${saldo}");
        }
    }

    public void Retirar(decimal cantidad)
    {
        if (cantidad > 0 && cantidad <= saldo)
        {
            saldo -= cantidad;
            Console.WriteLine($"Retiro: ${cantidad}. Nuevo saldo: ${saldo}");
        }
        else
        {
            Console.WriteLine("Fondos insuficientes o cantidad inválida.");
        }
    }
}

// 5. Herencia
class Animal
{
    public string Nombre { get; set; }

    public Animal(string nombre)
    {
        Nombre = nombre;
    }

    public virtual void HacerSonido()
    {
        Console.WriteLine($"{Nombre} hace un sonido.");
    }
}

class Perro : Animal
{
    public Perro(string nombre) : base(nombre) { }

    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} dice: ¡Guau!");
    }
}

class Gato : Animal
{
    public Gato(string nombre) : base(nombre) { }

    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} dice: ¡Miau!");
    }
}

// 6. Polimorfismo
class Figura
{
    public virtual double CalcularArea() => 0;
}

class Circulo : Figura
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }
}

class Rectangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Rectangulo(double baseRect, double altura)
    {
        Base = baseRect;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return Base * Altura;
    }
}

// 7. Abstracción
abstract class Empleado
{
    public string Nombre { get; set; }

    public Empleado(string nombre)
    {
        Nombre = nombre;
    }

    public abstract decimal CalcularSalario();
}

class EmpleadoTiempoCompleto : Empleado
{
    public decimal SalarioMensual { get; set; }

    public EmpleadoTiempoCompleto(string nombre, decimal salarioMensual) : base(nombre)
    {
        SalarioMensual = salarioMensual;
    }

    public override decimal CalcularSalario() => SalarioMensual;
}

class EmpleadoPorHoras : Empleado
{
    public decimal TarifaPorHora { get; set; }
    public int HorasTrabajadas { get; set; }

    public EmpleadoPorHoras(string nombre, decimal tarifa, int horas) : base(nombre)
    {
        TarifaPorHora = tarifa;
        HorasTrabajadas = horas;
    }

    public override decimal CalcularSalario() => TarifaPorHora * HorasTrabajadas;
}

interface INotificable
{
    void EnviarNotificacion(string mensaje);
}

class Usuario : INotificable
{
    public string Email { get; set; }

    public Usuario(string email)
    {
        Email = email;
    }

    public void EnviarNotificacion(string mensaje)
    {
        Console.WriteLine($"Email a {Email}: {mensaje}");
    }
}
