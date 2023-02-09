create Proc [dbo].[SP_GET_CLIENTES]
as
select id_cliente, nombre, apellido, fec_nac, calle, altura, telefono, mail
from clientes
where activo = 1

 ----------------------------------------------------------------------------

create proc [dbo].[SP_GET_CALIFICACIONES]
AS
select * from calificaciones
------------------------------------------------------------------------------

create proc [dbo].[SP_GET_ORIGENES]	
AS
select * from origen

-------------------------------------------------------------------------------

create proc [dbo].[SP_INSERT_PELICULA]
@titulo varchar(100), @sinopsis varchar(500), @fec_estreno datetime,
@elenco varchar(300), @duracion float, @calificacion int,  @apta_todo_publico bit, 
@idioma varchar(50), @subtitulo bit, @genero int, @origen int
as
begin
insert into Peliculas(titulo,sinopsis,fec_estreno,elenco,duracion,id_calificacion,apta_todo_publico,idioma,subtitulos,id_genero,id_origen, activa) 
			  values(@titulo,@sinopsis,@fec_estreno,@elenco,@duracion,@calificacion,@apta_todo_publico,@idioma,@subtitulo,@genero,@origen, 1)
end

---------------------------------------------------------------------------------

create proc SP_UPDATE_CLIENTE
@id_cliente int,
@nombre varchar (30),
@apellido varchar(30),
@fec_nac datetime,
@calle varchar(30),
@altura int,
@telefono varchar(20),
@mail varchar(50)
as
begin
Update clientes set nombre = @nombre,apellido = @apellido,fec_nac =@fec_nac,calle=@calle,altura = @altura,telefono= @telefono,mail = @mail
where id_cliente = @id_cliente
end			  

----------------------------------------------------------------------------------

create proc SP_INSERT_FUNCION
@fecha datetime, @hora_inicio datetime,
@precio money, @id_peli int, @id_sala int
as
insert into funciones (fecha, hora_inicio,precio,id_pelicula,id_sala, agotado) 
				values (@fecha,@hora_inicio,@precio,@id_peli,@id_sala,0)

----------------------------------------------------------------------------------

create proc SP_UPDATE_FUNCION
@id_funcion int, @fecha datetime, @hora_inicio datetime,
@precio money, @id_peli int, @id_sala int
as
update funciones set fecha=@fecha, hora_inicio=@hora_inicio,precio=@precio,id_pelicula=@id_peli,id_sala=@id_sala 
where id_funcion = @id_funcion

------------------------------------------------------------------------------------

Create PROCEDURE [dbo].[SP_INSERT_RESERVA]
@fec_reserva datetime,
@id_cliente int,
@idOut INT OUTPUT
AS
INSERT INTO reservas(fec_reserva,id_cliente)
VALUES (@fec_reserva , @id_cliente)
SET @idOut = @@Identity;

----------------------------------------------------------------------------------------

create proc SP_INSERT_DET_RESERVA
@id_reserva int, @id_funcion int, @cantidad int
as
insert into detalle_reserva (id_reserva, id_funcion, cantidad)
values(@id_reserva,@id_funcion,@cantidad)

---------------------------------------------------------------------------------------

create proc SP_GET_RESERVAS
AS
select r.id_reserva, r.id_cliente, c.nombre, c.apellido, fec_reserva 
from reservas r join clientes c on r.id_cliente=c.id_cliente

----------------------------------------------------------------------------------------

CREATE PROC SP_GET_DETALLE_RESERVA
@id_reserva int
as
select p.titulo, f.fecha, f.hora_inicio, f.precio, s.id_sala, s.tipo
from detalle_reserva d join funciones f on d.id_funcion=f.id_funcion join Peliculas p on p.id_pelicula=f.id_pelicula join salas s on s.id_sala=f.id_sala
where d.id_reserva = @id_reserva

------------------------------------------------------------------------------------------

create proc [dbo].[SP_INSERT_CLIENTE]
 @nombre varchar (30),
 @apellido varchar(30),
 @fec_nac datetime,
 @calle varchar(30),
 @altura int,
 @telefono varchar(20),
 @mail varchar(50)
 as
 begin
 insert into clientes(nombre,apellido,fec_nac,calle,altura,telefono,mail,activo) 
 values (@nombre,@apellido,@fec_nac,@calle,@altura,@telefono,@mail,1)
 end

 -------------------------------------------------------------------------------------------------

Create proc SP_GET_FUNCIONES
as
select f.id_funcion,p.id_pelicula, s.id_sala, f.fecha, f.hora_inicio, f.precio, p.titulo, s.tipo, agotado 
from funciones f join Peliculas p on p.id_pelicula = f.id_pelicula join salas s on s.id_sala=f.id_sala

---------------------------------------------------------------------------------------------------

Create proc SP_GET_FUNCION_X_NOMBRE
@nombre varchar(50)
as
select f.id_funcion,p.id_pelicula, s.id_sala,f.fecha, f.hora_inicio, f.precio, p.titulo, s.tipo, agotado
from funciones f join Peliculas p on f.id_pelicula=p.id_pelicula join salas s on s.id_sala=f.id_sala
where titulo like '%'+@nombre+'%'

--------------------------------------------------------------------------------------------------------

Create proc SP_GET_FUNCION_RESERVA
AS
select f.id_funcion,p.id_pelicula, s.id_sala,f.fecha, f.hora_inicio, f.precio, p.titulo, s.tipo, agotado
from funciones f join Peliculas p on f.id_pelicula=p.id_pelicula join salas s on s.id_sala=f.id_sala 

--------------------------------------------------------------------------------------------------------

create Proc SP_GET_PELICULAS
AS
SELECT id_pelicula, titulo, sinopsis, fec_estreno, elenco, duracion, c.calificacion, apta_todo_publico, idioma, subtitulos, g.genero, o.origen 
from Peliculas p join calificaciones c on p.id_calificacion=c.id_calificacion join generos g on g.id_genero=p.id_genero join
origen o on o.id_origen=p.id_origen
where activa = 1

----------------------------------------------------------------------------------------------------------

create proc SP_UPDATE_PELICULA
@id_pelicula int,@titulo varchar(100), @sinopsis varchar(500), @fec_estreno datetime,
@elenco varchar(300), @duracion float, @calificacion int,  @apta_todo_publico bit, 
@idioma varchar(50), @subtitulo bit, @genero int, @origen int
as
update Peliculas set titulo=@titulo, sinopsis=@sinopsis, fec_estreno=@fec_estreno, 
elenco=@elenco,duracion=@duracion, id_calificacion=@calificacion, apta_todo_publico=@apta_todo_publico,idioma=@idioma, subtitulos=@subtitulo,id_genero=@genero, id_origen=@origen
where id_pelicula = @id_pelicula

----------------------------------------------------------------------------------------------------------

create proc SP_GET_SALAS
as
select * from salas

-------------------------------------------------------------------------------------------------------------

create Proc SP_DELETE_PELICULA
@id_pelicula int
as
update Peliculas set activa = 0
where id_pelicula = @id_pelicula
select * from Peliculas


--Insert Necesarios 

Insert into generos values(1, 'Comedia')
Insert into generos values(2, 'Accion')
Insert into generos values(3, 'Romance')
Insert into generos values(4, 'Suspenso')
Insert into generos values(5, 'Terror')
Insert into generos values(6, 'Motivador')

exec SP_INSERT_PELICULA 'Rey Leon', 'Joven leon queda huerfano', '26/01/23', 'Los persos', 230.3, 4, 1,'Ingles',0,1,1

Insert into salas values('Sala 2D')
Insert into salas values('Sala 3D')
Insert into salas values('Sala VIP')
Insert into salas values('Sala 5.0')