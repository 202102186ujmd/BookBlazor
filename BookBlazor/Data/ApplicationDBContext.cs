using BookBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace BookBlazor.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }
        
        public DbSet<Libro>Libros { get; set; }
    }
}
