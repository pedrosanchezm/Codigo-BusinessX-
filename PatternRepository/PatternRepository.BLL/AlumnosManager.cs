using System;
using PatternRepository.DAL;
using PatternRepository.Entities;
using System.Collections.Generic;

namespace PatternRepository.BLL
{
    public class AlumnosManager
    {
        private readonly BibliotecaDAL alumnosDAL;

        public AlumnosManager()
        {
            alumnosDAL = new BibliotecaDAL();
        }

        public List<Libro> GetAlumnos()
        {
            //Aqui se implementa la logica de negocio
            return alumnosDAL.GetLibros();
        }

        public List<Libro> InsertAlumnos(Libro alumno)
        {
            return alumnosDAL.InsertLibros(alumno);
        }
    }
}
