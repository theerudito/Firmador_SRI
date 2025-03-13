namespace FE.Modelo
{
    public class Marcas : Adicionales
    {
        public int Id_Marcas { get; set; }

        public virtual List<Productos> Navegacion_Productos { get; set; } = new List<Productos>();
    }
}