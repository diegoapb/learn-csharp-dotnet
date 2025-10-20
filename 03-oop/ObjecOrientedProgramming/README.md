# ObjecOrientedProgramming

## 📝 Descripción

Introducción a la Programación Orientada a Objetos (OOP) en C#. Aprende a crear clases, objetos y aplicar los principios fundamentales de la OOP.

## 🎯 Conceptos Aprendidos

- **Clases y Objetos**: Definir plantillas y crear instancias
- **Propiedades y Métodos**: Encapsular datos y comportamientos
- **Constructores**: Inicializar objetos correctamente
- **Encapsulación**: Modificadores de acceso (public, private, protected)
- **Herencia**: Reutilizar código mediante clases base
- **Polimorfismo**: Sobrescritura de métodos (virtual, override)
- **Abstracción**: Clases abstractas e interfaces

## 🚀 Cómo Ejecutar

```bash
dotnet run
# Si estas en la raiz del proyecto usa:
cd 03-oop/ObjecOrientedProgramming/ObjecOrientedProgramming && dotnet run

```

## 📚 Recursos

- [Clases y Objetos en C#](https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/types/classes)
- [Herencia en C#](https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/object-oriented/inheritance)
- [Polimorfismo](https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/object-oriented/polymorphism)
- [Interfaces](https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/types/interfaces)

## 📝 Notas

**Diferencias clave:**
- **Clase abstracta**: Puede tener implementación parcial y un constructor
- **Interface**: Solo define el contrato (qué hacer, no cómo)
- **Virtual/Override**: Permite modificar el comportamiento en clases derivadas
- **Encapsulación**: Usar `private` para proteger datos internos
- **Polimorfismo** : Ejemplo :En un servicio de envio de mensajeria el mensaje tiene el metodo enviar(), pero dependiendo del tipo de mensaje (email, sms, push) el comportamiento de enviar() cambia y al mismo tiempo el comportamiento por proveedor (Gmail, Outlook, Twilio, Firebase) tambien puede cambiar.
  - Aqui estamos aplicando una patron de diseño llamado estrategia (Strategy Pattern) que nos permite definir una familia de algoritmos, encapsular cada uno de ellos y hacerlos intercambiables.
  - Tambien usamos un patron de diseño llamado fabrica (Factory Pattern) que nos permite crear objetos sin exponer la logica de creacion al cliente y referirnos a la nueva instancia usando una interfaz comun.
- **Abstracción**: Permite definir contratos claros y separar la implementación de la interfaz.
  