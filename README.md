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

## Creación del Proyecto Base y Estructura Inicial, repositorio github (Alexander Rafael Infante Salas)
Para dar inicio al desarrollo del Sistema de Gestión Escolar y establecer una base sólida para el resto del equipo, me encargué de la configuración inicial del proyecto y la primera migración de la base de datos. Las tareas que realicé fueron las siguientes:

1. **Configuración del Entorno y Proyecto:** Creé el proyecto inicial en Visual Studio utilizando la plantilla de Aplicación Web ASP.NET Core (Modelo-Vista-Controlador). Me aseguré de seleccionar el framework .NET 10.0 y configuré la autenticación en "Ninguno", cumpliendo con los parámetros establecidos por el docente.
2. **Definición de la Entidad Principal:** Desarrollé el modelo inicial de la entidad dependiente, creando la clase `Pelicula.cs` dentro de la carpeta Models. Definí sus propiedades básicas (Id, Titulo, Director, AnioEstreno, Genero), asegurando que los nombres no contuvieran tildes para evitar errores de compilación.
3. **Generación del Controlador y Vistas (Scaffolding):** Utilicé la herramienta de scaffolding de Entity Framework para generar automáticamente el controlador `PeliculasController` (verificando que el nombre estuviera en plural) y las vistas correspondientes con operaciones CRUD básicas. También ajusté el nombre de la carpeta de vistas a plural (`Peliculas`) para mantener la coherencia.
4. **Conexión a Base de Datos y Primera Migración:** Modifiqué el archivo `appsettings.json` para establecer la cadena de conexión hacia el servidor local (`localhost\SQLEXPRESS`). Finalmente, superé un bloqueo de seguridad de NuGet ajustando las reglas del proyecto (`<NuGetAudit>false</NuGetAudit>`), lo que me permitió ejecutar exitosamente los comandos `Add-Migration InitialCreate` y `Update-Database`, creando la base de datos `CineGrupo7Context` y la tabla `Pelicula`.
5. **Repositorio Remoto:** Inicialicé el control de versiones local, creé el repositorio público `CineGrupo7` en GitHub e invité a los demás miembros del equipo como colaboradores para que pudieran continuar con el flujo de trabajo.

---

## Validaciones DataAnnotations (Carmen Violeta Tapia Sotamba)

 1. **Definición de Reglas de Validación (DataAnnotations):** Actualización del modelo `Pelicula.cs` implementando atributos esenciales para blindar la integridad de los datos en la interfaz web y la persistencia:
    * Campos obligatorios (`[Required]`) para restringir registros sin título o director.
    * Límites de extensión de texto (`[StringLength]`) en campos alfanuméricos.
    * Restricción de rangos (`[Range]`) coherentes para el año de estreno.
    * Etiquetas visuales personalizadas en español mediante la propiedad `[Display]`.
  2. **Sincronización y Migración de Base de Datos:** Generación y ejecución de la migración `AgregarValidacionesPelicula` en Entity Framework Core, transformando las columnas de la tabla física `dbo.Pelicula` en SQL Server para restringir valores nulos (`NOT NULL`) y acotar las longitudes del tipo de dato `nvarchar`.
  3. **Pruebas de Integridad:** Verificación funcional del bloqueo inmediato con alertas en color rojo ante intentos de envíos vacíos en `/Peliculas/Create`, y auditoría de la correcta persistencia del historial dentro de `dbo.__EFMigrationsHistory`.

---

## Modeo y crud Género, llave foránea fk (Jannina Viviana Puga Monserrate)

  1. **Modelo de Datos (Genero.cs):** Creación de la clase con DataAnnotations (`Id` autoincremental y `Titulo` obligatorio limitado de 2 a 100 caracteres).
  2. **Controlador y Vistas (CRUD):** Scaffolding completo de `GenerosController` y generación de las vistas Razor (`Index`, `Create`, `Edit`, `Details`, `Delete`) para la gestión integral de la entidad principal.
  3. **Migraciones y Base de Datos:** Registro de la entidad en el `DbContext` y aplicación de la migración `AddGenero` (`Update-Database`) para crear la tabla física en SQL Server.
  4. **Interfaz de Usuario:** Actualización de la barra de navegación en `_Layout.cshtml` con accesos directos y acoplamiento de scripts de validación en el cliente.
  5. **Pruebas y Control de Versiones:** Verificación funcional local de los flujos de datos relacionales y sincronización mediante Push a la rama principal.

---

## Componente Autónomo Desarrollado, regenerar crud, lista despegable / readme (Eliecer Mateo Mogollón Ortiz)
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
