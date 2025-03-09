namespace FE.Clave_Acceso
{
    public static class Generar_Clave
    {
        public static string Generar(string fechaEmision,
                                     string tipoComprobante,
                                     string rucEmisor,
                                     string tipoAmbiente,
                                     string serieEstablecimiento,
                                     string numeroComprobante,
                                     string codigoNumerico,
                                     string tipoEmision)
        {
            // Validaciones de entrada
            if (string.IsNullOrWhiteSpace(fechaEmision) || string.IsNullOrWhiteSpace(tipoComprobante) ||
                string.IsNullOrWhiteSpace(rucEmisor) || string.IsNullOrWhiteSpace(codigoNumerico) ||
                string.IsNullOrWhiteSpace(tipoAmbiente) || string.IsNullOrWhiteSpace(serieEstablecimiento) ||
                string.IsNullOrWhiteSpace(numeroComprobante) || string.IsNullOrWhiteSpace(tipoEmision))
            {
                throw new ArgumentException("Ningún parámetro puede ser nulo o vacío.");
            }

            // Construcción de la clave de acceso sin el dígito verificador
            string claveAcceso = fechaEmision + tipoComprobante + rucEmisor + tipoAmbiente +
                                 serieEstablecimiento + numeroComprobante + codigoNumerico + tipoEmision;

            // Invertir la clave de acceso
            string claveAccesoInvertida = new string(claveAcceso.Reverse().ToArray());

            // Cálculo del dígito verificador usando módulo 11
            int acumulador = 0;
            int serie = 2;

            foreach (char c in claveAccesoInvertida)
            {
                if (!char.IsDigit(c)) throw new ArgumentException("La clave de acceso contiene caracteres no numéricos.");

                if (serie > 7) serie = 2; // Reiniciar la serie a 2 después de 7
                acumulador += (c - '0') * serie;
                serie++;
            }

            // Cálculo del dígito verificador
            int digitoVerificador = 11 - (acumulador % 11);
            if (digitoVerificador >= 10) digitoVerificador = digitoVerificador == 10 ? 1 : 0;

            // Retornar clave final
            return claveAcceso + digitoVerificador;
        }
    }
}