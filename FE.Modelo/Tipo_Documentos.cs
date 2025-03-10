namespace FE.Modelo
{
    public class Tipo_Documentos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;

        public List<Tipo_Documentos> Lista_Documentos()
        {
            return new List<Tipo_Documentos> {
                new Tipo_Documentos { Id = 1, Descripcion = "FACTURA", Codigo = "01" },
                new Tipo_Documentos { Id = 2, Descripcion = "LIQUIDACIÓN DE COMPRA DE BIENES Y PRESTACIÓN DE SERVICIOS", Codigo = "03" },
                new Tipo_Documentos { Id = 3, Descripcion = "NOTA DE CREDITO", Codigo = "04" },
                new Tipo_Documentos { Id = 4, Descripcion = "NOTA DE DEBITO", Codigo = "05" },
                new Tipo_Documentos { Id = 5, Descripcion = "GUÍA DE REMISION", Codigo = "06" },
                new Tipo_Documentos { Id = 6, Descripcion = "COMPROBANTE DE RETENCION", Codigo = "07" },
            };
        }
    }
}