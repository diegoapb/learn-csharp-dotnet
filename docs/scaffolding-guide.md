# 📋 Guía de Scaffolding - Repositorio de Aprendizaje C#

## 🎯 Objetivo

Este documento explica la estructura organizativa recomendada para un repositorio de aprendizaje de C# que contenga múltiples proyectos independientes.

---

## 📁 Estructura Completa del Repositorio

```
learn-csharp-dotnet/
├── .gitignore                          # Archivos ignorados por Git
├── README.md                           # Documentación principal del repo
├── .devcontainer/                      # Dev Container (opcional pero recomendado)
│   └── devcontainer.json
│
├── docs/                               # 📚 Documentación centralizada
│   ├── notes.md                        # Notas de aprendizaje
│   ├── coding-standards.md             # Convenciones de código
│   ├── resources.md                    # Enlaces y recursos útiles
│   └── images/                         # Imágenes para documentación
│
├── 01-fundamentals/                    # 🔤 Fundamentos de C#
│   ├── 01-hello-world/
│   │   ├── Program.cs
│   │   └── HelloWorld.csproj
│   ├── 02-variables-types/
│   │   ├── Program.cs
│   │   └── VariablesTypes.csproj
│   ├── 03-operators/
│   ├── 04-strings/
│   └── 05-input-output/
│
├── 02-control-flow/                    # 🔀 Control de flujo
│   ├── 01-if-else/
│   ├── 02-switch/
│   ├── 03-for-loops/
│   ├── 04-while-loops/
│   └── 05-break-continue/
│
├── 03-oop/                             # 🏗️ Programación Orientada a Objetos
│   ├── 01-classes-objects/
│   ├── 02-constructors/
│   ├── 03-properties/
│   ├── 04-methods/
│   ├── 05-inheritance/
│   ├── 06-polymorphism/
│   ├── 07-abstraction/
│   ├── 08-interfaces/
│   └── 09-encapsulation/
│
├── 04-collections/                     # 📦 Colecciones y estructuras de datos
│   ├── 01-arrays/
│   ├── 02-lists/
│   ├── 03-dictionaries/
│   ├── 04-hashsets/
│   ├── 05-queues-stacks/
│   └── 06-linq-basics/
│
├── 05-error-handling/                  # ⚠️ Manejo de errores
│   ├── 01-try-catch/
│   ├── 02-custom-exceptions/
│   └── 03-finally-using/
│
├── 06-file-io/                         # 📄 Entrada/Salida de archivos
│   ├── 01-reading-files/
│   ├── 02-writing-files/
│   ├── 03-json-serialization/
│   └── 04-csv-processing/
│
├── 07-advanced/                        # 🚀 Temas avanzados
│   ├── 01-delegates/
│   ├── 02-events/
│   ├── 03-generics/
│   ├── 04-async-await/
│   ├── 05-linq-advanced/
│   ├── 06-reflection/
│   └── 07-attributes/
│
├── 08-web-basics/                      # 🌐 Desarrollo web
│   ├── 01-aspnet-minimal-api/
│   ├── 02-mvc-intro/
│   ├── 03-razor-pages/
│   └── 04-blazor-intro/
│
├── 09-databases/                       # 🗄️ Bases de datos
│   ├── 01-entity-framework-intro/
│   ├── 02-linq-to-entities/
│   └── 03-repository-pattern/
│
├── projects/                           # 💼 Proyectos completos
│   ├── 01-calculator-console/
│   │   ├── Program.cs
│   │   ├── Calculator.cs
│   │   ├── README.md
│   │   └── Calculator.csproj
│   ├── 02-todo-list-console/
│   ├── 03-contact-manager/
│   ├── 04-library-system/
│   ├── 05-expense-tracker/
│   └── 06-todo-api/
│
├── exercises/                          # 🏋️ Ejercicios y desafíos
│   ├── beginner/
│   │   ├── 01-fizzbuzz/
│   │   ├── 02-palindrome/
│   │   └── 03-fibonacci/
│   ├── intermediate/
│   │   ├── 01-banking-system/
│   │   └── 02-inventory-manager/
│   └── advanced/
│       ├── 01-chess-validator/
│       └── 02-regex-engine/
│
├── tests/                              # 🧪 Tests unitarios
│   ├── Fundamentals.Tests/
│   ├── OOP.Tests/
│   └── Projects.Tests/
│
└── scripts/                            # 🔧 Scripts de utilidad
    ├── create-project.sh               # Crear nuevo proyecto
    ├── run-all.sh                      # Ejecutar todos los proyectos
    └── clean-all.sh                    # Limpiar archivos compilados
```

---

## 🎨 Convenciones de Nomenclatura

### Carpetas

✅ **USAR:**
- `kebab-case` para nombres de carpetas: `01-hello-world`, `control-flow`
- Prefijos numéricos para orden: `01-`, `02-`, `03-`
- Nombres descriptivos en inglés

❌ **EVITAR:**
- PascalCase o camelCase en carpetas
- Espacios en nombres
- Caracteres especiales

### Archivos de Proyecto (.csproj)

✅ **USAR:**
- `PascalCase`: `HelloWorld.csproj`, `VariablesTypes.csproj`
- Coincidir con el nombre del directorio (sin prefijo numérico)

### Archivos de Código (.cs)

✅ **USAR:**
- `PascalCase`: `Program.cs`, `Calculator.cs`, `PersonService.cs`
- Nombres descriptivos y significativos

---

## 📝 Cada Carpeta de Proyecto Debe Contener

### Estructura Mínima

```
01-hello-world/
├── Program.cs              # Código principal
├── HelloWorld.csproj       # Archivo de proyecto
└── README.md               # (Opcional) Documentación específica
```

### Estructura Completa (Proyectos Grandes)

```
06-todo-api/
├── Controllers/            # Controladores (si es web)
├── Models/                 # Modelos de datos
├── Services/               # Lógica de negocio
├── Data/                   # Acceso a datos
├── Program.cs              # Punto de entrada
├── TodoApi.csproj          # Archivo de proyecto
├── appsettings.json        # Configuración
└── README.md               # Documentación del proyecto
```

---

## 🚀 Comandos para Crear la Estructura

### Crear Carpetas Base

```bash
# Crear estructura principal
mkdir -p docs/images
mkdir -p {01-fundamentals,02-control-flow,03-oop,04-collections,05-error-handling}
mkdir -p {06-file-io,07-advanced,08-web-basics,09-databases}
mkdir -p projects exercises/{beginner,intermediate,advanced}
mkdir -p tests scripts
```

### Crear un Nuevo Proyecto

```bash
# Ejemplo: Crear proyecto en fundamentals
cd 01-fundamentals
mkdir 06-new-topic
cd 06-new-topic
dotnet new console -n NewTopic
```

### Script Automatizado (create-project.sh)

```bash
#!/bin/bash
# Uso: ./scripts/create-project.sh 01-fundamentals 07-my-topic

CATEGORY=$1
PROJECT_NAME=$2

if [ -z "$CATEGORY" ] || [ -z "$PROJECT_NAME" ]; then
    echo "Uso: ./create-project.sh <categoria> <nombre-proyecto>"
    exit 1
fi

mkdir -p "$CATEGORY/$PROJECT_NAME"
cd "$CATEGORY/$PROJECT_NAME"

# Convertir nombre a PascalCase para el proyecto
PROJECT_PASCAL=$(echo "$PROJECT_NAME" | sed -r 's/(^|-)([a-z])/\U\2/g' | sed 's/-//g')

dotnet new console -n "$PROJECT_PASCAL"

echo "✅ Proyecto creado en: $CATEGORY/$PROJECT_NAME"
```

---

## 📚 Organización de Documentación

### /docs/notes.md
Notas de aprendizaje generales, conceptos clave, tablas de referencia.

### /docs/coding-standards.md
Convenciones de código, buenas prácticas, estándares del equipo.

### /docs/resources.md
Enlaces útiles, tutoriales, referencias de documentación oficial.

### README.md en Proyectos
Cada proyecto grande debe tener su propio README explicando:
- ¿Qué hace?
- ¿Cómo ejecutarlo?
- Conceptos aprendidos
- Dependencias especiales

---

## 🎯 Ventajas de esta Estructura

### ✅ Organización Clara
- Fácil navegación
- Progresión lógica de aprendizaje
- Separación de conceptos

### ✅ Múltiples Proyectos Independientes
- Cada carpeta tiene su `.csproj`
- No hay conflictos entre proyectos
- Fácil de ejecutar individualmente

### ✅ Escalable
- Fácil agregar nuevos temas
- Estructura flexible
- Crecimiento ordenado

### ✅ Documentación Centralizada
- Todo en `/docs`
- Fácil de encontrar
- Separado del código

### ✅ Ideal para Aprendizaje
- Temas ordenados por dificultad
- Ejercicios separados
- Proyectos completos como referencia

---

## 🔄 Flujo de Trabajo Recomendado

### 1. Aprender un Concepto
```bash
# Ir a la carpeta correspondiente
cd 01-fundamentals/02-variables-types

# Ejecutar y experimentar
dotnet run
```

### 2. Crear Ejercicios
```bash
# Crear ejercicio en la carpeta apropiada
cd exercises/beginner
mkdir 04-my-exercise
cd 04-my-exercise
dotnet new console -n MyExercise
```

### 3. Desarrollar Proyectos
```bash
# Proyectos completos van en /projects
cd projects
mkdir 07-my-app
cd 07-my-app
dotnet new console -n MyApp
```

### 4. Documentar Aprendizaje
- Actualizar `/docs/notes.md` con conceptos nuevos
- Agregar comentarios en el código
- Crear READMEs en proyectos complejos

---

## 🛠️ Herramientas Recomendadas

### VS Code Extensions
- C# Dev Kit
- C#
- .NET Runtime
- GitLens (para ver historial)
- TODO Highlight (para marcar TODOs)

### Scripts Útiles

**scripts/run-all.sh** - Ejecutar todos los proyectos
```bash
#!/bin/bash
for dir in */*/; do
    if [ -f "$dir"*.csproj ]; then
        echo "▶️  Ejecutando: $dir"
        (cd "$dir" && dotnet run)
    fi
done
```

**scripts/clean-all.sh** - Limpiar compilaciones
```bash
#!/bin/bash
find . -type d -name "bin" -o -name "obj" | xargs rm -rf
echo "✅ Archivos de compilación eliminados"
```

---

## 📋 Checklist para Nuevos Proyectos

- [ ] Crear carpeta con nombre descriptivo
- [ ] Ejecutar `dotnet new console -n ProjectName`
- [ ] Agregar comentarios explicativos en el código
- [ ] (Opcional) Crear README.md si es complejo
- [ ] Probar que compila: `dotnet build`
- [ ] Probar que ejecuta: `dotnet run`
- [ ] Hacer commit con mensaje descriptivo

---

## 🎓 Progresión de Aprendizaje Sugerida

1. **Fundamentos** (01-fundamentals) - 1-2 semanas
2. **Control de Flujo** (02-control-flow) - 1 semana
3. **POO** (03-oop) - 2-3 semanas
4. **Colecciones** (04-collections) - 1-2 semanas
5. **Manejo de Errores** (05-error-handling) - 1 semana
6. **Archivos** (06-file-io) - 1 semana
7. **Temas Avanzados** (07-advanced) - 2-3 semanas
8. **Web** (08-web-basics) - 3-4 semanas
9. **Bases de Datos** (09-databases) - 2-3 semanas

**Total estimado**: 3-4 meses de aprendizaje progresivo

---

## 💡 Consejos Finales

1. **Mantén el Orden**: Usa prefijos numéricos consistentemente
2. **Documenta Mientras Aprendes**: No dejes documentación para después
3. **Experimenta**: Crea variaciones de los ejercicios
4. **Commits Frecuentes**: Cada concepto nuevo = 1 commit
5. **README Actualizado**: Mantén el README principal al día
6. **No Te Saltes Fundamentos**: Asegúrate de dominar cada nivel antes de avanzar

---

¡Feliz aprendizaje! 🚀
