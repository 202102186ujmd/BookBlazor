using BookBlazor.Models;

namespace BookBlazor.Repository
{
    public interface ILibroRepository
    {
        public Task<List<Libro>> GetLibros();//Devuelve una lista de libros
        public Task<Libro> GetLibro(int libroId);//Devuelve un libro
        public Task<Libro> CrearLibro(Libro libro);//Crea un libro
        public Task<Libro> ActualizarLibro(Libro libro);//Actualiza un libro
        public Task<Libro> BorrarLibro(int libroId);//Borra un libro
    }
}
