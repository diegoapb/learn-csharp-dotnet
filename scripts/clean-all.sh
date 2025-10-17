#!/bin/bash

# Script para limpiar todos los archivos de compilación (bin/, obj/)
# Uso: ./scripts/clean-all.sh

# Colores
GREEN='\033[0;32m'
BLUE='\033[0;34m'
YELLOW='\033[1;33m'
NC='\033[0m'

echo -e "${BLUE}🧹 Limpiando archivos de compilación...${NC}"
echo ""

# Contador
BIN_COUNT=0
OBJ_COUNT=0

# Encontrar y eliminar carpetas bin/
echo -e "${YELLOW}Eliminando carpetas bin/${NC}"
while IFS= read -r -d '' dir; do
    echo "  Eliminando: $dir"
    rm -rf "$dir"
    BIN_COUNT=$((BIN_COUNT + 1))
done < <(find . -type d -name "bin" -print0)

# Encontrar y eliminar carpetas obj/
echo ""
echo -e "${YELLOW}Eliminando carpetas obj/${NC}"
while IFS= read -r -d '' dir; do
    echo "  Eliminando: $dir"
    rm -rf "$dir"
    OBJ_COUNT=$((OBJ_COUNT + 1))
done < <(find . -type d -name "obj" -print0)

# Resumen
echo ""
echo "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"
echo -e "${GREEN}✅ Limpieza completada${NC}"
echo "  Carpetas bin/ eliminadas: $BIN_COUNT"
echo "  Carpetas obj/ eliminadas: $OBJ_COUNT"
echo "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"
