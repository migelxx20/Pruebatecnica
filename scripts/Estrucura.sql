

create table Producto (
Id  int IDENTITY primary key,
Codigo varchar(20) NOT NULL,
Nombre varchar (200) NOT NULL,
Descripcion  varchar(MAX),
PrecioVenta numeric(18,0) NOT NULL,
StockMinimo int not null,
StockMaximo int not null
);

create table InventarioFisico(
Id int IDENTITY primary key,
IdProducto  int not null ,
IdAlmacen int not null ,
Cantidad int not null 
);


create table Almacen(
Id int IDENTITY primary key,
Codigo  varchar(20)  not null ,
Nombre varchar(100) not null 
);


create table RemisionEntrada(
Id int IDENTITY primary key,
Codigo  varchar(20)  not null ,
FechaDcumento  date not null ,
IdProveedor int not null ,
IdAlmacen int not null ,
Estado int not null 
);


create table RemisionEntradaDetalle(
Id int IDENTITY primary key,
IdRemisionEntrada int not null ,
IdProducto int not null ,
Cantidad int not null 
);


create table Proveedor(
Id int IDENTITY primary key,
Codigo  varchar(20)  not null ,
Nombre varchar(200) not null, 
Direccion varchar(100) not null ,
Telefono varchar(50) not null ,
);


ALTER TABLE InventarioFisico   ADD CONSTRAINT FK_Producto_Inventario_Fisico FOREIGN KEY (IdProducto ) REFERENCES  Producto(Id);
ALTER TABLE InventarioFisico  ADD CONSTRAINT FK_Almacen_Inventario_Fisico FOREIGN KEY (IdAlmacen  ) REFERENCES Almacen (Id);
ALTER TABLE RemisionEntrada  ADD CONSTRAINT FK_RemisionEntrada_Almacen FOREIGN KEY (IdAlmacen  ) REFERENCES Almacen (Id);
ALTER TABLE RemisionEntradaDetalle  ADD CONSTRAINT FK_RemisionEntradaDetalle_RemisionEntrada FOREIGN KEY (IdRemisionEntrada  ) REFERENCES RemisionEntrada(Id);
ALTER TABLE RemisionEntrada  ADD CONSTRAINT FK_RemisionEntrada_Proveedor FOREIGN KEY (IdProveedor ) REFERENCES Proveedor(Id);