create database BDCrudVB
go

use BDCrudVB
go

create table categoria
(
	idCategoria int primary key identity(1,1) not null,
	descripcion varchar(50)
);

create table producto
(
	idProducto int identity(1,1) primary key not null,
	descripcion varchar(50) not null,
	precio numeric(18,1) not null,
	stock int not null,
	idCategoria int not null
);

alter table producto
add constraint FK_PC foreign key(idCategoria) references categoria(idCategoria)
go

-- REGISTROS

insert into categoria values('ABARROTES');
insert into categoria values('BEBIDAS');
insert into categoria values('CARNES');
insert into categoria values('LACTEOS');

insert into producto values('Leche Gloria',3.5,100,4);
go

--PROCEDIMIENTOS ALMACENADOS

CREATE PROC SP_ListaProductos
as
select * from producto
go

CREATE PROC SP_ListaCategorias
as
select * from categoria
go

CREATE PROC SP_InsertarProducto
@descripcion varchar(50),
@precio float,
@stock int,
@idCategoria int
as
INSERT INTO producto VALUES(@descripcion,@precio, @stock, @idCategoria)
go

CREATE PROC SP_BuscarProducto
@descripcion varchar(50)
as
select * from producto where descripcion = @descripcion
go

CREATE PROC SP_ActualizarProducto
@idProducto int,
@descripcion varchar(50),
@precio float,
@stock int,
@idCategoria int
as
update producto set descripcion = @descripcion, precio = @precio, 
stock = @stock,idCategoria = @idCategoria where idProducto = @idProducto
go

CREATE PROC SP_EliminarProducto
@idProducto int
as
delete from producto where idProducto = @idProducto
go