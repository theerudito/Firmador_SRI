namespace FE.Modelo
{
    public class Adicionales
    {
        public bool Estado { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public string Usuario_Creacion { get; set; } = string.Empty;
        public string Usuario_Modificacion { get; set; } = string.Empty;
        public DateTime Fecha_Creacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }
    }
}