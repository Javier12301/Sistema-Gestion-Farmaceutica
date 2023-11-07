use SistemaGestionFarmaceutica

-- Script de Base de Datos destinada para el modulo de seguridad

-- ROL

CREATE TABLE ROL(
	IDRol INT PRIMARY KEY IDENTITY,   
	Descripcion VARCHAR (50),
	FechaCreacion DATETIME DEFAULT getdate()
);


CREATE TABLE PERMISO(
	IDPermiso INT PRIMARY KEY IDENTITY,
	IDRol INT REFERENCES ROL(IDRol),
	NombreMenu varchar(50),
	FechaCreacion DATETIME DEFAULT getdate()
);