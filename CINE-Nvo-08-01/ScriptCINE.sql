USE [CineTUP_Oficial]
GO
/****** Object:  Table [dbo].[butacas]    Script Date: 18/01/2023 21:05:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[butacas](
	[id_butaca] [int] NOT NULL,
	[id_sala] [int] NULL,
 CONSTRAINT [pk_butaca] PRIMARY KEY CLUSTERED 
(
	[id_butaca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[calificaciones]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[calificaciones](
	[id_calificacion] [int] NOT NULL,
	[calificacion] [varchar](30) NULL,
 CONSTRAINT [pk_calificaciones] PRIMARY KEY CLUSTERED 
(
	[id_calificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[apellido] [varchar](30) NOT NULL,
	[fec_nac] [datetime] NULL,
	[calle] [varchar](30) NULL,
	[altura] [int] NULL,
	[telefono] [varchar](20) NULL,
	[mail] [varchar](50) NULL,
	[activo] [bit] NOT NULL,
 CONSTRAINT [pk_cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_factura]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_factura](
	[id_detalle_factura] [int] IDENTITY(1,1) NOT NULL,
	[id_factura] [int] NULL,
	[id_funcion] [int] NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [pk_detalle_factura] PRIMARY KEY CLUSTERED 
(
	[id_detalle_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_reserva]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_reserva](
	[id_detalle_reserva] [int] IDENTITY(1,1) NOT NULL,
	[id_reserva] [int] NULL,
	[id_funcion] [int] NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [pk_detalle_reserva] PRIMARY KEY CLUSTERED 
(
	[id_detalle_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[facturas]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[facturas](
	[id_factura] [int] IDENTITY(1,1) NOT NULL,
	[feecha] [datetime] NULL,
	[id_cliente] [int] NULL,
	[id_reserva] [int] NULL,
	[id_forma_pago] [int] NULL,
	[id_promocion] [int] NULL,
 CONSTRAINT [pk_facturas] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[formas_de_pago]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[formas_de_pago](
	[id_forma_pago] [int] NOT NULL,
	[forma_pago] [varchar](30) NULL,
 CONSTRAINT [pk_forma_pago] PRIMARY KEY CLUSTERED 
(
	[id_forma_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[funciones]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[funciones](
	[id_funcion] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NULL,
	[hora_inicio] [datetime] NULL,
	[precio] [float] NULL,
	[id_pelicula] [int] NULL,
	[id_sala] [int] NULL,
	[agotado] [bit] NULL,
 CONSTRAINT [pk_funcion] PRIMARY KEY CLUSTERED 
(
	[id_funcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[generos]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[generos](
	[id_genero] [int] NOT NULL,
	[genero] [varchar](30) NULL,
 CONSTRAINT [pk_genero] PRIMARY KEY CLUSTERED 
(
	[id_genero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[origen]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[origen](
	[id_origen] [int] NOT NULL,
	[origen] [varchar](30) NULL,
 CONSTRAINT [pk_origen] PRIMARY KEY CLUSTERED 
(
	[id_origen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Peliculas]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Peliculas](
	[id_pelicula] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](30) NOT NULL,
	[sinopsis] [varchar](300) NOT NULL,
	[fec_estreno] [datetime] NULL,
	[elenco] [varchar](50) NULL,
	[duracion] [float] NULL,
	[id_calificacion] [int] NULL,
	[apta_todo_publico] [bit] NULL,
	[idioma] [varchar](30) NULL,
	[subtitulos] [bit] NULL,
	[id_genero] [int] NULL,
	[id_origen] [int] NULL,
	[activa] [bit] NULL,
 CONSTRAINT [pk_pelicula] PRIMARY KEY CLUSTERED 
(
	[id_pelicula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[promociones]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[promociones](
	[id_promocion] [int] NOT NULL,
	[promocion] [varchar](30) NULL,
 CONSTRAINT [pk_promocion] PRIMARY KEY CLUSTERED 
(
	[id_promocion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reservas]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservas](
	[id_reserva] [int] IDENTITY(1,1) NOT NULL,
	[fec_reserva] [datetime] NULL,
	[id_cliente] [int] NULL,
 CONSTRAINT [pk_reserva] PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[salas]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salas](
	[id_sala] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](30) NULL,
 CONSTRAINT [pk_sala] PRIMARY KEY CLUSTERED 
(
	[id_sala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[butacas]  WITH CHECK ADD  CONSTRAINT [fk_butaca_sala] FOREIGN KEY([id_sala])
REFERENCES [dbo].[salas] ([id_sala])
GO
ALTER TABLE [dbo].[butacas] CHECK CONSTRAINT [fk_butaca_sala]
GO
ALTER TABLE [dbo].[detalle_factura]  WITH CHECK ADD  CONSTRAINT [fk_detFactura] FOREIGN KEY([id_factura])
REFERENCES [dbo].[facturas] ([id_factura])
GO
ALTER TABLE [dbo].[detalle_factura] CHECK CONSTRAINT [fk_detFactura]
GO
ALTER TABLE [dbo].[detalle_factura]  WITH CHECK ADD  CONSTRAINT [fk_detFactura_func] FOREIGN KEY([id_funcion])
REFERENCES [dbo].[funciones] ([id_funcion])
GO
ALTER TABLE [dbo].[detalle_factura] CHECK CONSTRAINT [fk_detFactura_func]
GO
ALTER TABLE [dbo].[detalle_reserva]  WITH CHECK ADD  CONSTRAINT [fk_detReserva_func] FOREIGN KEY([id_funcion])
REFERENCES [dbo].[funciones] ([id_funcion])
GO
ALTER TABLE [dbo].[detalle_reserva] CHECK CONSTRAINT [fk_detReserva_func]
GO
ALTER TABLE [dbo].[detalle_reserva]  WITH CHECK ADD  CONSTRAINT [fk_detReseva] FOREIGN KEY([id_reserva])
REFERENCES [dbo].[reservas] ([id_reserva])
GO
ALTER TABLE [dbo].[detalle_reserva] CHECK CONSTRAINT [fk_detReseva]
GO
ALTER TABLE [dbo].[facturas]  WITH CHECK ADD  CONSTRAINT [fk_fac_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[facturas] CHECK CONSTRAINT [fk_fac_cliente]
GO
ALTER TABLE [dbo].[facturas]  WITH CHECK ADD  CONSTRAINT [fk_fac_reserva] FOREIGN KEY([id_reserva])
REFERENCES [dbo].[reservas] ([id_reserva])
GO
ALTER TABLE [dbo].[facturas] CHECK CONSTRAINT [fk_fac_reserva]
GO
ALTER TABLE [dbo].[facturas]  WITH CHECK ADD  CONSTRAINT [fk_factu_FormPago] FOREIGN KEY([id_forma_pago])
REFERENCES [dbo].[formas_de_pago] ([id_forma_pago])
GO
ALTER TABLE [dbo].[facturas] CHECK CONSTRAINT [fk_factu_FormPago]
GO
ALTER TABLE [dbo].[facturas]  WITH CHECK ADD  CONSTRAINT [fk_factu_promo] FOREIGN KEY([id_promocion])
REFERENCES [dbo].[promociones] ([id_promocion])
GO
ALTER TABLE [dbo].[facturas] CHECK CONSTRAINT [fk_factu_promo]
GO
ALTER TABLE [dbo].[funciones]  WITH CHECK ADD  CONSTRAINT [fk_func_peli] FOREIGN KEY([id_pelicula])
REFERENCES [dbo].[Peliculas] ([id_pelicula])
GO
ALTER TABLE [dbo].[funciones] CHECK CONSTRAINT [fk_func_peli]
GO
ALTER TABLE [dbo].[funciones]  WITH CHECK ADD  CONSTRAINT [fk_func_sala] FOREIGN KEY([id_sala])
REFERENCES [dbo].[salas] ([id_sala])
GO
ALTER TABLE [dbo].[funciones] CHECK CONSTRAINT [fk_func_sala]
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [fk_peli_calif] FOREIGN KEY([id_calificacion])
REFERENCES [dbo].[calificaciones] ([id_calificacion])
GO
ALTER TABLE [dbo].[Peliculas] CHECK CONSTRAINT [fk_peli_calif]
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [fk_peli_genero] FOREIGN KEY([id_genero])
REFERENCES [dbo].[generos] ([id_genero])
GO
ALTER TABLE [dbo].[Peliculas] CHECK CONSTRAINT [fk_peli_genero]
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [fk_peli_origen] FOREIGN KEY([id_origen])
REFERENCES [dbo].[origen] ([id_origen])
GO
ALTER TABLE [dbo].[Peliculas] CHECK CONSTRAINT [fk_peli_origen]
GO
ALTER TABLE [dbo].[reservas]  WITH CHECK ADD  CONSTRAINT [fk_reserva_client] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[reservas] CHECK CONSTRAINT [fk_reserva_client]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CLIENTES]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[SP_GET_CLIENTES]
as
select id_cliente, nombre, apellido, fec_nac, calle, altura, telefono, mail
from clientes
where activo = 1

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_CALIFICACIONES]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_GET_CALIFICACIONES]
AS
select * from calificaciones
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_GENEROS]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_GET_GENEROS]	
AS
select * from generos
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_ORIGENES]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_GET_ORIGENES]	
AS
select * from origen
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_PELICULA]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_INSERT_PELICULA]
@titulo varchar(100), @sinopsis varchar(500), @fec_estreno datetime,
@elenco varchar(300), @duracion float, @calificacion int,  @apta_todo_publico bit, 
@idioma varchar(50), @subtitulo bit, @genero int, @origen int
as
begin
insert into Peliculas(titulo,sinopsis,fec_estreno,elenco,duracion,id_calificacion,apta_todo_publico,idioma,subtitulos,id_genero,id_origen, activa) 
			  values(@titulo,@sinopsis,@fec_estreno,@elenco,@duracion,@calificacion,@apta_todo_publico,@idioma,@subtitulo,@genero,@origen, 1)
end
GO
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

create proc SP_INSERT_FUNCION
@fecha datetime, @hora_inicio datetime,
@precio money, @id_peli int, @id_sala int
as
insert into funciones (fecha, hora_inicio,precio,id_pelicula,id_sala, agotado) 
				values (@fecha,@hora_inicio,@precio,@id_peli,@id_sala,0)

create proc SP_UPDATE_FUNCION
@id_funcion int, @fecha datetime, @hora_inicio datetime,
@precio money, @id_peli int, @id_sala int
as
update funciones set fecha=@fecha, hora_inicio=@hora_inicio,precio=@precio,id_pelicula=@id_peli,id_sala=@id_sala 
where id_funcion = @id_funcion	


GO
/****** Object:  StoredProcedure [dbo].[SP_NUEVA_RESERVA]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SP_INSERT_RESERVA]
@fec_reserva datetime,
@id_cliente int,
@idOut INT OUTPUT
AS
INSERT INTO reservas(fec_reserva,id_cliente)
VALUES (@fec_reserva , @id_cliente)
SET @idOut = @@Identity;
GO

create proc SP_INSERT_DET_RESERVA
@id_reserva int, @id_funcion int, @cantidad int
as
insert into detalle_reserva (id_reserva, id_funcion, cantidad)
values(@id_reserva,@id_funcion,@cantidad)

create proc SP_GET_RESERVAS
AS
select r.id_reserva, r.id_cliente, c.nombre, c.apellido, fec_reserva 
from reservas r join clientes c on r.id_cliente=c.id_cliente

CREATE PROC SP_GET_DETALLE_RESERVA
@id_reserva int
as
select p.titulo, f.fecha, f.hora_inicio, f.precio, s.id_sala, s.tipo
from detalle_reserva d join funciones f on d.id_funcion=f.id_funcion join Peliculas p on p.id_pelicula=f.id_pelicula join salas s on s.id_sala=f.id_sala
where d.id_reserva = @id_reserva

/****** Object:  StoredProcedure [dbo].[SP_NUEVO_CLIENTE]    Script Date: 18/01/2023 21:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO

alter proc SP_GET_FUNCIONES
as
select f.id_funcion,p.id_pelicula, s.id_sala, f.fecha, f.hora_inicio, f.precio, p.titulo, s.tipo, agotado 
from funciones f join Peliculas p on p.id_pelicula = f.id_pelicula join salas s on s.id_sala=f.id_sala

exec SP_GET_FUNCIONES

alter proc SP_GET_FUNCION_X_NOMBRE
@nombre varchar(50)
as
select f.id_funcion,p.id_pelicula, s.id_sala,f.fecha, f.hora_inicio, f.precio, p.titulo, s.tipo, agotado
from funciones f join Peliculas p on f.id_pelicula=p.id_pelicula join salas s on s.id_sala=f.id_sala
where titulo like '%'+@nombre+'%'

alter proc SP_GET_FUNCION_RESERVA
AS
select f.id_funcion,p.id_pelicula, s.id_sala,f.fecha, f.hora_inicio, f.precio, p.titulo, s.tipo, agotado
from funciones f join Peliculas p on f.id_pelicula=p.id_pelicula join salas s on s.id_sala=f.id_sala 

 
create Proc SP_GET_PELICULAS
AS
SELECT id_pelicula, titulo, sinopsis, fec_estreno, elenco, duracion, c.calificacion, apta_todo_publico, idioma, subtitulos, g.genero, o.origen 
from Peliculas p join calificaciones c on p.id_calificacion=c.id_calificacion join generos g on g.id_genero=p.id_genero join
origen o on o.id_origen=p.id_origen
where activa = 1

create proc SP_UPDATE_PELICULA
@id_pelicula int,@titulo varchar(100), @sinopsis varchar(500), @fec_estreno datetime,
@elenco varchar(300), @duracion float, @calificacion int,  @apta_todo_publico bit, 
@idioma varchar(50), @subtitulo bit, @genero int, @origen int
as
update Peliculas set titulo=@titulo, sinopsis=@sinopsis, fec_estreno=@fec_estreno, 
elenco=@elenco,duracion=@duracion, id_calificacion=@calificacion, apta_todo_publico=@apta_todo_publico,idioma=@idioma, subtitulos=@subtitulo,id_genero=@genero, id_origen=@origen
where id_pelicula = @id_pelicula

create proc SP_GET_SALAS
as
select * from salas

create Proc SP_DELETE_PELICULA
@id_pelicula int
as
update Peliculas set activa = 0
where id_pelicula = @id_pelicula
select * from Peliculas

Insert into generos values(1, 'Comedia')
Insert into generos values(2, 'Accion')
Insert into generos values(3, 'Romance')
Insert into generos values(4, 'Suspenso')
Insert into generos values(5, 'Terror')
Insert into generos values(6, 'Motivador')

Insert into origen values(1, 'Americana')
Insert into origen values(2, 'Ingles')
Insert into origen values(3, 'Latina')

select * from Peliculas
exec SP_UPDATE_PELICULA 2,'probandoo','adasdas','19/01/23','elenco',250,5,1,'idioma',0,2,2

Insert into calificaciones values(1, '1 Estrella')
Insert into calificaciones values(2, '2 Estrellas')
Insert into calificaciones values(3, '3 Estrellas')
Insert into calificaciones values(4, '4 Estrellas')
Insert into calificaciones values(5, '5 Estrellas')

exec SP_INSERT_PELICULA 'Rey Leon', 'Joven leon queda huerfano', '26/01/23', 'Los persos', 230.3, 4, 1,'Ingles',0,1,1

Insert into salas values('Sala 2D')
Insert into salas values('Sala 3D')
Insert into salas values('Sala VIP')
Insert into salas values('Sala 5.0')


