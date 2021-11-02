
create proc registrar_producto
@id_producto int,
@nombre nvarchar(30),
@cantidad int,
@precio int,
@categoria nvarchar(15),
@activo bit
as
insert into productos(id_producto,nombre_producto,cantidad,precio,categoria) 
values(@id_producto,@nombre,@cantidad,@precio,@categoria);


create proc consultar_producto
@id_producto int
as
SELECT * from productos;


create proc anular_producto
@id_producto int
as
delete from productos where id_producto=@id_producto
