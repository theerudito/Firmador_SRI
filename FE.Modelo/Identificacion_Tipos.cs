namespace FE.Modelo
{
    public class Identificacion_Tipos : Adicionales
    {
        public int Id_Identificacion_Tipos { get; set; }
        public string Codigo { get; set; } = string.Empty;

        public virtual List<Clientes> Navegacion_Clientes { get; set; } = new List<Clientes>();
    }
}