CREATE DATABASE MENAIER_DB
GO
USE MENAIER_DB
GO

-- AGREGAR FECHACREACION, IDUSUARIOCREACION, FECHAMODIFICACION, IDUSUARIOMODIFICACION. FECHACREACION PUEDE SER AUTOMATICA, GOOGLEAR.
-- EN LAS ENTIDADES PRINCIPALES (COMPRAS Y VENTAS)

CREATE TABLE MARCAS
(
	IDMARCA INT NOT NULL IDENTITY(40000000,1) PRIMARY KEY,
	DESCRIPCION VARCHAR(60) NOT NULL,
	ACTIVO BIT NOT NULL
)
GO
CREATE TABLE TIPOSPRODUCTO
(
	IDTIPOPRODUCTO INT NOT NULL IDENTITY(50000000,1) PRIMARY KEY,
	DESCRIPCION VARCHAR(60) NOT NULL,
	ACTIVO BIT NOT NULL
)
GO
CREATE TABLE CLIENTES
(
	IDCLIENTE INT NOT NULL IDENTITY(30000000,1) PRIMARY KEY,
	DNICUIT BIGINT NOT NULL,
	NOMBRE VARCHAR(60),
	APELLIDO VARCHAR(60),
	TIPOCLIENTE VARCHAR(2) NOT NULL,
	EMAIL VARCHAR(60),
	ACTIVO BIT NOT NULL
)
GO
CREATE TABLE CONTACTOS
(
	IDCONTACTO INT NOT NULL IDENTITY(60000000,1) PRIMARY KEY,
	NOMBRE VARCHAR(60) NOT NULL,
	APELLIDO VARCHAR(60) NOT NULL,
	DNI INT NOT NULL,
	EMAIL VARCHAR(60) NOT NULL,
	ACTIVO BIT NOT NULL
)
GO
CREATE TABLE PROVEEDORES
(
	IDPROVEEDOR INT NOT NULL IDENTITY(20000000,1) PRIMARY KEY,
	EMPRESA VARCHAR(60) NOT NULL,
	CUIT BIGINT NOT NULL,
	ACTIVO BIT NOT NULL
)
GO
CREATE TABLE EMPLEADOS
(
 	IDEMPLEADO INT NOT NULL IDENTITY(10000000,1) PRIMARY KEY,
	NOMBRE VARCHAR(60) NOT NULL,
	APELLIDO VARCHAR(60) NOT NULL,
	DNI INT NOT NULL,
	FECHANAC DATE,
	USUARIO VARCHAR(60),
	PASS VARCHAR(60),
	TIPOPERFIL INT NOT NULL,
	EMAIL VARCHAR(60) NOT NULL,
	ACTIVO BIT NOT NULL
)
GO
CREATE TABLE PRODUCTOS
(
	IDPRODUCTO INT NOT NULL IDENTITY(70000000,1) PRIMARY KEY,
	IDMARCA INT NOT NULL FOREIGN KEY REFERENCES MARCAS(IDMARCA),
	IDTIPOPRODUCTO INT NOT NULL FOREIGN KEY REFERENCES TIPOSPRODUCTO(IDTIPOPRODUCTO),
	DESCRIPCION VARCHAR(60) NOT NULL,
	STOCKMIN INT NOT NULL,
	STOCK INT NOT NULL,
	GANANCIA FLOAT NOT NULL,
	ACTIVO BIT NOT NULL
)
GO
CREATE TABLE VENTAS
(
	IDVENTA INT NOT NULL IDENTITY(80000000,1) PRIMARY KEY,
	FECHAVENTA DATE NOT NULL,
	IDEMPLEADO INT NOT NULL FOREIGN KEY REFERENCES EMPLEADOS(IDEMPLEADO),
	IDCLIENTE INT NOT NULL FOREIGN KEY REFERENCES CLIENTES(IDCLIENTE),
	ACTIVO BIT NOT NULL,
	FECHAREGISTRO DATE NOT NULL DEFAULT GETDATE()
)
GO
CREATE TABLE COMPRAS
(
	IDCOMPRA INT NOT NULL IDENTITY(90000000,1) PRIMARY KEY,
	FECHACOMPRA DATE NOT NULL,
	IDPROVEEDOR INT NOT NULL FOREIGN KEY REFERENCES PROVEEDORES(IDPROVEEDOR),
	ACTIVO BIT NOT NULL,
	FECHAREGISTRO DATE NOT NULL DEFAULT GETDATE()
)
GO
CREATE TABLE LOTES
(
	IDLOTE BIGINT IDENTITY(140000000,1) NOT NULL PRIMARY KEY,
	IDCOMPRA INT NOT NULL FOREIGN KEY REFERENCES COMPRAS(IDCOMPRA),
	IDPRODUCTO INT NOT NULL FOREIGN KEY REFERENCES PRODUCTOS(IDPRODUCTO),
	UNIDADESP INT NOT NULL,
	UNIDADESE INT NOT NULL,
	COSTOPU MONEY NOT NULL,
	ACTIVO BIT NOT NULL
)
GO
CREATE TABLE TELEFONOS
(
	IDTELEFONO INT NOT NULL IDENTITY(100000000,1) PRIMARY KEY,
	IDRELACION INT NOT NULL,
	NUMERO INT NOT NULL,
	DESCRIPCION VARCHAR(60) NOT NULL,
	ACTIVO BIT NOT NULL
)
GO
CREATE TABLE DOMICILIOS
(
	IDDOMICILIO INT NOT NULL IDENTITY(110000000,1) PRIMARY KEY,
	IDRELACION INT NOT NULL,
	CALLE VARCHAR(60) NOT NULL,
	ALTURA INT NOT NULL,
	DEPARTAMENTO VARCHAR(10),
	BARRIO VARCHAR(60) NOT NULL,
	CIUDAD VARCHAR(60) NOT NULL DEFAULT 'Buenos Aires',
	PAIS VARCHAR(60) NOT NULL DEFAULT 'Argentina',
	CP INT NOT NULL,
	ACTIVO BIT NOT NULL
)
GO
CREATE TABLE CONTACTOS_X_RELACION
(
	IDCONTACTO INT NOT NULL FOREIGN KEY REFERENCES CONTACTOS(IDCONTACTO),
	IDRELACION INT NOT NULL,
	PRIMARY KEY (IDCONTACTO,IDRELACION)
)
GO
CREATE TABLE PRODUCTOS_X_PROVEEDOR
(
	IDPROVEEDOR INT NOT NULL FOREIGN KEY REFERENCES PROVEEDORES(IDPROVEEDOR),
	IDPRODUCTO INT NOT NULL FOREIGN KEY REFERENCES PRODUCTOS(IDPRODUCTO),
	PRIMARY KEY (IDPROVEEDOR, IDPRODUCTO)
)
GO
CREATE TABLE PRODUCTOS_X_VENTA
(
	IDPXV BIGINT NOT NULL IDENTITY(140000000,1) PRIMARY KEY,
	IDVENTA INT NOT NULL FOREIGN KEY REFERENCES VENTAS(IDVENTA),
	IDPRODUCTO INT NOT NULL FOREIGN KEY REFERENCES PRODUCTOS(IDPRODUCTO),
	PRECIOPU MONEY NOT NULL,
	CANTIDAD INT NOT NULL
) 
GO

SET DATEFORMAT dmy;

INSERT INTO EMPLEADOS(NOMBRE,APELLIDO,DNI,FECHANAC,USUARIO,PASS,TIPOPERFIL,EMAIL,ACTIVO) VALUES ('Maximiliano','Sar Fernandez',28865175,'09/11/1978','msar','BD685E8384AB67EB8A74A5DC4A80EDDB',1,'msarfernandez@gmail.com',1),('Carlos','Menaier',15631367,'11/03/1995','cmenaier','BD685E8384AB67EB8A74A5DC4A80EDDB',1,'cmenaier@gmail.com',1);
INSERT INTO EMPLEADOS(NOMBRE,APELLIDO,DNI,FECHANAC,USUARIO,PASS,TIPOPERFIL,EMAIL,ACTIVO) VALUES ('Maggie','Pacheco',18975273,'10/01/1980','mpachecho','BD685E8384AB67EB8A74A5DC4A80EDDB',2,'mpacheco@gmail.com',1),('Ray','Humphrey',15473566,'07/06/1981','rhumphrey','BD685E8384AB67EB8A74A5DC4A80EDDB',3,'rhumphrey@gmail.com',1);
INSERT INTO EMPLEADOS(NOMBRE,APELLIDO,DNI,FECHANAC,USUARIO,PASS,TIPOPERFIL,EMAIL,ACTIVO) VALUES ('Hiram','Brown',33547894,'02/08/1996','hbrown','BD685E8384AB67EB8A74A5DC4A80EDDB',2,'hbrown@gmail.com',1),('Jaime','Keller',29945252,'26/03/1995','jkeller','BD685E8384AB67EB8A74A5DC4A80EDDB',3,'jkeller@gmail.com',1);
INSERT INTO EMPLEADOS(NOMBRE,APELLIDO,DNI,FECHANAC,USUARIO,PASS,TIPOPERFIL,EMAIL,ACTIVO) VALUES ('Raymond','Lindsey',15167996,'17/09/1988','rlindsey','BD685E8384AB67EB8A74A5DC4A80EDDB',3,'rlindsey@gmail.com',1),('Maryam','Watson',25354035,'11/11/1989','mwatson','BD685E8384AB67EB8A74A5DC4A80EDDB',3,'mwatson@gmail.com',1);

INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Las Vacas Felices',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Vegetalex',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Lucchetti',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Delicias Doradas',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Doritos',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Lays',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Arrocitas',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Mister Veggie',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Matarazzo',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Coca Cola Company',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Pepsi Inc',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('McCain',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Mi Soja',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Pureza',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Chango',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Natura',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Dánica',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Dame Mani',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Águila',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Soyana',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Virgen',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Titan',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Cachafaz',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Granix',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Oreo',1);
INSERT INTO MARCAS(DESCRIPCION,ACTIVO) VALUES ('Successo',1);

INSERT INTO TIPOSPRODUCTO(DESCRIPCION,ACTIVO) VALUES ('Golosinas',1);
INSERT INTO TIPOSPRODUCTO(DESCRIPCION,ACTIVO) VALUES ('Congelados',1);
INSERT INTO TIPOSPRODUCTO(DESCRIPCION,ACTIVO) VALUES ('Refrigerados',1);
INSERT INTO TIPOSPRODUCTO(DESCRIPCION,ACTIVO) VALUES ('Snacks',1);
INSERT INTO TIPOSPRODUCTO(DESCRIPCION,ACTIVO) VALUES ('Bebidas',1);
INSERT INTO TIPOSPRODUCTO(DESCRIPCION,ACTIVO) VALUES ('Galletitas',1);
INSERT INTO TIPOSPRODUCTO(DESCRIPCION,ACTIVO) VALUES ('Enlatados',1);
INSERT INTO TIPOSPRODUCTO(DESCRIPCION,ACTIVO) VALUES ('No perecederos',1);
INSERT INTO TIPOSPRODUCTO(DESCRIPCION,ACTIVO) VALUES ('Frutas',1);
INSERT INTO TIPOSPRODUCTO(DESCRIPCION,ACTIVO) VALUES ('Verduras',1);
INSERT INTO TIPOSPRODUCTO(DESCRIPCION,ACTIVO) VALUES ('Hongos',1);

INSERT INTO PROVEEDORES(EMPRESA,CUIT,ACTIVO) VALUES ('El Hermano',30215281223,1),('Dos Hermanos',34761241223,1),('Tres Hermanos',32465491217,1),('Cuatro Hermanos',307128535237,1)
INSERT INTO PROVEEDORES(EMPRESA,CUIT,ACTIVO) VALUES ('Cinco Hermanos',32765441223,1),('Seis Hermanos',31767454231,1),('Siete Hermanos',30145421258,1),('Los Hermanos',35765443821,1)

INSERT INTO PRODUCTOS(IDMARCA,IDTIPOPRODUCTO,DESCRIPCION,STOCK,STOCKMIN,GANANCIA,ACTIVO) VALUES (40000000,50000000,'Alfajor Sabor Mani',5,24,25,1),(40000002,50000001,'Milanesas de soja',7,25,20,1)           
INSERT INTO PRODUCTOS(IDMARCA,IDTIPOPRODUCTO,DESCRIPCION,STOCK,STOCKMIN,GANANCIA,ACTIVO) VALUES (40000003,50000007,'Fideos TriColor',10,30,18,1),(40000004,50000002,'Tapas de empanada',1,20,22,1)           
INSERT INTO PRODUCTOS(IDMARCA,IDTIPOPRODUCTO,DESCRIPCION,STOCK,STOCKMIN,GANANCIA,ACTIVO) VALUES (40000006,50000003,'Papas Fritas 180gr',0,32,30,1),(40000010,50000004,'Coca Cola 2,5L',15,24,26,1)     
INSERT INTO PRODUCTOS(IDMARCA,IDTIPOPRODUCTO,DESCRIPCION,STOCK,STOCKMIN,GANANCIA,ACTIVO) VALUES (40000019,50000000,'Barra Chocolate 200gr',20,24,25,1),(40000001,50000002,'Yoghurt Almendras',0,12,36,1)     

INSERT INTO CONTACTOS(NOMBRE,APELLIDO,DNI,EMAIL,ACTIVO) VALUES ('Diego','De Luca',15212524,'ddluca@gmail.com',1)

INSERT INTO PRODUCTOS_X_PROVEEDOR(IDPRODUCTO,IDPROVEEDOR) VALUES (70000000,20000000)

INSERT INTO CONTACTOS_X_RELACION(IDCONTACTO,IDRELACION) VALUES (60000000,20000000)

INSERT INTO TELEFONOS(IDRELACION,NUMERO,DESCRIPCION,ACTIVO) VALUES (10000001,1133375359,'Celular',1)

INSERT INTO DOMICILIOS(IDRELACION,CALLE,ALTURA,DEPARTAMENTO,BARRIO,CIUDAD,PAIS,CP,ACTIVO) VALUES (10000001,'Pres. Hipolito Yrigoyen',3248,'Casa','Florida Oeste','Buenos Aires','Argentina',1602,1)

INSERT INTO CLIENTES(DNICUIT,NOMBRE,TIPOCLIENTE,ACTIVO) VALUES (20145219562,'Las Hermanas','E',1)
INSERT INTO CLIENTES(DNICUIT,NOMBRE,APELLIDO,TIPOCLIENTE,EMAIL,ACTIVO) VALUES (28541236,'Mauricio','Macri','P','mmacri@gmail.com',1)

INSERT INTO COMPRAS(FECHACOMPRA,IDPROVEEDOR,ACTIVO) VALUES ('26/10/2018',20000000,1)

INSERT INTO LOTES(IDCOMPRA,IDPRODUCTO,UNIDADESP,UNIDADESE,COSTOPU,ACTIVO) VALUES (90000000,70000000,24,24,25.99,1)

INSERT INTO VENTAS(IDCLIENTE,IDEMPLEADO,FECHAVENTA,ACTIVO) VALUES (30000000,10000000,'05/06/2018',1)
INSERT INTO VENTAS(IDCLIENTE,IDEMPLEADO,FECHAVENTA,ACTIVO) VALUES (30000001,10000002,'21/10/2018',1)

