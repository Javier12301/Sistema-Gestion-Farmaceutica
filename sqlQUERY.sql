use SistemaGestionFarmaceutica

USE SistemaGestionFarmaceutica; -- Reemplaza "NombreDeTuBaseDeDatos" por el nombre de tu base de datos

GRANT REFERENCES ON OBJECT::dbo.Lotes TO Javier12301; -- Reemplaza "TuUsuario" por el nombre de tu usuario

CREATE TABLE Estantes(
	EstanteID INT IDENTITY(1,1) PRIMARY KEY,
	Nombre NVARCHAR(255) NOT NULL,
	Numero_de_estante INT NOT NULL,
	Sector NVARCHAR(255) NOT NULL
);

CREATE TABLE Categorias(
	CategoriaID INT IDENTITY(1,1) PRIMARY KEY,
	Nombre NVARCHAR(255) NOT NULL,
	Descripcion NVARCHAR(255) NOT NULL
);

SELECT * FROM Medicamentos;
SELECT * FROM Lotes;
SELECT * FROM Medicamentos WHERE CategoriaID = 15 AND EstanteID = 15

-- Crear Tabla LOTE
CREATE TABLE Lotes(
	LoteID INT PRIMARY KEY,
	Stock INT NOT NULL,
	Nombre_Medicamento NVARCHAR(255) NOT NULL,
	FechaVencimiento DATE NOT NULL
);

GRANT SELECT, INSERT, UPDATE ON Lotes TO Javier12301;
GRANT REFERENCES ON Lotes TO Javier12301;
GRANT CREATE ON dbo.Lotes TO Javier12301;

--SELECT M.LoteID, M.CategoriaID, M.EstanteID, M.PrecioUnitario, L.Stock, L.Nombre_Medicamento, L.FechaVencimiento,C.Nombre AS CategoriaNombre, E.Nombre AS EstanteNombre, E.Sector, E.Numero_de_estanteFROM Medicamentos M
--INNER JOIN Lotes L ON M.LoteID = L.LoteID
--INNER JOIN Categorias C ON M.CategoriaID = C.CategoriaID
--INNER JOIN Estantes E ON M.EstanteID = E.EstanteID
--WHERE M.CategoriaID = @CategoriaID AND M.EstanteID = @EstanteID";

SELECT 
    M.LoteID AS Lote,
    L.Nombre_Medicamento AS Nombre_Medicamento,
    L.Stock AS Cantidad,
    L.FechaVencimiento AS Vencimiento,
    C.Nombre AS Categoria,
    E.Nombre AS Nombre_Estante,
    E.Sector AS Sector,
    E.Numero_de_estante AS Numero_Estante
FROM Medicamentos M
INNER JOIN Lotes L ON M.LoteID = L.LoteID
INNER JOIN Categorias C ON M.CategoriaID = C.CategoriaID
INNER JOIN Estantes E ON M.EstanteID = E.EstanteID;


CREATE TABLE Medicamentos(
	LoteID INT FOREIGN KEY REFERENCES Lotes(LoteID),
	EstanteID INT FOREIGN KEY REFERENCES Estantes(EstanteID),
	CategoriaID INT FOREIGN KEY REFERENCES Categorias(CategoriaID),
	PrecioUnitario DECIMAL(10, 2),
	PRIMARY KEY (LoteID)
);

DROP TABLE Lotes;

ALTER TABLE Medicamentos
ADD PrecioUnitario DECIMAL(10, 2); -- Cambia el tamaño y precisión según tus necesidades



SELECT * FROM Estantes;

UPDATE Categorias 
SET Nombre = 'probandomodi1', Descripcion = 'xcvxzv' 
WHERE CategoriaID = 10;

INSERT INTO Categorias (Nombre, Descripcion)
VALUES ('Jeringas', 'Categoría de productos relacionados con jeringas'),
       ('Proteinas', 'Categoría de productos relacionados con proteínas'),
       ('Vitaminas', 'Categoría de productos relacionados con vitaminas');

INSERT INTO Lotes (Stock, Nombre_Medicamento, FechaVencimiento)
VALUES (100, 'Medicamento A', '2023-12-31'),
       (50, 'Medicamento B', '2024-06-30'),
       (200, 'Medicamento C', '2023-11-15');

INSERT INTO Estantes (Nombre, Numero_de_estante, Sector)
VALUES ('Estante A', 1, 'Sector A'),
       ('Estante B', 2, 'Sector B'),
       ('Estante C', 3, 'Sector C');

INSERT INTO Medicamentos (LoteID, EstanteID, CategoriaID)
VALUES (1, 1, 1),
       (2, 2, 2),
       (3, 3, 3);

SELECT Lotes.LoteID, Lotes.Nombre_Medicamento, Lotes.Stock, Categorias.Nombre AS Categoria, Lotes.FechaVencimiento , Estantes.Nombre, Estantes.Numero_de_estante FROM Medicamentos
INNER JOIN Lotes ON Medicamentos.LoteID = Lotes.LoteID
INNER JOIN Estantes ON Medicamentos.EstanteID = Estantes.EstanteID
INNER JOIN Categorias ON Medicamentos.CategoriaID = Categorias.CategoriaID;

SELECT * FROM Categorias