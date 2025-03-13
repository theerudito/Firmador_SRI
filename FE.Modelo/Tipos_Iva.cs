namespace FE.Modelo
{
    public class Tipos_Iva : Adicionales
    {
        public int Id_Tipos_Iva { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Valor { get; set; } = string.Empty;

        public DateTime Fecha_Desde { get; set; }
        public DateTime Fecha_Hasta { get; set; }
    }
}