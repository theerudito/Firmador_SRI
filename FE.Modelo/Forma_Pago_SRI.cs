namespace FE.Modelo
{
    public class Forma_Pago_SRI : Adicionales
    {
        public int Id_Forma_Pago_SRI { get; set; }
        public string Codigo { get; set; } = string.Empty;

        public DateTime Fecha_Desde { get; set; }
        public DateTime Fecha_Hasta { get; set; }
    }
}