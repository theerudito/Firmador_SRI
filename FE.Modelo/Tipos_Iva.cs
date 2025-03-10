namespace FE.Modelo
{
    public class Tipos_Iva
    {
        public int Id { get; set; }
        public string Porcentaje { get; set; } = string.Empty;
        public string Codigo_SRI { get; set; } = string.Empty;
        public string Valor { get; set; } = string.Empty;

        public DateTime Fecha_Desde { get; set; }
        public DateTime Fecha_Hasta { get; set; }

        public static List<Tipos_Iva> _Lista_Iva = new List<Tipos_Iva>
        {
            new Tipos_Iva
            {
                Id = 1,
                Porcentaje = "0%",
                Codigo_SRI = "0",
                Valor = "0",
                Fecha_Desde = DateTime.Parse("1900-01-01"),
                Fecha_Hasta = DateTime.Parse("2100-12-31")
            },
            new Tipos_Iva
            { Id = 2,
                Porcentaje = "13%",
                Codigo_SRI = "10",
                Valor = "13",
                Fecha_Desde = DateTime.Parse("2027-01-01"),
                Fecha_Hasta = DateTime.Parse("2050-12-31")
            },
            new Tipos_Iva
            {
                Id = 3,
                Porcentaje = "12%",
                Codigo_SRI = "2",
                Valor = "12",
                Fecha_Desde = DateTime.Parse("1900-01-01"),
                Fecha_Hasta = DateTime.Parse("2024-03-31")
            },
            new Tipos_Iva
            {
                Id = 4,
                Porcentaje = "14%",
                Codigo_SRI = "3",
                Valor = "14",
                Fecha_Desde = DateTime.Parse("2016-06-01"),
                Fecha_Hasta = DateTime.Parse("2024-03-31")
            },
            new Tipos_Iva
            {
                Id = 5,
                Porcentaje = "15%",
                Codigo_SRI = "4",
                Valor = "15",
                Fecha_Desde = DateTime.Parse("2024-04-01"),
                Fecha_Hasta = DateTime.Parse("2026-12-31")
            },
            new Tipos_Iva
            {
                Id = 6,
                Porcentaje = "5%",
                Codigo_SRI = "5",
                Valor = "5",
                Fecha_Desde = DateTime.Parse("2024-04-01"),
                Fecha_Hasta = DateTime.Parse("2026-12-31")
            },
            new Tipos_Iva
            {
                Id = 7,
                Porcentaje = "No Objeto",
                Codigo_SRI = "6",
                Valor = "0",
                Fecha_Desde = DateTime.Parse("1900-01-01"),
                Fecha_Hasta = DateTime.Parse("2100-12-31")
            },
            new Tipos_Iva
            {
                Id = 8,
                Porcentaje = "Exento de IVA",
                Codigo_SRI = "7",
                Valor = "0",
                Fecha_Desde = DateTime.Parse("1900-01-01"),
                Fecha_Hasta = DateTime.Parse("2026-12-31")
            },
            new Tipos_Iva
            {
                Id = 9,
                Porcentaje = "8%",
                Codigo_SRI = "8",
                Valor = "8",
                Fecha_Desde = DateTime.Parse("2023-01-01"),
                Fecha_Hasta = DateTime.Parse("2100-12-31")
            }
        };
    }
}