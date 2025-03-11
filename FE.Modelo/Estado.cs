namespace FE.Modelo
{
    public class Estado
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;

        public List<Estado> _lista_Estados = new List<Estado>
        {
                new Estado
                {
                    Id = 1,
                    Descripcion = "EN PROCESAMIENTO",
                    Codigo = "PPR"
                },
                new Estado
                {
                    Id = 2,
                    Descripcion = "AUTORIZADO",
                    Codigo = "AUT"
                },
                new Estado {
                    Id = 3,
                    Descripcion = "NO AUTORIZADO",
                    Codigo = "NAT"
                }
        };
    }
}