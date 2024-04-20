using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace L02P02_2021CE650_2021ML601.Models
{
    public class LibreriaDbContext : DbContext
    {
        public LibreriaDbContext(DbContextOptions<LibreriaDbContext> options) : base(options)
        {
        }

        public DbSet<equipos> equipos { get; set; }
    }
}
