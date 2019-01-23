using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessX.ViewModel
{
    public class MostrarDellalleVM : ViewModelBase
    {
        public MostrarDellalleVM()
        {
            InitialMDVM();
        }

        public void InitialMDVM()
        {

        }
        #region Properties
        private List<Entities.Libro> Libros_BF;
        public List<Entities.Libro> Libros
        {
            get { return Libros_BF; }
            set
            {
                Libros_BF = value;
                OnPropertyChanged();
            }
        }

        private Entities.Libro LibroSelected_BF;
        public Entities.Libro LibroSelected
        {
            get { return LibroSelected_BF; }
            set
            {
                LibroSelected_BF = value;
                OnPropertyChanged();
            }
        }

        private int IDL_BF;
        public int IDL
        {
            get { return IDL_BF; }
            set
            {
                IDL_BF = value;
                OnPropertyChanged();
            }
        }

        private string NombreL_BF;
        public string NombreL
        {
            get { return NombreL_BF; }
            set
            {
                NombreL_BF = value;
                OnPropertyChanged();
            }
        }

        private string AutorL_BF;
        public string AutorL
        {
            get { return AutorL_BF; }
            set
            {
                AutorL_BF = value;
                OnPropertyChanged();
            }
        }

        private string Editorial_BF;
        public string Editorial
        {
            get { return Editorial_BF; }
            set
            {
                Editorial_BF = value;
                OnPropertyChanged();
            }
        }

        private string ISBN_BF;
        public string ISBN
        {
            get { return ISBN_BF; }
            set
            {
                ISBN_BF = value;
                OnPropertyChanged();
            }
        }

        private double PrecioL_BF;
        public double PrecioL
        {
            get { return PrecioL_BF; }
            set
            {
                PrecioL_BF = value;
                OnPropertyChanged();
            }
        }

        private string RutaImgL_BF;
        public string RutaImgL
        {
            get { return RutaImgL_BF; }
            set
            {
                RutaImgL_BF = value;
                OnPropertyChanged();
            }
        }

        private int IDGeneroL_BF;
        public int IDGeneroL
        {
            get { return IDGeneroL_BF; }
            set
            {
                IDGeneroL_BF = value;
                OnPropertyChanged();
            }
        }

        #endregion

        public CommandDelegate BuscarLibroCommand { get; set; }
        public CommandDelegate BuscarLibroPorIDCommand { get; set; }
        public CommandDelegate CrearLibroCommand { get; set; }
        public CommandDelegate ActualizarLibroCommand { get; set; }
        public CommandDelegate EliminarLibroCommand { get; set; }
    }


}
