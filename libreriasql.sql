CREATE DATABASE libreria
GO

CREATE TABLE libros 
(id int identity(1,1),
titulo varchar(100),
categoria varchar(50),
descripcion text,
img image,
ruta varchar(100))
