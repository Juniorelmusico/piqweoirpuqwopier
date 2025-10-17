# Hola Mundo en ASP.NET Core

Esta es una aplicación web simple de "Hola Mundo" creada con ASP.NET Core.

## Características

- API REST básica con ASP.NET Core 8.0
- Endpoints para mostrar mensajes de saludo
- Configuración mínima para desarrollo

## Cómo ejecutar

1. Asegúrate de tener .NET 8.0 SDK instalado
2. Abre una terminal en el directorio del proyecto
3. Ejecuta los siguientes comandos:

```bash
dotnet restore
dotnet run
```

4. Abre tu navegador y ve a:
   - `https://localhost:5001/api/HolaMundo` - Para el mensaje básico
   - `https://localhost:5001/api/HolaMundo/saludo` - Para el mensaje de saludo

## Endpoints disponibles

- `GET /api/HolaMundo` - Retorna "¡Hola Mundo desde ASP.NET Core!"
- `GET /api/HolaMundo/saludo` - Retorna "¡Saludos desde ASP.NET Core! 🚀"

## Estructura del proyecto

```
.
├── Controllers/
│   └── HolaMundoController.cs
├── HolaMundo.csproj
├── Program.cs
├── global.json
└── README.md
```
