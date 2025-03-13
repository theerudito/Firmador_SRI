namespace FE.Modelo
{
    public class Clientes : Adicionales
    {
        public int Id_Clientes { get; set; }
        public string Identificacion { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Id_Ciudades { get; set; }

        public virtual Ciudades Ciudades { get; set; } = null!;
        public int Id_Identificacion_Tipos { get; set; }

        public virtual Identificacion_Tipos Identificacion_Tipos { get; set; } = null!;
    }
}