namespace FE.Modelo
{
    public class Ciudades : Adicionales
    {
        public int Id_Ciudades { get; set; }
        public virtual List<Clientes> Navegacion_Clientes { get; set; } = new List<Clientes>();
    }
}