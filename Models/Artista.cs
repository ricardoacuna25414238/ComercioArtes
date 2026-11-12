namespace ComercioArtes.Models
{
    // Clase Artista, hereda de Persona
    public class Artista : Persona
    {
        // Datos propios del artista
        public string Pais { get; set; }
        public string Biografia { get; set; }
        public string Trayectoria { get; set; }

        public Artista()
        {
            Pais = string.Empty;
            Biografia = string.Empty;
            Trayectoria = string.Empty;
        }

        // Constructor con todos los datos
        public Artista(int id, string nombre, string correo, string telefono,
                       string pais, string biografia, string trayectoria)
            : base(id, nombre, correo, telefono)
        {
            Pais = pais;
            Biografia = biografia;
            Trayectoria = trayectoria;
        }

        // Indica que esta persona es un artista
        public override string Rol => "Artista";
    }
}
