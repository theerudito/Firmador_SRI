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

        public static List<Productos> _listas_Productos = new List<Productos>
        {
                new Productos
                {
                    IdProductos = 1,
                    Nombre = "Producto 1",
                    Codigo = "001",
                    Cantidad = 2,
                    Precio_Unitario = 10,
                    Descuento = 0
                },

                new Productos
                {
                    IdProductos = 2,
                    Nombre = "Producto 2",
                    Codigo = "002",
                    Cantidad = 3,
                    Precio_Unitario = 15,
                    Descuento = 0
                },

                new Productos
                {
                    IdProductos = 3,
                    Nombre = "Producto 3",
                    Codigo = "003",
                    Cantidad = 1,
                    Precio_Unitario = 20,
                    Descuento = 0
                }
        };
    }
}