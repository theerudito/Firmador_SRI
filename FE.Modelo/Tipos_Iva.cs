namespace FE.Modelo
{
    public class Tipos_Iva
    {
        public int Id { get; set; }
        public string Porcentaje { get; set; } = string.Empty;
        public string Codigo_SRI { get; set; } = string.Empty;
        public string Valor { get; set; } = string.Empty;

        public DateTime Fecha_Desde { get; set; }
        public DateTime Fecha_Hasta { get; set; }
    }
}