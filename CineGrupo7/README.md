# Proyecto CineGrupo7 - Relación Uno a Muchos (ASP.NET Core MVC)

Este proyecto corresponde a la actividad práctica grupal para la materia de Programación. Implementa una arquitectura **MVC** utilizando **Entity Framework Core** y **SQL Server**, aplicando una relación de uno a muchos entre las entidades **Género** y **Película**.

## Integrantes - Grupo 7
* Alex (Líder / Estructura Base y Migraciones)
* Compañero 2 (Validaciones de Entidades)
* Compañero 3 (Modelado de Relaciones)
* **Emmanuel Mogollón** (Componente Autónomo, Documentación y Entrega)

---

## Tema Asignado: Tema 7 (Género y Película)
El sistema permite gestionar un catálogo cinematográfico completo donde un **Género** (Entidad Principal) puede contener múltiples **Películas** (Entidad Dependiente).

### 🛠️ Tecnologías Utilizadas
* **Lenguaje:** C#
* **Framework:** .NET 8.0 / ASP.NET Core MVC
* **ORM:** Entity Framework Core
* **Base de Datos:** SQL Server (`LocalDB` / `SQLEXPRESS`)
* **Diseño Visual:** Bootstrap 5 & CSS3

---

## Componente Autónomo Desarrollado (Turno 4)
Para dar solución a los requerimientos autónomos planteados por el docente, se realizaron las siguientes optimizaciones sobre los formularios automáticos:

1. **Lista Desplegable Dinámica:** Se sustituyó el campo de texto plano de la Clave Foránea en el formulario de creación (`Create.cshtml`) de Películas por un elemento `<select>` de Bootstrap. Este componente mapea dinámicamente los registros de la tabla `Genero` directo desde la Base de Datos.
2. **Mapeo de Datos Relacionados:** Se optimizó el método `POST` en el controlador `PeliculasController` para interceptar el ID seleccionado, recuperar el objeto correspondiente de la base de datos y almacenar directamente el nombre textual del género (*Acción, Comedia, etc.*), corrigiendo el fallo del ID numérico expuesto en el listado principal (`Index.cshtml`).

---

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
