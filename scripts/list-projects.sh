#!/bin/bash

# Script para listar todos los proyectos en el repositorio
# Uso: ./scripts/list-projects.sh

# Colores
GREEN='\033[0;32m'
BLUE='\033[0;34m'
CYAN='\033[0;36m'
YELLOW='\033[1;33m'
NC='\033[0m'

echo -e "${BLUE}📚 Proyectos en el Repositorio${NC}"
echo ""

# Contador
TOTAL=0

# Función para listar proyectos en una categoría
list_category() {
    local category=$1
    local has_projects=false
    
    # Verificar si hay proyectos en la categoría
    for project_dir in "$category"*/ ; do
        if [ -d "$project_dir" ]; then
            local csproj_file=$(find "$project_dir" -maxdepth 1 -name "*.csproj" | head -n 1)
            if [ -n "$csproj_file" ]; then
                has_projects=true
                break
            fi
        fi
    done
    
    # Si hay proyectos, mostrar la categoría
    if [ "$has_projects" = true ]; then
        echo -e "${CYAN}━━━ $(basename "$category") ━━━${NC}"
        
        for project_dir in "$category"*/ ; do
            if [ -d "$project_dir" ]; then
                local csproj_file=$(find "$project_dir" -maxdepth 1 -name "*.csproj" | head -n 1)
                
                if [ -n "$csproj_file" ]; then
                    TOTAL=$((TOTAL + 1))
                    local project_name=$(basename "$project_dir")
                    local csproj_name=$(basename "$csproj_file" .csproj)
                    
                    echo -e "  ${GREEN}✓${NC} $project_name ${YELLOW}($csproj_name)${NC}"
                fi
            fi
        done
        echo ""
    fi
}

# Listar categorías principales (01-, 02-, etc.)
for category in 0*/; do
    if [ -d "$category" ]; then
        list_category "$category"
    fi
done

# Listar proyectos
if [ -d "projects/" ]; then
    list_category "projects/"
fi

# Listar ejercicios
for difficulty in exercises/*/; do
    if [ -d "$difficulty" ]; then
        list_category "$difficulty"
    fi
done

# Resumen
echo "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"
echo -e "${BLUE}Total de proyectos: ${GREEN}$TOTAL${NC}"
echo "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"
