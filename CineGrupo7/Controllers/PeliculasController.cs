
using CineGrupo7.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

public class PeliculasController : Controller
{
    private readonly CineGrupo7Context _context;

    public PeliculasController(CineGrupo7Context context)
    {
        _context = context;
    }

    // GET: PELICULAS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Pelicula.ToListAsync());
    }

    // GET: PELICULAS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var pelicula = await _context.Pelicula
            .FirstOrDefaultAsync(m => m.Id == id);
        if (pelicula == null)
        {
            return NotFound();
        }

        return View(pelicula);
    }

    // GET: PELICULAS/Create
    // GET: Peliculas/Create
    public IActionResult Create()
    {
        // Carga los géneros en un SelectList enviando el ID y el título para la lista desplegable
        ViewData["GeneroId"] = new SelectList(_context.Genero, "Id", "Titulo");
        return View();
    }


    // POST: PELICULAS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    // POST: Peliculas/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Titulo,Director,AnioEstreno,Genero")] Pelicula pelicula)
    {
        // 1. Validamos si el usuario seleccionó un ID válido en el formulario
        if (!string.IsNullOrEmpty(pelicula.Genero) && int.TryParse(pelicula.Genero, out int generoId))
        {
            // 2. Buscamos el objeto Genero real en la base de datos usando ese ID
            var generoReal = await _context.Genero.FindAsync(generoId);
            if (generoReal != null)
            {
                // 3. Reemplazamos el ID numérico por el NOMBRE real del género (ej: "Comedia")
                pelicula.Genero = generoReal.Titulo;
            }
        }

        if (ModelState.IsValid)
        {
            _context.Add(pelicula);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        ViewData["GeneroId"] = new SelectList(_context.Genero, "Id", "Titulo", pelicula.Genero);
        return View(pelicula);
    }



    // GET: PELICULAS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var pelicula = await _context.Pelicula.FindAsync(id);
        if (pelicula == null)
        {
            return NotFound();
        }
        return View(pelicula);
    }

    // POST: PELICULAS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Titulo,Director,AnioEstreno,Genero")] Pelicula pelicula)
    {
        if (id != pelicula.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(pelicula);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeliculaExists(pelicula.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(pelicula);
    }

    // GET: PELICULAS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var pelicula = await _context.Pelicula
            .FirstOrDefaultAsync(m => m.Id == id);
        if (pelicula == null)
        {
            return NotFound();
        }

        return View(pelicula);
    }

    // POST: PELICULAS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var pelicula = await _context.Pelicula.FindAsync(id);
        if (pelicula != null)
        {
            _context.Pelicula.Remove(pelicula);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool PeliculaExists(int? id)
    {
        return _context.Pelicula.Any(e => e.Id == id);
    }
}
