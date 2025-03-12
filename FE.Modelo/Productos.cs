namespace FE.Modelo
{
    public class Productos
    {
        public int IdProductos { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public int Cantidad { get; set; }
        public decimal Precio_Unitario { get; set; }
        public decimal Descuento { get; set; }
    }
}