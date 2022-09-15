create database CrudAdoNetProductos
go

use CrudAdoNetProductos

create table Productos(
Id_prod int identity(1,1) not null,
nombre_prod varchar(50) unique not null,
precio_prod money not null
constraint PK_Productos primary key (Id_prod)
)

insert into Productos(nombre_prod,precio_prod)
select 'Leche',120 union
select 'Papa',30 union
select 'Carne',900

select * from Productos