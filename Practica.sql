create database recursosHumanos;

use recursosHumanos;

--CREATING TABLES

CREATE TABLE COMPETENCIAS(id int primary key identity, descripcion varchar(100)not null,
							estado bit not null);
CREATE TABLE IDIOMAS(id int primary key identity, nombre varchar(60) not null, descripcion varchar (100));

CREATE TABLE CAPACITACIONES(id int primary key identity,descripcion varchar(100),idNivelCapacitacion int not null, 
							fechaDesde datetime not null,fechaHasta datetime not null,institutcion varchar(100));

CREATE TABLE NIVELESCAPACITACIONES(id int primary key identity,nombre varchar(60)not null);

CREATE TABLE PUESTOS(id int primary key identity,nombre varchar(60) not null,idNivelRiesgo int not null,nivelMinimoSalario decimal(6,2) 
						not null,nivlMaximoSalario decimal(6,2) not null,estado bit not null); 

CREATE TABLE NIVELESRIESGO(id int primary Key identity,nombre varchar(60)not null);

CREATE TABLE CANDIDATOS(id int primary key identity,cedula varchar(13)not null, nombre varchar(60) not null,
						puestoAspira varchar(60) not null, idDepartamento int not null,salarioAspira decimal(6,2), 
						principalesCompetencias text,principalesCapacitaciones text, idExperienciaLaboral int not null,
						recomendado varchar(60));

CREATE TABLE DEPARTAMENTOS(id int primary key identity,nombre varchar(60) not null,descripcion varchar(100));

CREATE TABLE EXPERIENCIASLABORALES(id int primary key identity,empresa varchar(60) not null,puestoOcupado varchar(60),
									fechaDesde datetime,salario decimal(6,2));

CREATE TABLE EMPLEADOS(id int primary key identity,cedula varchar(13) not null,nombre varchar(60) not null,fechaIngreso datetime not null,
						 idPuesto int not null,idDepartamento int not null,salarioMensual decimal(6,2),estado bit);

CREATE TABLE usuarios(id int identity, nombreUsuario varchar(60) not null, nombrePila varchar(60) not null,
						contrasena varchar(30)not null, 
						CONSTRAINT PK_Users_IdNombreUsuario PRIMARY KEY (id,nombreUsuario));
					
--FOREIGN KEYS
ALTER TABLE PUESTOS
ADD CONSTRAINT FK_Puestos_NivlesRiesgos FOREIGN KEY (idNivelRiesgo) 
	REFERENCES NIVELESRIESGO(id);

ALTER TABLE CAPACITACIONES 
	ADD CONSTRAINT FK_Capacitaciones_NivelesCapacitaciones FOREIGN KEY(IdNivelCapacitacion)
	REFERENCES NIVELESCAPACITACIONES(id);

ALTER TABLE CANDIDATOS 
	ADD CONSTRAINT FK_Candidatos_Departamentos FOREIGN KEY (idDepartamento)
	REFERENCES DEPARTAMENTOS(id);
	
ALTER TABLE CANDIDATOS 
	ADD CONSTRAINT FK_Candidatos_ExperienciasLaborales FOREIGN KEY(idExperienciaLaboral)
	REFERENCES EXPERIENCIASLABORALES(id);
	
ALTER TABLE EMPLEADOS
	ADD CONSTRAINT FK_Empleados_Departamentos FOREIGN KEY (idDepartamento)
	REFERENCES DEPARTAMENTOS(id);

  --STORED PROCEDURES
 
GO
CREATE PROCEDURE obtenerIdioma
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM IDIOMAS;
END
GO

GO
CREATE PROCEDURE insertarActualizarIdioma(
	@mode char(1) ,
	@id int = '', 
	@name nvarchar(60),
	@descr nvarchar(60))
AS
BEGIN
	if(@mode=0)
	BEGIN
		INSERT INTO IDIOMAS(nombre,descripcion) 
			VALUES(@name,@descr)
	END

	else if(@mode=1)
	BEGIN
		UPDATE IDIOMAS SET nombre=@name,descripcion=@descr
		WHERE id=@id
	END	
END
GO

GO
CREATE PROCEDURE obtenerIdiomaWhere(
	@id int)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM IDIOMAS where id = @id;
END
GO

GO
CREATE PROCEDURE eliminarIdioma(
	@id int)
AS
BEGIN
	SET NOCOUNT ON;
	DELETE from IDIOMAS WHERE id=@id;
END
GO

GO
CREATE PROCEDURE enviarDatosATextBox(
	@id int)
AS
BEGIN
	select * from IDIOMAS
	where id = @id
END
GO

enviarDatosATextBox 1;

  /*
GO
CREATE PROCEDURE getCustomerTest
	@Id int,
	@CustomerName nvarchar(60),
	@CompanyName nvarchar(60)
as
	SET NOCOUNT ON;
	select a.idCustomer,a.customerName,b.companyName from Customers a
	INNER JOIN Companies b on a.idCompany=b.idCompany
	WHERE a.idCustomer = @Id and a.customerName = @CustomerName 
	AND b.companyName = @CompanyName;
GO

EXEC getCustomerTest 1,'Jesus Mejia','CONSORCIO DE BANCAS FRANKLIN';

GO
ALTER PROCEDURE getCustomerTest (
	@Id int)
AS
BEGIN
	SET NOCOUNT ON;
	select a.idCustomer,a.customerName,b.companyName from Customers a
	INNER JOIN Companies b on a.idCompany=b.idCompany
	WHERE a.idCustomer = @Id;
END
GO

CREATE PROCEDURE insertCustomerTest (
	@Name nvarchar(60),
	@idCompany int )
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Customers values(@Name,@idCompany);
END

EXEC insertCustomerTest 'Diego Idelfonso', 2;

EXEC getCustomerTest 4