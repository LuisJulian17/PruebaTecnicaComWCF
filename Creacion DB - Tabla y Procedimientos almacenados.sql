
/*Creacion de base de datos*/
create database DBPRUEBA
go

use DBPRUEBA
go
/*Creacion de tabla usuarios*/
create table usuarios(
id int primary key identity,
nombre varchar (100) not null,
fecha varchar(100) ,
sexo varchar(1)
)
/*Valores para insertar en la tabla usuarios*/
insert into usuarios(nombre,fecha,sexo)
values
('Julian', '1998-09-23', 'M'),
('Sofia', '1999-06-15', 'F'),
('Luis', '2000-02-12', 'M'),
('Karen', '1980-12-01', 'F');


/*Procedimientos almacenados*/
use DBPRUEBA

if OBJECT_ID('Listar') is not null
	drop proc Listar
go
create proc Listar
as
	select * from usuarios
go

if OBJECT_ID('Insertar') is not null
	drop proc Insertar
go
create proc Insertar (@nom varchar(100), @fechaN date, @sexo char)
as
	insert into usuarios values (@nom,@fechaN,@sexo)
go

if OBJECT_ID('Actualizar') is not null
	drop proc Actualizar
go
create proc Actualizar (@id int,@nom varchar(100), @fechaN date, @sexo char)
as
update usuarios set nombre = @nom, fecha = @fechaN , sexo = @sexo 
where id = @id
go

if OBJECT_ID('Eliminar') is not null
	drop proc Eliminar
go
create proc Eliminar (@id int)
as
delete from usuarios where id = @id
go

if OBJECT_ID('Buscar') is not null
	drop proc Buscar
go
create proc Buscar (@id int)
as
	select * from usuarios where id = @id
go

