use SistemaGestionFarmaceutica

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

SELECT * FROM Medicamentos


-- Crear Tabla LOTE
CREATE TABLE Lotes(
	LoteID INT IDENTITY(1,1) PRIMARY KEY,
	Stock INT NOT NULL,
	Nombre_Medicamento NVARCHAR(255) NOT NULL,
	FechaVencimiento DATE NOT NULL
);


CREATE TABLE Medicamentos(
	LoteID INT FOREIGN KEY REFERENCES Lotes(LoteID),
	EstanteID INT FOREIGN KEY REFERENCES Estantes(EstanteID),
	CategoriaID INT FOREIGN KEY REFERENCES Categorias(CategoriaID),
	PRIMARY KEY (LoteID)
);


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