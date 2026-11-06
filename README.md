# Proyecto CineGrupo7 - Relación Uno a Muchos (ASP.NET Core MVC)

Este proyecto corresponde a la actividad práctica grupal para la materia de Programación. Implementa una arquitectura **MVC** utilizando **Entity Framework Core** y **SQL Server**, aplicando una relación de uno a muchos entre las entidades **Género** y **Película**.

## Integrantes - Grupo 7
* Alexander Rafael Infante Salas (Estructura Base y Migraciones, repositorio GitHub, CRUD)
* Carmen Violeta Tapia Sotamba (Validaciones de Entidades Validaciones DataAnnotations en Pelicula)
* Jannina Viviana Puga Monserrate  (Modelado de Relaciones, Modelo y CRUD Genero, llave foránea (FK))
* Eliecer Mateo Mogollón Ortiz  (Componente Autónomo, Documentación, Regenerar CRUD Pelicula, lista desplegable, README)

---

## Tema Asignado: Tema 7 (Género y Película)
El sistema permite gestionar un catálogo cinematográfico completo donde un **Género** (Entidad Principal) puede contener múltiples **Películas** (Entidad Dependiente).

### 🛠️ Tecnologías Utilizadas
* **Lenguaje:** C#
* **Framework:** .NET 8.0 / ASP.NET Core MVC
* **ORM:** Entity Framework Core
* **Base de Datos:** SQL Server (`LocalDB` / `SQLEXPRESS`)
* **Diseño Visual:** Bootstrap 5 & CSS3

## Instrucciones para Ejecución Local

Si deseas clonar y ejecutar este proyecto en tu entorno local, sigue estos pasos:

1. **Clonar el Repositorio:**
   ```bash
   https://github.com/alexkinfante-07/CineGrupo7.git
   ```
2. **Generar la Base de Datos:**
   Abre la *Consola del Administrador de Paquetes* en Visual Studio y ejecuta el siguiente comando para aplicar las migraciones correspondientes:
   ```text
   Update-Database
   ```
3. **Ejecutar el Proyecto:**
   Presione `F5` o el botón de iniciar en Visual Studio para desplegar la aplicación en el navegador local.
