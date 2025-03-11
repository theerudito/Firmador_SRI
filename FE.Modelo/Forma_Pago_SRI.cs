namespace FE.Modelo
{
    public class Forma_Pago_SRI
    {
        public int Id { get; set; }
        public string Codigo_SRI { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;

        public DateTime Fecha_Desde { get; set; }
        public DateTime Fecha_Hasta { get; set; }

        public static List<Forma_Pago_SRI> _lista_Forma_Pago_SRI = new List<Forma_Pago_SRI>
        {
            new Forma_Pago_SRI
            {
                Id = 1,
                Codigo_SRI = "01",
                Descripcion = "Sin Utilización Del Sistema Financiero",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            },
            new Forma_Pago_SRI
            {
                Id = 2,
                Codigo_SRI = "15",
                Descripcion = "Compensación De Deudas",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            },
            new Forma_Pago_SRI
            {
                Id = 3,
                Codigo_SRI = "16",
                Descripcion = "Tarjeta De Débito",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            },
            new Forma_Pago_SRI
            {
                Id = 4,
                Codigo_SRI = "18",
                Descripcion = "Tarjeta Prepago",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            },
            new Forma_Pago_SRI
            {
                Id = 5,
                Codigo_SRI = "19",
                Descripcion = "Tarjeta De Crédito",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            },
            new Forma_Pago_SRI
            {
                Id = 6,
                Codigo_SRI = "20",
                Descripcion = "Otros Con Utilización Del Sistema Financiero",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            },
            new Forma_Pago_SRI
            {
                Id = 8,
                Codigo_SRI = "21",
                Descripcion = "Endoso De Títulos",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            }
        };
    }
}