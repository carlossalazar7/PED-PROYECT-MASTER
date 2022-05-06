--Creando base de datos
Create database  proyecto_ped_master;

use proyecto_ped_master;
go

-------------------------------------------------------------------------------------------------------

--Creacion de tablas

-------------------------------------------------------------------------------------------------------

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
	 country_id int not null,
	 birth_date date,
	 gender char(1) check(gender = 'F'or gender = 'M'),
	 id_role int not null,
	 FOREIGN KEY (id_role) REFERENCES roles(id),
	 FOREIGN KEY (country_id) REFERENCES Country(id)
);
go

CREATE TABLE Country
(
id int NOT NULL primary key,
name varchar(255) not null,
)
GO

CREATE TABLE States
(
id int not null primary key,
name varchar(255) not null,
id_Country int not null,
FOREIGN KEY(id_Country) REFERENCES Country(id)

)
GO


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
	latitude decimal(18, 15),
	longitude decimal(18, 15),
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

-------------------------------------------------------------------------------------------------------

INSERT INTO [dbo].[roles] ([id], [name]) VALUES(1,'Administrador') --Inserción de rol administrador
go

INSERT INTO [dbo].[roles]([id],[name]) VALUES ( 2,'Usuario') --Inserción de rol usuario
go

-- Inserción de administrador en la tabla usuarios
INSERT INTO [dbo].[users] ([first_name], [last_name], [password], [email], [nit], [dui], [dirrection], [age], [country_id], [birth_date], [gender], [id_role])
     VALUES ( 'Carlos Eduardo', 'Peñate Salazar', '123456', 'carlossalazar22282@gmail.com', 12345678923456, 12345678, 'San Salvador', 21, 1, SYSDATETIME(),'M', 1)
GO

INSERT INTO [dbo].[users] ([first_name], [last_name], [password], [email], [nit], [dui], [dirrection], [age], [country_id], [birth_date], [gender], [id_role])
     VALUES ( 'Javier Ernesto ', 'Perez Joaquin', '123456', 'perezxavier918@gmail.com', 12345678923456, 12345678, 'San Salvador', 21, 1, SYSDATETIME(),'M', 2)
GO

--Select para verificar la correcta inserción
use proyecto_ped_master
go

select *
from users
GO

SELECT users.first_name, Country.name AS Pais
From users
INNER JOIN Country
ON users.country_id = Country.id
GO

DELETE 
FROM users
GO



-------------------------------------------------------------------------------------------------------

USE [proyecto_ped_master]
GO


-------------------------------

--Inserción de climas

-------------------------------

USE [proyecto_ped_master]
GO

INSERT INTO [dbo].[climates]
           (
		   id,
		   [name]
           ,[description])
     VALUES
           (1,

           'Nublado',
           'día nublado'),
		   (2,
           'Soliado',
           'día soliado')
GO

-------------------------------

--Query para insertar categoria

-------------------------------

USE [proyecto_ped_master]
GO

INSERT INTO [dbo].[categories]
           ([id]
           ,[name]
           ,[description])
     VALUES
           (
		   1,
           'Pueblo',
		   'rutas turisticas de pueblos'
           )
GO
-------------------------------

--querys para insertar rutas
-------------------------------
USE [proyecto_ped_master]
GO

INSERT INTO [dbo].[routes]
           ([id]
           ,[name]
           ,[description]
           ,[picture]
           ,[assessment]
           ,[attribute1]
           ,[attribute2]
           ,[attribute3]
           ,[attribute4]
           ,[attribute5])
     VALUES
           (1,	'Ruta las flores',
		   'Sint ex quis aute nisi id tempor ad do duis. Enim elit elit elit eiusmod ut ipsum aute in. Irure ea exercitation duis exercitation. Ipsum cillum est qui fugiat laborum dolor labore est eiusmod culpa pariatur ad aute reprehenderit. Mollit deserunt officia qui ut ullamco.',	
		   'C:/Users/carlos/OneDrive/Escritorio/Programación con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
		   1,
		   NULL,
		   NULL,
		   NULL,
		   NULL,
		   NULL),
		   (2,
		   'Ruta Monseñor Romero',
		   'Eu sunt mollit commodo exercitation excepteur. Duis magna pariatur sint labore deserunt. Aliquip elit fugiat enim incididunt ipsum cupidatat excepteur commodo labore ea incididunt esse adipisicing reprehenderit.',
		   'C:/Users/carlos/OneDrive/Escritorio/Programación con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
		   1,
		   NULL,
		   NULL,
		   NULL,
		   NULL,
		   NULL),
		    (3,	'Ruta Arqueológica',	
			'Nostrud dolore ex enim ex ullamco adipisicing ipsum eu pariatur commodo laborum. Excepteur eiusmod adipisicing commodo reprehenderit reprehenderit ut non sunt. ',
		   'C:/Users/carlos/OneDrive/Escritorio/Programación con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
		   1,
		   NULL,
		   NULL,
		   NULL,
		   NULL,
		   NULL)
GO

-------------------------------

--querys para insertar sitios

-------------------------------
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
	 (1,
		   'Ahuachapán',
           'Et esse ea anim est ut id id qui Lorem eiusmod laborum. Elit elit dolore adipisicing fugiat commodo ad. Duis non voluptate mollit magna sit nulla irure velit nostrud est minim exercitation eiusmod fugiat. Aliqua aute aute voluptate ex mollit laborum eiusmod reprehenderit sint laboris ex dolore adipisicing. Qui ipsum exercitation ex dolore consequat eiusmod amet minim Lorem laborum ullamco ea sint id. Proident nostrud ex incididunt ipsum reprehenderit cillum veniam ad occaecat proident minim. Occaecat proident eu excepteur est elit.',
           5,
           'C:/Users/carlos/OneDrive/Escritorio/Programación con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
           1,
           1,
           1,
           1,
           1,
           1,
          13.9259486,
		  -89.8411382),
         (2,
		   'Concepción de Ataco',
           'Enim occaecat veniam veniam voluptate sunt adipisicing dolore officia cupidatat anim aliqua occaecat ut. Cupidatat nulla in nulla et duis consectetur culpa voluptate officia ad consectetur aute. Cupidatat occaecat voluptate reprehenderit laboris nostrud dolor. Tempor mollit minim fugiat qui tempor proident nulla occaecat amet quis laboris velit qui occaecat. Magna ullamco tempor cupidatat laborum nostrud. Anim dolore minim ut voluptate nulla eiusmod eiusmod.',
           5,
           'C:/Users/carlos/OneDrive/Escritorio/Programación con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
           1,
           1,
           1,
           1,
           1,
           1,
           13.8683828,
		   -89.8584498),
		 (3,
		   'Apanhecat',
           'Ut est pariatur sunt consequat mollit nisi commodo. Aliquip labore aute culpa officia nulla do. Velit laboris voluptate exercitation officia cillum culpa. Fugiat id sunt ipsum labore irure sint occaecat minim aute cillum.',
           5,
           'C:/Users/carlos/OneDrive/Escritorio/Programación con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
           1,
           1,
           1,
           1,
           1,
           1,
          13.8626493, 
		  -89.8103242),
 (4,
		   'Juayúa',
           'Consequat ullamco do cillum voluptate mollit commodo magna pariatur eu deserunt. Excepteur aliqua esse occaecat anim eiusmod cupidatat sunt sunt elit ex sint ea ut duis. Magna nisi consequat non eiusmod. Cillum in fugiat est ullamco aliqua deserunt eu eu ipsum aliquip ullamco. Consequat amet cillum eiusmod commodo minim id officia culpa. Exercitation officia dolor aute commodo et amet magna aute.',
           5,
           'C:/Users/carlos/OneDrive/Escritorio/Programación con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
           1,
           1,
           1,
           1,
           1,
           1,
		 13.8431922,
		 -89.7535668),
		 (5,
		   'Salcoatitán',
           'Ipsum ex enim exercitation cupidatat minim ex tempor. Eu fugiat enim pariatur magna mollit. Nostrud aliquip mollit in cillum ullamco enim. Cillum Lorem voluptate adipisicing ipsum in deserunt irure amet labore.',
           4,
           'C:/Users/carlos/OneDrive/Escritorio/Programación con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
           1,
           1,
           1,
           1,
           1,
           1,
		 13.8302042,
		 -89.7591162),
		 (6,
		   'Santa Catarina Masahuat',
           'Ipsum ex enim exercitation cupidatat minim ex tempor. Eu fugiat enim pariatur magna mollit. Nostrud aliquip mollit in cillum ullamco enim. Cillum Lorem voluptate adipisicing ipsum in deserunt irure amet labore.',
           3,
           'C:/Users/carlos/OneDrive/Escritorio/Programación con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
           1,
           1,
           1,
           1,
           1,
           1,
		13.7896338, 
		-89.7638154),
		(7,
		   'Nahuizalco',
           'Exercitation laboris in consectetur culpa in. Sunt sunt adipisicing anim id amet veniam nulla dolore exercitation qui. Mollit occaecat duis exercitation irure esse veniam exercitation ipsum exercitation aliquip aute. Lorem nostrud consectetur qui eiusmod cillum velit nostrud. Cillum anim excepteur proident ut exercitation aliqua ut do consequat deserunt culpa anim nulla. Eu Lorem dolore ipsum anim nisi excepteur ad dolore minim elit aute ad. Et ipsum sunt nostrud quis voluptate magna reprehenderit ullamco magna ipsum commodo.',
           5,
           'C:/Users/carlos/OneDrive/Escritorio/Programación con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
           1,
           1,
           1,
           1,
           1,
           1,
		13.7804785,
		-89.7474662)

GO

-------------------------------

--Insercion de paises

-------------------------------

INSERT INTO Country([id],[name])
VALUES
(1, 'El Salvador')

INSERT INTO Country([id],[name])
VALUES
(2, 'España'),
(3, 'Costa Rica'),
(4, 'Panama'),
(5, 'Guatemala'),
(6, 'Honduras'),
(7, 'Puerto Rico'),
(8, 'Estados Unidos'),
(9, 'Nicaragua'),
(10, 'Colombia')

SELECT COUNT(*)
FROM Country
GO

SELECT *
FROM Country
GO

-------------------------------

--Insercion de departamentos/Estados/municipios

-------------------------------
INSERT INTO States([id],[id_Country],[name])
VALUES
(1, 1, 'Ahuachapán'),
(2, 1, 'Santa Ana'),
(3, 1, 'Sonsonate'),
(4, 1, 'La Libertad'),
(5, 1, 'Chalatenango'),
(6, 1, 'Cuscatlán'),
(7, 1, 'San Salvador'),
(8, 1, 'La Paz'),
(9, 1, 'Cabañas'),
(10, 1, 'San Vicente'),
(11, 1, 'Usulután'),
(12, 1, 'San Miguel'),
(13, 1, 'Morazán'),
(14, 1, 'La Unión'),
(15, 2, 'Madrid'),
(16, 2, 'Barcelona'),
(17, 2, 'Valencia'),
(18, 2, 'Sevilla'),
(19, 2, 'Zaragoza'),
(20, 2, 'Malaga'),
(21, 2, 'Murcia'),
(22, 2, 'Palma de Mallorca'),
(23, 2, 'Las palmas de G.C.'),
(24, 2, 'Bilbao'),
(25, 2, 'Alicante'),
(26, 2, 'Córdoba'),
(27, 2, 'Valladolid'),
(28, 2, 'Vigo'),
(29, 2, 'Gijón'),
(30, 2, 'Hospitalet de Llobregat'),
(31, 2, 'Victoria'),
(32, 2, 'La Coruña'),
(33, 2, 'Elche'),
(34, 2, 'Granada')
GO

DELETE FROM States






