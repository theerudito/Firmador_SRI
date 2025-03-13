namespace FE.Modelo
{
    public class Forma_Pago_Empresa : Adicionales
    {
        public int Id_Forma_Pago_Empresa { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
    }
}