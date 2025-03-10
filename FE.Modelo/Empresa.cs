namespace FE.Modelo
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }
        public string Nombre_Comercial { get; set; } = string.Empty;
        public string Razon_Social { get; set; } = string.Empty;
        public string RUC { get; set; } = string.Empty;

        public string Direccion { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public byte[] Logo { get; set; } = null!;
    }
}