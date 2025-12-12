# Proyecto .NET – Microservicio de Integración con Pipedream

Este microservicio forma parte de la arquitectura distribuida del proyecto y actúa como servicio integrador. Su función principal es recibir eventos internos y enviarlos a Pipedream mediante webhooks, permitiendo automatizar tareas como envío de correos y validación de códigos.

## Tecnologías utilizadas

- Lenguaje: C#
- Framework: .NET 8.0 (ASP.NET Core Web API)
- Comunicación: HttpClient estándar o RestSharp
- Integración externa: Webhooks de Pipedream

## Requisitos previos

Antes de ejecutar el proyecto, asegúrate de tener:

1. .NET 8.0 SDK  
2. Visual Studio 2022 o VS Code con la extensión C# Dev Kit  
3. Postman u otra herramienta para pruebas HTTP  

## Cómo ejecutar el proyecto

### Desde la terminal

1. Restaurar paquetes:
   ```bash
   dotnet restore
