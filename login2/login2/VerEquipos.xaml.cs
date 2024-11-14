using login2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace login2
{

    public partial class VerEquipos : ContentPage
    {
        public VerEquipos()
        {
            InitializeComponent();

            // Crear un equipo de ejemplo con cinco jugadores
            var equipoEjemplo = new Equipo
            {
                Nombre = "Equipo Legendario",
                Jugadores = new List<Jugador>
            {

                
            }
            };

            // Crear una lista de equipos para mostrar
            var equipos = new List<Equipo> { equipoEjemplo };

            // Asignar la lista de equipos al CollectionView
            EquiposCollectionView.ItemsSource = equipos;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Aquí puedes implementar la lógica de búsqueda si es necesario
        }
    }
}





