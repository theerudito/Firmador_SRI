namespace FE.Modelo
{
    public class Empresa : Adicionales
    {
        public int Id_Empresa { get; set; }
        public string RUC { get; set; } = string.Empty;
        public string Razon_Social { get; set; } = string.Empty;
        public string Nombre_Comercial { get; set; } = string.Empty;
        public string Direccion_Matriz { get; set; } = string.Empty;
        public string Direccion_Emisor { get; set; } = string.Empty;
        public string Establecimiento { get; set; } = string.Empty;
        public string Punto_Emision { get; set; } = string.Empty;
        public string Contribuyento_Especial { get; set; } = string.Empty;
        public string Telefono1 { get; set; } = string.Empty;
        public string Telefono2 { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Web { get; set; } = string.Empty;
        public string Informacion { get; set; } = string.Empty;
        public string Url_Descarga_Documentos { get; set; } = string.Empty;

        // EMAIL
        public string Servidor_Email { get; set; } = string.Empty;

        public int Puerto_Email { get; set; }
        public string Cuenta_Email { get; set; } = string.Empty;
        public string Contraseña_Email { get; set; } = string.Empty;
        public string ApiKey_Email { get; set; } = string.Empty;

        // OPCIONALES
        public byte[] Logo { get; set; } = null!;

        public DateTime Fecha_Instalacion { get; set; }
        public DateTime Fecha_Expirarion { get; set; }

        public byte[] FirmaElectronica { get; set; } = null!;

        public string Clave_Firma { get; set; } = string.Empty;
        public DateTime Expirarion_Firma { get; set; }

        public string Cuenta_DropBox { get; set; } = string.Empty;
        public string Contraseña_DropBox { get; set; } = string.Empty;
        public string ApiKey_DropBox { get; set; } = string.Empty;
    }
}