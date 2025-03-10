namespace FE.Modelo
{
    public class Tipo_Emision
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;

        public List<Tipo_Emision> Lista_Emision()
        {
            return new List<Tipo_Emision> {
                new Tipo_Emision { Id = 1, Descripcion = "NORMAL" },
                new Tipo_Emision { Id = 2, Descripcion = "CONTINGENCIA" }
            };
        }
    }
}