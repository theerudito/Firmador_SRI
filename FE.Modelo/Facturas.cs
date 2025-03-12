namespace FE.Modelo
{
    public class Facturas
    {
        public int IdFactura { get; set; }

        public byte[] XML { get; set; } = null!;

        public byte[] PDF { get; set; } = null!;
    }
}