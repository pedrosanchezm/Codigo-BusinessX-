using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternRepository.Entities;
using PatternRepository.Repository;
using PatternRepository.RepositoryDapper;

namespace PatternRepository.DAL
{
    public class BibliotecaDAL
    {
        private readonly IRepository<Libro> repository;

        public BibliotecaDAL()
        {
            repository = new RepositoryDapper<Libro>();
        }

        public List<Libro> GetLibros()
        {
            var query = "SELECT * FROM \"T_Libros\"";
            return repository.GetAll(query).ToList();
        }

        public List<Libro> InsertLibros(Libro libro)
        {
            var query = "INSERT INTO \"T_Libros\" (NombreL,AutorL,Editorial,ISBN,PrecioL,IDGeneroL) ";
            query+= string.Format("VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6});", libro.NombreL, libro.AutorL, libro.Editorial, libro.ISBN, libro.PrecioL, libro.RutaImgL, libro.IDGeneroL);
            return repository.GetAll(query).ToList();
        }
    }
}
