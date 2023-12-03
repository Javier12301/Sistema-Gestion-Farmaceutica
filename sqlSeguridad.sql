use FarmaciaDB

-- Script de Base de Datos destinada para el modulo de seguridad

-- ROL

-- Creación de tablas
CREATE TABLE ROL (
    RolID INT PRIMARY KEY IDENTITY,
    Descripcion VARCHAR(50),
    FechaCreacion DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE PERMISO (
    PermisoID INT PRIMARY KEY IDENTITY,
    RolID INT REFERENCES ROL(RolID),
    NombreMenu VARCHAR(50),
    FechaCreacion DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE USUARIO (
    UsuarioID INT IDENTITY PRIMARY KEY,
    Documento VARCHAR(50),
    NombreCompleto VARCHAR(50),
    Correo VARCHAR(50),
    Clave VARCHAR(20),
    RolID INT REFERENCES ROL(RolID),
    Estado BIT,
    FechaCreacion DATETIME DEFAULT GETDATE()
);
GO

SELECT * FROM ROL

 insert into rol (Descripcion)
 values('ADMINISTRADOR')

 GO

 insert into rol (Descripcion)
 values('EMPLEADO')

 GO

 insert into USUARIO(Documento,NombreCompleto,Correo,Clave,RolID,Estado)
 values 
 ('44608055','ADMIN','javi@gmail.com','123',1,1)

 GO

DBCC CHECKIDENT ('CATEGORIA', RESEED, 0);
