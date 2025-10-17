# Hola Mundo en ASP.NET Core

Una aplicación web API REST básica implementada con ASP.NET Core 8.0 que demuestra los conceptos fundamentales de una API web moderna.

## 📋 Requisitos del Sistema

- **.NET 8.0 SDK** o superior
- **Windows 10/11**, **macOS 10.15+**, o **Linux** (Ubuntu 18.04+)
- **Visual Studio 2022**, **Visual Studio Code**, o cualquier editor de código
- **Navegador web** moderno (Chrome, Firefox, Safari, Edge)

## 🚀 Instalación y Configuración

### 1. Verificar la instalación de .NET
```powershell
dotnet --version
```
Debería mostrar la versión 8.0.x o superior.

### 2. Clonar/Descargar el proyecto
```powershell
# Si tienes el código fuente, navega al directorio
cd C:\Users\junio\Downloads\piqweoirpuqwopier
```

### 3. Restaurar dependencias
```powershell
dotnet restore
```

### 4. Compilar el proyecto
```powershell
dotnet build
```

### 5. Ejecutar la aplicación
```powershell
dotnet run
```

## 🌐 Acceso a la Aplicación

Una vez ejecutada, la aplicación estará disponible en:

- **URL Principal**: `https://localhost:5001`
- **URL HTTP**: `http://localhost:5000`

### Endpoints de la API

| Método | Endpoint | Descripción | Respuesta |
|--------|----------|-------------|-----------|
| `GET` | `/api/HolaMundo` | Mensaje básico de bienvenida | `"¡Hola Mundo desde ASP.NET Core!"` |
| `GET` | `/api/HolaMundo/saludo` | Mensaje de saludo extendido | `"¡Saludos desde ASP.NET Core! 🚀"` |

### Ejemplos de uso

**Usando el navegador:**
- Abre: `https://localhost:5001/api/HolaMundo`
- Abre: `https://localhost:5001/api/HolaMundo/saludo`

**Usando PowerShell/CMD:**
```powershell
# Mensaje básico
Invoke-RestMethod -Uri "https://localhost:5001/api/HolaMundo" -Method GET

# Mensaje de saludo
Invoke-RestMethod -Uri "https://localhost:5001/api/HolaMundo/saludo" -Method GET
```

**Usando cURL:**
```bash
# Mensaje básico
curl -k https://localhost:5001/api/HolaMundo

# Mensaje de saludo
curl -k https://localhost:5001/api/HolaMundo/saludo
```

## 🏗️ Arquitectura del Proyecto

### Estructura de archivos
```
piqweoirpuqwopier/
├── Controllers/
│   └── HolaMundoController.cs    # Controlador API con endpoints
├── HolaMundo.csproj              # Archivo de proyecto .NET
├── Program.cs                    # Punto de entrada de la aplicación
├── global.json                   # Configuración del SDK .NET
└── README.md                     # Este archivo de documentación
```

### Componentes principales

#### `Program.cs`
- Configuración del host web
- Registro de servicios (controladores)
- Configuración del pipeline de middleware
- Configuración de routing y autorización

#### `Controllers/HolaMundoController.cs`
- Controlador API REST
- Atributos de routing: `[ApiController]`, `[Route("api/[controller]")]`
- Métodos HTTP: `[HttpGet]`, `[HttpGet("saludo")]`
- Retorna respuestas JSON automáticamente

#### `HolaMundo.csproj`
- SDK: `Microsoft.NET.Sdk.Web`
- Framework: `.NET 8.0`
- Configuraciones: Nullable reference types habilitado

## 🔧 Desarrollo

### Comandos útiles

```powershell
# Ejecutar en modo desarrollo (con hot reload)
dotnet watch run

# Ejecutar con logs detallados
dotnet run --verbosity normal

# Limpiar archivos de compilación
dotnet clean

# Publicar para producción
dotnet publish -c Release -o ./publish
```

### Modo desarrollo con hot reload
```powershell
dotnet watch run
```
Este comando reinicia automáticamente la aplicación cuando detecta cambios en el código.

## 🔒 Configuración de Seguridad

La aplicación incluye:
- **HTTPS redirection** - Redirige HTTP a HTTPS automáticamente
- **HSTS** (HTTP Strict Transport Security) - En producción
- **Exception handling** - Manejo de errores en producción

## 🐛 Solución de Problemas

### Error: "No se puede conectar a localhost"
- Verifica que la aplicación esté ejecutándose
- Asegúrate de usar `https://localhost:5001` (no `http://`)
- En algunos navegadores, acepta el certificado SSL autofirmado

### Error: "dotnet command not found"
- Instala .NET 8.0 SDK desde [dotnet.microsoft.com](https://dotnet.microsoft.com/download)
- Reinicia la terminal después de la instalación

### Puerto en uso
Si el puerto 5001 está ocupado:
```powershell
# Especificar un puerto diferente
dotnet run --urls "https://localhost:5002"
```

## 📚 Próximos Pasos

Para expandir esta aplicación, considera:
- Agregar más endpoints con diferentes métodos HTTP (POST, PUT, DELETE)
- Implementar un modelo de datos con Entity Framework Core
- Agregar autenticación y autorización
- Implementar logging con Serilog
- Agregar tests unitarios con xUnit
- Configurar Swagger/OpenAPI para documentación automática

## 📄 Licencia

Este proyecto es de código abierto y está disponible bajo la licencia MIT.
