CREATE DATABASE Restaurante;
USE Restaurante;

#//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#////////////////////////////////////////////////////////////////GERENTE

CREATE TABLE Gerente(
ID INT AUTO_INCREMENT PRIMARY KEY,
Nombre VARCHAR(100),
Apellido VARCHAR(100),
Domicilio VARCHAR(100),
Telefono BIGINT,
Contraseña VARCHAR(100));

DELIMITER $$
DROP PROCEDURE if EXISTS p_insertargerente;
CREATE PROCEDURE p_insertargerente(
IN p_ID INT,
IN p_Nombre VARCHAR(100),
IN p_Apellido VARCHAR(100),
IN p_Domicilio VARCHAR(100),
IN p_Telefono BIGINT,
IN p_Contraseña VARCHAR(100)
)
BEGIN
	
   if p_ID<0 then
	INSERT INTO Gerente VALUES (NULL,p_Nombre,p_Apellido,p_Domicilio,p_Telefono,p_Contraseña); 
	ELSE if p_ID>0 then
	UPDATE gerente SET Nombre = p_Nombre, Apellido = p_Apellido, Domicilio = p_Domicilio,
	Telefono = p_Telefono, Contraseña = p_Contraseña
	WHERE ID = p_ID;
	ELSE 
	UPDATE gerente SET  Apellido = p_Apellido, Domicilio = p_Domicilio,
	Telefono = p_Telefono, Contraseña = p_Contraseña
	WHERE ID = p_ID;
	END if;
	END if;
END;

DELIMITER $$
DROP PROCEDURE if EXISTS showgerente;
CREATE PROCEDURE showgerente(
IN _Nombre VARCHAR(100)
)
BEGIN
SELECT GE.ID, GE.Nombre AS Nombre,GE.Apellido AS Apellido, GE.Domicilio AS Domicilio, GE.Telefono
AS telefono FROM mesero AS GE 
WHERE Nombre LIKE _Nombre ORDER BY Nombre;
END ;;

DELIMITER $$
DROP PROCEDURE if EXISTS deletegerente;
CREATE PROCEDURE deletegerente(
IN _ID INT
)
BEGIN
DELETE FROM gerente WHERE ID = _ID;
END;;

INSERT INTO gerente VALUES(NULL,'Marina Fernanda','Duran Ibarra','Atalo Montoya #79',4741423009,'TEAMO');

#////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#/////////////////////////////////////////////////////////////////FIN GERENTE


#//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#////////////////////////////////////////////////////////////////MESERO

CREATE TABLE Mesero(
ID INT AUTO_INCREMENT PRIMARY KEY,
Nombre VARCHAR(100),
Apellido VARCHAR(100),
Domicilio VARCHAR(100),
Telefono BIGINT,
Contraseña VARCHAR(100));

DELIMITER $$
DROP PROCEDURE if EXISTS p_insertarmesero;
CREATE PROCEDURE p_insertarmesero(
IN p_ID INT,
IN p_Nombre VARCHAR(100),
IN p_Apellido VARCHAR(100),
IN p_Domicilio VARCHAR(100),
IN p_Telefono BIGINT,
IN p_Contraseña VARCHAR(100)
)
BEGIN
	
   if p_ID<0 then
	INSERT INTO mesero VALUES (NULL,p_Nombre,p_Apellido,p_Domicilio,p_Telefono,p_Contraseña); 
	ELSE if p_ID>0 then
	UPDATE mesero SET Nombre = p_Nombre, Apellido = p_Apellido, Domicilio = p_Domicilio,
	Telefono = p_Telefono, Contraseña = p_Contraseña
	WHERE ID = p_ID;
	ELSE 
	UPDATE mesero SET  Apellido = p_Apellido, Domicilio = p_Domicilio,
	Telefono = p_Telefono, Contraseña = p_Contraseña
	WHERE ID = p_ID;
	END if;
	END if;
END;

DROP PROCEDURE  showPedidos;

DELIMITER $$
DROP PROCEDURE if EXISTS showmesero;
CREATE PROCEDURE showmesero(
IN _Nombre VARCHAR(100)
)
BEGIN
SELECT GE.ID, GE.Nombre AS Nombre,GE.Apellido AS Apellido, GE.Domicilio AS Domicilio, GE.Telefono
AS telefono FROM mesero AS GE 
WHERE Nombre LIKE _Nombre ORDER BY Nombre;
END ;;

DELIMITER $$
DROP PROCEDURE if EXISTS deletemesero;
CREATE PROCEDURE deletemesero(
IN _ID INT
)
BEGIN
DELETE FROM mesero WHERE ID = _ID;
END;;


INSERT INTO MESERO VALUES(NULL,'Giovanni Ricardo','Rojas Garcia','Av.Martin Diaz',4741084636,'HOLA');
SELECT * FROM mesero;

#////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#/////////////////////////////////////////////////////////////////FIN MESERO

#//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#////////////////////////////////////////////////////////////////ALMACEN

CREATE TABLE Almacen(
ID_Insumo INT AUTO_INCREMENT PRIMARY KEY,
Nombre VARCHAR(100),
Tipo VARCHAR(100),
Proveedor VARCHAR(100),
Cantidad INT,
Fecha_Caducidad DATE);

DELIMITER $$
DROP PROCEDURE if EXISTS p_insertaralmacen;
CREATE PROCEDURE p_insertaralmacen(
IN p_Nombre VARCHAR(100),
IN p_Tipo VARCHAR(100),
IN p_Proveedor VARCHAR(100),
IN p_Cantidad INT,
IN p_Fecha_Caducidad DATE,
IN p_ID_Insumo INT
)
BEGIN
	
   if p_ID_Insumo<0 then
	INSERT INTO almacen VALUES (NULL,p_Nombre,p_Tipo,p_Proveedor,p_Cantidad,p_Fecha_Caducidad); 
	ELSE if p_ID_Insumo>0 then
	UPDATE almacen SET Nombre = p_Nombre, Tipo = p_Tipo, Proveedor = p_Proveedor, Cantidad = p_Cantidad,
	Fecha_Caducidad  = p_Fecha_Caducidad 
	WHERE ID_Insumo = p_ID_Insumo;
	ELSE 
	UPDATE almacen SET  Tipo = p_Tipo, Proveedor = p_Proveedor, Cantidad = p_Cantidad,
	Fecha_Caducidad  = p_Fecha_Caducidad 
	WHERE ID_Insumo = p_ID_Insumo;
	END if;
	END if;
END;

DELIMITER $$
DROP PROCEDURE if EXISTS showalmacen;
CREATE PROCEDURE showalmacen(
IN _Nombre VARCHAR(100)
)
BEGIN
SELECT AL.ID_Insumo, AL.Nombre AS Nombre,AL.Tipo AS Tipo, AL.Proveedor AS Proveedor, AL.Cantidad AS Cantidad,
AL.Fecha_Caducidad AS Fecha_Caducidad FROM almacen AS AL 
WHERE Nombre LIKE _Nombre ORDER BY Nombre;
END ;;

DELIMITER $$
DROP PROCEDURE if EXISTS deletealmacen;
CREATE PROCEDURE deletealmacen(
IN _ID_Insumo INT
)
BEGIN
DELETE FROM almacen WHERE ID_Insumo = _ID_Insumo;
END;;

#////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#/////////////////////////////////////////////////////////////////FIN ALMACEN

#//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#////////////////////////////////////////////////////////////////PLATILLO


CREATE TABLE Platillo(
ID INT AUTO_INCREMENT PRIMARY KEY,
Nombre VARCHAR(100),
Precio DOUBLE,
Descripcion VARCHAR(200));

DELIMITER $$
DROP PROCEDURE if EXISTS p_insertarplatillo;
CREATE PROCEDURE p_insertarplatillo(
IN p_ID INT,
IN p_Nombre VARCHAR(100),
IN p_Precio DOUBLE,
IN p_Descripcion VARCHAR(200)
)
BEGIN
	
   if p_ID<0 then
	INSERT INTO platillo VALUES (NULL,p_Nombre,p_Precio,p_Descripcion); 
	ELSE if p_ID>0 then
	UPDATE almacen SET Nombre = p_Nombre, Precio = p_Precio, Descripcion = p_Descripcion
	WHERE ID = p_ID;
	ELSE 
	UPDATE almacen SET  Precio = p_Precio, Descripcion = p_Descripcion
	WHERE ID = p_ID;
	END if;
	END if;
END;

DELIMITER $$
DROP PROCEDURE if EXISTS showplatillo;
CREATE PROCEDURE showplatillo(
IN _Nombre VARCHAR(100)
)
BEGIN
SELECT PL.ID, AL.Nombre AS Nombre,PL.Precio AS Precio, PL.Descripcion AS Descripcion
FROM platillo AS PL 
WHERE Nombre LIKE _Nombre ORDER BY Nombre;
END ;;

DELIMITER $$
DROP PROCEDURE if EXISTS deleteplatillo;
CREATE PROCEDURE deleteplatillo(
IN _ID INT
)
BEGIN
DELETE FROM platillo WHERE ID = _ID;
END;;

INSERT INTO platillo VALUES (NULL,'Hamburguesa',20.50,'Hamburguesa de Carne');

SELECT * FROM platillo;

#////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#/////////////////////////////////////////////////////////////////FIN PLATILLO


#//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#////////////////////////////////////////////////////////////////RECETA

CREATE TABLE Receta(
ID INT AUTO_INCREMENT PRIMARY KEY,
FK_ID_Platillo INT,
FK_ID_Insumo INT,
Cantidad INT,
Tipo VARCHAR(100),
FOREIGN KEY(FK_ID_Platillo) REFERENCES Platillo(ID),
FOREIGN KEY(FK_ID_Insumo) REFERENCES Almacen(ID_Insumo));

DELIMITER $$
DROP PROCEDURE if EXISTS p_insertarreceta;
CREATE PROCEDURE p_insertarreceta(
IN p_ID INT,
IN p_FK_ID_Platillo INT,
IN p_FK_ID_Insumo INT,
IN p_Cantidad INT,
IN p_Tipo VARCHAR(100)
)
BEGIN
	
   if p_ID<0 then
	INSERT INTO receta VALUES (NULL,p_FK_ID_Platillo,p_FK_ID_Insumo,p_Cantidad,p_Tipo); 
	ELSE if p_ID>0 then
	UPDATE receta SET FK_ID_Platillo = p_FK_ID_Platillo, FK_ID_Insumo = p_FK_ID_Insumo,
	Cantidad = p_Cantidad, Tipo = p_Tipo
	WHERE ID = p_ID;
	ELSE 
	UPDATE receta SET  FK_ID_Insumo = p_FK_ID_Insumo,
	Cantidad = p_Cantidad, Tipo = p_Tipo
	WHERE ID = p_ID;
	END if;
	END if;
END;

DELIMITER $$
DROP PROCEDURE if EXISTS showreceta;
CREATE PROCEDURE showreceta(
IN _FK_ID_Platillo INT
)
BEGIN
SELECT RE.ID, AL.FK_ID_Platillo AS FK_ID_Platillo,RE.FK_ID_Insumo AS FK_ID_Insumo, 
RE.Cantidad AS Cantidad, RE.Tipo AS Tipo
FROM receta AS RE 
WHERE FK_ID_Platillo LIKE _FK_ID_Platillo ORDER BY FK_ID_Platillo;
END ;;

DELIMITER $$
DROP PROCEDURE if EXISTS deletereceta;
CREATE PROCEDURE deletereceta(
IN _ID INT
)
BEGIN
DELETE FROM receta WHERE ID = _ID;
END;;


#////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#/////////////////////////////////////////////////////////////////FIN RESETA


#/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#///////////////////////////////////////////////////////////lISTO


#/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#///////////////////////////////////////////////////////////PEDIDOS

CREATE TABLE pedidos(													#Para registrar los pedidos despues de la orden
ID INT AUTO_INCREMENT PRIMARY KEY,
FK_ID_Orden INT,
Precio DOUBLE,
Cantidad INT,
FK_ID_Platillo INT,
Estado VARCHAR(100),
FOREIGN KEY(FK_ID_Orden) REFERENCES Orden(Folio),
FOREIGN KEY(FK_ID_Platillo) REFERENCES Platillo(ID));

DELIMITER $$
DROP PROCEDURE if EXISTS p_insertarPedidos;
CREATE PROCEDURE p_insertarPedidos(
IN p_ID INT,
IN p_FK_ID_Orden INT,
IN p_Precio DOUBLE,
IN p_Cantidad INT,
IN p_FK_ID_Platillo INT,
IN p_Estado VARCHAR(100)
)
BEGIN
	
   if p_ID<0 then
	INSERT INTO pedidos VALUES (NULL,p_FK_ID_Orden,P_Precio,P_Cantidad,P_FK_ID_Platillo,P_Estado); 
	ELSE if p_ID>0 then
	UPDATE pedidos SET Precio = P_Precio, Cantidad = p_Cantidad, FK_ID_Platillo = p_FK_ID_Platillo,
	Estado = P_Estado
	WHERE ID = p_ID;
	END if;
	END if;
END;

DELIMITER $$
DROP PROCEDURE if EXISTS showpedido;
CREATE PROCEDURE showpedido(
IN P_FK_ID_Orden INT
)
BEGIN
SELECT pedidos.ID AS Num, pedidos.FK_ID_Orden AS Num_Orden, pedidos.Precio, pedidos.Cantidad, pedidos.FK_ID_Platillo AS Num_Platillo, platillo.Nombre AS Nombre_Platillo, 
pedidos.Estado FROM pedidos, platillo WHERE pedidos.FK_ID_Platillo = platillo.ID ORDER BY pedidos.ID;
END ;;

DELIMITER $$
DROP PROCEDURE if EXISTS deletepedidos;
CREATE PROCEDURE deletepedidos(
IN _ID INT
)
BEGIN
DELETE FROM Pedidos WHERE ID = _ID;
END;;


#////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#/////////////////////////////////////////////////////////////////FIN PEDIDOS


#////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#/////////////////////////////////////////////////////////////////ORDEN



CREATE TABLE Orden(
Folio INT AUTO_INCREMENT PRIMARY KEY,
Mesa INT,
Fecha_Hora DATETIME,
Observaciones VARCHAR(200),
FK_ID_Mesero INT,
FOREIGN KEY(FK_ID_Mesero) REFERENCES Mesero(ID));

DELIMITER $$
DROP PROCEDURE if EXISTS p_insertarorden;
CREATE PROCEDURE p_insertarorden(
IN p_Folio INT,
IN p_Mesa INT,
IN p_Fecha_Hora DATETIME,
IN p_Observaciones VARCHAR(200),
IN p_FK_ID_Mesero INT
)
BEGIN
	
   if p_Folio<0 then
	INSERT INTO orden VALUES (NULL,p_Mesa,CURRENT_TIMESTAMP,p_Observaciones,p_FK_ID_Mesero); 
	ELSE if p_Folio>0 then
	UPDATE orden SET Mesa = p_Mesa, Fecha_Hora = p_Fecha_Hora, Observaciones = p_Observaciones,
	FK_ID_Mesero = p_FK_ID_Mesero
	WHERE Folio = p_Folio;
	ELSE 
	UPDATE orden SET  Fecha_Hora = p_Fecha_Hora, Observaciones = p_Observaciones,
	FK_ID_Mesero = p_FK_ID_Mesero
	WHERE Folio = p_Folio;
	END if;
	END if;
END;


DELIMITER $$
DROP PROCEDURE if EXISTS showorden;
CREATE PROCEDURE showorden(
IN _Mesa INT
)
BEGIN
SELECT PE.Folio, PE.Mesa AS Mesa,PE.Fecha_Hora AS Fecha_Hora, PE.Observaciones AS Observaciones,
PE.FK_ID_Mesero AS FK_ID_Mesero FROM orden AS PE 
WHERE Mesa LIKE _Mesa ORDER BY Mesa;
END ;;

DELIMITER $$
DROP PROCEDURE if EXISTS deletepedidos;
CREATE PROCEDURE deletepedidos(
IN _Folio INT
)
BEGIN
DELETE FROM orden WHERE Folio = _Folio;
END;;



INSERT INTO orden VALUES (NULL,1,CURRENT_TIMESTAMP,'SIN VERDURA',1);
SELECT * FROM orden;

INSERT INTO pedidos VALUES (NULL,12,20.40,3,1,'Por Entregar');


#////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#/////////////////////////////////////////////////////////////////FIN ORDEN

delimiter $$
DROP TRIGGER IF EXISTS trigger_para_realizar_venta;
CREATE TRIGGER trigger_para_realizar_venta 
BEFORE DELETE ON orden 
FOR EACH ROW 
BEGIN 
DECLARE X DOUBLE;
SELECT SUM(pedidos.Precio * pedidos.Cantidad) FROM pedidos WHERE FK_ID_Orden = OLD.Folio INTO X;
INSERT INTO venta VALUES (NULL,OLD.Folio,X,CURRENT_TIMESTAMP);
DELETE FROM pedidos WHERE pedidos.FK_ID_Orden = OLD.Folio;

END;;

CREATE TABLE Venta(
ID INT AUTO_INCREMENT PRIMARY KEY,
FK_ID_Orden INT,
Precio_Total DOUBLE,
Fecha_hora DATETIME,
FOREIGN KEY(FK_ID_Orden) REFERENCES Orden(Folio));

SELECT * FROM venta;


#///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#/////////////////////////////////////////////////////////////////////////////////////////////VISTA

CREATE VIEW PEDIDO_VIEW AS SELECT pedidos.ID AS NUm_Pedido, pedidos.FK_ID_Orden AS Num_Orden, orden.Mesa, pedidos.FK_ID_Platillo AS Num_Platillo, platillo.Nombre ,pedidos.Precio,
pedidos.Cantidad,orden.Fecha_Hora,orden.Observaciones
 FROM pedidos, orden, platillo WHERE pedidos.FK_ID_Orden = orden.Folio AND pedidos.FK_ID_Platillo = platillo.ID;
 
 SELECT * FROM PEDIDO_VIEW;

