namespace FE.Modelo
{
    public class Forma_Pago_SRI
    {
        public int Id { get; set; }
        public string Codigo_SRI { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;

        public DateTime Fecha_Desde { get; set; }
        public DateTime Fecha_Hasta { get; set; }
    }
}