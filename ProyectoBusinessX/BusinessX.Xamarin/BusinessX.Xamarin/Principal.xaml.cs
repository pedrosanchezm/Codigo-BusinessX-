using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BusinessX.Xamarin
{
    public partial class Principal : ContentPage
    {
        public Principal()
        {
            InitializeComponent();
            
        }

        private void MenuItem1_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new CUD());
        }

        private void BtnVerDetalle_Clicked(object sender, EventArgs e)
        {
            //ObservableCollection<Entities.Libro> ObjLibro = 
            
            //ObjLibro.Add(new Entities.Libro { IDL= 1 });
            //Navigation.PushAsync(new MostrarDetalle());
        }

        //private void ListLibros_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        //{
            
        //}

        //private void ListLibros_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        //{

        //}
    }
}
