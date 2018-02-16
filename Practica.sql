create database recursosHumanos;

use recursosHumanos;

--CREATING TABLES

CREATE TABLE COMPETENCIAS(id int primary key identity, descripcion varchar(100)not null,
							estado bit not null);
CREATE TABLE IDIOMAS(id int primary key identity, nombre varchar(60) not null, descripcion varchar (100));

CREATE TABLE CAPACITACIONES(id int primary key ident ity,nombre varchar(50) not null,descripcion varchar(100),idNivelCapacitacion int not null, 
							fechaDesde datetime not null,fechaHasta datetime not null,institutcion varchar(100)  );
							
CREATE TABLE NIVELESCAPACITACIONES(id int primary key identity,nombre varchar(60)not null);

CREATE TABLE PUESTOS(id int primary key identity,nombre varchar(60) not null,idNivelRiesgo int not null,nivelMinimoSalario decimal(8,2) 
						not null,nivlMaximoSalario decimal(8,2) not null,estado bit not null); 

CREATE TABLE NIVELESRIESGO(id int primary Key identity,nombre varchar(60)not null);

CREATE TABLE CANDIDATOS(id int primary key identity,cedula varchar(13)not null, nombre varchar(60) not null,
						puestoAspira varchar(60) not null, idDepartamento int not null,salarioAspira decimal(8,2), 
						principalesCompetencias text,principalesCapacitaciones text, idExperienciaLaboral int not null,
						recomendado varchar(60));
						
CREATE TABLE DEPARTAMENTOS(id int primary key identity,nombre varchar(60) not null,descripcion varchar(100));

CREATE TABLE EXPERIENCIASLABORALES(id int primary key identity,empresa varchar(60) not null,puestoOcupado varchar(60),
									fechaDesde datetime,fechaHasta datetime,salario decimal(8,2),cedula varchar(13));

CREATE TABLE EMPLEADOS(id int primary key identity,cedula varchar(13) not null,nombre varchar(60) not null,fechaIngreso datetime not null,
						 idPuesto int not null,idDepartamento int not null,salarioMensual decimal(8,2),estado bit);

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
 
 --IDIOMA
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
CREATE PROCEDURE enviarDatosATextBoxIdioma(
	@id int)
AS
BEGIN
	select * from IDIOMAS
	where id = @id
END
GO


--Nivel de capacitacion
GO
CREATE PROCEDURE obtenerNivelDeCap
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM NIVELESCAPACITACIONES;
END
GO

GO
CREATE PROCEDURE insertarActualizarNivelDeCap(
	@mode char(1) ,
	@id int = '', 
	@name nvarchar(60))
AS
BEGIN
	if(@mode=0)
	BEGIN
		INSERT INTO NIVELESCAPACITACIONES(nombre) 
			VALUES(@name)
	END

	else if(@mode=1)
	BEGIN
		UPDATE NIVELESCAPACITACIONES SET nombre=@name
		WHERE id=@id
	END	
END
GO

GO
CREATE PROCEDURE obtenerNivelDeCapWhere(
	@id int)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM NIVELESCAPACITACIONES where id = @id;
END
GO

GO
CREATE PROCEDURE eliminarNivelDeCap(
	@id int)
AS
BEGIN
	SET NOCOUNT ON;
	DELETE from NIVELESCAPACITACIONES WHERE id=@id;
END
GO

GO
CREATE PROCEDURE enviarDatosATextBoxNivelDeCap(
	@id int)
AS
BEGIN
	select * from NIVELESCAPACITACIONES
	where id = @id
END
GO

--CAPACITACIONES--------------------------------------------- select * from CAPACITACIONES

GO
ALTER PROCEDURE obtenerCapacitacion
AS
BEGIN
	SET NOCOUNT ON;
	select c.id,c.nombre,c.descripcion,d.nombre as 'nivel de capacitacion',c.fechaDesde,c.fechaHasta,c.institucion,c.cedulaTitular from CAPACITACIONES c
	INNER JOIN NIVELESCAPACITACIONES d on c.id = d.id;
END
GO

GO
ALTER PROCEDURE insertarActualizarCapacitacion(
	@mode char(1) ,
	@id int = '', 
	@name nvarchar(60),
	@descr varchar(100),
	@idNivelCapacitacion int,
	@fechaDesde date, 
	@fechaHasta date,
	@institucion nvarchar(60),
	@cedularTitular nvarchar(13))
AS
BEGIN
	if(@mode=0)
	BEGIN
		INSERT INTO CAPACITACIONES(nombre,descripcion,idNivelCapacitacion,fechaDesde,fechaHasta,institucion,cedulaTitular) 
			VALUES(@name,@descr,(select id from NIVELESCAPACITACIONES where id =  @idNivelCapacitacion),@fechaDesde,
					@fechaHasta,@institucion,@cedularTitular)
	END
	else if(@mode=1)
	BEGIN
		UPDATE CAPACITACIONES SET nombre=@name,descripcion=@descr,idNivelCapacitacion=@idNivelCapacitacion,cedulaTitular=@cedularTitular,
				fechaDesde=@fechaDesde,fechaHasta=@fechaHasta,institucion=@institucion
		WHERE id=@id
	END	
END
GO

GO
CREATE PROCEDURE obtenerCapacitacionWhere(
	@id int)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM NIVELESCAPACITACIONES where id = @id;
END
GO

GO
CREATE PROCEDURE eliminarCapacitacion(
	@id int)
AS
BEGIN
	SET NOCOUNT ON;
	DELETE from CAPACITACIONES WHERE id=@id;
END
GO

GO
CREATE PROCEDURE enviarDatosATextBoxCap(
	@id int)
AS
BEGIN
	select * from CAPACITACIONES
	where id = @id
END
GO

--Department------------------------------------------------- select * from departamentos

GO
CREATE PROCEDURE obtenerDepartamento
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM DEPARTAMENTOS;
END
GO

GO
CREATE PROCEDURE insertarActualizarDepartamento(
	@mode char(1) ,
	@id int = '', 
	@name nvarchar(60),
	@descr nvarchar(60))
AS
BEGIN
	if(@mode=0)
	BEGIN
		INSERT INTO DEPARTAMENTOS(nombre,descripcion) 
			VALUES(@name,@descr)
	END

	else if(@mode=1)
	BEGIN
		UPDATE DEPARTAMENTOS SET nombre=@name,descripcion=@descr
		WHERE id=@id
	END	
END
GO

GO
CREATE PROCEDURE obtenerDepartamentoWhere(
	@id int)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM DEPARTAMENTOS where id = @id;
END
GO

GO
CREATE PROCEDURE eliminarDepartamento(
	@id int)
AS
BEGIN
	SET NOCOUNT ON;
	DELETE from DEPARTAMENTOS WHERE id=@id;
END
GO

GO
CREATE PROCEDURE enviarDatosATextBoxDepartamento(
	@id int)
AS
BEGIN
	select * from DEPARTAMENTOS
	where id = @id
END
GO

--ExperienciasLaborales------------------------------------------------- select * from ExperienciasLaborales

GO
CREATE PROCEDURE obtenerExperienciaLaboral
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM EXPERIENCIASLABORALES;
END
GO

GO
CREATE PROCEDURE insertarActualizarExperienciaLaboral(
	@mode char(1) ,
	@id int = '', 
	@company nvarchar(60),
	@positionOccupied nvarchar(60),
	@beginDate date,
	@finishDate date,
	@salary decimal(8,2),
	@cedula nvarchar(13))
AS
BEGIN
	if(@mode=0)
	BEGIN
		INSERT INTO EXPERIENCIASLABORALES(empresa,puestoOcupado,fechaDesde,fechaHasta,salario,cedula) 
			VALUES(@company,@positionOccupied,@beginDate,@finishDate,@salary,@cedula)
	END

	else if(@mode=1)
	BEGIN
		UPDATE EXPERIENCIASLABORALES SET empresa = @company,puestoOcupado=@positionOccupied,fechaDesde=@beginDate,
						fechaHasta=@finishDate,salario=@salary,cedula=@cedula
		WHERE id=@id
	END	
END
GO

GO
CREATE PROCEDURE obtenerExperienciaLaboralWhere(
	@id int)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM EXPERIENCIASLABORALES where id = @id;
END
GO

GO
CREATE PROCEDURE eliminarExperienciaLaboral(
	@id int)
AS
BEGIN
	SET NOCOUNT ON;
	DELETE from EXPERIENCIASLABORALES WHERE id=@id;
END
GO

GO
CREATE PROCEDURE enviarDatosATextBoxExperienciaLaboral(
	@id int)
AS
BEGIN
	select * from EXPERIENCIASLABORALES
	where id = @id
END
GO




--EMPLEADOS--------------------------------------------- select * from EMPLEADOS

GO
ALTER PROCEDURE obtenerEmpleado
AS
BEGIN
	SET NOCOUNT ON;
	select emp.id,emp.cedula,emp.nombre,emp.fechaIngreso,pue.nombre as 'puesto',dep.nombre as 'departamento',emp.salarioMensual,emp.estado from EMPLEADOS emp
	INNER JOIN PUESTOS pue on emp.idPuesto = pue.id
	INNER JOIN DEPARTAMENTOS dep on emp.idDepartamento = dep.id;
END
GO

GO
CREATE PROCEDURE obtenerEmpleadoLike
	(@nombreLike nvarchar(50))
AS
BEGIN
	SET NOCOUNT ON;
	select emp.id,emp.cedula,emp.nombre,emp.fechaIngreso,pue.nombre as 'puesto',dep.nombre as 'departamento',emp.salarioMensual,emp.estado from EMPLEADOS emp
	INNER JOIN PUESTOS pue on emp.idPuesto = pue.id
	INNER JOIN DEPARTAMENTOS dep on emp.idDepartamento = dep.id
	where emp.nombre like @nombreLike
END
GO 

GO
CREATE PROCEDURE insertarActualizarEmpleado(
	@mode char(1) ,
	@id int = '',
	@cedula nvarchar(13),
	@nombre nvarchar(60),
	@fechaIngreso date,
	@idPuesto int,
	@idDepartamento int,
	@salarioMensual decimal(8,2),
	@estado bit)
AS
BEGIN
	if(@mode=0)
	BEGIN
		INSERT INTO EMPLEADOS(cedula, nombre,fechaIngreso,idPuesto,idDepartamento,salarioMensual,estado) 
			VALUES(@cedula,@nombre, @fechaIngreso,(select id from PUESTOS where id =  @idPuesto),
					(select id from DEPARTAMENTOS where id =  @idDepartamento),@salarioMensual,@estado)
	END
	else if(@mode=1)
	BEGIN
		UPDATE EMPLEADOS SET cedula=@cedula,nombre=@nombre,fechaIngreso=@fechaIngreso,idPuesto=@idPuesto,
				idDepartamento=@idDepartamento,salarioMensual=@salarioMensual,estado=@estado
		WHERE id=@id
	END	
END
GO

GO
CREATE PROCEDURE obtenerCapacitacionWhere(
	@id int)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM NIVELESCAPACITACIONES where id = @id;
END
GO

GO
CREATE PROCEDURE eliminarCapacitacion(
	@id int)
AS
BEGIN
	SET NOCOUNT ON;
	DELETE from CAPACITACIONES WHERE id=@id;
END
GO

GO
CREATE PROCEDURE enviarDatosATextBoxCap(
	@id int)
AS
BEGIN
	select * from CAPACITACIONES
	where id = @id
END
GO


--PUESTOS---------------------------------------- select * from PUESTOS
SELECT * FROM NIVELESRIESGO
GO
CREATE PROCEDURE obtenerPuesto
AS
BEGIN
	SET NOCOUNT ON;
	select pues.id,pues.nombre,d.nombre as 'nivel de riesgo',pues.nivelMinimoSalario,pues.nivlMaximoSalario,pues.estado from PUESTOS pues
	INNER JOIN NIVELESRIESGO d on pues.id = d.id;
END
GO

GO
CREATE PROCEDURE insertarActualizarPuesto(
	@mode char(1),
	@id int = '', 
	@name nvarchar(60),
	@idNivelRiesgo int,
	@salarioMin decimal(8,2), 
	@salarioMax decimal(8,2),
	@estado bit)
AS
BEGIN
	if(@mode=0)
	BEGIN
		INSERT INTO PUESTOS(nombre,idNivelRiesgo,nivelMinimoSalario,nivlMaximoSalario,estado) 
			VALUES(@name,(select id from NIVELESRIESGO where id =  @idNivelRiesgo),@salarioMin,@salarioMax,@estado)
	END
	else if(@mode=1)
	BEGIN
		UPDATE PUESTOS SET nombre=@name,idNivelRiesgo=@idNivelRiesgo,nivelMinimoSalario=@salarioMin,
				nivlMaximoSalario=@salarioMax,estado=@estado
		WHERE id=@id
	END	
END
GO

GO
CREATE PROCEDURE eliminarPuesto(
	@id int)
AS
BEGIN
	SET NOCOUNT ON;
	DELETE from PUESTOS WHERE id=@id;
END
GO

GO
CREATE PROCEDURE enviarDatosATextBoxPuesto(
	@id int)
AS
BEGIN
	select * from PUESTOS
	where id = @id
END
GO

