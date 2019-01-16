using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternRepository.BLL;

namespace PatternRepository.SistemaEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido!");
            Console.WriteLine("Ingrese 'Y' para ingresar un registro o 'N' para ver los registros actuales.");
            var Decision = Console.ReadLine();

            switch (Decision)
            {
                case "Y":
                    IngresarDatos();
                    break;
                case "N":
                    MostrarDatos();
                    break;
                default:
                    break;
            }
           

            void IngresarDatos()
            {
                var ObjLibro = new Entities.Libro();
                int resultado = 0;

                while (resultado!=1)
                {
                    Console.WriteLine("Ingrese un Registro");
                    Console.WriteLine("Ingrese el Nombre: ");
                    ObjLibro.NombreL = Console.ReadLine();
                    Console.WriteLine("Ingrese el Autor: ");
                    ObjLibro.AutorL = Console.ReadLine();
                    Console.WriteLine("Ingrese la Editorial: ");
                    ObjLibro.Editorial = Console.ReadLine();
                    Console.WriteLine("Ingrese ISBN: ");
                    ObjLibro.ISBN = Console.ReadLine();
                    Console.WriteLine("Ingrese Precio: ");
                    ObjLibro.PrecioL = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese Genero: ");
                    ObjLibro.IDGeneroL = Convert.ToInt32(Console.ReadLine());

                    var InstarAlum = new LibrosManager().InsertLibros(ObjLibro);
                    Console.WriteLine("Ingrese 1 para salir.");
                    resultado = Convert.ToInt32(Console.ReadLine());
                }
               
            }

            void MostrarDatos()
            {
                var Libros = new LibrosManager().GetLibros();
                int resultado = 0;

                while (resultado != 1)
                {
                    Console.WriteLine("Registros Actuales");
                    foreach (var libro in Libros)
                    {

                        Console.WriteLine($"Id: {libro.IDL}, " +
                            $"Nombre: {libro.NombreL}, " +
                            $"Autor: {libro.AutorL}, " +
                            $"Editorial: {libro.Editorial}, " +
                            $"ISBN: {libro.ISBN}, " +
                            $"Precio: {libro.PrecioL}, " +
                            $"Genero: {libro.IDGeneroL}. ");
                    }
                    Console.WriteLine("Ingrese 1 para salir.");
                    resultado = Convert.ToInt32(Console.ReadLine());
                }
            }

        }
    }
}
