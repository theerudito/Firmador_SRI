using ZXing;
using ZXing.SkiaSharp;

namespace FE.Helpers
{
    public class Generar_Codigo_Barras
    {
        public static byte[] Crear(string texto)
        {
            var barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new ZXing.Common.EncodingOptions
                {
                    Height = 40,
                    Width = 300,
                    Margin = 10
                }
            };

            using var bitmap = barcodeWriter.Write(texto);
            using var stream = new MemoryStream();
            bitmap.Encode(SkiaSharp.SKEncodedImageFormat.Png, 100).SaveTo(stream);

            return stream.ToArray();
        }
    }
}