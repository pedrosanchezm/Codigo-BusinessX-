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
                var ObjAlumno = new PatternRepository.Entities.Libro();
                int resultado = 0;

                while (resultado!=1)
                {
                    Console.WriteLine("Ingrese un Registro");
                    Console.WriteLine("Ingrese el Nombre: ");
                    ObjAlumno.NombreAlum = Console.ReadLine();
                    Console.WriteLine("Ingrese el Apellido: ");
                    ObjAlumno.ApellidoAlum = Console.ReadLine();
                    Console.WriteLine("Ingrese la Direccion: ");
                    ObjAlumno.DireccionAlum = Console.ReadLine();
                    Console.WriteLine("Ingrese el Telefono: ");
                    ObjAlumno.TelefonoAlum = Console.ReadLine();

                    var InstarAlum = new AlumnosManager().InsertAlumnos(ObjAlumno);
                    Console.WriteLine("Ingrese 1 para salir.");
                    resultado = Convert.ToInt32(Console.ReadLine());
                }
               
            }

            void MostrarDatos()
            {
                var Alumnos = new AlumnosManager().GetAlumnos();
                int resultado = 0;

                while (resultado != 1)
                {
                    Console.WriteLine("Registros Actuales");
                    foreach (var alumno in Alumnos)
                    {

                        Console.WriteLine($"Id: {alumno.IdAlum}, " +
                            $"Nombre: {alumno.NombreAlum}, " +
                            $"Apellido: {alumno.ApellidoAlum}, " +
                            $"Direccion: {alumno.DireccionAlum}, " +
                            $"Telefono: {alumno.TelefonoAlum}. ");
                    }
                    Console.WriteLine("Ingrese 1 para salir.");
                    resultado = Convert.ToInt32(Console.ReadLine());
                }
            }

        }
    }
}
