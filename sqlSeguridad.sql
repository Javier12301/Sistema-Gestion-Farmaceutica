use SistemaGestionFarmaceutica

-- Script de Base de Datos destinada para el modulo de seguridad

-- ROL

CREATE TABLE ROL(
	RolID INT PRIMARY KEY IDENTITY,   
	Descripcion VARCHAR (50),
	FechaCreacion DATETIME DEFAULT getdate()
);


CREATE TABLE PERMISO(
	PermisoID INT PRIMARY KEY IDENTITY,
	RolID INT REFERENCES ROL(RolID),
	NombreMenu varchar(50),
	FechaCreacion DATETIME DEFAULT getdate()
);

CREATE TABLE USUARIO(
	UsuarioID INT IDENTITY PRIMARY KEY,   
	Documento VARCHAR(50),  
	NombreCompleto VARCHAR(50),
	Correo VARCHAR(50),            
	Clave VARCHAR(20),          	
	RolID INT REFERENCES ROL(RolID),
	Estado bit,
	FechaCreacion DATETIME DEFAULT getdate()
);
