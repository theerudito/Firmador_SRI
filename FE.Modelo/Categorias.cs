namespace FE.Modelo
{
    public class Categorias : Adicionales
    {
        public int Id_Categorias { get; set; }

        public virtual List<Productos> Navegacion_Productos { get; set; } = new List<Productos>();
    }
}