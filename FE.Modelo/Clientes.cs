namespace FE.Modelo
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Identificacion { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}