# TouchConsulting

## Descripción General
TouchConsulting es un sistema de gestión empresarial basado en una arquitectura de microservicios, diseñado para manejar la gestión de usuarios, productos e inventario. El sistema está compuesto por múltiples componentes independientes que trabajan en conjunto para proporcionar una solución completa.

## Arquitectura del Sistema

### Componentes Principales

1. **API Identity Service**
   - Microservicio encargado de la gestión de autenticación y autorización
   - Manejo de usuarios, roles y permisos
   - Generación y validación de tokens JWT
   - Tecnología: .NET Core

2. **API Product Service**
   - Microservicio para la gestión de productos e inventario
   - Manejo del catálogo de productos
   - Control de stock
   - Tecnología: .NET Core

3. **API Gateway**
   - Punto de entrada único para todas las APIs
   - Enrutamiento y redirección de solicitudes
   - Balanceo de carga
   - Tecnología: .NET Core

4. **Web Application (Angular)**
   - Interfaz de usuario moderna y responsive
   - Módulos principales:
     - Gestión de usuarios
     - Gestión de productos
     - Reportes de stock mínimo
   - Tecnología: Angular 16+

## Requisitos Previos

- Node.js (v18 o superior)
- .NET Core SDK 7.0 o superior
- SQL Server 2019 o superior
- Angular CLI (última versión estable)

## Instrucciones de Instalación y Ejecución

### 1. Configuración de Base de Datos
```bash
# Ejecutar scripts de migración para cada servicio
# En la carpeta de cada API:
dotnet ef database update
```

### 2. API Identity Service
```bash
cd Identity.API
dotnet restore
dotnet run
```
El servicio estará disponible en: `https://localhost:44351`

### 3. API Product Service
```bash
cd Product.API
dotnet restore
dotnet run
```
El servicio estará disponible en: `https://localhost:7034`

### 4. API Gateway
```bash
cd Gateway.API
dotnet restore
dotnet run
```
El gateway estará disponible en: `https://localhost:44300`

### 5. Aplicación Web Angular
```bash
cd Web-App-Angular/touch-project-product
npm install
ng serve
```
La aplicación web estará disponible en: `http://localhost:4200`

## Estructura del Proyecto

```
TouchConsulting/
├── Identity.API/          # Servicio de autenticación y autorización
├── Product.API/           # Servicio de gestión de productos
├── Gateway.API/           # API Gateway
└── Web-App-Angular/       # Aplicación web en Angular
    └── touch-project-product/
```

## Configuración

Cada componente tiene su propio archivo de configuración:

- APIs: `appsettings.json`
- Angular: `environment.ts`

Asegúrese de configurar las URLs y credenciales de base de datos según su entorno.

## Características Principales

- Autenticación y autorización basada en JWT
- Gestión completa de usuarios y roles
- Catálogo de productos con categorías
- Control de inventario
- Reportes de stock mínimo
- Interfaz de usuario moderna y responsive
- Arquitectura escalable basada en microservicios

## Seguridad

- Autenticación basada en tokens JWT
- Autorización basada en roles
- HTTPS habilitado por defecto
- Validación de datos en cada capa

## Soporte

Para reportar problemas o solicitar soporte, por favor crear un issue en el repositorio del proyecto.

## Licencia

Este proyecto está bajo la licencia [MIT](LICENSE).
