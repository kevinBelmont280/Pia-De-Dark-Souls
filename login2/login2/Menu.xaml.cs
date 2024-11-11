using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace login2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        // Acción para el primer botón (crear equipo)
        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Navegar a la página Creación_de_Equipo
            await Navigation.PushAsync(new Creación_de_Equipo());
        }

        // Acción para el segundo botón (ver equipo)
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VerEquipos());
        }
    }
}
