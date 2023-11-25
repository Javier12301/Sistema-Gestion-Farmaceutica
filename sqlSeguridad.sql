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

DBCC CHECKIDENT ('CATEGORIA', RESEED, 0);
