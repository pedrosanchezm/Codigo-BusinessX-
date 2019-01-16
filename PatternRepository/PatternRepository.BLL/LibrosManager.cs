using System;
using PatternRepository.DAL;
using PatternRepository.Entities;
using System.Collections.Generic;

namespace PatternRepository.BLL
{
    public class LibrosManager
    {
        private readonly BibliotecaDAL librosDAL;

        public LibrosManager()
        {
            librosDAL = new BibliotecaDAL();
        }

        public List<Libro> GetLibros()
        {
            //Aqui se implementa la logica de negocio
            return librosDAL.GetLibros();
        }

        public List<Libro> InsertLibros(Libro libro)
        {
            return librosDAL.InsertLibros(libro);
        }
    }
}
