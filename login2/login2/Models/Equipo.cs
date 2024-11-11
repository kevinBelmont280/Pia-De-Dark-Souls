using System.Collections.Generic;

namespace login2.Models
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public string Clase { get; set; }
        public string Regalo { get; set; }
        public int Vitalidad { get; set; }
        public int Aprendizaje { get; set; }
        public int Aguante { get; set; }
        public int Fuerza { get; set; }
        public int Destreza { get; set; }
        public int Resistencia { get; set; }
        public int Inteligencia { get; set; }
        public int Fe { get; set; }
    }

    public class Equipo
    {
        public string Nombre { get; set; }
        public List<Jugador> Jugadores { get; set; }

        public Equipo()
        {
            Jugadores = new List<Jugador>();
        }

        // Método para obtener los equipos ya creados
        public static List<Equipo> ObtenerEquiposCreados()
        {
            // Aquí cargas los equipos ya existentes desde una base de datos, archivo, o lista en memoria
            return new List<Equipo>
            {
                new Equipo
                {
                    Nombre = "Equipo Fuego",
                    Jugadores = new List<Jugador>
                    {
                        new Jugador { Nombre = "Juan", Clase = "Guerrero", Regalo = "Espada", Vitalidad = 100, Aprendizaje = 50, Aguante = 70, Fuerza = 90, Destreza = 60, Resistencia = 80, Inteligencia = 40, Fe = 30 },
                        new Jugador { Nombre = "Ana", Clase = "Maga", Regalo = "Báculo", Vitalidad = 70, Aprendizaje = 90, Aguante = 50, Fuerza = 30, Destreza = 40, Resistencia = 60, Inteligencia = 100, Fe = 80 }
                    }
                },
                new Equipo
                {
                    Nombre = "Equipo Agua",
                    Jugadores = new List<Jugador>
                    {
                        new Jugador { Nombre = "Luis", Clase = "Arquero", Regalo = "Arco", Vitalidad = 85, Aprendizaje = 55, Aguante = 65, Fuerza = 70, Destreza = 85, Resistencia = 60, Inteligencia = 50, Fe = 20 },
                        new Jugador { Nombre = "María", Clase = "Sanadora", Regalo = "Amuleto", Vitalidad = 60, Aprendizaje = 85, Aguante = 45, Fuerza = 40, Destreza = 50, Resistencia = 70, Inteligencia = 80, Fe = 100 }
                    }
                }
            };
        }
    }
}
