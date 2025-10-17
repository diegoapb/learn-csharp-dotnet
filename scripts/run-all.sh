#!/bin/bash

# Script para ejecutar todos los proyectos en el repositorio
# Uso: ./scripts/run-all.sh [categoria]

# Colores
GREEN='\033[0;32m'
BLUE='\033[0;34m'
RED='\033[0;31m'
YELLOW='\033[1;33m'
NC='\033[0m'

# Si se proporciona una categoría, solo ejecutar esa
CATEGORY=$1

echo -e "${BLUE}🚀 Ejecutando proyectos de C#${NC}"
echo ""

# Contador de proyectos
SUCCESS=0
FAILED=0
TOTAL=0

# Función para ejecutar un proyecto
run_project() {
    local project_dir=$1
    local csproj_file=$(find "$project_dir" -maxdepth 1 -name "*.csproj" | head -n 1)
    
    if [ -n "$csproj_file" ]; then
        TOTAL=$((TOTAL + 1))
        echo -e "${YELLOW}▶️  Ejecutando: $project_dir${NC}"
        echo "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"
        
        if (cd "$project_dir" && dotnet run); then
            SUCCESS=$((SUCCESS + 1))
            echo -e "${GREEN}✅ Éxito${NC}"
        else
            FAILED=$((FAILED + 1))
            echo -e "${RED}❌ Falló${NC}"
        fi
        
        echo ""
        echo ""
    fi
}

# Si se especifica una categoría
if [ -n "$CATEGORY" ]; then
    if [ ! -d "$CATEGORY" ]; then
        echo -e "${RED}Error: La categoría '$CATEGORY' no existe${NC}"
        exit 1
    fi
    
    echo -e "${BLUE}Ejecutando proyectos en: $CATEGORY${NC}"
    echo ""
    
    for project_dir in "$CATEGORY"/*/ ; do
        if [ -d "$project_dir" ]; then
            run_project "$project_dir"
        fi
    done
else
    # Ejecutar todos los proyectos
    echo -e "${BLUE}Ejecutando TODOS los proyectos${NC}"
    echo ""
    
    # Buscar en todas las categorías principales
    for category in 0*/ projects/; do
        if [ -d "$category" ]; then
            echo -e "${BLUE}━━━ Categoría: $category ━━━${NC}"
            for project_dir in "$category"*/ ; do
                if [ -d "$project_dir" ]; then
                    run_project "$project_dir"
                fi
            done
        fi
    done
fi

# Resumen
echo "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"
echo -e "${BLUE}📊 Resumen:${NC}"
echo -e "  Total:   $TOTAL proyectos"
echo -e "  ${GREEN}Éxito:   $SUCCESS${NC}"
echo -e "  ${RED}Fallados: $FAILED${NC}"
echo "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"
