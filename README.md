# AlumnosApp

Aplicación ASP.NET Core MVC migrada desde el proyecto clásico ASP.NET MVC 5 / .NET Framework 4.7.2 para ejecutarse en contenedores Linux y desplegarse en Render.

## Ejecutar localmente

Requiere el SDK de .NET 10.

```bash
dotnet run --project AlumnosWeb/AlumnosWeb.csproj
```

La aplicación estará disponible en la dirección local que indique la consola.

## Construir con Docker

Desde la raíz del repositorio:

```bash
docker build -t alumnos-app .
docker run --rm -p 10000:10000 -e PORT=10000 alumnos-app
```

Abrir http://localhost:10000.

## Desplegar en Render

1. Crear un servicio **Web Service** y conectar este repositorio.
2. Elegir **Docker** como Runtime.
3. Dejar el Dockerfile Path como `./Dockerfile`.
4. Dejar el contexto de construcción en la raíz del repositorio.
5. Crear el servicio. La aplicación escucha en el puerto indicado por Render mediante la variable `PORT` (usa 10000 como valor local predeterminado).

## Datos

La pantalla conserva los ocho registros de ejemplo del proyecto original. Los datos siguen almacenados en memoria; no hay una base de datos configurada, por lo que no deben considerarse persistentes.
