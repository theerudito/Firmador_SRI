namespace FE.Modelo
{
    public class Facturas : Adicionales
    {
        public int Id_Factura { get; set; }

        public byte[] XML { get; set; } = null!;

        public byte[] PDF { get; set; } = null!;
    }
}