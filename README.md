# Proyecto CineGrupo7 - Relación Uno a Muchos (ASP.NET Core MVC)

Este proyecto corresponde a la actividad práctica grupal para la materia de Programación. Implementa una arquitectura **MVC** utilizando **Entity Framework Core** y **SQL Server**, aplicando una relación de uno a muchos entre las entidades **Género** y **Película**.

## Integrantes - Grupo 7
* Alexander Rafael Infante Salas (Estructura Base y Migraciones, repositorio GitHub, CRUD Película y 1ra migración).
* Carmen Violeta Tapia Sotamba (Validaciones de Entidades, Validaciones DataAnnotations en Pelicula y 2da migración).
* Jannina Viviana Puga Monserrate  (Modelado de Relaciones, Modelo y CRUD Género, llave foránea (FK) y 3ra migración).
* Eliecer Mateo Mogollón Ortiz  (Componente Autónomo, Documentación, Regenerar CRUD Película, lista desplegable, README y PDF entregable).

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

## Componente Autónomo Desarrollado (Eliecer Mateo Mogollón Ortiz)
Para dar solución a los requerimientos autónomos planteados por el docente, se realizaron las siguientes optimizaciones avanzadas sobre los formularios automáticos y la documentación del sistema:

1. **Lista Desplegable Dinámica (Create y Edit):** Se eliminaron los campos de texto plano donde el usuario debía digitar manualmente el identificador. Se sustituyeron por componentes `<select>` de Bootstrap dinámicos tanto en el formulario de creación (`Create.cshtml`) como en el de edición (`Edit.cshtml`), permitiendo seleccionar el género de forma interactiva directamente desde la Base de Datos.
2. **Mapeo Avanzado en el Controlador:** Se optimizó el método de persistencia `POST` en el controlador `PeliculasController`. El sistema ahora intercepta la selección del usuario, consulta dinámicamente el registro en la tabla `Genero` y almacena de forma limpia la descripción textual del género (*Acción, Comedia, etc.*), solucionando el fallo visual del ID expuesto en el listado principal (`Index.cshtml`).
3. **Personalización Profesional de Vistas:** Se erradicaron los encabezados automáticos genéricos generados por el scaffolding (`Index`, `Edit`). Se reestructuraron las interfaces visuales incorporando títulos claros en español como *"Listado de Películas"* y *"Géneros Disponibles"*, mejorando drásticamente la experiencia de usuario.
4. **Documentación Técnica del Repositorio (README.md):** Diseño, redacción y estructuración completa del archivo de documentación técnica en la raíz del repositorio de GitHub empleando un formato Markdown, detallando las tecnologías, integrantes y el alcance del desarrollo.
5. **Informe PDF Entregable:** Elaboración y estructuración del documento final PDF para la entrega, recopilando la justificación técnica del desarrollo autónomo, la URL del repositorio síncrono y las evidencias gráficas del funcionamiento del sistema y el historial de commits.

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
