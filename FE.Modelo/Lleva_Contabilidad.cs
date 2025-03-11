namespace FE.Modelo
{
    public class Lleva_Contabilidad
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;

        public static List<Lleva_Contabilidad> _lista_Lleva_Contabilidad = new List<Lleva_Contabilidad>
        {
            new Lleva_Contabilidad
            {
                Id = 1,
                Descripcion = "SI"
            },
            new Lleva_Contabilidad
            {
                Id = 2,
                Descripcion = "NO"
            },
        };
    }
}