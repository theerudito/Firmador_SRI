using FE.Modelo;

namespace FE.Helpers
{
    public class Datos_Iniciales
    {
        public static List<Estado> _lista_Estados = new List<Estado>
        {
                new Estado
                {
                    Id_Estado = 1,
                    Descripcion = "EN PROCESAMIENTO",
                    Codigo = "PPR"
                },
                new Estado
                {
                    Id_Estado = 2,
                    Descripcion = "AUTORIZADO",
                    Codigo = "AUT"
                },
                new Estado {
                    Id_Estado = 3,
                    Descripcion = "NO AUTORIZADO",
                    Codigo = "NAT"
                }
        };

        public static List<Forma_Pago_Empresa> _listaForma_Pago_Empresa = new List<Forma_Pago_Empresa>
        {
           new Forma_Pago_Empresa
           {
               Id_Forma_Pago_Empresa = 1,
               Codigo = "01",
               Tipo = "EF",
               Descripcion = "Efectivo",
           },
           new Forma_Pago_Empresa
           {
               Id_Forma_Pago_Empresa = 2,
               Codigo = "01",
               Tipo = "CR",
               Descripcion = "Crédito",
           },
           new Forma_Pago_Empresa
           {
               Id_Forma_Pago_Empresa = 3,
               Codigo = "20",
               Tipo = "CH",
               Descripcion = "Cheque",
           },
           new Forma_Pago_Empresa
           {
               Id_Forma_Pago_Empresa = 4,
               Codigo = "19",
               Tipo = "TA",
               Descripcion = "Tarjeta de Crédito",
           },
           new Forma_Pago_Empresa
           {
               Id_Forma_Pago_Empresa = 5,
               Codigo = "20",
               Tipo = "DP",
               Descripcion = "Deposito",
           },
           new Forma_Pago_Empresa
           {
               Id_Forma_Pago_Empresa = 6,
               Codigo = "01",
               Tipo = "NC",
               Descripcion = "Nota de Crédito",
           },
           new Forma_Pago_Empresa
           {
               Id_Forma_Pago_Empresa = 7,
               Codigo = "01",
               Tipo = "ND",
               Descripcion = "Nota de Débito",
           },
           new Forma_Pago_Empresa
           {
               Id_Forma_Pago_Empresa = 8,
               Codigo = "01",
               Tipo = "MP",
               Descripcion = "Múltiple",
           },
           new Forma_Pago_Empresa
           {
               Id_Forma_Pago_Empresa = 9,
               Codigo = "01",
               Tipo = "CI",
               Descripcion = "NC Interna",
           },
           new Forma_Pago_Empresa
           {
               Id_Forma_Pago_Empresa = 10,
               Codigo = "01",
               Tipo = "DI",
               Descripcion = "ND Interna",
           },
        };

        public static List<Identificacion_Tipos> _lista_Identificacion_Tipos = new List<Identificacion_Tipos>
        {
            new Identificacion_Tipos
            {
                Id_Identificacion_Tipos = 1,
                Descripcion = "RUC",
                Codigo = "04"
            },
            new Identificacion_Tipos
            {
                Id_Identificacion_Tipos = 2,
                Descripcion = "CEDULA",
                Codigo = "05"
            },
            new Identificacion_Tipos
            {
                Id_Identificacion_Tipos = 3,
                Descripcion = "PASAPORTE",
                Codigo = "06"
            },
            new Identificacion_Tipos
            {
                Id_Identificacion_Tipos = 4,
                Descripcion = "VENTA A CONSUMIDOR FINAL",
                Codigo = "07"
            },
            new Identificacion_Tipos
            {
                Id_Identificacion_Tipos = 5,
                Descripcion = "IDENTIFICACIÓN DELEXTERIOR",
                Codigo = "08"
            }
        };

        public static List<Forma_Pago_SRI> _lista_Forma_Pago_SRI = new List<Forma_Pago_SRI>
        {
            new Forma_Pago_SRI
            {
                Id_Forma_Pago_SRI = 1,
                Codigo = "01",
                Descripcion = "Sin Utilización Del Sistema Financiero",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            },
            new Forma_Pago_SRI
            {
                Id_Forma_Pago_SRI = 2,
                Codigo = "15",
                Descripcion = "Compensación De Deudas",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            },
            new Forma_Pago_SRI
            {
                Id_Forma_Pago_SRI = 3,
                Codigo = "16",
                Descripcion = "Tarjeta De Débito",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            },
            new Forma_Pago_SRI
            {
                Id_Forma_Pago_SRI = 4,
                Codigo = "18",
                Descripcion = "Tarjeta Prepago",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            },
            new Forma_Pago_SRI
            {
                Id_Forma_Pago_SRI = 5,
                Codigo = "19",
                Descripcion = "Tarjeta De Crédito",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            },
            new Forma_Pago_SRI
            {
                Id_Forma_Pago_SRI = 6,
                Codigo = "20",
                Descripcion = "Otros Con Utilización Del Sistema Financiero",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            },
            new Forma_Pago_SRI
            {
                Id_Forma_Pago_SRI = 8,
                Codigo = "21",
                Descripcion = "Endoso De Títulos",
                Fecha_Desde = new DateTime(2016, 01, 01),
                Fecha_Hasta = new DateTime(2050, 01, 01)
            }
        };

        public static List<Lleva_Contabilidad> _lista_Lleva_Contabilidad = new List<Lleva_Contabilidad>
        {
            new Lleva_Contabilidad
            {
                Id_Lleva_Contabilidad = 1,
                Descripcion = "SI"
            },
            new Lleva_Contabilidad
            {
                Id_Lleva_Contabilidad = 2,
                Descripcion = "NO"
            },
        };

        public static List<Productos> _listas_Productos = new List<Productos>
        {
                new Productos
                {
                    Id_Productos = 1,
                    Nombre = "Producto 1",
                    Codigo = "001",
                    Cantidad = 2,
                    Precio_Unitario = 10,
                    Descuento = 0
                },

                new Productos
                {
                    Id_Productos = 2,
                    Nombre = "Producto 2",
                    Codigo = "002",
                    Cantidad = 3,
                    Precio_Unitario = 15,
                    Descuento = 0
                },

                new Productos
                {
                    Id_Productos = 3,
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
                    Id_Tipo_Ambiente = 1,
                    Descripcion = "PRUEBAS",
                    Codigo = "1"
                },
                new Tipo_Ambiente
                {
                    Id_Tipo_Ambiente = 2,
                    Descripcion = "PRODUCCION",
                    Codigo = "2"
                }
        };

        public static List<Tipo_Documentos> _lista_Tipos_Documentos = new List<Tipo_Documentos>
        {
                new Tipo_Documentos
                {
                    Id_Tipo_Documentos = 1,
                    Descripcion = "FACTURA",
                    Codigo = "01"
                },
                new Tipo_Documentos
                {
                    Id_Tipo_Documentos = 2,
                    Descripcion = "LIQUIDACIÓN DE COMPRA DE BIENES Y PRESTACIÓN DE SERVICIOS",
                    Codigo = "03"
                },
                new Tipo_Documentos
                {
                    Id_Tipo_Documentos = 3,
                    Descripcion = "NOTA DE CREDITO",
                    Codigo = "04"
                },
                new Tipo_Documentos
                {
                    Id_Tipo_Documentos = 4,
                    Descripcion = "NOTA DE DEBITO",
                    Codigo = "05"
                },
                new Tipo_Documentos
                {
                    Id_Tipo_Documentos = 5,
                    Descripcion = "GUÍA DE REMISION",
                    Codigo = "06"
                },
                new Tipo_Documentos
                {
                    Id_Tipo_Documentos = 6,
                    Descripcion = "COMPROBANTE DE RETENCION",
                    Codigo = "07"
                },
         };

        public static List<Tipo_Emision> _lista_Emision = new List<Tipo_Emision>
        {
                new Tipo_Emision
                {
                    Id_Tipo_Emision = 1,
                    Descripcion = "NORMAL"
                },
                new Tipo_Emision
                {
                    Id_Tipo_Emision = 2,
                    Descripcion = "CONTINGENCIA"
                }
        };

        public static List<Tipos_Iva> _lista_Iva = new List<Tipos_Iva>
        {
            new Tipos_Iva
            {
                Id_Tipos_Iva = 1,
                Descripcion = "0%",
                Codigo = "0",
                Valor = "0",
                Fecha_Desde = new DateTime(1900, 01, 01),
                Fecha_Hasta = new DateTime(2100, 12, 31)
            },
            new Tipos_Iva
            {
                Id_Tipos_Iva = 2,
                Descripcion = "13%",
                Codigo = "10",
                Valor = "13",
                Fecha_Desde = new DateTime(2027, 01, 01),
                Fecha_Hasta = new DateTime(2050, 12, 31)
            },
            new Tipos_Iva
            {
                Id_Tipos_Iva = 3,
                Descripcion = "12%",
                Codigo = "2",
                Valor = "12",
                Fecha_Desde = new DateTime(1900, 01, 01),
                Fecha_Hasta = new DateTime(2024, 03, 31)
            },
            new Tipos_Iva
            {
                Id_Tipos_Iva = 4,
                Descripcion = "14%",
                Codigo = "3",
                Valor = "14",
                Fecha_Desde = new DateTime(2016, 06, 01),
                Fecha_Hasta = new DateTime(2024, 03, 31)
            },
            new Tipos_Iva
            {
                Id_Tipos_Iva = 5,
                Descripcion = "15%",
                Codigo = "4",
                Valor = "15",
                Fecha_Desde = new DateTime(2024, 04, 01),
                Fecha_Hasta = new DateTime(2026, 12, 31)
            },
            new Tipos_Iva
            {
                Id_Tipos_Iva = 6,
                Descripcion = "5%",
                Codigo = "5",
                Valor = "5",
                Fecha_Desde = new DateTime(2024, 04, 01),
                Fecha_Hasta = new DateTime(2026, 12, 31)
            },
            new Tipos_Iva
            {
                Id_Tipos_Iva = 7,
                Descripcion = "No Objeto",
                Codigo = "6",
                Valor = "0",
                Fecha_Desde = new DateTime(1900, 01, 01),
                Fecha_Hasta = new DateTime(2100, 12, 31)
            },
            new Tipos_Iva
            {
                Id_Tipos_Iva = 8,
                Descripcion = "Exento de IVA",
                Codigo = "7",
                Valor = "0",
                Fecha_Desde = new DateTime(1900, 01, 01),
                Fecha_Hasta = new DateTime(2026, 12, 31)
            },
            new Tipos_Iva
            {
                Id_Tipos_Iva = 9,
                Descripcion = "8%",
                Codigo = "8",
                Valor = "8",
                Fecha_Desde = new DateTime(2023, 01, 01),
                Fecha_Hasta = new DateTime(2100, 12, 31)
            }
        };

        public static List<Ciudades> _lista_Ciudades = new List<Ciudades>
        {
            new Ciudades { Id_Ciudades = 1, Descripcion = "SIN CIUDAD" },
            new Ciudades { Id_Ciudades = 2, Descripcion = "24 DE MAYO" },
            new Ciudades { Id_Ciudades = 3, Descripcion = "ABDON CALDERÓN" },
            new Ciudades { Id_Ciudades = 4, Descripcion = "AGUARICO" },
            new Ciudades { Id_Ciudades = 5, Descripcion = "ALAUSÍ" },
            new Ciudades { Id_Ciudades = 6, Descripcion = "ALFREDO BAQUERIZO MORENO (JUJÁN)" },
            new Ciudades { Id_Ciudades = 7, Descripcion = "AMBATO" },
            new Ciudades { Id_Ciudades = 8, Descripcion = "ANTONIO ANTE" },
            new Ciudades { Id_Ciudades = 9, Descripcion = "ARAJUNO" },
            new Ciudades { Id_Ciudades = 11, Descripcion = "ARENILLAS" },
            new Ciudades { Id_Ciudades = 12, Descripcion = "ATACAMES" },
            new Ciudades { Id_Ciudades = 13, Descripcion = "ATAHUALPA" },
            new Ciudades { Id_Ciudades = 14, Descripcion = "AZOGUES" },
            new Ciudades { Id_Ciudades = 15, Descripcion = "BABA" },
            new Ciudades { Id_Ciudades = 16, Descripcion = "BABAHOYO" },
            new Ciudades { Id_Ciudades = 17, Descripcion = "BALAO" },
            new Ciudades { Id_Ciudades = 18, Descripcion = "BALSAS" },
            new Ciudades { Id_Ciudades = 19, Descripcion = "BALZAR" },
            new Ciudades { Id_Ciudades = 20, Descripcion = "BAÑOS DE AGUA SANTA" },
            new Ciudades { Id_Ciudades = 21, Descripcion = "BIBLIÁN" },
            new Ciudades { Id_Ciudades = 22, Descripcion = "BOLÍVAR" },
            new Ciudades { Id_Ciudades = 23, Descripcion = "BOLÍVAR" },
            new Ciudades { Id_Ciudades = 24, Descripcion = "BUENA FÉ" },
            new Ciudades { Id_Ciudades = 25, Descripcion = "CALUMA" },
            new Ciudades { Id_Ciudades = 26, Descripcion = "CALVAS" },
            new Ciudades { Id_Ciudades = 27, Descripcion = "CAMILO PONCE ENRÍQUEZ" },
            new Ciudades { Id_Ciudades = 28, Descripcion = "CAÑAR" },
            new Ciudades { Id_Ciudades = 29, Descripcion = "CARLOS JULIO AROSEMENA TOLA" },
            new Ciudades { Id_Ciudades = 30, Descripcion = "CASCALES" },
            new Ciudades { Id_Ciudades = 31, Descripcion = "CATAMAYO" },
            new Ciudades { Id_Ciudades = 32, Descripcion = "CAYAMBE" },
            new Ciudades { Id_Ciudades = 33, Descripcion = "CELICA" },
            new Ciudades { Id_Ciudades = 34, Descripcion = "CENTINELA DEL CÓNDOR" },
            new Ciudades { Id_Ciudades = 35, Descripcion = "CEVALLOS" },
            new Ciudades { Id_Ciudades = 36, Descripcion = "CHAGUARPAMBA" },
            new Ciudades { Id_Ciudades = 37, Descripcion = "CHAMBO" },
            new Ciudades { Id_Ciudades = 38, Descripcion = "CHILLA" },
            new Ciudades { Id_Ciudades = 39, Descripcion = "CHILLANES" },
            new Ciudades { Id_Ciudades = 40, Descripcion = "CHIMBO" },
            new Ciudades { Id_Ciudades = 41, Descripcion = "CHINCHIPE" },
            new Ciudades { Id_Ciudades = 42, Descripcion = "CHONE" },
            new Ciudades { Id_Ciudades = 43, Descripcion = "CHORDELEG" },
            new Ciudades { Id_Ciudades = 44, Descripcion = "CHUNCHI" },
            new Ciudades { Id_Ciudades = 45, Descripcion = "COLIMES" },
            new Ciudades { Id_Ciudades = 46, Descripcion = "COLTA" },
            new Ciudades { Id_Ciudades = 47, Descripcion = "CORONEL MARCELINO MARIDUEÑA" },
            new Ciudades { Id_Ciudades = 48, Descripcion = "COTACACHI" },
            new Ciudades { Id_Ciudades = 49, Descripcion = "CUENCA" },
            new Ciudades { Id_Ciudades = 50, Descripcion = "CUMANDÁ" },
        };

        public static List<Clientes> _lista_Clientes = new List<Clientes>
        {
            new Clientes
            {
                Id_Clientes = 1,
                Identificacion = "9999999999999",
                Codigo = "CF",
                Nombres = "CONSUMIDOR",
                Apellidos = "FINAL",
                Direccion = "SN",
                Telefono = "9999999999",
                Email = "",
                Id_Ciudades = 1,
                Id_Identificacion_Tipos = 1
            }
        };

        public static List<Categorias> _lista_Categorias = new List<Categorias>
        {
            new Categorias
            {
                Id_Categorias = 1,
                Descripcion = "LAPTOPS",
                Estado = true,
                Fecha_Creacion = DateTime.UtcNow,
                Fecha_Modificacion = DateTime.UtcNow,
                Usuario_Creacion = "",
                Usuario_Modificacion = "",
            },
            new Categorias
            {
                Id_Categorias = 2,
                Descripcion = "CELULARES",
                Estado = true,
                Fecha_Creacion = DateTime.UtcNow,
                Fecha_Modificacion = DateTime.UtcNow,
                Usuario_Creacion = "",
                Usuario_Modificacion = ""
            }
        };

        public static List<Marcas> _lista_Marcas = new List<Marcas>
        {
            new Marcas
            {
                Id_Marcas = 1,
                Descripcion = "LENOVO",
                Estado = true,
                Fecha_Creacion = DateTime.UtcNow,
                Fecha_Modificacion = DateTime.UtcNow,
                Usuario_Creacion = "",
                Usuario_Modificacion = ""
            },
            new Marcas
            {
                Id_Marcas = 2,
                Descripcion = "HONOR",
                Estado = true,
                Fecha_Creacion = DateTime.UtcNow,
                Fecha_Modificacion = DateTime.UtcNow,
                Usuario_Creacion = "",
                Usuario_Modificacion = ""
            }
        };
    }
}