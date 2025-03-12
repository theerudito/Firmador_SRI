using FE.Modelo;

namespace FE.Helpers
{
    public class Datos_Iniciales
    {
        public static List<Estado> _lista_Estados = new List<Estado>
        {
                new Estado
                {
                    Id = 1,
                    Descripcion = "EN PROCESAMIENTO",
                    Codigo = "PPR"
                },
                new Estado
                {
                    Id = 2,
                    Descripcion = "AUTORIZADO",
                    Codigo = "AUT"
                },
                new Estado {
                    Id = 3,
                    Descripcion = "NO AUTORIZADO",
                    Codigo = "NAT"
                }
        };

        public static List<Forma_Pago_Empresa> _listaForma_Pago_Empresa = new List<Forma_Pago_Empresa>
        {
           new Forma_Pago_Empresa
           {
               Id = 1,
               Codigo_SRI = "01",
               Tipo = "EF",
               Descripcion = "Efectivo",
           },
           new Forma_Pago_Empresa
           {
               Id = 2,
               Codigo_SRI = "01",
               Tipo = "CR",
               Descripcion = "Crédito",
           },
           new Forma_Pago_Empresa
           {
               Id = 3,
               Codigo_SRI = "20",
               Tipo = "CH",
               Descripcion = "Cheque",
           },
           new Forma_Pago_Empresa
           {
               Id = 4,
               Codigo_SRI = "19",
               Tipo = "TA",
               Descripcion = "Tarjeta de Crédito",
           },
           new Forma_Pago_Empresa
           {
               Id = 5,
               Codigo_SRI = "20",
               Tipo = "DP",
               Descripcion = "Deposito",
           },
           new Forma_Pago_Empresa
           {
               Id = 6,
               Codigo_SRI = "01",
               Tipo = "NC",
               Descripcion = "Nota de Crédito",
           },
           new Forma_Pago_Empresa
           {
               Id = 7,
               Codigo_SRI = "01",
               Tipo = "ND",
               Descripcion = "Nota de Débito",
           },
           new Forma_Pago_Empresa
           {
               Id = 8,
               Codigo_SRI = "01",
               Tipo = "MP",
               Descripcion = "Múltiple",
           },
           new Forma_Pago_Empresa
           {
               Id = 9,
               Codigo_SRI = "01",
               Tipo = "CI",
               Descripcion = "NC Interna",
           },
           new Forma_Pago_Empresa
           {
               Id = 10,
               Codigo_SRI = "01",
               Tipo = "DI",
               Descripcion = "ND Interna",
           },
        };

        public static List<Clientes_Tipos> _lista_Clientes = new List<Clientes_Tipos>
        {
            new Clientes_Tipos
            {
                Id = 1,
                Descripcion = "RUC",
                Codigo = "04"
            },
            new Clientes_Tipos
            {
                Id = 2,
                Descripcion = "CEDULA",
                Codigo = "05"
            },
            new Clientes_Tipos
            {
                Id = 3,
                Descripcion = "PASAPORTE",
                Codigo = "06"
            },
            new Clientes_Tipos
            {
                Id = 4,
                Descripcion = "VENTA A CONSUMIDOR FINAL",
                Codigo = "07"
            },
            new Clientes_Tipos
            {
                Id = 5,
                Descripcion = "IDENTIFICACIÓN DELEXTERIOR",
                Codigo = "08"
            }
        };

        public static List<Forma_Pago_SRI> _lista_Forma_Pago_SRI = new List<Forma_Pago_SRI>
        {
            new Forma_Pago_SRI
            {
                Id = 1,
                Codigo_SRI = "01",
                Descripcion = "Sin Utilización Del Sistema Financiero",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            },
            new Forma_Pago_SRI
            {
                Id = 2,
                Codigo_SRI = "15",
                Descripcion = "Compensación De Deudas",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            },
            new Forma_Pago_SRI
            {
                Id = 3,
                Codigo_SRI = "16",
                Descripcion = "Tarjeta De Débito",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            },
            new Forma_Pago_SRI
            {
                Id = 4,
                Codigo_SRI = "18",
                Descripcion = "Tarjeta Prepago",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            },
            new Forma_Pago_SRI
            {
                Id = 5,
                Codigo_SRI = "19",
                Descripcion = "Tarjeta De Crédito",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            },
            new Forma_Pago_SRI
            {
                Id = 6,
                Codigo_SRI = "20",
                Descripcion = "Otros Con Utilización Del Sistema Financiero",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            },
            new Forma_Pago_SRI
            {
                Id = 8,
                Codigo_SRI = "21",
                Descripcion = "Endoso De Títulos",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            }
        };

        public static List<Lleva_Contabilidad> _lista_Lleva_Contabilidad = new List<Lleva_Contabilidad>
        {
            new Lleva_Contabilidad
            {
                Id = 1,
                Descripcion = "SI"
            },
            new Lleva_Contabilidad
            {
                Id = 2,
                Descripcion = "NO"
            },
        };

        public static List<Productos> _listas_Productos = new List<Productos>
        {
                new Productos
                {
                    IdProductos = 1,
                    Nombre = "Producto 1",
                    Codigo = "001",
                    Cantidad = 2,
                    Precio_Unitario = 10,
                    Descuento = 0
                },

                new Productos
                {
                    IdProductos = 2,
                    Nombre = "Producto 2",
                    Codigo = "002",
                    Cantidad = 3,
                    Precio_Unitario = 15,
                    Descuento = 0
                },

                new Productos
                {
                    IdProductos = 3,
                    Nombre = "Producto 3",
                    Codigo = "003",
                    Cantidad = 1,
                    Precio_Unitario = 20,
                    Descuento = 0
                }
        };

        public static List<Tipo_Ambiente> _lista_Tipo_Ambiente = new List<Tipo_Ambiente>
        {
                new Tipo_Ambiente
                {
                    Id = 1,
                    Descripcion = "PRUEBAS",
                    Codigo = "1"
                },
                new Tipo_Ambiente
                {
                    Id = 2,
                    Descripcion = "PRODUCCION",
                    Codigo = "2"
                }
        };

        public static List<Tipo_Documentos> _lista_Tipos_Documentos = new List<Tipo_Documentos>
        {
                new Tipo_Documentos
                {
                    Id = 1,
                    Descripcion = "FACTURA",
                    Codigo = "01"
                },
                new Tipo_Documentos
                {
                    Id = 2,
                    Descripcion = "LIQUIDACIÓN DE COMPRA DE BIENES Y PRESTACIÓN DE SERVICIOS",
                    Codigo = "03"
                },
                new Tipo_Documentos
                {
                    Id = 3,
                    Descripcion = "NOTA DE CREDITO",
                    Codigo = "04"
                },
                new Tipo_Documentos
                {
                    Id = 4,
                    Descripcion = "NOTA DE DEBITO",
                    Codigo = "05"
                },
                new Tipo_Documentos
                {
                    Id = 5,
                    Descripcion = "GUÍA DE REMISION",
                    Codigo = "06"
                },
                new Tipo_Documentos
                {
                    Id = 6,
                    Descripcion = "COMPROBANTE DE RETENCION",
                    Codigo = "07"
                },
         };

        public static List<Tipo_Emision> _lista_Emision = new List<Tipo_Emision>
        {
                new Tipo_Emision
                {
                    Id = 1,
                    Descripcion = "NORMAL"
                },
                new Tipo_Emision
                {
                    Id = 2,
                    Descripcion = "CONTINGENCIA"
                }
        };

        public static List<Tipos_Iva> _Lista_Iva = new List<Tipos_Iva>
        {
            new Tipos_Iva
            {
                Id = 1,
                Porcentaje = "0%",
                Codigo_SRI = "0",
                Valor = "0",
                Fecha_Desde = new DateTime(1900, 01, 01),
                Fecha_Hasta = new DateTime(2100, 12, 31)
            },
            new Tipos_Iva
            { Id = 2,
                Porcentaje = "13%",
                Codigo_SRI = "10",
                Valor = "13",
                Fecha_Desde = new DateTime(2027, 01, 01),
                Fecha_Hasta = new DateTime(2050, 12, 31)
            },
            new Tipos_Iva
            {
                Id = 3,
                Porcentaje = "12%",
                Codigo_SRI = "2",
                Valor = "12",
                Fecha_Desde = new DateTime(1900, 01, 01),
                Fecha_Hasta = new DateTime(2024, 03, 31)
            },
            new Tipos_Iva
            {
                Id = 4,
                Porcentaje = "14%",
                Codigo_SRI = "3",
                Valor = "14",
                Fecha_Desde = new DateTime(2016, 06, 01),
                Fecha_Hasta = new DateTime(2024, 03, 31)
            },
            new Tipos_Iva
            {
                Id = 5,
                Porcentaje = "15%",
                Codigo_SRI = "4",
                Valor = "15",
                Fecha_Desde = new DateTime(2024, 04, 01),
                Fecha_Hasta = new DateTime(2026, 12, 31)
            },
            new Tipos_Iva
            {
                Id = 6,
                Porcentaje = "5%",
                Codigo_SRI = "5",
                Valor = "5",
                Fecha_Desde = new DateTime(2024, 04, 01),
                Fecha_Hasta = new DateTime(2026, 12, 31)
            },
            new Tipos_Iva
            {
                Id = 7,
                Porcentaje = "No Objeto",
                Codigo_SRI = "6",
                Valor = "0",
                Fecha_Desde = new DateTime(19000101),
                Fecha_Hasta = new DateTime(21001231)
            },
            new Tipos_Iva
            {
                Id = 8,
                Porcentaje = "Exento de IVA",
                Codigo_SRI = "7",
                Valor = "0",
                Fecha_Desde = new DateTime(19000101),
                Fecha_Hasta = new DateTime(202612-31)
            },
            new Tipos_Iva
            {
                Id = 9,
                Porcentaje = "8%",
                Codigo_SRI = "8",
                Valor = "8",
                Fecha_Desde = new DateTime(20230101),
                Fecha_Hasta = new DateTime(21001231)
            }
        };
    }
}