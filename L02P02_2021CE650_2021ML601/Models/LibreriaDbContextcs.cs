using L02P02_2021CE650_2021ML601.Controllers;
using Microsoft.EntityFrameworkCore;

namespace L02P02_2021CE650_2021ML601.Models
{
    public class LibreriaDbContext : DbContext
    {
        public LibreriaDbContext(DbContextOptions<LibreriaDbContext> options) : base(options)
        {
        }

        public DbSet<LibreriaDb> libros { get; set; }
    }
}
