using PatternRepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PatternRepository.BLL;

namespace WebApi.Models
{
    public class RepositoryMemoryData
    {
        private List<Libro> Libros = new List<Libro>();

        private static int NextID;

        public RepositoryMemoryData()
        {
            Libros = new LibrosManager().GetLibros();
        }
        public List<Libro> ObtenerTodoLibro()
        {
            return Libros;
        }

        public Libro ObtenerLibro(int id)
        {

            return Libros.Find(p => p.IDL == id);
        }

        public Libro CrearLibro(Libro nuevoLibro)
        {
            if (nuevoLibro == null)
            {
                throw new ArgumentException("Libro");
            }
            nuevoLibro.IDL = ++NextID;
            Libros.Add(nuevoLibro);
            return nuevoLibro;
        }

        public bool EliminarLibro(int id)
        {
            bool Resultado = false;
            var pr = Libros.RemoveAll(p => p.IDL == id);
            if (pr > 0)
            {
                Resultado = true;
            }
            return Resultado;
        }

        public bool ActualizarLibro(Libro LibroToUpdate)
        {
            if (LibroToUpdate == null)
            {
                throw new ArgumentException("Libro");
            }

            int index = Libros.FindIndex(p => p.IDL == LibroToUpdate.IDL);
            if (index == -1)
            {
                return false;
            }
            Libros.RemoveAt(index);
            Libros.Add(LibroToUpdate);
            return true;
        }
    }
}