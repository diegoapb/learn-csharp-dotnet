#!/bin/bash

# Script para crear un nuevo proyecto en el repositorio de aprendizaje de C#
# Uso: ./scripts/create-project.sh <categoria> <nombre-proyecto>
# Ejemplo: ./scripts/create-project.sh 01-fundamentals 06-my-new-topic

# Colores para output
GREEN='\033[0;32m'
BLUE='\033[0;34m'
RED='\033[0;31m'
NC='\033[0m' # No Color

# Función para convertir kebab-case a PascalCase
to_pascal_case() {
    echo "$1" | sed -r 's/(^|-)([a-z0-9])/\U\2/g' | sed 's/-//g' | sed 's/^[0-9]*//'
}

# Verificar argumentos
if [ -z "$1" ] || [ -z "$2" ]; then
    echo -e "${RED}Error: Faltan argumentos${NC}"
    echo "Uso: ./scripts/create-project.sh <categoria> <nombre-proyecto>"
    echo ""
    echo "Categorías disponibles:"
    echo "  - 01-fundamentals"
    echo "  - 02-control-flow"
    echo "  - 03-oop"
    echo "  - 04-collections"
    echo "  - 05-error-handling"
    echo "  - 06-file-io"
    echo "  - 07-advanced"
    echo "  - 08-web-basics"
    echo "  - 09-databases"
    echo "  - projects"
    echo "  - exercises/beginner"
    echo "  - exercises/intermediate"
    echo "  - exercises/advanced"
    echo ""
    echo "Ejemplo:"
    echo "  ./scripts/create-project.sh 01-fundamentals 06-my-topic"
    exit 1
fi

CATEGORY=$1
PROJECT_NAME=$2

# Verificar que la categoría existe
if [ ! -d "$CATEGORY" ]; then
    echo -e "${RED}Error: La categoría '$CATEGORY' no existe${NC}"
    echo "Crea la carpeta primero con: mkdir -p $CATEGORY"
    exit 1
fi

# Crear el directorio del proyecto
PROJECT_PATH="$CATEGORY/$PROJECT_NAME"

if [ -d "$PROJECT_PATH" ]; then
    echo -e "${RED}Error: El proyecto '$PROJECT_PATH' ya existe${NC}"
    exit 1
fi

echo -e "${BLUE}Creando proyecto en: $PROJECT_PATH${NC}"
mkdir -p "$PROJECT_PATH"
cd "$PROJECT_PATH" || exit

# Convertir nombre a PascalCase para el proyecto .NET
PROJECT_PASCAL=$(to_pascal_case "$PROJECT_NAME")

echo -e "${BLUE}Creando proyecto .NET: $PROJECT_PASCAL${NC}"
dotnet new console -n "$PROJECT_PASCAL" --framework net9.0

# Crear un README básico
echo -e "${BLUE}Creando README.md${NC}"
cat > README.md << EOF
# $PROJECT_PASCAL

## 📝 Descripción

[Agregar descripción del proyecto]

## 🎯 Conceptos Aprendidos

- [Concepto 1]
- [Concepto 2]
- [Concepto 3]

## 🚀 Cómo Ejecutar

\`\`\`bash
dotnet run
\`\`\`

## 📚 Recursos

- [Enlace a documentación relevante]

## 📝 Notas

[Agregar notas adicionales]
EOF

echo -e "${GREEN}✅ Proyecto creado exitosamente!${NC}"
echo ""
echo -e "${GREEN}📁 Ubicación:${NC} $PROJECT_PATH"
echo -e "${GREEN}📦 Nombre del proyecto:${NC} $PROJECT_PASCAL"
echo ""
echo -e "${BLUE}Próximos pasos:${NC}"
echo "  1. cd $PROJECT_PATH"
echo "  2. code ."
echo "  3. Edita Program.cs"
echo "  4. dotnet run"
