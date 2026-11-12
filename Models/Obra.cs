namespace ComercioArtes.Models
{
    // Clase Obra, representa una obra de arte
    public class Obra
    {
        // Datos de la obra
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public TecnicaObra Tecnica { get; set; }
        public string Dimensiones { get; set; }
        public int Anio { get; set; }
        public decimal Precio { get; set; }
        public EstadoObra Estado { get; set; }         // si está disponible, vendida, etc
        public int IdArtista { get; set; }     // artista que la creó

        public Obra()
        {
            Titulo = string.Empty;
            Descripcion = string.Empty;
            Dimensiones = string.Empty;
            Estado = EstadoObra.Disponible;
        }

        // Constructor con todos los datos de la obra
        public Obra(int id, string titulo, string descripcion, TecnicaObra tecnica,
                    string dimensiones, int anio, decimal precio, int idArtista)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = descripcion;
            Tecnica = tecnica;
            Dimensiones = dimensiones;
            Anio = anio;
            Precio = precio;
            IdArtista = idArtista;
            Estado = EstadoObra.Disponible;
        }

        public override string ToString() => Titulo;
    }
}
