namespace FE.Modelo
{
    public class Tipo_Ambiente
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;

        public List<Tipo_Ambiente> Lista_Ambiente()
        {
            return new List<Tipo_Ambiente> {
                new Tipo_Ambiente { Id = 1, Descripcion = "PRUEBAS", Codigo = "1"},
                new Tipo_Ambiente { Id = 2, Descripcion = "PRODUCCION", Codigo = "2" }
            };
        }
    }
}