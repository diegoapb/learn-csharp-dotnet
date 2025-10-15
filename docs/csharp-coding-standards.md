# Guía de Estilo y Mejores Prácticas de C#

## Tabla de Contenidos
1. [Convenciones de Nomenclatura](#convenciones-de-nomenclatura)
2. [Formato y Estructura](#formato-y-estructura)
3. [Comentarios y Documentación](#comentarios-y-documentación)
4. [Principios de Diseño](#principios-de-diseño)
5. [Manejo de Errores](#manejo-de-errores)
6. [Buenas Prácticas Generales](#buenas-prácticas-generales)
7. [Características Modernas de C#](#características-modernas-de-c)

---

## Convenciones de Nomenclatura

### PascalCase
Usar **PascalCase** para:
- Clases
- Interfaces (prefijo `I`)
- Métodos
- Propiedades
- Enumeraciones
- Espacios de nombres
- Eventos

```csharp
public class CustomerManager
{
    public void ProcessOrder() { }
    public string CustomerName { get; set; }
}

public interface IRepository { }

public enum OrderStatus
{
    Pending,
    Processing,
    Completed
}
```

### camelCase
Usar **camelCase** para:
- Variables locales
- Parámetros de métodos
- Campos privados (con prefijo `_`)

```csharp
public class Product
{
    private readonly string _productCode;
    private int _quantity;

    public void UpdatePrice(decimal newPrice)
    {
        decimal oldPrice = Price;
        Price = newPrice;
    }
}
```

### Convenciones Específicas
- **Constantes**: UPPER_CASE o PascalCase
- **Booleanos**: Usar prefijos `Is`, `Has`, `Can`, `Should`
- **Interfaces**: Siempre comenzar con `I`

```csharp
public const int MAX_CONNECTIONS = 100;
public bool IsActive { get; set; }
public bool HasPermission { get; set; }
public interface IDataService { }
```

---

## Formato y Estructura

### Indentación y Espaciado
- Usar **4 espacios** para indentación (no tabs)
- Una línea en blanco entre métodos
- Espacios alrededor de operadores

```csharp
public class Example
{
    private int _value;

    public void Method1()
    {
        int result = _value + 10;
    }

    public void Method2()
    {
        // Código aquí
    }
}
```

### Llaves (Braces)
- Llaves en **nueva línea** (estilo Allman)
- Siempre usar llaves, incluso para bloques de una línea

```csharp
// ✅ CORRECTO
if (condition)
{
    DoSomething();
}

// ❌ EVITAR
if (condition)
    DoSomething();
```

### Orden de Miembros de Clase
```csharp
public class OrderedClass
{
    // 1. Campos constantes
    private const int MaxSize = 100;

    // 2. Campos estáticos
    private static int _instanceCount;

    // 3. Campos de instancia
    private readonly ILogger _logger;
    private string _name;

    // 4. Constructores
    public OrderedClass(ILogger logger)
    {
        _logger = logger;
    }

    // 5. Propiedades
    public string Name { get; set; }
    public int Id { get; private set; }

    // 6. Métodos públicos
    public void PublicMethod() { }

    // 7. Métodos privados
    private void PrivateMethod() { }

    // 8. Clases anidadas
    private class NestedClass { }
}
```

### Longitud de Línea
- Máximo **120-140 caracteres** por línea
- Dividir líneas largas de manera lógica

```csharp
// ✅ CORRECTO
var result = SomeMethod(
    parameter1,
    parameter2,
    parameter3);

// Para LINQ
var query = customers
    .Where(c => c.IsActive)
    .OrderBy(c => c.Name)
    .Select(c => c.Id);
```

---

## Comentarios y Documentación

### XML Documentation Comments
Usar comentarios XML para APIs públicas:

```csharp
/// <summary>
/// Procesa un pedido y actualiza el inventario.
/// </summary>
/// <param name="orderId">El ID único del pedido.</param>
/// <param name="quantity">La cantidad de items a procesar.</param>
/// <returns>True si el procesamiento fue exitoso; de lo contrario, false.</returns>
/// <exception cref="ArgumentException">Se lanza cuando orderId es inválido.</exception>
public bool ProcessOrder(int orderId, int quantity)
{
    // Implementación
    return true;
}
```

### Comentarios de Código
- Explicar **por qué**, no **qué**
- Mantener comentarios actualizados
- Evitar comentarios obvios

```csharp
// ❌ EVITAR - comentario obvio
// Incrementa el contador
counter++;

// ✅ MEJOR - explica el por qué
// Incrementamos el contador aquí porque el API externa requiere
// que trackeemos el número de reintentos para límite de rate
counter++;
```

---

## Principios de Diseño

### SOLID Principles

#### 1. Single Responsibility Principle (SRP)
Cada clase debe tener una única responsabilidad:

```csharp
// ❌ EVITAR - múltiples responsabilidades
public class User
{
    public void SaveToDatabase() { }
    public void SendEmail() { }
    public void GenerateReport() { }
}

// ✅ CORRECTO - responsabilidades separadas
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
}

public class UserRepository
{
    public void Save(User user) { }
}

public class EmailService
{
    public void SendWelcomeEmail(User user) { }
}
```

#### 2. Open/Closed Principle
Abierto para extensión, cerrado para modificación:

```csharp
// ✅ Usar abstracción e interfaces
public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

public class CreditCardProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount) { }
}

public class PayPalProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount) { }
}
```

#### 3. Dependency Injection
Inyectar dependencias en lugar de crearlas:

```csharp
// ❌ EVITAR
public class OrderService
{
    private readonly EmailService _emailService = new EmailService();
}

// ✅ CORRECTO
public class OrderService
{
    private readonly IEmailService _emailService;

    public OrderService(IEmailService emailService)
    {
        _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
    }
}
```

---

## Manejo de Errores

### Excepciones Específicas
```csharp
// ❌ EVITAR - captura genérica
try
{
    ProcessData();
}
catch (Exception ex)
{
    // Manejo genérico
}

// ✅ CORRECTO - excepciones específicas
try
{
    ProcessData();
}
catch (FileNotFoundException ex)
{
    _logger.LogError(ex, "Archivo no encontrado");
    throw;
}
catch (UnauthorizedAccessException ex)
{
    _logger.LogError(ex, "Acceso denegado");
    throw new SecurityException("No tiene permisos", ex);
}
```

### Validación de Argumentos
```csharp
public class CustomerService
{
    public void CreateCustomer(string name, string email)
    {
        // Validación temprana
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("El nombre no puede estar vacío", nameof(name));

        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("El email no puede estar vacío", nameof(email));

        // Lógica de negocio
    }

    // C# 10+ - ArgumentNullException.ThrowIfNull
    public void ProcessOrder(Order order)
    {
        ArgumentNullException.ThrowIfNull(order);
        // Continuar con la lógica
    }
}
```

### Using Statement para Recursos
```csharp
// ✅ CORRECTO - Liberación automática de recursos
using (var connection = new SqlConnection(connectionString))
{
    connection.Open();
    // Usar conexión
} // Se cierra automáticamente

// C# 8+ - Using declaration
using var fileStream = new FileStream("file.txt", FileMode.Open);
// Se libera al final del scope
```

---

## Buenas Prácticas Generales

### 1. Usar Propiedades en lugar de Campos Públicos
```csharp
// ❌ EVITAR
public class Product
{
    public string Name;
}

// ✅ CORRECTO
public class Product
{
    public string Name { get; set; }

    // Aún mejor con validación
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }
}
```

### 2. Inmutabilidad cuando sea Posible
```csharp
// ✅ Objetos inmutables son más seguros
public class Point
{
    public int X { get; init; }
    public int Y { get; init; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

// C# 9+ Records para DTOs
public record Customer(string Name, string Email);
```

### 3. Preferir Tipos de Valor Nullable Explícitos
```csharp
// ✅ CORRECTO
public int? GetOptionalValue()
{
    return null;
}

// Manejo seguro de nullables
int? value = GetOptionalValue();
int result = value ?? 0; // Operador de fusión nula
int result2 = value.GetValueOrDefault();
```

### 4. String Interpolation
```csharp
string name = "Juan";
int age = 30;

// ❌ EVITAR concatenación
string message = "Hola, " + name + ". Tienes " + age + " años.";

// ✅ CORRECTO - interpolación
string message = $"Hola, {name}. Tienes {age} años.";

// Para formato
string formatted = $"Precio: {price:C2}";
```

### 5. Usar var con Criterio
```csharp
// ✅ CORRECTO - tipo obvio
var customers = new List<Customer>();
var name = "John Doe";

// ❌ EVITAR - tipo no obvio
var result = GetData();

// ✅ MEJOR
Customer result = GetData();
```

### 6. Async/Await para Operaciones Asíncronas
```csharp
// ✅ Métodos asíncronos con sufijo Async
public async Task<Customer> GetCustomerAsync(int id)
{
    var customer = await _repository.FindAsync(id);
    return customer;
}

// Evitar async void excepto para event handlers
public async void Button_Click(object sender, EventArgs e)
{
    await ProcessAsync();
}
```

### 7. LINQ para Consultas
```csharp
// ✅ LINQ es más expresivo y legible
var activeCustomers = customers
    .Where(c => c.IsActive)
    .OrderBy(c => c.Name)
    .Select(c => new CustomerDto
    {
        Name = c.Name,
        Email = c.Email
    })
    .ToList();
```

### 8. Evitar Números Mágicos
```csharp
// ❌ EVITAR
if (status == 1)
{
    ProcessOrder();
}

// ✅ CORRECTO
private const int STATUS_PENDING = 1;

if (status == STATUS_PENDING)
{
    ProcessOrder();
}

// ✅ MEJOR - usar enum
public enum OrderStatus
{
    Pending = 1,
    Processing = 2,
    Completed = 3
}

if (status == OrderStatus.Pending)
{
    ProcessOrder();
}
```

---

## Características Modernas de C#

### C# 8.0+

#### Nullable Reference Types
```csharp
#nullable enable

public class Customer
{
    // No nullable
    public string Name { get; set; } = string.Empty;

    // Nullable explícito
    public string? MiddleName { get; set; }

    public void Process(string value, string? optionalValue)
    {
        Console.WriteLine(value.Length); // Seguro
        Console.WriteLine(optionalValue?.Length ?? 0); // Necesita verificación
    }
}
```

#### Pattern Matching
```csharp
public string GetDiscount(object customer) => customer switch
{
    VIPCustomer vip => $"VIP discount: {vip.DiscountRate}%",
    RegularCustomer regular when regular.YearsActive > 5 => "Loyalty discount: 10%",
    RegularCustomer => "Standard discount: 5%",
    _ => "No discount"
};

// Switch expressions
var result = value switch
{
    < 0 => "Negativo",
    0 => "Cero",
    > 0 and < 10 => "Pequeño",
    >= 10 => "Grande"
};
```

#### Using Declarations
```csharp
public void ProcessFile()
{
    using var file = File.OpenRead("data.txt");
    // Usar archivo
    // Se libera automáticamente al final del método
}
```

### C# 9.0+

#### Records
```csharp
// Record para DTOs inmutables
public record CustomerDto(int Id, string Name, string Email);

// Record con validación
public record Product
{
    public string Name { get; init; }
    public decimal Price { get; init; }

    public Product(string name, decimal price)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Price = price >= 0 ? price : throw new ArgumentException("Price must be positive");
    }
}
```

#### Init-only Properties
```csharp
public class Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
}

var person = new Person
{
    FirstName = "John",
    LastName = "Doe"
};
// person.FirstName = "Jane"; // Error de compilación
```

#### Top-level Statements
```csharp
// Program.cs
using System;

Console.WriteLine("Hello, World!");
ProcessData();

void ProcessData()
{
    // Lógica aquí
}
```

### C# 10.0+

#### Global Usings
```csharp
// GlobalUsings.cs
global using System;
global using System.Collections.Generic;
global using System.Linq;
global using Microsoft.Extensions.Logging;
```

#### File-scoped Namespaces
```csharp
namespace MyApp.Services;

public class CustomerService
{
    // Todo el archivo está en el namespace
}
```

#### Constant Interpolated Strings
```csharp
const string BaseUrl = "https://api.example.com";
const string Endpoint = $"{BaseUrl}/customers";
```

### C# 11.0+

#### Raw String Literals
```csharp
string json = """
    {
        "name": "John",
        "age": 30,
        "email": "john@example.com"
    }
    """;
```

#### List Patterns
```csharp
int[] numbers = { 1, 2, 3, 4 };

if (numbers is [1, 2, .., 4])
{
    Console.WriteLine("Starts with 1, 2 and ends with 4");
}
```

### C# 12.0+

#### Primary Constructors
```csharp
public class CustomerService(ILogger<CustomerService> logger, IRepository repository)
{
    public void Process()
    {
        logger.LogInformation("Processing...");
        repository.Save();
    }
}
```

#### Collection Expressions
```csharp
// Sintaxis simplificada para colecciones
int[] numbers = [1, 2, 3, 4, 5];
List<string> names = ["Alice", "Bob", "Charlie"];

// Spread operator
int[] moreNumbers = [..numbers, 6, 7, 8];
```

---

## Patrones de Diseño Comunes

### Repository Pattern
```csharp
public interface IRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
}

public class CustomerRepository : IRepository<Customer>
{
    private readonly DbContext _context;

    public CustomerRepository(DbContext context)
    {
        _context = context;
    }

    public async Task<Customer> GetByIdAsync(int id)
    {
        return await _context.Set<Customer>().FindAsync(id);
    }

    // Implementar otros métodos...
}
```

### Unit of Work Pattern
```csharp
public interface IUnitOfWork : IDisposable
{
    ICustomerRepository Customers { get; }
    IOrderRepository Orders { get; }
    Task<int> SaveChangesAsync();
}
```

### Builder Pattern
```csharp
public class EmailBuilder
{
    private string _to;
    private string _subject;
    private string _body;

    public EmailBuilder To(string email)
    {
        _to = email;
        return this;
    }

    public EmailBuilder WithSubject(string subject)
    {
        _subject = subject;
        return this;
    }

    public EmailBuilder WithBody(string body)
    {
        _body = body;
        return this;
    }

    public Email Build()
    {
        return new Email(_to, _subject, _body);
    }
}

// Uso
var email = new EmailBuilder()
    .To("user@example.com")
    .WithSubject("Welcome")
    .WithBody("Welcome to our service!")
    .Build();
```

---

## Testing

### Convenciones de Nombrado para Tests
```csharp
// Patrón: MethodName_Scenario_ExpectedBehavior
[Fact]
public void GetCustomer_ValidId_ReturnsCustomer()
{
    // Arrange
    var repository = new Mock<ICustomerRepository>();
    var service = new CustomerService(repository.Object);

    // Act
    var result = service.GetCustomer(1);

    // Assert
    Assert.NotNull(result);
}

[Theory]
[InlineData(0)]
[InlineData(-1)]
public void GetCustomer_InvalidId_ThrowsException(int id)
{
    // Test implementation
}
```

---

## Configuración Recomendada

### .editorconfig
```ini
# Nivel superior
root = true

# Archivos C#
[*.cs]
indent_style = space
indent_size = 4
end_of_line = crlf
charset = utf-8
trim_trailing_whitespace = true
insert_final_newline = true

# Organizar usings
dotnet_sort_system_directives_first = true
dotnet_separate_import_directive_groups = false

# Preferencias de estilo
csharp_prefer_braces = true:warning
csharp_prefer_simple_using_statement = true:suggestion

# Naming conventions
dotnet_naming_rule.private_fields_rule.symbols = private_fields
dotnet_naming_rule.private_fields_rule.style = underscore_camelcase
dotnet_naming_rule.private_fields_rule.severity = warning

dotnet_naming_symbols.private_fields.applicable_kinds = field
dotnet_naming_symbols.private_fields.applicable_accessibilities = private

dotnet_naming_style.underscore_camelcase.capitalization = camel_case
dotnet_naming_style.underscore_camelcase.required_prefix = _
```

---

## Recursos Adicionales

### Documentación Oficial
- [C# Coding Conventions (Microsoft)](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- [Framework Design Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/)
- [C# Language Reference](https://docs.microsoft.com/en-us/dotnet/csharp/)

### Herramientas
- **StyleCop**: Análisis de estilo de código
- **Roslyn Analyzers**: Análisis de código en tiempo de compilación
- **SonarQube**: Análisis de calidad de código
- **ReSharper**: Refactoring y análisis de código

### Libros Recomendados
- "C# in Depth" - Jon Skeet
- "Clean Code" - Robert C. Martin
- "Design Patterns: Elements of Reusable Object-Oriented Software" - Gang of Four
- "Effective C#" - Bill Wagner

---

## Resumen de Puntos Clave

✅ **Usar convenciones de nomenclatura consistentes** (PascalCase, camelCase)  
✅ **Aplicar principios SOLID**  
✅ **Preferir inmutabilidad cuando sea posible**  
✅ **Usar características modernas de C#** (records, pattern matching, nullable reference types)  
✅ **Escribir código autodocumentado con nombres descriptivos**  
✅ **Implementar manejo robusto de errores**  
✅ **Usar async/await para operaciones asíncronas**  
✅ **Aplicar dependency injection**  
✅ **Escribir pruebas unitarias**  
✅ **Mantener métodos pequeños y enfocados**  

---

**Fecha de creación**: Octubre 2025  
**Versión de C#**: 12.0  
**Framework**: .NET 8.0+
