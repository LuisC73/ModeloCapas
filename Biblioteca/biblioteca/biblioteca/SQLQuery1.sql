create database biblioteca;

create table productos(

id_producto int primary key identity,
nombre_producto nvarchar(30),
cantidad int,
autor nvarchar(50),
categoria nvarchar(15),
precio int,
activo bit





);

