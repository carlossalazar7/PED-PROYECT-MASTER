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

INSERT INTO [dbo].[roles] ([id], [name]) VALUES(1,'Administrador') --Inserci�n de rol administrador
go

INSERT INTO [dbo].[roles]([id],[name]) VALUES ( 2,'Usuario') --Inserci�n de rol usuario
go

-- Inserci�n de administrador en la tabla usuarios
INSERT INTO [dbo].[users] ([first_name], [last_name], [password], [email], [nit], [dui], [dirrection], [age], [nationality], [birth_date], [gender], [id_role])
     VALUES ( 'Carlos Eduardo', 'Pe�ate Salazar', '123456', 'carlossalazar22282@gmail.com', 12345678923456, 12345678, 'San Salvador', 21, 'Salvadore�o', SYSDATETIME(),'M', 1)
GO

--Select para verificar la correcta inserci�n
use proyecto_ped_master
go
select first_name, last_name, password, email
from users
where email = 'carlossalazar22282@gmail.com'



-------------------------------------------------------------------------------------------------------

USE [proyecto_ped_master]
GO


-------------------------------

--Inserci�n de climas

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
           'd�a nublado'),
		   (2,
           'Soliado',
           'd�a soliado')
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
		   'C:/Users/carlos/OneDrive/Escritorio/Programaci�n con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
		   1,
		   NULL,
		   NULL,
		   NULL,
		   NULL,
		   NULL),
		   (2,
		   'Ruta Monse�or Romero',
		   'Eu sunt mollit commodo exercitation excepteur. Duis magna pariatur sint labore deserunt. Aliquip elit fugiat enim incididunt ipsum cupidatat excepteur commodo labore ea incididunt esse adipisicing reprehenderit.',
		   'C:/Users/carlos/OneDrive/Escritorio/Programaci�n con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
		   1,
		   NULL,
		   NULL,
		   NULL,
		   NULL,
		   NULL),
		    (3,	'Ruta Arqueol�gica',	
			'Nostrud dolore ex enim ex ullamco adipisicing ipsum eu pariatur commodo laborum. Excepteur eiusmod adipisicing commodo reprehenderit reprehenderit ut non sunt. ',
		   'C:/Users/carlos/OneDrive/Escritorio/Programaci�n con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
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
		   'Ahuachap�n',
           'Et esse ea anim est ut id id qui Lorem eiusmod laborum. Elit elit dolore adipisicing fugiat commodo ad. Duis non voluptate mollit magna sit nulla irure velit nostrud est minim exercitation eiusmod fugiat. Aliqua aute aute voluptate ex mollit laborum eiusmod reprehenderit sint laboris ex dolore adipisicing. Qui ipsum exercitation ex dolore consequat eiusmod amet minim Lorem laborum ullamco ea sint id. Proident nostrud ex incididunt ipsum reprehenderit cillum veniam ad occaecat proident minim. Occaecat proident eu excepteur est elit.',
           5,
           'C:/Users/carlos/OneDrive/Escritorio/Programaci�n con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
           1,
           1,
           1,
           1,
           1,
           1,
          13.9259486,
		  -89.8411382),
         (2,
		   'Concepci�n de Ataco',
           'Enim occaecat veniam veniam voluptate sunt adipisicing dolore officia cupidatat anim aliqua occaecat ut. Cupidatat nulla in nulla et duis consectetur culpa voluptate officia ad consectetur aute. Cupidatat occaecat voluptate reprehenderit laboris nostrud dolor. Tempor mollit minim fugiat qui tempor proident nulla occaecat amet quis laboris velit qui occaecat. Magna ullamco tempor cupidatat laborum nostrud. Anim dolore minim ut voluptate nulla eiusmod eiusmod.',
           5,
           'C:/Users/carlos/OneDrive/Escritorio/Programaci�n con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
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
           'C:/Users/carlos/OneDrive/Escritorio/Programaci�n con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
           1,
           1,
           1,
           1,
           1,
           1,
          13.8626493, 
		  -89.8103242),
 (4,
		   'Juay�a',
           'Consequat ullamco do cillum voluptate mollit commodo magna pariatur eu deserunt. Excepteur aliqua esse occaecat anim eiusmod cupidatat sunt sunt elit ex sint ea ut duis. Magna nisi consequat non eiusmod. Cillum in fugiat est ullamco aliqua deserunt eu eu ipsum aliquip ullamco. Consequat amet cillum eiusmod commodo minim id officia culpa. Exercitation officia dolor aute commodo et amet magna aute.',
           5,
           'C:/Users/carlos/OneDrive/Escritorio/Programaci�n con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
           1,
           1,
           1,
           1,
           1,
           1,
		 13.8431922,
		 -89.7535668),
		 (5,
		   'Salcoatit�n',
           'Ipsum ex enim exercitation cupidatat minim ex tempor. Eu fugiat enim pariatur magna mollit. Nostrud aliquip mollit in cillum ullamco enim. Cillum Lorem voluptate adipisicing ipsum in deserunt irure amet labore.',
           4,
           'C:/Users/carlos/OneDrive/Escritorio/Programaci�n con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
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
           'C:/Users/carlos/OneDrive/Escritorio/Programaci�n con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
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
           'C:/Users/carlos/OneDrive/Escritorio/Programaci�n con Estructura de Datos/proyecto/prototipo/descarga.jpeg',
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








