using Microsoft.EntityFrameworkCore;

public class CineGrupo7Context(DbContextOptions<CineGrupo7Context> options) : DbContext(options)
{
    public DbSet<CineGrupo7.Models.Pelicula> Pelicula { get; set; } = default!;
}
