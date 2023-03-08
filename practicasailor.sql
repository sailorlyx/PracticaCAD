create database PracticaSailor
go

create table Sailor
(
id int identity (1,1) PRIMARY KEY,
nombre nvarchar (50),
planeta nvarchar (20)
)

insert into Sailor
values
('Usagi','Moon'),
('Hotaru','Saturno')

create proc Mostrar_Sailor
as
select * from Sailor
GO

create proc InsertarSailor
@nombre nvarchar (50),
@planeta nvarchar (20)
as
insert into Sailor values (@nombre, @planeta)
go

create proc EliminarSailor
@idpro int
as
delete from Sailor WHERE id = @idpro
go

create proc EditarSailor
@id int,
@nombre nvarchar (50),
@planeta nvarchar(20)
as
update Sailor set nombre = @nombre, planeta = @planeta where id = @id
go