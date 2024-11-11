using login2.Models;
using System;
using Xamarin.Forms;

namespace login2
{
    public partial class Creación_de_Equipo : ContentPage
    {
        private Equipo equipo;
        private int jugadoresAgregados = 0;
        private int puntosDisponibles = 20;

        public Creación_de_Equipo()
        {
            InitializeComponent();
            equipo = new Equipo(); // Instancia de equipo
        }

        // Evento para el botón "Crear Equipo"
        private void Button_Clicked(object sender, EventArgs e)
        {
            string nombreEquipo = entryNombreEquipo.Text;
            if (!string.IsNullOrEmpty(nombreEquipo))
            {
                equipo.Nombre = nombreEquipo;
                DisplayAlert("Equipo Creado", $"El equipo '{nombreEquipo}' ha sido creado.", "OK");
            }
            else
            {
                DisplayAlert("Error", "Por favor, ingresa un nombre para el equipo.", "OK");
            }
        }

        // Evento para el botón "Agregar Jugador"
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (jugadoresAgregados < 5)
            {
                string nombreJugador = entryNombreJugador.Text;
                string clase = pickerClase.SelectedItem?.ToString();
                string regalo = pickerRegalo.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(nombreJugador) && clase != null && regalo != null)
                {
                    Jugador nuevoJugador = new Jugador
                    {
                        Nombre = nombreJugador,
                        Clase = clase,
                        Regalo = regalo,
                        Vitalidad = int.Parse(labelVitalidad.Text),
                        Aprendizaje = int.Parse(labelAprendizaje.Text),
                        Aguante = int.Parse(labelAguante.Text),
                        Fuerza = int.Parse(labelFuerza.Text),
                        Destreza = int.Parse(labelDestreza.Text),
                        Resistencia = int.Parse(labelResistencia.Text),
                        Inteligencia = int.Parse(labelInteligencia.Text),
                        Fe = int.Parse(labelFe.Text)
                    };

                    equipo.Jugadores.Add(nuevoJugador); // Agrega el jugador al equipo
                    jugadoresAgregados++;
                    labelJugadores.Text = $"Jugadores: {jugadoresAgregados}/5";
                    DisplayAlert("Jugador Agregado", $"{nombreJugador} ha sido agregado al equipo.", "OK");

                    // Reiniciar campos después de agregar un jugador
                    entryNombreJugador.Text = string.Empty;
                    pickerClase.SelectedItem = null;
                    pickerRegalo.SelectedItem = null;
                }
                else
                {
                    DisplayAlert("Error", "Por favor, completa todos los campos para agregar un jugador.", "OK");
                }
            }
            else
            {
                DisplayAlert("Límite Alcanzado", "Ya has agregado el máximo de jugadores (5).", "OK");
            }
        }

        // Evento para el botón "Finalizar Creación"
        private void Button_Clicked_2(object sender, EventArgs e)
        {
            if (jugadoresAgregados == 5)
            {
                DisplayAlert("Equipo Creado", $"El equipo '{equipo.Nombre}' ha sido creado exitosamente con {equipo.Jugadores.Count} jugadores.", "OK");
                // Aquí puedes guardar el equipo en una base de datos, o pasar el objeto `equipo` a otra página
            }
            else
            {
                DisplayAlert("Error", "Debes agregar 5 jugadores antes de finalizar.", "OK");
            }
        }

        // Método para actualizar los puntos disponibles en la interfaz
        private void ActualizarPuntos()
        {
            labelPuntos.Text = $"Puntos disponibles: {puntosDisponibles}";
        }

        // Evento para aumentar el valor de las estadísticas
        private void AumentarValor(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            StackLayout parent = (StackLayout)button.Parent;
            Label label = (Label)parent.Children[1];

            if (puntosDisponibles > 0)
            {
                int valorActual = int.Parse(label.Text);
                valorActual++;
                puntosDisponibles--;
                label.Text = valorActual.ToString();
                ActualizarPuntos();
            }
        }

        // Evento para disminuir el valor de las estadísticas
        private void DisminuirValor(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            StackLayout parent = (StackLayout)button.Parent;
            Label label = (Label)parent.Children[1];

            int valorActual = int.Parse(label.Text);
            if (valorActual > 1)
            {
                valorActual--;
                puntosDisponibles++;
                label.Text = valorActual.ToString();
                ActualizarPuntos();
            }
        }

        // Evento para actualizar la imagen según la clase seleccionada
        private void pickerClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = pickerClase.SelectedIndex;
            if (selectedIndex != -1)
            {
                switch (selectedIndex)
                {
                    case 0:
                        imageClase.Source = "https://static.wikia.nocookie.net/dark-souls/images/7/74/Guerrero.jpg/revision/latest?cb=20190222201640&path-prefix=es";
                        break;
                    case 1:
                        imageClase.Source = "https://static.wikia.nocookie.net/dark-souls/images/d/d0/Caballero.jpg/revision/latest?cb=20190222201639&path-prefix=es";
                        break;
                    case 2:
                        imageClase.Source = "https://static.wikia.nocookie.net/dark-souls/images/d/de/Vagabundo.jpg/revision/latest?cb=20190222201923&path-prefix=es";
                        break;
                    case 3:
                        imageClase.Source = "https://static.wikia.nocookie.net/dark-souls/images/b/bf/Ladr%C3%B3n.jpg/revision/latest?cb=20190222201640&path-prefix=es";
                        break;
                    case 4:
                        imageClase.Source = "https://static.wikia.nocookie.net/dark-souls/images/1/17/Bandido.jpg/revision/latest?cb=20190222201639&path-prefix=es";
                        break;
                    case 5:
                        imageClase.Source = "https://static.wikia.nocookie.net/dark-souls/images/b/b6/Cazador.jpg/revision/latest?cb=20190222201639&path-prefix=es";
                        break;
                    case 6:
                        imageClase.Source = "https://static.wikia.nocookie.net/dark-souls/images/3/31/Hechicero.jpg/revision/latest?cb=20190222201640&path-prefix=es";
                        break;
                    case 7:
                        imageClase.Source = "https://static.wikia.nocookie.net/dark-souls/images/5/5b/Pirom%C3%A1ntico.jpg/revision/latest?cb=20190222201913&path-prefix=es";
                        break;
                    case 8:
                        imageClase.Source = "https://static.wikia.nocookie.net/dark-souls/images/c/cc/Cl%C3%A9rigo.jpg/revision/latest?cb=20190222201640&path-prefix=es";
                        break;
                    case 9:
                        imageClase.Source = "https://static.wikia.nocookie.net/dark-souls/images/5/51/Marginado.jpg/revision/latest?cb=20190222201640&path-prefix=es";
                        break;
                    default:
                        imageClase.Source = "https://png.pngtree.com/thumb_back/fh260/background/20210207/pngtree-simple-black-solid-color-background-image_556932.jpg";
                        break;
                }
            }
        }
    }
}
