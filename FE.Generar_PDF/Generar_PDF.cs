using FE.Clave_Acceso;
using FE.Helpers;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace FE.Generar_PDF
{
    public class Generar_PDF
    {
        public static void Crear_Factura_PDF()
        {
            QuestPDF.Settings.License = LicenseType.Community;

            byte[] logoBytes = File.ReadAllBytes(@"C:\My Info\My Proyects\App Consola\FE\FE.Generar_PDF\logo.png");

            string numeroAutorizacion = Generar_Clave.Generar(
                                                Datos._fecha_emision(DateTime.Now.ToString("dd/MM/yyyy")),
                                                Datos._tipo_comprobante("01"),
                                                Datos._ruc_Emisor("1721457495001"),
                                                Datos._ambiente("PRUEBAS"),
                                                Datos._serie_establecimiento("001001"),
                                                Datos._numero_comprobante("123"),
                                                Datos._codigo_numerico(),
                                                Datos._tipo_emision("NORMAL"));

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(30);
                    page.DefaultTextStyle(x => x.FontSize(10));

                    page.Header().AlignCenter().Row(row =>
                    {
                        row.RelativeItem().Column(empresa =>
                        {
                            empresa.Item().AlignLeft().Column(col =>
                            {
                                col.Item().Height(100).Image(logoBytes);
                            });

                            empresa.Item().Text("BETWEEN BYTE SOFTWARE").FontSize(10);
                            empresa.Item().Text("RUC: 1721457495001").FontSize(8);
                            empresa.Item().Text("Direccion: Libertad del Toachi Km 8").FontSize(8);
                            empresa.Item().Text("Sucursal:").FontSize(8);
                            empresa.Item().Text("Telefono: 0960806054").FontSize(8);
                            empresa.Item().Text("OBLIGADO A LLEVAR CONTABILIDAD: NO").FontSize(8);
                        });

                        row.RelativeItem().Column(facturaCol =>
                        {
                            facturaCol.Item().PaddingTop(5).Row(facturaRow =>
                            {
                                facturaRow.RelativeItem().AlignCenter().Width(150).Height(20).AlignMiddle().AlignCenter().Text($"FACTURA: 001-002-{Datos._numero_comprobante("123")}").FontColor("#FFF").FontSize(10);
                            });

                            facturaCol.Item().PaddingTop(5).PaddingLeft(10).Text($"FECHA AUTORIZACION: {DateTime.Now.ToString("dd/MM/yyyy")} - Hora: {DateTime.Now.ToString("HH:mm:ss")}").FontSize(8);
                            facturaCol.Item().PaddingTop(2).PaddingLeft(10).Text($"AMBIENTE: {(Datos._ambiente("PRUEBAS") == "1" ? "PRUEBAS" : "PRODUCCION")}").FontSize(8);
                            facturaCol.Item().PaddingTop(2).PaddingLeft(10).Text($"EMISION: {(Datos._tipo_emision("NORMAL") == "1" ? "NORMAL" : "FACTURANDO")}").FontSize(8);

                            facturaCol.Item().PaddingTop(2).AlignCenter().Text("NUMERO DE AUTORIZACION:").Bold().FontSize(8);
                            facturaCol.Item().PaddingTop(2).AlignCenter().Text(numeroAutorizacion).FontSize(7);
                            facturaCol.Item().PaddingTop(2).AlignCenter().Text("CLAVE DE ACCESO:").Bold().FontSize(8);
                            facturaCol.Item().PaddingTop(2).AlignCenter().Image(Generar_Codigo_Barras.Crear((numeroAutorizacion)));
                        });
                    });

                    page.Content().Column(col =>
                    {
                        col.Item().PaddingVertical(2).LineHorizontal(1).LineColor("#512BD4");

                        col.Item().PaddingTop(3).Row(row =>
                        {
                            row.RelativeItem(2).Column(column =>
                            {
                                column.Item().Text("RUC/CI: 1721457495").FontSize(7);
                                column.Item().Text("CLIENTE: JORGE LOOR").FontSize(7);
                                column.Item().Text("TELEFONO: 0960806054").FontSize(7);
                                column.Item().Text("CIUDAD: SIN CIUDAD").FontSize(7);
                            });

                            row.RelativeItem(3).Column(col =>
                            {
                                col.Item().Text($"FECHA: {DateTime.Now.ToString("dd/MM/yyyy")}").FontSize(7);
                                col.Item().Text("EMAIL: erudito.tv@gmail.com").FontSize(7);
                                col.Item().Text("DIRECCION: LIBERTAD DEL TOACHI").FontSize(7);
                                col.Item().Text("CODIGO: 36").FontSize(7);
                            });
                        });

                        col.Item().PaddingVertical(2).Background("#512BD4").Row(row =>
                        {
                            row.RelativeItem().Text("CODIGO").FontColor("#FFFFFF").Bold().FontSize(8);
                            row.RelativeItem().Text("DESCRIPCION").FontColor("#FFFFFF").Bold().FontSize(8);
                            row.RelativeItem().Text("CANTIDAD").FontColor("#FFFFFF").Bold().FontSize(8);
                            row.RelativeItem().Text("P/UNITARIO").FontColor("#FFFFFF").Bold().FontSize(8);
                            row.RelativeItem().Text("DESCUENTO").FontColor("#FFFFFF").Bold().FontSize(8);
                            row.RelativeItem().Text("P/TOTAL").FontColor("#FFFFFF").Bold().FontSize(8);
                        });

                        // productos

                        foreach (var item in Datos_Iniciales._listas_Productos)
                        {
                            col.Item().BorderBottom(0.5f).BorderColor("#7C11F7").Row(row =>
                            {
                                row.RelativeItem().Text(item.Codigo).FontSize(8);
                                row.RelativeItem().Text(item.Nombre).FontSize(8);
                                row.RelativeItem().Text(item.Cantidad.ToString()).FontSize(8);
                                row.RelativeItem().Text(item.Precio_Unitario.ToString()).FontSize(8);
                                row.RelativeItem().Text(item.Descuento.ToString()).FontSize(8);
                                row.RelativeItem().Text((item.Cantidad * item.Precio_Unitario).ToString()).FontSize(8);
                            });
                        }

                        col.Item().Row(row =>
                        {
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().PaddingVertical(2).Text("Forma Pago").FontSize(8);
                                col.Item().Text("Sin Utilización Del Sistema Financiero 47.50").FontSize(8);
                                col.Item().Text("INFORMACIÓN ADICIONAL").FontSize(8);
                                col.Item().Text("Vendedor: JORGE LOOR").FontSize(8);

                                col.Item().PaddingVertical(15);

                                col.Item().Row(row =>
                                {
                                    row.RelativeItem(1).AlignCenter().Column(innerCol =>
                                    {
                                        innerCol.Item().Text("----------------------");
                                        innerCol.Item().Text("FIRMA CLIENTE").AlignCenter().FontSize(8);
                                    });

                                    row.RelativeItem(1).AlignCenter().Column(innerCol =>
                                    {
                                        innerCol.Item().Text("------------------------");
                                        innerCol.Item().Text("FIRMA AUTORIZADA").AlignCenter().FontSize(8);
                                    });
                                });
                            });

                            row.RelativeItem().PaddingTop(2).Column(col =>
                            {
                                col.Item().AlignRight().Border(1).BorderColor("#512BD4").Column(totals =>
                                {
                                    totals.Item().Row(row =>
                                    {
                                        row.RelativeItem().PaddingLeft(5).Text("Subtotal:").AlignLeft().FontSize(8);
                                        row.RelativeItem().PaddingRight(5).Text("46,79").AlignRight().FontSize(8);
                                    });

                                    totals.Item().Row(row =>
                                    {
                                        row.RelativeItem().PaddingLeft(5).Text("Descuento:").AlignLeft().FontSize(8);
                                        row.RelativeItem().PaddingRight(5).Text("3,34").AlignRight().FontSize(8);
                                    });

                                    totals.Item().Row(row =>
                                    {
                                        row.RelativeItem().PaddingLeft(5).Text("Subtotal Neto:").AlignLeft().FontSize(8);
                                        row.RelativeItem().PaddingRight(5).Text("43,45").AlignRight().FontSize(8);
                                    });

                                    totals.Item().Row(row =>
                                    {
                                        row.RelativeItem().PaddingLeft(5).Text("Subtotal 5%:").AlignLeft().FontSize(8);
                                        row.RelativeItem().PaddingRight(5).Text("0,00").AlignRight().FontSize(8);
                                    });

                                    totals.Item().Row(row =>
                                    {
                                        row.RelativeItem().PaddingLeft(5).Text("Subtotal 15%:").AlignLeft().FontSize(8);
                                        row.RelativeItem().PaddingRight(5).Text("25,45").AlignRight().FontSize(8);
                                    });

                                    totals.Item().Row(row =>
                                    {
                                        row.RelativeItem().PaddingLeft(5).Text("Subtotal 0%:").AlignLeft().FontSize(8);
                                        row.RelativeItem().PaddingRight(5).Text("18,00").AlignRight().FontSize(8);
                                    });

                                    totals.Item().Row(row =>
                                    {
                                        row.RelativeItem().PaddingLeft(5).Text("IVA 5%:").AlignLeft().FontSize(8);
                                        row.RelativeItem().PaddingRight(5).Text("0,00").AlignRight().FontSize(8);
                                    });

                                    totals.Item().Row(row =>
                                    {
                                        row.RelativeItem().PaddingLeft(5).Text("IVA 15%:").AlignLeft().FontSize(8);
                                        row.RelativeItem().PaddingRight(5).Text("3,05").AlignRight().FontSize(8);
                                    });

                                    totals.Item().Row(row =>
                                    {
                                        row.RelativeItem().PaddingLeft(5).Text("Propina:").AlignLeft().FontSize(8);
                                        row.RelativeItem().PaddingRight(5).Text("1,00").AlignRight().FontSize(8);
                                    });

                                    totals.Item().Row(row =>
                                    {
                                        row.RelativeItem().PaddingLeft(5).Text("VALOR TOTAL:").Bold().AlignLeft().FontSize(8);
                                        row.RelativeItem().PaddingRight(5).Text("47,50").Bold().AlignRight().FontSize(8);
                                    });
                                });
                            });
                        });

                        page.Footer().Text("Hecho por Between Byte Software 2024");
                    });
                });
            }).GeneratePdfAndShow();

            //Stream stream = new MemoryStream(pdf);

            //using (FileStream file = new FileStream("./file.pdf", FileMode.Create, FileAccess.Write))
            //{
            //    stream.CopyTo(file);
            //}
        }
    }
}