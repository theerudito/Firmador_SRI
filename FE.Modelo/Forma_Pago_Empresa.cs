namespace FE.Modelo
{
    public class Forma_Pago_Empresa
    {
        public int Id { get; set; }
        public string Codigo_SRI { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
    }
}