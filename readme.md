# 🚀 Laboratorios de C# y .NET

Repositorio de aprendizaje de C# y .NET con laboratorios prácticos desde conceptos básicos hasta temas avanzados.

---

## 🐳 Inicio Rápido con Dev Container (Recomendado)

Este proyecto incluye un **Dev Container** con .NET 9.0 y todas las herramientas preconfiguradas.

### Requisitos

1. **[Docker Desktop](https://docs.docker.com/desktop/install/)** (Windows/Mac/Linux)
2. **[VS Code](https://code.visualstudio.com/)**
3. **Extensión**: `Dev Containers` para VS Code

### Pasos

1. Clona y abre el proyecto:
   ```bash
   git clone <url-del-repositorio>
   cd csharp-dotnet
   code .
   ```

2. Cuando VS Code muestre la notificación, haz clic en **"Reopen in Container"**
   - O presiona `F1` → `Dev Containers: Reopen in Container`

3. Espera a que el contenedor se construya (2-5 min la primera vez)

4. Verifica la instalación:
   ```bash
   dotnet --version  # Debe mostrar 9.0.x
   cd 01-hello-world
   dotnet run
   ```

### Extensiones Incluidas

- ✅ C# Dev Kit + C# Language Support
- ✅ .NET Runtime
- ✅ GitHub Copilot (requiere suscripción)
- ✅ ESLint

---

## 🔧 Alternativa: Instalación Local

Si no usas Dev Container, instala:

- **[.NET SDK 9.0](https://dotnet.microsoft.com/download)**
- **VS Code** con las extensiones: C# Dev Kit, C#, .NET Runtime

### 📜 Scripts Básicos de C# (Opcional)

Si quieres ejecutar scripts de C# sin crear un proyecto completo (archivos `.csx`), instala `dotnet-script`:

```bash
# Instalar dotnet-script globalmente
dotnet tool install -g dotnet-script
```

**Configurar el PATH:**

Después de instalar, agrega la ruta de las herramientas de .NET al PATH en tu `~/.bashrc`:

```bash
# Agregar herramientas de .NET al PATH
export PATH="$PATH:$HOME/.dotnet/tools"
```

Luego recarga la configuración:

```bash
source ~/.bashrc
```

**Uso:**
```bash
# Ejecutar un script .csx
dotnet script mi-script.csx

# O simplemente
dotnet-script mi-script.csx
```

**Ejemplo de script (`hello.csx`):**
```csharp
Console.WriteLine("¡Hola desde un script C#!");
var nombre = "Desarrollador";
Console.WriteLine($"Bienvenido, {nombre}");
```

> **💡 Nota**: Los laboratorios de este repositorio usan proyectos de consola estándar (`dotnet run`), no scripts `.csx`. Esta herramienta es útil para pruebas rápidas y experimentación.

---

### ¿Qué es un Dev Container?

Un Dev Container es un entorno de desarrollo completo que se ejecuta dentro de un contenedor Docker. Incluye:
- ✅ .NET SDK 8.0 preinstalado
- ✅ Todas las herramientas necesarias (Git, Node.js, etc.)
- ✅ Extensiones de VS Code configuradas
- ✅ Configuración de desarrollo lista para usar
- ✅ Entorno consistente para todos los desarrolladores

### 📦 Requisitos para Usar el Dev Container

Necesitas tener instalado en tu máquina:

1. **Docker Desktop**
   - **Windows**: [Docker Desktop para Windows](https://docs.docker.com/desktop/install/windows-install/)
   - **macOS**: [Docker Desktop para Mac](https://docs.docker.com/desktop/install/mac-install/)
   - **Linux**: [Docker Engine](https://docs.docker.com/engine/install/) o Docker Desktop

2. **Visual Studio Code**
   - Descarga desde: [https://code.visualstudio.com/](https://code.visualstudio.com/)

3. **Extensión Dev Containers para VS Code**
   - Instala desde el marketplace: `ms-vscode-remote.remote-containers`
   - O busca "Dev Containers" en las extensiones de VS Code

### � Cómo Lanzar el Dev Container

#### Opción 1: Abrir desde VS Code (Más Fácil)

1. **Clona el repositorio**:
   ```bash
   git clone <url-del-repositorio>
   ```

2. **Abre la carpeta en VS Code**:
   ```bash
   cd csharp-dotnet
   code .
   ```

3. **VS Code detectará el Dev Container automáticamente** y mostrará una notificación:
   ```
   📦 Folder contains a Dev Container configuration file.
   Reopen in Container
   ```

4. **Haz clic en "Reopen in Container"** (o "Reabrir en Contenedor")

5. **Espera a que el contenedor se construya** (solo la primera vez, puede tomar 2-5 minutos)

6. **¡Listo!** Ya estás dentro del Dev Container con todo configurado

#### Opción 2: Usando la Paleta de Comandos

1. Abre VS Code en la carpeta del proyecto

2. Presiona `F1` o `Ctrl+Shift+P` (Windows/Linux) / `Cmd+Shift+P` (Mac)

3. Escribe y selecciona:
   ```
   Dev Containers: Reopen in Container
   ```

4. Espera a que se construya el contenedor

#### Opción 3: Desde GitHub (Sin Clonar Primero)

Si tienes la extensión instalada, puedes:

1. Presiona `F1` en VS Code

2. Selecciona:
   ```
   Dev Containers: Clone Repository in Container Volume...
   ```

3. Pega la URL del repositorio

4. VS Code clonará y abrirá el proyecto en el contenedor automáticamente

### ✅ Verificar que el Dev Container Funciona

Una vez dentro del contenedor, abre una terminal en VS Code (`Ctrl+ñ` o `Terminal > New Terminal`) y ejecuta:

```bash
# Verificar versión de .NET
dotnet --version
# Debería mostrar: 9.0.x

# Ver información completa del SDK
dotnet --info

# Verificar Git
git --version

# Verificar Node.js
node --version

# Probar el primer laboratorio
cd 01-hello-world
dotnet run
# Debería mostrar: Hello, World!
```

**Salida esperada para `dotnet --version`:**
```
9.0.xxx
```

### 🔧 Características del Dev Container Incluido

Este Dev Container incluye:

#### 🖥️ Entorno Base
- **Sistema Operativo**: Debian GNU/Linux 12 (bookworm)
- **.NET SDK**: Versión **9.0** (última versión estable)
- **Imagen Base**: `mcr.microsoft.com/devcontainers/dotnet:1-9.0-bookworm`
- **Usuario**: Configurado como `root` para máximos permisos
- **Git**: Última versión compilada desde el código fuente
- **Node.js y npm**: Para desarrollo web y herramientas adicionales
- **Herramientas de línea de comandos**: curl, wget, tree, y más

#### 🔌 Extensiones de VS Code Preinstaladas

El Dev Container viene con las siguientes extensiones ya configuradas:

1. **ms-dotnettools.csdevkit** - C# Dev Kit
   - Suite completa de herramientas para desarrollo en C#
   - Incluye gestión de proyectos y soluciones
   - IntelliSense avanzado

2. **ms-dotnettools.csharp** - C#
   - Soporte del lenguaje C#
   - Depuración y ejecución de código
   - Resaltado de sintaxis

3. **ms-dotnettools.vscode-dotnet-runtime** - .NET Runtime
   - Gestión de runtimes de .NET
   - Instalación automática de SDKs necesarios

4. **GitHub.copilot** - GitHub Copilot
   - Asistente de IA para programación
   - Sugerencias de código inteligentes
   - Autocompletado con IA

5. **GitHub.copilot-chat** - GitHub Copilot Chat
   - Chat interactivo con IA
   - Explicaciones de código
   - Ayuda contextual para resolver problemas

6. **dbaeumer.vscode-eslint** - ESLint
   - Linter para JavaScript/TypeScript
   - Análisis de calidad de código
   - Formateo automático

### 🛠️ Problemas Comunes con Dev Containers

#### Docker Desktop no está ejecutándose

**Error**: `Cannot connect to the Docker daemon`

**Solución**:
- Asegúrate de que Docker Desktop esté ejecutándose
- En Windows/Mac: busca el ícono de Docker en la bandeja del sistema
- Reinicia Docker Desktop si es necesario

#### El contenedor tarda mucho en construirse

**Causa**: Es normal la primera vez (descarga de imágenes)

**Solución**:
- Ten paciencia (2-5 minutos la primera vez)
- Las siguientes veces será instantáneo
- Asegúrate de tener buena conexión a Internet

#### Error de permisos en Windows

**Error**: Problemas al montar volúmenes

**Solución**:
- Asegúrate de que Docker Desktop tenga permisos para acceder a tus carpetas
- Ve a: Docker Desktop > Settings > Resources > File Sharing
- Agrega la carpeta del proyecto

#### El contenedor se construye pero VS Code no responde

**Solución**:
```bash
# Reconstruir el contenedor completamente
# Presiona F1 y selecciona:
Dev Containers: Rebuild Container
```

### 🔄 Salir del Dev Container

Cuando termines de trabajar:

1. **Opción 1**: Cierra VS Code normalmente
   - El contenedor se detendrá automáticamente

2. **Opción 2**: Reabrir en tu máquina local
   - Presiona `F1`
   - Selecciona: `Dev Containers: Reopen Folder Locally`

3. **Opción 3**: Detener el contenedor manualmente
   ```bash
   # Desde tu terminal local (fuera del contenedor)
   docker ps  # Ver contenedores activos
   docker stop <container-id>
   ```

### 💡 Ventajas de Usar el Dev Container

- ✅ **No necesitas instalar nada**: .NET SDK ya está incluido
- ✅ **Entorno consistente**: Todos usan la misma configuración
- ✅ **Fácil de compartir**: Ideal para equipos y enseñanza
- ✅ **No ensucia tu máquina**: Todo está aislado en el contenedor
- ✅ **Multiplataforma**: Funciona igual en Windows, Mac y Linux
- ✅ **Actualizaciones fáciles**: Solo actualiza el archivo de configuración

---

## 🔧 Requisitos Previos

### Si NO Usas el Dev Container

Si prefieres trabajar directamente en tu máquina (sin Dev Container), necesitarás instalar:

- **.NET SDK 9.0 o superior**
  - Verifica tu instalación: `dotnet --version`
  - Descarga: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

- **Editor de Código** (elige uno):
  - Visual Studio Code (recomendado para principiantes)
  - Visual Studio 2022
  - JetBrains Rider

- **Extensiones Recomendadas para VS Code** (si no usas el Dev Container):
  - C# Dev Kit (`ms-dotnettools.csdevkit`)
  - C# (`ms-dotnettools.csharp`)
  - .NET Runtime (`ms-dotnettools.vscode-dotnet-runtime`)
  - IntelliCode (opcional pero recomendado)

> **💡 Recomendación**: Si eres principiante o quieres empezar rápidamente, usa el Dev Container. Es más fácil y evita problemas de configuración.

---

## � Laboratorios

### 01 - Hello World
```bash
cd 01-hello-world
dotnet run
```
Tu primer programa en C#. Aprende la estructura básica y `Console.WriteLine()`.

### 02 - Tipos de Datos
```bash
cd 02-tipos-de-datos
dotnet run
```
Variables, tipos numéricos, strings, conversiones y más.

---

## � Crear un Proyecto con .NET

### Tipos de Proyectos Comunes

```bash
# Ver todas las plantillas disponibles
dotnet new list

# Aplicación de consola (lo más común para aprender)
dotnet new console -n MiProyecto

# Aplicación web ASP.NET Core
dotnet new web -n MiWebApp

# API Web
dotnet new webapi -n MiAPI

# Biblioteca de clases
dotnet new classlib -n MiBiblioteca

# Aplicación Blazor (aplicaciones web interactivas)
dotnet new blazor -n MiAppBlazor
```

### Crear y Ejecutar un Proyecto Paso a Paso

```bash
# 1. Crear un nuevo proyecto de consola
dotnet new console -n 03-mi-primer-proyecto

# 2. Entrar al directorio del proyecto
cd 03-mi-primer-proyecto

# 3. Ejecutar el proyecto
dotnet run

# 4. Compilar sin ejecutar
dotnet build

# 5. Limpiar archivos compilados
dotnet clean

# 6. Ejecutar en modo watch (recarga automática al guardar)
dotnet watch run
```

### Estructura de un Proyecto

Después de crear un proyecto con `dotnet new console -n MiProyecto`, obtendrás:

```
MiProyecto/
├── Program.cs           # Archivo principal con el código
├── MiProyecto.csproj    # Archivo de configuración del proyecto
└── obj/                 # Archivos temporales de compilación (ignorar)
```

### Agregar Paquetes NuGet

```bash
# Buscar un paquete
dotnet search <nombre-paquete>

# Agregar un paquete al proyecto
dotnet add package Newtonsoft.Json

# Agregar una versión específica
dotnet add package Newtonsoft.Json --version 13.0.3

# Listar paquetes instalados
dotnet list package

# Eliminar un paquete
dotnet remove package Newtonsoft.Json
```

### Crear una Solución (Múltiples Proyectos)

```bash
# 1. Crear una solución
dotnet new sln -n MiSolucion

# 2. Crear proyectos
dotnet new console -n App
dotnet new classlib -n Biblioteca

# 3. Agregar proyectos a la solución
dotnet sln add App/App.csproj
dotnet sln add Biblioteca/Biblioteca.csproj

# 4. Compilar toda la solución
dotnet build

# 5. Ejecutar un proyecto específico
dotnet run --project App
```

---

## �🛠️ Comandos Útiles

```bash
# Ejecutar un laboratorio
dotnet run

# Compilar
dotnet build

# Modo watch (recarga automática)
dotnet watch run

# Limpiar archivos de compilación
dotnet clean

# Ver información del SDK instalado
dotnet --info

# Ver versión
dotnet --version

# Restaurar dependencias
dotnet restore

# Publicar aplicación para distribución
dotnet publish -c Release
```

---

## 📖 Recursos

- **Guía de estilo**: [`docs/csharp-coding-standards.md`](docs/csharp-coding-standards.md)
- **Documentación oficial**: [docs.microsoft.com/dotnet/csharp](https://docs.microsoft.com/es-es/dotnet/csharp/)
- **Microsoft Learn**: [learn.microsoft.com/training](https://learn.microsoft.com/es-es/training/paths/csharp-first-steps/)

---

## 📝 Info

- **C# Version**: 12.0
- **.NET**: 9.0
- **Última actualización**: Octubre 2025

---

¡Feliz codificación!
