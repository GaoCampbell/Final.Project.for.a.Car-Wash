USE [master]
GO
/****** Object:  Database [Ingenieria]    Script Date: 03/04/2018 21:50:26 ******/
CREATE DATABASE [Ingenieria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ingenieria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Ingenieria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ingenieria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Ingenieria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Ingenieria] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ingenieria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ingenieria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ingenieria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ingenieria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ingenieria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ingenieria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ingenieria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Ingenieria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ingenieria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ingenieria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ingenieria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ingenieria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ingenieria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ingenieria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ingenieria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ingenieria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Ingenieria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ingenieria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ingenieria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ingenieria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ingenieria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ingenieria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ingenieria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ingenieria] SET RECOVERY FULL 
GO
ALTER DATABASE [Ingenieria] SET  MULTI_USER 
GO
ALTER DATABASE [Ingenieria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ingenieria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ingenieria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ingenieria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ingenieria] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Ingenieria', N'ON'
GO
USE [Ingenieria]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Ingenieria]
GO
/****** Object:  Table [dbo].[almacen]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[almacen](
	[idalmacen] [int] IDENTITY(1,1) NOT NULL,
	[CodCategoria] [int] NULL,
	[nombre] [nvarchar](100) NULL,
	[ubicacion] [nvarchar](100) NULL,
	[descripcion] [nvarchar](100) NULL,
	[NombreCategoria] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idalmacen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[area]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[area](
	[idArea] [int] IDENTITY(1,1) NOT NULL,
	[area] [nvarchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idArea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[categoria]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[CodCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [nvarchar](50) NULL,
	[Nombredelproducto] [nvarchar](50) NULL,
	[CodProducto] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[clientes]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [nvarchar](120) NOT NULL,
	[apellido] [nvarchar](120) NOT NULL,
	[correo] [nvarchar](80) NOT NULL,
	[celular] [int] NULL,
	[estado] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[compra]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compra](
	[idCompra] [int] IDENTITY(1,1) NOT NULL,
	[idProveedor] [int] NULL,
	[fechaCompra] [date] NULL,
	[Aplicada] [bit] NULL,
	[HoraCompra] [time](7) NULL,
	[idusuario] [int] NULL,
	[Subtotal] [numeric](18, 2) NULL,
	[Descuento] [numeric](18, 2) NULL,
	[TotalCordobas] [numeric](18, 2) NULL,
	[TotalDolares] [numeric](18, 2) NULL,
	[TipoPago] [nvarchar](50) NULL,
 CONSTRAINT [PK__compra__48B99DB7A19D3F9A] PRIMARY KEY CLUSTERED 
(
	[idCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detallecompra]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detallecompra](
	[idCompra] [int] NULL,
	[idProducto] [int] NULL,
	[cantidad] [numeric](18, 2) NOT NULL,
	[total] [numeric](18, 2) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detallepago]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detallepago](
	[iddetallepago] [int] IDENTITY(1,1) NOT NULL,
	[numerodocumento] [int] NULL,
	[codigotipopago] [nvarchar](50) NULL,
	[monto] [numeric](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[iddetallepago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detalleventa]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalleventa](
	[cantidad] [int] NULL,
	[idVenta] [int] NULL,
	[idProducto] [int] NULL,
	[totaldetalle] [decimal](18, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[devolucion]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[devolucion](
	[Iddevolucion] [int] IDENTITY(1,1) NOT NULL,
	[idcliente] [int] NULL,
	[NumVenta] [int] NULL,
	[fecha] [date] NULL,
	[observacion] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Iddevolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[empleado]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleado](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[celular] [int] NULL,
	[direccion] [nvarchar](90) NOT NULL,
	[cedula] [nvarchar](16) NOT NULL,
	[apellidos] [nvarchar](120) NOT NULL,
	[nombres] [nvarchar](80) NOT NULL,
	[fechaNac] [datetime] NOT NULL,
	[salario] [money] NOT NULL,
	[cargo] [nvarchar](50) NULL,
	[estado] [nvarchar](10) NULL,
	[idArea] [int] NULL,
	[idgrupo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[grupoTrabajadores]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grupoTrabajadores](
	[idgrupo] [int] IDENTITY(1,1) NOT NULL,
	[grupoTrabajadores] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[idgrupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[lavado]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lavado](
	[idLavado] [int] IDENTITY(1,1) NOT NULL,
	[total] [money] NOT NULL,
	[fecha] [datetime] NULL,
	[placa] [nvarchar](10) NOT NULL,
	[idLavadoVehiculo] [int] NULL,
	[idgrupo] [int] NULL,
	[usuario] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idLavado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LavadoVehiculo]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LavadoVehiculo](
	[idLavadoVehiculo] [int] IDENTITY(1,1) NOT NULL,
	[idServicioLavado] [int] NULL,
	[idVehiculoLavado] [int] NULL,
	[precio] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[idLavadoVehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[logTransacciones]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[logTransacciones](
	[TipoTrn] [char](1) NULL,
	[Tabla] [varchar](128) NULL,
	[PK] [varchar](1000) NULL,
	[Campo] [varchar](128) NULL,
	[ValorOriginal] [varchar](1000) NULL,
	[ValorNuevo] [varchar](1000) NULL,
	[FechaTrn] [datetime] NULL,
	[Usuario] [varchar](128) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[mantenimiento]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mantenimiento](
	[idMantenimiento] [int] IDENTITY(1,1) NOT NULL,
	[total] [money] NOT NULL,
	[fecha] [date] NULL,
	[placa] [nvarchar](10) NOT NULL,
	[idgrupo] [int] NULL,
	[idservicioVehiculo] [int] NULL,
	[usuario] [nvarchar](100) NULL,
 CONSTRAINT [PK__mantenim__187F756A96D1568E] PRIMARY KEY CLUSTERED 
(
	[idMantenimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[CodMarca] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [nvarchar](50) NULL,
 CONSTRAINT [PK__Marcas__AA3A5ECCCAC30603] PRIMARY KEY CLUSTERED 
(
	[CodMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[pago]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pago](
	[numerodocumento] [int] NULL,
	[cordobas] [numeric](18, 6) NULL,
	[dolares] [numeric](18, 6) NULL,
	[vuelto] [numeric](18, 6) NULL,
	[fecha] [datetime] NULL,
	[idUsuario] [int] NULL,
	[montofactura] [numeric](18, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[permiso]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso](
	[idUsuario] [int] NULL,
	[venta] [bit] NULL,
	[mantenimiento] [bit] NULL,
	[lavado] [bit] NULL,
	[compra] [bit] NULL,
	[empleado] [bit] NULL,
	[Tusuario] [bit] NULL,
	[producto] [bit] NULL,
	[proveedor] [bit] NULL,
	[Password] [bit] NULL,
	[usuario] [varchar](50) NULL,
UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Productos]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[CodProducto] [int] IDENTITY(1,1) NOT NULL,
	[Producto] [nvarchar](50) NULL,
	[CodMarca] [int] NULL,
	[CodSAC] [nvarchar](20) NULL,
	[Existencia] [numeric](18, 2) NULL,
	[Costo] [numeric](18, 2) NULL,
	[Precio] [numeric](18, 2) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK__Producto__0D06FDF334322440] PRIMARY KEY CLUSTERED 
(
	[CodProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedor](
	[idProveedor] [int] IDENTITY(1,1) NOT NULL,
	[apellidos] [nvarchar](120) NULL,
	[nombres] [nvarchar](80) NOT NULL,
	[nombreempresa] [nvarchar](80) NULL,
	[direccion] [nvarchar](max) NOT NULL,
	[RUC] [nvarchar](50) NULL,
	[telefono] [nvarchar](12) NULL,
	[correo] [nvarchar](80) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK__proveedo__A3FA8E6B806206D1] PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[servicioLavado]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[servicioLavado](
	[idServicioLavado] [int] IDENTITY(1,1) NOT NULL,
	[servicioLavado] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idServicioLavado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[servicioMantenimiento]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[servicioMantenimiento](
	[idServicioMantenimiento] [int] IDENTITY(1,1) NOT NULL,
	[servicioMantenimiento] [nvarchar](50) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK__servicio__55760ABF8E3ED749] PRIMARY KEY CLUSTERED 
(
	[idServicioMantenimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ServicioVehiculo]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServicioVehiculo](
	[idServicioVehiculo] [int] IDENTITY(1,1) NOT NULL,
	[idServicioMantenimiento] [int] NULL,
	[idVehiculoMantenimiento] [int] NULL,
	[precio] [money] NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idServicioVehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipopago]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipopago](
	[codigotipopago] [nvarchar](50) NOT NULL,
	[TipoPago] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[codigotipopago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NULL,
	[estado] [nvarchar](10) NULL,
	[Password] [nvarchar](max) NULL,
	[idEmpleado] [int] NULL,
 CONSTRAINT [PK_idUsuario_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VehiculoLavado]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehiculoLavado](
	[idVehiculoLavado] [int] IDENTITY(1,1) NOT NULL,
	[vehiculoLavado] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idVehiculoLavado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VehiculoMantenimiento]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehiculoMantenimiento](
	[idVehiculoMantenimiento] [int] IDENTITY(1,1) NOT NULL,
	[vehiculoMantenimiento] [nvarchar](50) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idVehiculoMantenimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[venta]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venta](
	[NumVenta] [int] IDENTITY(1,1) NOT NULL,
	[idCliente] [int] NULL,
	[idUsuario] [int] NULL,
	[fechaFac] [date] NULL,
	[Subtotal] [numeric](18, 2) NULL,
	[Descuento] [numeric](18, 2) NULL,
	[totalcordobas] [numeric](18, 2) NULL,
	[TipoPago] [nvarchar](50) NULL,
	[HoraFac] [time](7) NULL,
	[TotalDolares] [numeric](18, 2) NULL,
 CONSTRAINT [PK__venta__5B397B9C0054EB42] PRIMARY KEY CLUSTERED 
(
	[NumVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[almacen]  WITH CHECK ADD FOREIGN KEY([CodCategoria])
REFERENCES [dbo].[categoria] ([CodCategoria])
GO
ALTER TABLE [dbo].[categoria]  WITH CHECK ADD FOREIGN KEY([CodProducto])
REFERENCES [dbo].[Productos] ([CodProducto])
GO
ALTER TABLE [dbo].[compra]  WITH CHECK ADD  CONSTRAINT [FK__compra__idProvee__4316F928] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[proveedor] ([idProveedor])
GO
ALTER TABLE [dbo].[compra] CHECK CONSTRAINT [FK__compra__idProvee__4316F928]
GO
ALTER TABLE [dbo].[compra]  WITH CHECK ADD  CONSTRAINT [FK_compra_Usuarios] FOREIGN KEY([idusuario])
REFERENCES [dbo].[Usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[compra] CHECK CONSTRAINT [FK_compra_Usuarios]
GO
ALTER TABLE [dbo].[detallecompra]  WITH CHECK ADD  CONSTRAINT [FK__detalleco__idCom__440B1D61] FOREIGN KEY([idCompra])
REFERENCES [dbo].[compra] ([idCompra])
GO
ALTER TABLE [dbo].[detallecompra] CHECK CONSTRAINT [FK__detalleco__idCom__440B1D61]
GO
ALTER TABLE [dbo].[detallecompra]  WITH CHECK ADD  CONSTRAINT [FK__detalleco__idPro__44FF419A] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Productos] ([CodProducto])
GO
ALTER TABLE [dbo].[detallecompra] CHECK CONSTRAINT [FK__detalleco__idPro__44FF419A]
GO
ALTER TABLE [dbo].[detallepago]  WITH CHECK ADD FOREIGN KEY([codigotipopago])
REFERENCES [dbo].[tipopago] ([codigotipopago])
GO
ALTER TABLE [dbo].[detalleventa]  WITH CHECK ADD  CONSTRAINT [FK__detalleve__idPro__46E78A0C] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Productos] ([CodProducto])
GO
ALTER TABLE [dbo].[detalleventa] CHECK CONSTRAINT [FK__detalleve__idPro__46E78A0C]
GO
ALTER TABLE [dbo].[detalleventa]  WITH CHECK ADD  CONSTRAINT [FK__detalleve__idVen__47DBAE45] FOREIGN KEY([idVenta])
REFERENCES [dbo].[venta] ([NumVenta])
GO
ALTER TABLE [dbo].[detalleventa] CHECK CONSTRAINT [FK__detalleve__idVen__47DBAE45]
GO
ALTER TABLE [dbo].[devolucion]  WITH CHECK ADD FOREIGN KEY([idcliente])
REFERENCES [dbo].[clientes] ([idCliente])
GO
ALTER TABLE [dbo].[devolucion]  WITH CHECK ADD  CONSTRAINT [FK__devolucio__NumVe__49C3F6B7] FOREIGN KEY([NumVenta])
REFERENCES [dbo].[venta] ([NumVenta])
GO
ALTER TABLE [dbo].[devolucion] CHECK CONSTRAINT [FK__devolucio__NumVe__49C3F6B7]
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([idArea])
REFERENCES [dbo].[area] ([idArea])
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([idgrupo])
REFERENCES [dbo].[grupoTrabajadores] ([idgrupo])
GO
ALTER TABLE [dbo].[lavado]  WITH CHECK ADD FOREIGN KEY([idgrupo])
REFERENCES [dbo].[grupoTrabajadores] ([idgrupo])
GO
ALTER TABLE [dbo].[lavado]  WITH CHECK ADD FOREIGN KEY([idLavadoVehiculo])
REFERENCES [dbo].[LavadoVehiculo] ([idLavadoVehiculo])
GO
ALTER TABLE [dbo].[LavadoVehiculo]  WITH CHECK ADD FOREIGN KEY([idServicioLavado])
REFERENCES [dbo].[servicioLavado] ([idServicioLavado])
GO
ALTER TABLE [dbo].[LavadoVehiculo]  WITH CHECK ADD FOREIGN KEY([idVehiculoLavado])
REFERENCES [dbo].[VehiculoLavado] ([idVehiculoLavado])
GO
ALTER TABLE [dbo].[mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK__mantenimi__idgru__5070F446] FOREIGN KEY([idgrupo])
REFERENCES [dbo].[grupoTrabajadores] ([idgrupo])
GO
ALTER TABLE [dbo].[mantenimiento] CHECK CONSTRAINT [FK__mantenimi__idgru__5070F446]
GO
ALTER TABLE [dbo].[mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK__mantenimi__idser__5165187F] FOREIGN KEY([idservicioVehiculo])
REFERENCES [dbo].[ServicioVehiculo] ([idServicioVehiculo])
GO
ALTER TABLE [dbo].[mantenimiento] CHECK CONSTRAINT [FK__mantenimi__idser__5165187F]
GO
ALTER TABLE [dbo].[pago]  WITH CHECK ADD FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[permiso]  WITH CHECK ADD FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK__Productos__CodMa__5441852A] FOREIGN KEY([CodMarca])
REFERENCES [dbo].[Marcas] ([CodMarca])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK__Productos__CodMa__5441852A]
GO
ALTER TABLE [dbo].[ServicioVehiculo]  WITH CHECK ADD  CONSTRAINT [FK__ServicioV__idSer__5535A963] FOREIGN KEY([idServicioMantenimiento])
REFERENCES [dbo].[servicioMantenimiento] ([idServicioMantenimiento])
GO
ALTER TABLE [dbo].[ServicioVehiculo] CHECK CONSTRAINT [FK__ServicioV__idSer__5535A963]
GO
ALTER TABLE [dbo].[ServicioVehiculo]  WITH CHECK ADD FOREIGN KEY([idVehiculoMantenimiento])
REFERENCES [dbo].[VehiculoMantenimiento] ([idVehiculoMantenimiento])
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK__venta__idCliente__5812160E] FOREIGN KEY([idCliente])
REFERENCES [dbo].[clientes] ([idCliente])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK__venta__idCliente__5812160E]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK__venta__idUsuario__59063A47] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK__venta__idUsuario__59063A47]
GO
/****** Object:  StoredProcedure [dbo].[actualizar_clientes]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create PROCEDURE [dbo].[actualizar_clientes]
(
@i_idcliente int,
@i_nombres  nvarchar(120),
@i_apellido nvarchar(120),
@i_correo nvarchar(80),
@i_celular nvarchar(8),
@i_estado nvarchar(10)
  )
  AS 
  BEGIN
  UPDATE clientes SET  nombres=@i_nombres, apellido=@i_apellido, correo= @i_correo, celular = @i_celular , estado= @i_estado where idCliente=@i_idcliente
  END
 
 

GO
/****** Object:  StoredProcedure [dbo].[actualizaralmacen]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actualizaralmacen]
(
@idalmacen int,
@CodCategoria int,
@nombre nvarchar(100),
@ubicacion nvarchar(100),
@descripcion nvarchar(100),
@NombreCategoria nvarchar(50)
)
as
begin
update almacen  set CodCategoria=@CodCategoria,nombre = @nombre , ubicacion = @ubicacion , descripcion=@descripcion, NombreCategoria=@NombreCategoria where idalmacen=@idalmacen
end
GO
/****** Object:  StoredProcedure [dbo].[actualizarcategoria]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create PROCEDURE [dbo].[actualizarcategoria]
(
@CodCategoria int,
@Tipo nvarchar(50),
@Codproducto nvarchar(20),
@Nombredelproducto nvarchar(50)

 )
 AS 
 BEGIN
 UPDATE categoria SET  Tipo=@Tipo, CodProducto= @Codproducto , Nombredelproducto = @Nombredelproducto   where CodCategoria  =@CodCategoria
 END




GO
/****** Object:  StoredProcedure [dbo].[actualizarmarca]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create PROCEDURE [dbo].[actualizarmarca]
(
@Codmarca int,
@marca nvarchar(20)
 )
 AS 
 BEGIN
 UPDATE Marcas SET  Marca = @marca where CodMarca  =@Codmarca
 END


GO
/****** Object:  StoredProcedure [dbo].[actualizarproducto]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create PROCEDURE [dbo].[actualizarproducto]
(
@Codproducto int,
@Producto nvarchar (50),
@Codmarca int,
@CodSac nvarchar(20),
@existencia numeric(18,2),
@Costo numeric(18,2),
@Precio numeric(18,2),
@Activo bit
 )
 AS 
 BEGIN
 UPDATE productos SET Producto=@Producto, CodMarca= @Codmarca , CodSAC =@CodSac,Existencia= @existencia, Costo = @Costo , Precio = @Precio ,Activo= @Activo where CodProducto=@Codproducto
 END





GO
/****** Object:  StoredProcedure [dbo].[agregarventa]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[agregarventa]
(
@I_idcliente int,
@Idusuario int,
@fechafactura date,
@Horafactura time,
@tipopago nvarchar(50),
@Subtotal numeric (18,2),
@Descuento numeric (18,2),
@totalcordobas numeric(18,2),
@totaldolares numeric(18,2)
)
as 
begin
insert into venta (idCliente,idUsuario,fechaFac,HoraFac,TipoPago,Subtotal,Descuento,totalcordobas,TotalDolares)
values (@I_idcliente,@Idusuario,@fechafactura,@Horafactura,@tipopago,@Subtotal,@Descuento,@totalcordobas,@totaldolares)
select SCOPE_IDENTITY() as id
end

GO
/****** Object:  StoredProcedure [dbo].[getalmacen]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[getalmacen]
as
begin
select
a.idalmacen,
a.CodCategoria,
a.nombre,
a.ubicacion,
a.descripcion,
a.NombreCategoria
from almacen as A
inner join categoria as C on c.CodCategoria = A.CodCategoria

end



GO
/****** Object:  StoredProcedure [dbo].[getcategoria]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getcategoria]
 as 
begin 
select  C.CodCategoria,
c.Tipo,
C.CodProducto,
C.Nombredelproducto
from categoria as C
inner join Productos as P on P.CodProducto = C.CodProducto
 end



GO
/****** Object:  StoredProcedure [dbo].[getcliente]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getcliente]
 as select  idcliente,nombres,apellido,correo,celular,estado from clientes where estado = 'Activo' 


GO
/****** Object:  StoredProcedure [dbo].[getcompra]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getcompra]
 as 
 begin 
 select  c.idCompra,
	c.idProveedor,
	c.fechaCompra,
	c.HoraCompra,
	c.TotalCordobas,
	c.idusuario,
	c.TipoPago,
	c.Descuento,
	c.Subtotal,
	c.TotalDolares

	
  from compra as C
  inner join proveedor as p on p.idProveedor= c.idProveedor
   inner join Usuarios as u on u.idUsuario= c.idusuario
  end 


GO
/****** Object:  StoredProcedure [dbo].[getdetallecompra]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getdetallecompra]
as
begin
select 
d.idCompra,
d.cantidad,
d.total,
d.idproducto,
p.Producto,
p.CodProducto,
p.Costo
from detallecompra as d
inner join compra as c on c.idCompra = d.idCompra
inner join productos as p on p.CodProducto = d.idproducto 
end


GO
/****** Object:  StoredProcedure [dbo].[getdetalleventa]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getdetalleventa]
as
begin
select 
d.cantidad,
d.idVenta,
v.totalcordobas,
d.idproducto,
p.Producto,
p.Precio,
d.totaldetalle
from detalleventa as d
inner join venta as v on v.NumVenta = d.idVenta
inner join productos as p on P.CodProducto = d.idproducto 
end


GO
/****** Object:  StoredProcedure [dbo].[getmarca]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getmarca]
 as 
select  CodMarca,
Marca
from Marcas 

GO
/****** Object:  StoredProcedure [dbo].[getprodcuto]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getprodcuto]
 as 
 begin 
 select  p.CodProducto,
 p.Producto,
 p.CodMarca,
 p.CodSAC,
 p.Existencia,
 p.Costo,
 p.Precio,
 p.Activo
  from Productos as P
  inner join Marcas as M on M.CodMarca= p.CodMarca
  end 







GO
/****** Object:  StoredProcedure [dbo].[getventa]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[getventa]
as
begin
	select
	v.NumVenta,
	v.idCliente,
	v.idUsuario,
	v.fechaFac,
	v.HoraFac,
	v.TipoPago,
	v.Subtotal,
	v.Descuento,
	v.totalcordobas,
	v.TotalDolares	
	from venta as v
	inner join Usuarios as u on  u.idUsuario = v.idUsuario
	inner join clientes as c on  c.idCliente = v.idCliente
end

GO
/****** Object:  StoredProcedure [dbo].[insertar_cliente]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE procedure [dbo].[insertar_cliente]
(

@nombres  nvarchar(120),
@apellido nvarchar(120),
@cedula nvarchar (16),
@correo nvarchar(80),
@celular nvarchar(8),
@estado nvarchar(10)
  )
  AS 
  BEGIN
  INSERT INTO clientes( nombres,apellido,correo,celular,estado)
  VALUES ( @nombres, @apellido, @correo,@celular,@estado)
  END

GO
/****** Object:  StoredProcedure [dbo].[insertar_detalle]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE procedure [dbo].[insertar_detalle]
(
@cantidad int,
@idventa int,
@idproducto int,
@totaldetalle decimal(18,1)
  )
  AS 
  BEGIN
  INSERT INTO detalleventa( cantidad,idVenta,idProducto,totaldetalle)
  VALUES ( @cantidad,@idventa,@idproducto, @totaldetalle)
  END




GO
/****** Object:  StoredProcedure [dbo].[insertaralmacen]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE procedure [dbo].[insertaralmacen]
 (

@CodCategoria int,
@nombre nvarchar(100),
@ubicacion nvarchar(100),
@descripcion nvarchar(100),
@NombreCategoria nvarchar(50)
 )
 as
 begin 
 insert into almacen(nombre,CodCategoria,ubicacion,descripcion,NombreCategoria)
 values (@nombre,@CodCategoria,@ubicacion,@descripcion,@NombreCategoria)
 end
GO
/****** Object:  StoredProcedure [dbo].[insertarcategoria]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertarcategoria]
(
@Tipo nvarchar(50),
@Codproducto nvarchar(20),
@Nombredelproducto nvarchar(50)
  )
  AS 
  BEGIN
  INSERT INTO categoria(Tipo,CodProducto,Nombredelproducto)
  VALUES ( @Tipo,@Codproducto,@Nombredelproducto)
  END

GO
/****** Object:  StoredProcedure [dbo].[insertarcompra]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertarcompra]
(

@IdProveedor int,
@Idusuario int,
@TotalCordobas Numeric(18,2),
@TotalDolares Numeric(18,2),
@Tipopago nvarchar(50),
@Descuento Numeric(18,2),
@Subtotal Numeric(18,2),
@FechaCompra date,
@HoraCompra time

  )
  AS 
  BEGIN
  INSERT INTO compra(idProveedor,idusuario,TotalCordobas,TotalDolares,TipoPago,Descuento,Subtotal,fechaCompra,HoraCompra)
  VALUES ( @IdProveedor,@Idusuario,@TotalCordobas,@TotalDolares,@Tipopago,@Descuento,@Subtotal,@FechaCompra,@HoraCompra)
  select SCOPE_IDENTITY() as id
  END






GO
/****** Object:  StoredProcedure [dbo].[insertardetallecompra]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE procedure [dbo].[insertardetallecompra]
(
@idcompra int,
@idproducto int,
@cantidad int,
@total numeric(18,2)
  )
  AS 
  BEGIN
  INSERT INTO detallecompra( idCompra,idProducto,cantidad,total)
  VALUES ( @idcompra,@idproducto,@cantidad, @total)
  END




GO
/****** Object:  StoredProcedure [dbo].[insertarmarca]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[insertarmarca]
(
@marca nvarchar(20)
  )
  AS 
  BEGIN
  INSERT INTO Marcas(Marca)
  VALUES ( @marca)
  END


GO
/****** Object:  StoredProcedure [dbo].[insertarproducto]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[insertarproducto]
(
@Producto nvarchar (50),
@Codmarca int,
@CodSAC Nvarchar(20),
@existencia numeric(18,2),
@Costo numeric(18,2),
@Precio numeric(18,2),
@Activo bit
  )
  AS 
  BEGIN
  INSERT INTO productos (Producto,CodMarca,CodSAC,Existencia,Costo,Precio,Activo)
  VALUES ( @Producto,@Codmarca,@CodSAC,@existencia,@Costo,@Precio ,@Activo)
  END




GO
/****** Object:  StoredProcedure [dbo].[sp_Area]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Area](
	@idArea int ='',
	@i_area nvarchar(15)='',
	@i_operacion char(1)
)
as
if @i_operacion = 'I'
begin
insert into Ingenieria..area([area]) 
values (@i_area)
end

if @i_operacion = 'S'
begin
select [idArea],[area] from area
end

if @i_operacion = 'U'
begin
update area set area = @i_area
where idArea = @idArea
end

GO
/****** Object:  StoredProcedure [dbo].[sp_empleado]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_empleado](
	@idEmpleado int = '',
	@i_celular int = '',
	@i_direccion nvarchar(90)='',
	@i_cedula nvarchar(16)='',
	@i_apellidos nvarchar(120)='',
	@i_nombres nvarchar(80)='',
	@i_fechaNac datetime='',
	@i_salario money='',
	@i_cargo nvarchar(50)='',
	@i_estado nvarchar(10)='',
	@i_idArea int='',
	@i_idGrupo int='',
	@i_operacion char(1)
)
as
if @i_operacion = 'I'
begin
insert into Ingenieria..empleado([celular],[direccion],[cedula],[apellidos],[nombres],
[fechaNac],[salario],[cargo],[estado],[idArea],[idgrupo]) values
(@i_celular ,@i_direccion ,@i_cedula ,@i_apellidos ,@i_nombres,@i_fechaNac ,@i_salario,@i_cargo ,
	@i_estado ,@i_idArea ,@i_idGrupo )
end

if @i_operacion = 'U'
begin
update Ingenieria..empleado set celular = @i_celular, direccion = @i_direccion, cedula = @i_cedula,
apellidos = @i_apellidos, nombres = @i_nombres, fechaNac = @i_fechaNac, salario =  @i_salario,
cargo = @i_cargo, estado = @i_estado, idArea = @i_idArea, idgrupo = @i_idGrupo
where idEmpleado = @idEmpleado
end

if @i_operacion = 'S'
begin
select empleado.idEmpleado,grupoTrabajadores.idgrupo,area.idArea,
empleado.nombres, empleado.apellidos,empleado.fechaNac,
empleado.cedula,empleado.direccion,empleado.celular,empleado.salario,
empleado.cargo,
empleado.estado,area.area,grupoTrabajadores.grupoTrabajadores from area inner join empleado on
area.idArea = empleado.idArea inner join grupoTrabajadores on
empleado.idgrupo = grupoTrabajadores.idgrupo
end

/*exec sp_empleado
	@idEmpleado = 2,
	@i_celular  = 89,
	@i_direccion ='matagalpa',
	@i_cedula ='002',
	@i_apellidos ='treminiooo',
	@i_nombres ='bladimir',
	@i_fechaNac ='11/12/2000',
	@i_salario =9000,
	@i_cargo ='lavado',
	@i_estado ='activo',
	@i_idArea =1,
	@i_idGrupo =1,
	@i_operacion ='U'*/

GO
/****** Object:  StoredProcedure [dbo].[sp_grupoTrabajadores]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_grupoTrabajadores](
	@idgrupo int ='',
	@i_grupoTrabajadores nvarchar(15)='',
	@i_operacion char(1)
)
as
if @i_operacion = 'I'
begin
insert into Ingenieria..grupoTrabajadores([grupoTrabajadores]) values
(@i_grupoTrabajadores)
end

if @i_operacion = 'U'
begin
update grupoTrabajadores set grupoTrabajadores = @i_grupoTrabajadores 
where idgrupo = @idgrupo
end

if @i_operacion =  'S'
begin
select [idgrupo],[grupoTrabajadores] from grupoTrabajadores
end

/*exec sp_grupoTrabajadores
	@idgrupo  = 2,
	@i_grupoTrabajadores ='mantenimiento',
	@i_operacion ='U'*/

GO
/****** Object:  StoredProcedure [dbo].[sp_lavado]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_lavado]
(
	@idLavado int = '',
	@i_total money = '',
	@i_fecha datetime ='',
	@i_placa nvarchar(10)='',
	@i_idlavadoVehiculo int='',
	@i_idGrupo int='',
	@i_usuario nvarchar(100)='',
	@i_operacion char(1)
)
as
if @i_operacion = 'I'
begin
insert into Ingenieria..lavado([total],[fecha],[placa],[idLavadoVehiculo],[idgrupo],[usuario]) values
(@i_total,@i_fecha,@i_placa,@i_idlavadoVehiculo,@i_idGrupo,@i_usuario)
end
if @i_operacion = 'S'
begin
select lavado.idLavado,lavado.fecha,Usuarios.Usuario,empleado.nombres + ' ' + empleado.apellidos,
grupoTrabajadores.idgrupo,grupoTrabajadores.grupoTrabajadores as Area,
VehiculoLavado.idVehiculoLavado,VehiculoLavado.vehiculoLavado,
servicioLavado.idServicioLavado,servicioLavado.servicioLavado,lavado.idgrupo as Grupo_asignado,
LavadoVehiculo.idLavadoVehiculo,LavadoVehiculo.precio,lavado.placa,lavado.total
from Usuarios inner join empleado on Usuarios.idEmpleado = empleado.idEmpleado
inner join grupoTrabajadores on empleado.idgrupo = grupoTrabajadores.idgrupo
inner join lavado on Usuarios.Usuario = lavado.usuario 
inner join LavadoVehiculo on lavado.idLavadoVehiculo = LavadoVehiculo.idLavadoVehiculo
inner join VehiculoLavado on LavadoVehiculo.idVehiculoLavado = vehiculoLavado.idVehiculoLavado
inner join servicioLavado on LavadoVehiculo.idServicioLavado = servicioLavado.idServicioLavado
end
/*select * from lavado
select * from LavadoVehiculo
select * from grupoTrabajadores
select * from servicioLavado
select * from VehiculoLavado
select * from Ingenieria..empleado
select * from Usuarios
select * from area
end
*/

if @i_operacion = 'U'
begin
update Ingenieria..lavado set total = @i_total,fecha = @i_fecha,placa = @i_placa, idLavadoVehiculo = @i_idlavadoVehiculo,
idgrupo = @i_idGrupo, usuario = @i_usuario where idLavado = @idLavado
end
/*select * from lavado
select * from LavadoVehiculo
exec [sp_lavado]
	@idLavado = 3,
	@i_total = '250',
	@i_fecha ='29/03/2018',
	@i_placa ='19',
	@i_idlavadoVehiculo ='2',
	@i_idGrupo ='1',
	@i_usuario ='joc',
	@i_operacion = 'u'*/




GO
/****** Object:  StoredProcedure [dbo].[sp_lavadoVehiculo]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_lavadoVehiculo](
	@idLavadoVehiculo int = '',
	@i_idServicioLavado int = '',
	@i_idVehiculoLavado int = '',
	@i_precio money ='',
	@i_operacion char(1)
)
as
if @i_operacion = 'I'
begin
insert into Ingenieria..LavadoVehiculo([idServicioLavado],[idVehiculoLavado],[precio])
values (@i_idServicioLavado,@i_idVehiculoLavado,@i_precio)
end
if @i_operacion = 'S'
begin
/*select * from LavadoVehiculo
select * from servicioLavado
select * from VehiculoLavado*/

select LavadoVehiculo.idLavadoVehiculo,servicioLavado.idServicioLavado,
VehiculoLavado.idVehiculoLavado,
VehiculoLavado.vehiculoLavado,servicioLavado.servicioLavado,
LavadoVehiculo.precio
from LavadoVehiculo inner join servicioLavado on LavadoVehiculo.idServicioLavado = servicioLavado.idServicioLavado
inner join VehiculoLavado on LavadoVehiculo.idVehiculoLavado = vehiculoLavado.idVehiculoLavado
end
if @i_operacion = 'U'
begin
update Ingenieria..LavadoVehiculo set idServicioLavado = @i_idServicioLavado,
idVehiculoLavado = @i_idVehiculoLavado, precio = @i_precio where
idLavadoVehiculo = @idLavadoVehiculo
end

--exec  sp_lavadoVehiculo
--	--@idLavadoVehiculo = 3,
--	--@i_idServicioLavado  = 2,
--	--@i_idVehiculoLavado  = 6,
--	--@i_precio  ='650',
--	@i_operacion ='S'
GO
/****** Object:  StoredProcedure [dbo].[sp_mantenimiento]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mantenimiento]
(
@idMantenimiento int = 0,
@total money = 0,
@fecha date='',
@placa nvarchar(10)='',
@idgrupo int =0,
@idservicioVehiculo int=0, 
@usuario nvarchar(100)='',
@i_operacion char(1)
)
as 
if @i_operacion='S'
begin 
select m.idMantenimiento,m.total,m.fecha,m.placa,gt.grupoTrabajadores,sm.servicioMantenimiento,vm.vehiculoMantenimiento,m.usuario,e.nombres,e.apellidos,m.idgrupo,m.idservicioVehiculo,sm.idServicioMantenimiento,vm.idVehiculoMantenimiento from mantenimiento m
inner join Usuarios u on u.Usuario=m.usuario
inner join empleado e on e.idEmpleado=u.idEmpleado
inner join grupoTrabajadores gt on gt.idgrupo=m.idgrupo
inner join ServicioVehiculo sv on sv.idServicioVehiculo=m.idservicioVehiculo
inner join servicioMantenimiento sm on sm.idServicioMantenimiento=sv.idServicioMantenimiento
inner join VehiculoMantenimiento vm on vm.idVehiculoMantenimiento=sv.idVehiculoMantenimiento

end

if @i_operacion='I'
begin
insert into mantenimiento(total,fecha,placa,idgrupo,idservicioVehiculo,usuario)
values (@total,@fecha,@placa,@idgrupo,@idservicioVehiculo,@usuario)

end
GO
/****** Object:  StoredProcedure [dbo].[sp_Pago]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Pago](
 @i_numeroDocumento int = '',
 @i_cordobas numeric(18,6) = '',
 @i_dolares numeric(18,6)='',
 @i_vuelto numeric(18,6)='',
 @fecha datetime,
 @i_idUsuario int='',
 @i_montoFactura numeric(18,2)='',
 @i_operacion char(1)
)
as
if @i_operacion = 'I'
begin
insert into Ingenieria..pago([numerodocumento],[cordobas],[dolares],[vuelto],
[fecha],[idUsuario],[montofactura]) values (@i_numeroDocumento,@i_cordobas,
@i_dolares,@i_vuelto,@fecha,@i_idUsuario,@i_montoFactura)
end

if @i_operacion = 'S'
begin
select numerodocumento,cordobas,dolares,vuelto,fecha,montofactura,
pago.idUsuario,Usuarios.Usuario,empleado.nombres+' '+ empleado.apellidos from pago inner join Usuarios
on pago.idUsuario = Usuarios.idUsuario inner join empleado on Usuarios.idEmpleado = empleado.idEmpleado
end
if @i_operacion = 'U'
begin
update Ingenieria..pago set cordobas = @i_cordobas, dolares = @i_dolares,
vuelto = @i_vuelto,fecha = @fecha,idUsuario = @i_idUsuario, montofactura = @i_montoFactura
where numerodocumento = @i_numeroDocumento
end

--exec  sp_Pago
-- @i_numeroDocumento  = '0001',
-- @i_cordobas  = 2500,
-- @i_dolares = 70,
-- @i_vuelto = 50,
-- @fecha ='01/04/2018',
-- @i_idUsuario = 3,
-- @i_montoFactura ='2600',
-- @i_operacion ='U'
-- select * from Usuarios
-- select * from empleado
GO
/****** Object:  StoredProcedure [dbo].[sp_proveedor]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_proveedor]
(
@idProveedor int=0,
@nombres nvarchar(80) = '',
@apellidos nvarchar(120)='' ,
@telefono nvarchar(12) = '',
@RUC nvarchar(50)='',
@correo nvarchar(80) = '',
@direccion nvarchar(max) = '',
@estado bit = 1,
@nombreempresa nvarchar(80)='',
@i_operacion varchar(1)
)
as

if @i_operacion='I'
begin

insert into [Ingenieria]..proveedor(nombres,apellidos,RUC,telefono,correo,direccion,estado,nombreempresa)
values (@nombres,@apellidos,@RUC,@telefono,@correo,@direccion,@estado,@nombreempresa)
end

if @i_operacion='U'
begin 

update [Ingenieria]..proveedor set nombres=@nombres,apellidos=@apellidos,telefono=@telefono,correo=@correo,direccion=@direccion,estado=@estado,nombreempresa=@nombreempresa,RUC=@RUC where idProveedor=@idProveedor

end

if @i_operacion='S'
begin

select idProveedor,nombres,apellidos,RUC,telefono,correo,direccion,estado,nombreempresa from proveedor where estado='True'

end
GO
/****** Object:  StoredProcedure [dbo].[sp_servicioLavado]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_servicioLavado](
	@idServicioLavado int ='',
	@i_servicioLavado nvarchar(50) = '',
	@i_operacion char(1)
)
as
if @i_operacion = 'I'
begin
insert into Ingenieria..servicioLavado([servicioLavado])
values (@i_servicioLavado)
end

if @i_operacion = 'U'
begin
update servicioLavado set servicioLavado = @i_servicioLavado
where idServicioLavado = @idServicioLavado
end

if @i_operacion = 'S'
begin
select idServicioLavado,servicioLavado from servicioLavado
end
GO
/****** Object:  StoredProcedure [dbo].[sp_serviciomantenimiento]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_serviciomantenimiento]
(
@idServicioMantenimiento int=0,
@servicioMantenimiento nvarchar(50)='',
@estado bit=0,
@i_operacion varchar(1)
)as

if @i_operacion='I'
begin

insert into Ingenieria..servicioMantenimiento(servicioMantenimiento,estado)
values(@servicioMantenimiento,@estado)
 end

 if @i_operacion = 'U'
 begin

 update Ingenieria..servicioMantenimiento set servicioMantenimiento=@servicioMantenimiento,estado=@estado where idServicioMantenimiento=@idServicioMantenimiento

 end

 if @i_operacion = 'S'
 begin
 select idServicioMantenimiento,servicioMantenimiento,estado from Ingenieria..servicioMantenimiento where estado='True'
 end
GO
/****** Object:  StoredProcedure [dbo].[sp_ServicioVehiculo]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_ServicioVehiculo]
(
@idServicioVehiculo int = 0,
@idServicioMantenimiento int=0,
@idVehiculoMantenimiento int = 0,
@precio money = 0,
@estado bit=0,
@i_operacion varchar(1)=''
)
as

if @i_operacion='I'
begin
insert into Ingenieria..ServicioVehiculo(idServicioMantenimiento,idVehiculoMantenimiento,precio,estado)
values(@idServicioMantenimiento,@idVehiculoMantenimiento,@precio,@estado)
end

if @i_operacion='U'
begin
update Ingenieria..ServicioVehiculo set idServicioMantenimiento=@idServicioMantenimiento,idVehiculoMantenimiento=@idVehiculoMantenimiento,precio=@precio,estado=@estado where idServicioVehiculo=@idServicioVehiculo
end

if @i_operacion='S'
begin
select sv.idServicioVehiculo,sm.servicioMantenimiento,vm.vehiculoMantenimiento,sv.precio,sv.estado,sv.idServicioMantenimiento,sv.idVehiculoMantenimiento from ServicioVehiculo sv 
inner join servicioMantenimiento sm on sm.idServicioMantenimiento=sv.idServicioMantenimiento
inner join VehiculoMantenimiento vm on vm.idVehiculoMantenimiento=sv.idVehiculoMantenimiento
where sv.estado=1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Usuarios]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_Usuarios](
	@idUsuario int = '',
	@i_usuario varchar(50)='',
	@i_password nvarchar(max)='',
	@i_idEmpleado int='',
	@i_estado nvarchar(10)='',
	@i_PidUsuario int='',
	@i_Pusuario nvarchar(100)= '',
	@i_venta bit= '',
	@i_mantenimiento bit= '',
	@i_lavado bit= '',
	@i_compra bit= '',
	@i_empleado bit= '',
	@i_Tusuario bit= '',
	@i_producto bit= '',
	@i_proveedor bit= '',
	@V_usuario nvarchar(max)='',
	@V_password nvarchar(max)='',
	@i_operacion char(1)
)
as
if @i_operacion = 'I'
begin
insert into Ingenieria..Usuarios([Usuario],[Password],[idEmpleado],[estado])
values (@i_usuario,@i_password,@i_idEmpleado,@i_estado)
select @i_PidUsuario = max(idusuario) from Usuarios
--select @i_PidUsuario = ISNULL()
insert into Ingenieria..permiso([idUsuario],[venta],[mantenimiento],
[lavado],[compra],[empleado],
[Tusuario],[producto],[proveedor],[usuario]) values
(@i_PidUsuario,@i_venta,@i_mantenimiento,@i_lavado,@i_compra,
@i_empleado,@i_Tusuario,@i_producto,
@i_proveedor,@i_Pusuario)
end

if @i_operacion = 'U'
begin
update Ingenieria..Usuarios 
set Usuario = @i_usuario,
Password = @i_password, 
idEmpleado = @i_idEmpleado,estado = @i_estado
where Usuarios.idUsuario = @idUsuario
update Ingenieria..permiso set venta = @i_venta,
 mantenimiento = @i_mantenimiento, lavado = @i_lavado,
compra = @i_compra, empleado = @i_empleado, Tusuario = @i_Tusuario, 
producto = @i_producto, 
proveedor = @i_proveedor, usuario = @i_Pusuario
 where permiso.idUsuario = @i_PidUsuario
end

if @i_operacion = 'S'
begin
select empleado.nombres + ' ' + empleado.apellidos,
empleado.cargo,Usuarios.Usuario,
Usuarios.Password,Usuarios.estado,permiso.venta,
permiso.mantenimiento,permiso.lavado,
permiso.compra,permiso.empleado,permiso.Tusuario,
permiso.producto,permiso.proveedor,Usuarios.idUsuario,permiso.idUsuario,empleado.idEmpleado from
empleado inner join Usuarios on empleado.idEmpleado = Usuarios.idEmpleado inner join
permiso on Usuarios.idUsuario = permiso.idUsuario where Usuarios.estado = 'Activo'
end

if @i_operacion = 'V'
begin
select empleado.nombres + ' ' + empleado.apellidos,empleado.cargo,
Usuarios.Usuario,
Usuarios.Password,Usuarios.estado,permiso.venta,permiso.mantenimiento,
permiso.lavado,
permiso.compra,permiso.empleado,permiso.Tusuario,permiso.producto,
permiso.proveedor from
empleado inner join Usuarios on empleado.idEmpleado = Usuarios.idEmpleado inner join
permiso on Usuarios.idUsuario = permiso.idUsuario where permiso.usuario = @V_usuario and
Usuarios.Password = @V_password and Usuarios.estado = 'activo'
end

/*exec sp_Usuarios
	@idUsuario  = 1,
	@i_usuario ='jocsel',
	@i_password ='joc',
	@i_idEmpleado = 1,
	@i_estado ='activo',
	@i_PidUsuario ='1',
	@i_Pusuario = 'joc',
	@i_venta = 1,
	@i_mantenimiento = 1,
	@i_lavado = 1,
	@i_compra = 1,
	@i_empleado = 1,
	@i_Tusuario = 1,
	@i_producto = 1,
	@i_proveedor = 1,
	--@V_usuario = 'joc',
	--@V_password = 'joc',
	@i_operacion = 'u'


select * from Usuarios
select * from permiso*/

GO
/****** Object:  StoredProcedure [dbo].[sp_vehiculoLavado]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_vehiculoLavado](
	@idVehiculoLavado int = '',
	@i_vehiculoLavado nvarchar(50) = '',
	@i_operacion char(1)
)
as 
if @i_operacion = 'I'
begin
insert into Ingenieria..VehiculoLavado ([vehiculoLavado])
values (@i_vehiculoLavado)
end
if @i_operacion = 'S'
begin
select [idVehiculoLavado],[vehiculoLavado] from VehiculoLavado
end
if @i_operacion = 'U'
begin
update Ingenieria..VehiculoLavado set vehiculoLavado = @i_vehiculoLavado
where idVehiculoLavado = @idVehiculoLavado
end

--exec sp_vehiculoLavado
--	@idVehiculoLavado  = 7,
--	@i_vehiculoLavado = 'Moto',
--	@i_operacion = 'u'

GO
/****** Object:  StoredProcedure [dbo].[sp_vehiculoMantenimiento]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_vehiculoMantenimiento]
(
@idVehiculoMantenimiento int = 0,
@vehiculoMantenimiento nvarchar(50)='',
@estado bit='',
@i_operacion varchar(1)=''
)
as

if @i_operacion='S'
begin 
select idVehiculoMantenimiento,vehiculoMantenimiento,estado from VehiculoMantenimiento where estado='True'
end
if @i_operacion='I'
begin
insert into Ingenieria..VehiculoMantenimiento(vehiculoMantenimiento,estado)
values(@vehiculoMantenimiento,@estado)
end
 if @i_operacion='U'
 begin
 update VehiculoMantenimiento set vehiculoMantenimiento=@vehiculoMantenimiento,estado=@estado where idVehiculoMantenimiento=@idVehiculoMantenimiento
 end
GO
/****** Object:  Trigger [dbo].[trIUDproveedor]    Script Date: 03/04/2018 21:50:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*go
CREATE TABLE logTransacciones(

  TipoTrn char(1),
  Tabla varchar(128),
  PK varchar(1000),
  Campo varchar(128),
  ValorOriginal varchar(1000),
  ValorNuevo varchar(1000),
  FechaTrn datetime,
  Usuario varchar(128))

GO
*/
/*

*/
CREATE TRIGGER [dbo].[trIUDproveedor] ON [dbo].[proveedor] FOR INSERT, UPDATE, DELETE
AS 

DECLARE @bit int ,	
        @field int ,	
        @maxfield int ,	
        @char int ,	
        @fieldname varchar(128) ,	
        @TableName varchar(128) ,	
        @PKCols varchar(1000) ,	
        @sql varchar(2000), 	
        @UpdateDate varchar(21) ,	
        @UserName varchar(128) ,	
        @Type char(1) ,	
        @PKSELECT varchar(1000)
	
SELECT @TableName = 'proveedor' --<-- cambiar el nombre de la tabla 

-- Fecha y Usuario
SELECT @UserName = SYSTEM_USER,
       @UpdateDate = convert(varchar(8), getdate(), 112) + 
                     ' ' + 
                     convert(varchar(12), getdate(), 114)

SET NoCount ON 

-- Identificar que evento se está ejecutando (Insert, Update o Delete) 
--en base a cursores especiales (inserted y deleted)
if exists (SELECT * FROM inserted) 
  if exists (SELECT * FROM deleted) --Si es un update
    SELECT @Type = 'U'
  else                              --Si es un insert
    SELECT @Type = 'I'
else                                --si es un delete
    SELECT @Type = 'D'
	
-- Obtenemos la lista de columnas de los cursores
SELECT * INTO #ins FROM inserted
SELECT * INTO #del FROM deleted
	
-- Obtener las columnas de llave primaria
SELECT @PKCols = coalesce(@PKCols + ' and', ' on') + 
       ' i.' + 
       c.COLUMN_NAME + ' = d.' + 
       c.COLUMN_NAME
 FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS pk
  JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE c
  ON c.TABLE_NAME = pk.TABLE_NAME
  AND c.CONSTRAINT_NAME = pk.CONSTRAINT_NAME
 WHERE pk.TABLE_NAME = @TableName AND 
  pk.CONSTRAINT_TYPE = 'PRIMARY KEY'
	
-- Obtener la llave primaria y columnas para la inserción en la tabla de auditoria
SELECT 
 @PKSELECT = coalesce(@PKSelect+'+','') + 
 '''' + 
 COLUMN_NAME + 
 '=''+convert(varchar(100),coalesce(i.' + 
 COLUMN_NAME +',d.' + 
 COLUMN_NAME + '))+''''' 
 FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS pk  
 JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE c
  ON c.TABLE_NAME = pk.TABLE_NAME
  AND c.CONSTRAINT_NAME = pk.CONSTRAINT_NAME
 WHERE pk.TABLE_NAME = @TableName
  AND CONSTRAINT_TYPE = 'PRIMARY KEY'
	
if @PKCols is null --<-- Este trigger solo funciona si la tabla tiene llave primaria
 BEGIN
  RAISERROR('no PK on table %s', 16, -1, @TableName)
  RETURN
 END
	
--Loop para armar el query de inserción en la tabla de log. 
--Un registro por cada campo afectado.
SELECT 
 @field = 0, 
 @maxfield = max(ORDINAL_POSITION) 
 FROM INFORMATION_SCHEMA.COLUMNS 
 WHERE TABLE_NAME = @TableName
	
while @field < @maxfield
 BEGIN
  SELECT @field = min(ORDINAL_POSITION) 
   FROM INFORMATION_SCHEMA.COLUMNS 
   WHERE TABLE_NAME = @TableName and ORDINAL_POSITION > @field
  SELECT @bit = (@field - 1 )% 8 + 1
  SELECT @bit = power(2,@bit - 1)
  SELECT @char = ((@field - 1) / 8) + 1
  if substring(COLUMNS_UPDATED(),@char, 1) & @bit > 0 or @Type in ('I','D')
   BEGIN
     SELECT @fieldname = COLUMN_NAME 
      FROM INFORMATION_SCHEMA.COLUMNS 
	  WHERE TABLE_NAME = @TableName and ORDINAL_POSITION = @field
     SELECT @sql = 'insert LogTransacciones (TipoTrn, Tabla, PK, Campo, ValorOriginal, ValorNuevo, FechaTrn, Usuario)'
     SELECT @sql = @sql + 	' SELECT ''' + @Type + ''''
     SELECT @sql = @sql + 	',''' + @TableName + ''''
     SELECT @sql = @sql + 	',' + @PKSelect
     SELECT @sql = @sql + 	',''' + @fieldname + ''''
     SELECT @sql = @sql + 	',convert(varchar(1000),d.' + @fieldname + ')'
     SELECT @sql = @sql + 	',convert(varchar(1000),i.' + @fieldname + ')'
     SELECT @sql = @sql + 	',''' + @UpdateDate + ''''
     SELECT @sql = @sql + 	',''' + @UserName + ''''
     SELECT @sql = @sql + 	' from #ins i full outer join #del d'
     SELECT @sql = @sql + 	@PKCols
     SELECT @sql = @sql + 	' where i.' + @fieldname + ' <> d.' + @fieldname 
     SELECT @sql = @sql + 	' or (i.' + @fieldname + ' is null and  d.' + @fieldname + ' is not null)' 
     SELECT @sql = @sql + 	' or (i.' + @fieldname + ' is not null and  d.' + @fieldname + ' is null)' 
     exec (@sql)
   END
 END
	 
SET NoCount OFF 

GO
ALTER TABLE [dbo].[proveedor] ENABLE TRIGGER [trIUDproveedor]
GO
USE [master]
GO
ALTER DATABASE [Ingenieria] SET  READ_WRITE 
GO
