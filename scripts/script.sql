USE [master]
GO
/****** Object:  Database [indigo]    Script Date: 10/02/2022 9:33:28 a. m. ******/
CREATE DATABASE [indigo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'indigo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\indigo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'indigo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\indigo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [indigo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [indigo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [indigo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [indigo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [indigo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [indigo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [indigo] SET ARITHABORT OFF 
GO
ALTER DATABASE [indigo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [indigo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [indigo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [indigo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [indigo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [indigo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [indigo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [indigo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [indigo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [indigo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [indigo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [indigo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [indigo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [indigo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [indigo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [indigo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [indigo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [indigo] SET RECOVERY FULL 
GO
ALTER DATABASE [indigo] SET  MULTI_USER 
GO
ALTER DATABASE [indigo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [indigo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [indigo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [indigo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [indigo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [indigo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'indigo', N'ON'
GO
ALTER DATABASE [indigo] SET QUERY_STORE = OFF
GO
USE [indigo]
GO
/****** Object:  User [lmcorral]    Script Date: 10/02/2022 9:33:28 a. m. ******/
CREATE USER [lmcorral] FOR LOGIN [lmcorral] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Almacen]    Script Date: 10/02/2022 9:33:28 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Almacen](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](20) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InventarioFisico]    Script Date: 10/02/2022 9:33:28 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InventarioFisico](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[IdAlmacen] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 10/02/2022 9:33:28 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](20) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[Descripcion] [varchar](max) NULL,
	[PrecioVenta] [numeric](18, 0) NOT NULL,
	[StockMinimo] [int] NOT NULL,
	[StockMaximo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 10/02/2022 9:33:28 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](20) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RemisionEntrada]    Script Date: 10/02/2022 9:33:28 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RemisionEntrada](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](20) NOT NULL,
	[FechaDocumento] [date] NOT NULL,
	[IdProveedor] [int] NOT NULL,
	[IdAlmacen] [int] NOT NULL,
	[Estado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RemisionEntradaDetalle]    Script Date: 10/02/2022 9:33:28 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RemisionEntradaDetalle](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdRemisionEntrada] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[InventarioFisico]  WITH CHECK ADD  CONSTRAINT [FK_Almacen_Inventario_Fisico] FOREIGN KEY([IdAlmacen])
REFERENCES [dbo].[Almacen] ([Id])
GO
ALTER TABLE [dbo].[InventarioFisico] CHECK CONSTRAINT [FK_Almacen_Inventario_Fisico]
GO
ALTER TABLE [dbo].[InventarioFisico]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Inventario_Fisico] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Producto] ([Id])
GO
ALTER TABLE [dbo].[InventarioFisico] CHECK CONSTRAINT [FK_Producto_Inventario_Fisico]
GO
ALTER TABLE [dbo].[RemisionEntrada]  WITH CHECK ADD  CONSTRAINT [FK_RemisionEntrada_Almacen] FOREIGN KEY([IdAlmacen])
REFERENCES [dbo].[Almacen] ([Id])
GO
ALTER TABLE [dbo].[RemisionEntrada] CHECK CONSTRAINT [FK_RemisionEntrada_Almacen]
GO
ALTER TABLE [dbo].[RemisionEntrada]  WITH CHECK ADD  CONSTRAINT [FK_RemisionEntrada_Proveedor] FOREIGN KEY([IdProveedor])
REFERENCES [dbo].[Proveedor] ([Id])
GO
ALTER TABLE [dbo].[RemisionEntrada] CHECK CONSTRAINT [FK_RemisionEntrada_Proveedor]
GO
ALTER TABLE [dbo].[RemisionEntradaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_RemisionEntradaDetalle_RemisionEntrada] FOREIGN KEY([IdRemisionEntrada])
REFERENCES [dbo].[RemisionEntrada] ([Id])
GO
ALTER TABLE [dbo].[RemisionEntradaDetalle] CHECK CONSTRAINT [FK_RemisionEntradaDetalle_RemisionEntrada]
GO
/****** Object:  StoredProcedure [dbo].[Sp_Admintra_remisiones]    Script Date: 10/02/2022 9:33:28 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_Admintra_remisiones]
@Id int,
@Codigo varchar(20),
@FechaDocumento date,
@IdProveedor int,
@IdAlmacen int,
@Estado int,
@TipoOpera int


AS
BEGIN
	SET NOCOUNT ON;
    DECLARE @status NVARCHAR(50);
	DECLARE @estados int;
	DECLARE @identra int;
	DECLARE @cant int;
	DECLARE @idpro int;
	DECLARE @valida int;
	DECLARE @msj int;

   if (@TipoOpera=1)
   BEGIN
      INSERT INTO RemisionEntrada VALUES (@Codigo,@FechaDocumento,@IdProveedor,@IdAlmacen,@Estado);
	  SET @status ='Remision Guardada correctamente.!';
   END
   ELSE IF (@TipoOpera=2)
   BEGIN

      INSERT INTO RemisionEntrada VALUES (@Codigo,@FechaDocumento,@IdProveedor,@IdAlmacen,@Estado);
	  SET @identra = (SELECT SCOPE_IDENTITY());
	  SET @idpro = (select IdProducto from RemisionEntrada re ,Almacen al, InventarioFisico inv where re.IdAlmacen=al.Id and al.Id = inv.IdAlmacen and re.IdAlmacen=@IdAlmacen and re.IdProveedor=@IdProveedor);
	  SET @cant = (select Cantidad from RemisionEntrada re ,Almacen al, InventarioFisico inv where re.IdAlmacen=al.Id and al.Id = inv.IdAlmacen and re.IdAlmacen=@IdAlmacen and re.IdProveedor=@IdProveedor);

	  SET @valida =(select COUNT(*) from RemisionEntradaDetalle where IdProducto=@idpro );
	  if(@valida>=1)
	  BEGIN
	   --no se hace nada 
	   SET @msj='';
	  END 
	  ELSE
	  BEGIN
		--insert into RemisionEntradaDetalle values (@identra,@idpro,@cant);
		SET @msj='';
	  END 
      SET @status ='Remision Guardada y confirmada correctamente.!'; 
   END 
   ELSE IF (@TipoOpera=3)
   BEGIN
      
	  SET @estados = (SELECT  estado from RemisionEntrada where id= @Id);
	  
	  if (@estados != 1)
	    BEGIN
			SET @status ='El estado de esta remision no permite hacer una modificacion.';
		END 
	  ELSE
		BEGIN
		     update RemisionEntrada set Codigo=@Codigo,FechaDocumento=@FechaDocumento,IdProveedor=@IdProveedor,IdAlmacen=@IdAlmacen where Id=@Id;
		     SET @status ='Remision Modificada correctamente.'; 
	    END 
	         
   END 
   ELSE IF(@TipoOpera=4)
   BEGIN
	  SET @estados = (SELECT  estado from RemisionEntrada where id= @Id);
	  
	  if (@estados != 1)
	    BEGIN
			SET @status ='El estado de esta remision no permite hacer una anulacion.';
		END 
	  ELSE
		BEGIN
		     update RemisionEntrada set Estado=@Estado where Id=@Id;
		     SET @status ='Remision Anulada correctamente.'; 
	    END 
   END 
   ELSE IF(@TipoOpera=5)
   BEGIN
	  SET @estados = (SELECT  estado from RemisionEntrada where id= @Id);
	  
	  if (@estados != 1)
	    BEGIN
			SET @status ='El estado de esta remision no permite confirmala.';
		END 
	  ELSE
		BEGIN
		     update RemisionEntrada set Estado=@Estado where Id=@Id;
----------------------------------------------------------------------
      SET @idpro =(select IdProducto from RemisionEntrada re ,Almacen al, InventarioFisico inv where re.IdAlmacen=al.Id and al.Id = inv.IdAlmacen and re.IdAlmacen=@IdAlmacen);
	  SET @cant = (select Cantidad from RemisionEntrada re ,Almacen al, InventarioFisico inv where re.IdAlmacen=al.Id and al.Id = inv.IdAlmacen and re.IdAlmacen=@IdAlmacen);

	  SET @valida =(select COUNT(*) from RemisionEntradaDetalle where IdProducto=@idpro );

	  if(@valida>=1)
	  BEGIN
	   --no se hace nada 
	   SET @msj='';
	  END 
	  ELSE
	  BEGIN
		--insert into RemisionEntradaDetalle values (@Id,@idpro,@cant);
		SET @msj='';
	  END 
		     SET @status ='Remision Confirmada correctamente.'; 
	    END 
   END 
   ELSE
   BEGIN
    SET @status ='Opcion No controlada'; 
   END 

   select @status AS 'STATUS';
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_datos_proveedor]    Script Date: 10/02/2022 9:33:28 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_datos_proveedor]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from proveedor;
END
GO
USE [master]
GO
ALTER DATABASE [indigo] SET  READ_WRITE 
GO
