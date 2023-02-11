using CRUDNET7MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDNET7MVC.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 

        } 

        public DbSet<Contacto> Contactos { get; set; }
        
    }
}
