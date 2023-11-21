using BookBlazor.Data;
using BookBlazor.Models;

namespace BookBlazor.Repository
{
    public class LibroRepository : ILibroRepository
    {
        private readonly ApplicationDBContext _db;
        public LibroRepository(ApplicationDBContext db)
        {
            this._db = db;
        }
      
        public Task<Libro> GetLibro(int libroId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Libro>> GetLibros()
        {
            throw new NotImplementedException();
        }
        public async Task<Libro> CrearLibro(Libro libro)
        {
            if (libro != null)
            {
                await _db.Libros.AddAsync(libro);//Agregamos el libro a la BD
                await _db.SaveChangesAsync();//Guardamos los cambios
                return libro;//Retornamos el libro
            }
            else
            {
                return new Libro();
            }
        }
        public Task<Libro> ActualizarLibro(Libro libro)
        {
            throw new NotImplementedException();
        }

        public Task<Libro> BorrarLibro(int libroId)
        {
            throw new NotImplementedException();
        }

        
    }
}
