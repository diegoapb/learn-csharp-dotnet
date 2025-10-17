# 🔧 Scripts de Utilidad

Esta carpeta contiene scripts bash para automatizar tareas comunes en el repositorio de aprendizaje de C#.

---

## 📝 Scripts Disponibles

### 1. `create-project.sh` - Crear Nuevo Proyecto

Crea automáticamente un nuevo proyecto .NET con la estructura correcta.

**Uso:**
```bash
./scripts/create-project.sh <categoria> <nombre-proyecto>
```

**Ejemplos:**
```bash
# Crear proyecto en fundamentals
./scripts/create-project.sh 01-fundamentals 04-arrays

# Crear proyecto completo
./scripts/create-project.sh projects 01-calculadora

# Crear ejercicio
./scripts/create-project.sh exercises/beginner 01-fizzbuzz
```

**Lo que hace:**
- ✅ Verifica que la categoría exista
- ✅ Crea el directorio del proyecto
- ✅ Ejecuta `dotnet new console` con el nombre en PascalCase
- ✅ Genera un README.md con plantilla
- ✅ Muestra los próximos pasos

**Categorías válidas:**
- `01-fundamentals`
- `02-control-flow`
- `03-oop`
- `04-collections`
- `05-error-handling`
- `06-file-io`
- `07-advanced`
- `08-web-basics`
- `09-databases`
- `projects`
- `exercises/beginner`
- `exercises/intermediate`
- `exercises/advanced`

---

### 2. `list-projects.sh` - Listar Proyectos

Muestra todos los proyectos .NET en el repositorio organizados por categoría.

**Uso:**
```bash
./scripts/list-projects.sh
```

**Salida esperada:**
```
📚 Proyectos en el Repositorio

━━━ 01-fundamentals ━━━
  ✓ 01-hello-world (HelloWorld)
  ✓ 02-variables-types (VariablesTypes)
  ✓ 03-operators (Operators)

━━━ projects ━━━
  ✓ 01-calculator (Calculator)
  ✓ 02-todo-list (TodoList)

━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
Total de proyectos: 5
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
```

**Lo que hace:**
- ✅ Busca archivos `.csproj` en todas las carpetas
- ✅ Organiza por categorías
- ✅ Muestra el nombre del proyecto y el nombre .NET
- ✅ Cuenta el total de proyectos

---

### 3. `run-all.sh` - Ejecutar Proyectos

Ejecuta todos los proyectos o solo los de una categoría específica.

**Uso:**
```bash
# Ejecutar TODOS los proyectos
./scripts/run-all.sh

# Ejecutar solo una categoría
./scripts/run-all.sh 01-fundamentals
```

**Salida esperada:**
```
🚀 Ejecutando proyectos de C#

▶️  Ejecutando: 01-fundamentals/01-hello-world
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
Hello, World!
✅ Éxito

━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
📊 Resumen:
  Total:   3 proyectos
  Éxito:   3
  Fallados: 0
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
```

**Lo que hace:**
- ✅ Encuentra todos los proyectos con `.csproj`
- ✅ Ejecuta `dotnet run` en cada uno
- ✅ Muestra el output de cada proyecto
- ✅ Marca éxitos y fallos
- ✅ Genera un resumen final

**Casos de uso:**
- Verificar que todos los proyectos compilan
- Probar que no hay errores después de cambios globales
- Demostración rápida de todos los conceptos aprendidos

---

### 4. `clean-all.sh` - Limpiar Compilaciones

Elimina todas las carpetas `bin/` y `obj/` para liberar espacio en disco.

**Uso:**
```bash
./scripts/clean-all.sh
```

**Salida esperada:**
```
🧹 Limpiando archivos de compilación...

Eliminando carpetas bin/
  Eliminando: ./01-fundamentals/01-hello-world/bin
  Eliminando: ./01-fundamentals/02-variables/bin

Eliminando carpetas obj/
  Eliminando: ./01-fundamentals/01-hello-world/obj
  Eliminando: ./01-fundamentals/02-variables/obj

━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
✅ Limpieza completada
  Carpetas bin/ eliminadas: 2
  Carpetas obj/ eliminadas: 2
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
```

**Lo que hace:**
- ✅ Busca recursivamente todas las carpetas `bin/` y `obj/`
- ✅ Las elimina para liberar espacio
- ✅ Muestra un resumen de lo eliminado

**Cuándo usar:**
- Antes de hacer commit (los archivos compilados no deben subirse)
- Cuando el disco esté lleno
- Después de cambiar configuraciones del proyecto
- Para forzar una recompilación limpia

---

## 🎨 Convenciones de los Scripts

### Colores en la Terminal

Los scripts usan colores para mejorar la legibilidad:

- 🔵 **Azul (`BLUE`)**: Información general, títulos
- 🟢 **Verde (`GREEN`)**: Éxito, confirmaciones
- 🟡 **Amarillo (`YELLOW`)**: Advertencias, acciones en progreso
- 🔴 **Rojo (`RED`)**: Errores, fallos

### Códigos de Salida

- `0`: Éxito
- `1`: Error (categoría no existe, argumentos faltantes, etc.)

---

## 🔒 Permisos de Ejecución

Todos los scripts ya tienen permisos de ejecución. Si necesitas restablecerlos:

```bash
chmod +x scripts/*.sh
```

---

## 🛠️ Modificar los Scripts

Los scripts están diseñados para ser editables. Algunas personalizaciones comunes:

### Cambiar Categorías en `create-project.sh`

Edita la ayuda en línea 13-25 para agregar/quitar categorías.

### Cambiar Framework en `create-project.sh`

Modifica la línea 62:
```bash
dotnet new console -n "$PROJECT_PASCAL" --framework net9.0
```

Cambia `net9.0` a `net8.0`, `net7.0`, etc.

### Agregar Nuevas Plantillas de README

Edita las líneas 66-84 en `create-project.sh` para personalizar el README generado.

---

## 📋 Ejemplos de Flujo de Trabajo

### Crear un nuevo tema en fundamentals

```bash
# 1. Asegurar que la categoría existe
mkdir -p 01-fundamentals

# 2. Crear el proyecto
./scripts/create-project.sh 01-fundamentals 05-metodos

# 3. Entrar al proyecto
cd 01-fundamentals/05-metodos/Metodos

# 4. Editar el código
code Program.cs

# 5. Ejecutar
dotnet run
```

### Verificar que todos los proyectos funcionan

```bash
# 1. Limpiar compilaciones anteriores
./scripts/clean-all.sh

# 2. Ejecutar todos los proyectos
./scripts/run-all.sh

# 3. Revisar el resumen
```

### Preparar para commit

```bash
# 1. Listar proyectos
./scripts/list-projects.sh

# 2. Limpiar archivos compilados
./scripts/clean-all.sh

# 3. Hacer commit
git add .
git commit -m "Add new projects"
```

---

## 🐛 Solución de Problemas

### Error: "Permission denied"

```bash
chmod +x scripts/<nombre-script>.sh
```

### Error: "Category does not exist"

Crea la categoría primero:
```bash
mkdir -p <nombre-categoria>
```

### Los scripts no encuentran proyectos

Verifica que los proyectos tengan archivos `.csproj`:
```bash
find . -name "*.csproj"
```

---

## 💡 Consejos

1. **Usa tab completion**: Los nombres de scripts se completan con Tab
2. **Ejecuta desde la raíz**: Siempre ejecuta los scripts desde la raíz del repositorio
3. **Revisa la ayuda**: Ejecuta los scripts sin argumentos para ver la ayuda
4. **Personaliza**: No dudes en modificar los scripts según tus necesidades

---

## 📚 Más Información

- Ver [Guía de Scaffolding](../docs/scaffolding-guide.md) para la estructura completa del repositorio
- Ver [README principal](../readme.md) para la documentación general

---

¡Feliz automatización! 🎉
