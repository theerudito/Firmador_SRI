namespace FE.Modelo
{
    public class Clientes_Tipos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;

        public List<Clientes_Tipos> Lista_Tipos_Clientes()
        {
            return new List<Clientes_Tipos> {
                new Clientes_Tipos { Id = 1, Descripcion = "RUC", Codigo = "04"},
                new Clientes_Tipos { Id = 2, Descripcion = "CEDULA", Codigo = "05" },
                new Clientes_Tipos { Id = 3, Descripcion = "PASAPORTE", Codigo = "06" },
                new Clientes_Tipos { Id = 4, Descripcion = "VENTA A CONSUMIDOR FINAL", Codigo = "07" },
                new Clientes_Tipos { Id = 5, Descripcion = "IDENTIFICACIÓN DELEXTERIOR", Codigo = "08" }
            };
        }
    }
}