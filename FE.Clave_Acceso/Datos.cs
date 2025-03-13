namespace FE.Clave_Acceso
{
    public static class Datos
    {
        // Fecha de emisión(ddMMyyyy)
        public static string _fecha_emision(string fecha)
        {
            DateTime fechaConvertida;
            string formatoEntrada = "dd/MM/yyyy";

            if (DateTime.TryParseExact(fecha, formatoEntrada,
                                       System.Globalization.CultureInfo.InvariantCulture,
                                       System.Globalization.DateTimeStyles.None,
                                       out fechaConvertida))
            {
                return fechaConvertida.ToString("ddMMyyyy");
            }
            else
            {
                Console.WriteLine("Fecha inválida.");
                return DateTime.Now.ToString("ddMMyyyy");
            }
        }

        // Tipo de comprobante
        public static string _tipo_comprobante(string tipo)
        {
            switch (tipo)
            {
                case "Factura": return "01";
                case "Nota de Crédito": return "04";
                case "Nota de Débito": return "05";
                case "Guía de Remisión": return "06";
                case "Comprobante de Retención": return "07";
                default: return "01";
            }
        }

        // RUC del emisor
        public static string _ruc_Emisor(string ruc)
        {
            if (ruc.Length != 13 || !ruc.All(char.IsDigit))
            {
                Console.WriteLine("El RUC debe tener 13 dígitos numéricos.");
            }
            return ruc;
        }

        // Código numérico aleatorio
        public static string _codigo_numerico()
        {
            Random random = new Random();
            return random.Next(10000000, 99999999).ToString("D8");
        }

        // Tipo de ambiente
        public static string _ambiente(string tipo) => tipo.ToUpper() == "PRUEBAS" ? "1" : "2";

        // Serie (establecimiento + punto emisión)
        public static string _serie_establecimiento(string serie)
        {
            if (serie.Length != 6 || !serie.All(char.IsDigit))
            {
                Console.WriteLine("El código del establecimiento y punto de emisión debe tener 6 dígitos.");
            }

            return serie;
        }

        // Código numérico
        public static string _numero_comprobante(string numero)
        {
            return numero.PadLeft(9, '0');
        }

        // Tipo de emisión
        public static string _tipo_emision(string tipo) => tipo.ToUpper() == "NORMAL" ? "1" : "2";
    }
}