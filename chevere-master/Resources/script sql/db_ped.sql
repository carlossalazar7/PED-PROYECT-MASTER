
Create database  proyecto_ped_master;

use proyecto_ped_master;
go

create table roles(
	id int not null  primary key ,
	name varchar(100)
);
go

create table users(
	 id int not null primary key IDENTITY(1,1),
	 first_name varchar(100) not null,
	 last_name varchar(100),
	 password varchar(100),
	 email varchar(255) not null unique,
	 nit char(14),
	 dui char(9),
	 dirrection varchar(255),
	 age int,
	 nationality varchar(255),
	 birth_date date,
	 gender char(1) check(gender = 'F'or gender = 'M'),
	 id_role int not null,
	 FOREIGN KEY (id_role) REFERENCES roles(id)
);
go


create table climates(
	id int not null primary key,
	name varchar(255),
	description text
);
go

create table categories(
	id int not null  primary key,
	name varchar(255),
	description text
);
go

create table sites(
	id int not null IDENTITY(1,1) primary key,
	name varchar(255),
	description text,
	assessment int check (assessment<=5), --valoracion
	picture text,
	latitude int,
	longitude int,
	climate_id int,
	category_id int,
	visitado int,
	etiqueta int,
	tree_root int,
	routesID int,
	FOREIGN KEY (climate_id) REFERENCES climates(id),
	FOREIGN KEY (category_id) REFERENCES categories(id),
	FOREIGN KEY (routesID) REFERENCES routes (id)
);
go


create table routes(
	id int not null IDENTITY(1,1) primary key,
	name varchar(255),
	description text,
	picture text,
	assessment int check (assessment<=5), --valoracion
	attribute1 int,
	attribute2 int,	
	attribute3 int,
	attribute4 int,
	attribute5 int,
);
go


INSERT INTO [dbo].[roles] ([id], [name]) VALUES(1,'Administrador')
go

INSERT INTO [dbo].[roles]([id],[name]) VALUES ( 2,'Usuario')
go


INSERT INTO [dbo].[users] ([first_name], [last_name], [password], [email], [nit], [dui], [dirrection], [age], [nationality], [birth_date], [gender], [id_role])
     VALUES ( 'Carlos Eduardo', 'Peñate Salazar', '123456', 'carlossalazar22282@gmail.com', 12345678923456, 12345678, 'San Salvador', 21, 'Salvadoreño', SYSDATETIME(),'M', 1)
GO



---tablas de conexion de routes y sites con user,

CREATE TABLE user_routes
(
User_id int not null,
Routes_id int not null,
CONSTRAINT fk_UserR FOREIGN KEY(User_id)
REFERENCES users(id),
CONSTRAINT fk_Routes FOREIGN KEY(Routes_id)
REFERENCES routes(id),
Comment varchar(255),
assessment int check (assessment<=5)
)
GO

CREATE TABLE user_sites
(
User_id int not null,
Sites_id int not null,
CONSTRAINT fk_UserS FOREIGN KEY(User_id)
REFERENCES users(id),
CONSTRAINT fk_Sites FOREIGN KEY(Sites_id)
REFERENCES sites(id),
Comment varchar(255),
assessment int check (assessment<=5)
)
GO

select*from users

use proyecto_ped_master
go

-------------------------------

ALTER TABLE sites
ADD [latitude] decimal(18, 15);
go

ALTER TABLE sites
ADD longitude decimal(18, 15);
go



-------------------------------

USE [proyecto_ped_master]
GO

INSERT INTO [dbo].[sites]
           ([id]
           ,[name]
           ,[description]
           ,[assessment]
           ,[picture]
           ,[climate_id]
           ,[category_id]
           ,[visitado]
           ,[etiqueta]
           ,[tree_root]
           ,[routesID]
           ,[latitude]
           ,[longitude])
     VALUES
           (2,
            'Ahuachapan',
           'Ut eu esse dolor sit laboris adipisicing ullamco. Sint qui excepteur labore esse reprehenderit velit quis exercitation exercitation do cupidatat nulla. Est dolore nisi incididunt deserunt ullamco quis voluptate dolor. Est proident mollit ad ut in deserunt sit sint.',
           5,
           'C:/Users/carlos/OneDrive/Escritorio/Programación con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
           1,
           1,
           1,
           1,
           1,
           1,
           13.9259486,
          -89.8411382)
GO





