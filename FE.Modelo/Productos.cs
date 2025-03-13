namespace FE.Modelo
{
    public class Productos : Adicionales
    {
        public int Id_Productos { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;
        public int Cantidad { get; set; }
        public decimal Precio_Unitario { get; set; }
        public decimal Descuento { get; set; }

        public int Id_Marcas { get; set; }
        public virtual Marcas Marcas { get; set; } = null!;

        public int Id_Categorias { get; set; }
        public virtual Categorias Categorias { get; set; } = null!;
    }
}