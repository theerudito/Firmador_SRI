namespace FE.Modelo
{
    public class Tipo_Emision
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;

        public static List<Tipo_Emision> _lista_Emision = new List<Tipo_Emision>
        {
                new Tipo_Emision
                {
                    Id = 1,
                    Descripcion = "NORMAL"
                },
                new Tipo_Emision
                {
                    Id = 2,
                    Descripcion = "CONTINGENCIA"
                }
        };
    }
}