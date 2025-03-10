namespace FE.Modelo
{
    public class Forma_Pago_Empresa
    {
        public int Id { get; set; }
        public string Codigo_SRI { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;

        public static List<Forma_Pago_Empresa> _listaForma_Pago_Empresa = new List<Forma_Pago_Empresa>
        {
           new Forma_Pago_Empresa
           {
               Id = 1,
               Codigo_SRI = "01",
               Tipo = "EF",
               Descripcion = "Efectivo",
           },
           new Forma_Pago_Empresa
           {
               Id = 2,
               Codigo_SRI = "01",
               Tipo = "CR",
               Descripcion = "Crédito",
           },
           new Forma_Pago_Empresa
           {
               Id = 3,
               Codigo_SRI = "20",
               Tipo = "CH",
               Descripcion = "Cheque",
           },
           new Forma_Pago_Empresa
           {
               Id = 4,
               Codigo_SRI = "19",
               Tipo = "TA",
               Descripcion = "Tarjeta de Crédito",
           },
           new Forma_Pago_Empresa
           {
               Id = 5,
               Codigo_SRI = "20",
               Tipo = "DP",
               Descripcion = "Deposito",
           },
           new Forma_Pago_Empresa
           {
               Id = 6,
               Codigo_SRI = "01",
               Tipo = "NC",
               Descripcion = "Nota de Crédito",
           },
           new Forma_Pago_Empresa
           {
               Id = 7,
               Codigo_SRI = "01",
               Tipo = "ND",
               Descripcion = "Nota de Débito",
           },
           new Forma_Pago_Empresa
           {
               Id = 8,
               Codigo_SRI = "01",
               Tipo = "MP",
               Descripcion = "Múltiple",
           },
           new Forma_Pago_Empresa
           {
               Id = 9,
               Codigo_SRI = "01",
               Tipo = "CI",
               Descripcion = "NC Interna",
           },
           new Forma_Pago_Empresa
           {
               Id = 10,
               Codigo_SRI = "01",
               Tipo = "DI",
               Descripcion = "ND Interna",
           },
        };
    }
}