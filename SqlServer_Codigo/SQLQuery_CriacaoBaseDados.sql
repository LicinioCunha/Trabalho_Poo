CREATE DATABASE GestaoAlojamentos;

USE GestaoAlojamentos;

-- Tabela Clientes
CREATE TABLE Clientes (
    IDCliente INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Telefone NVARCHAR(15) NOT NULL
);

-- Tabela Alojamentos
CREATE TABLE Alojamentos (
    IDAlojamento INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
    Região NVARCHAR(200) NOT NULL,
	Morada NVARCHAR (200) NOT NULL,
    Tipologia NVARCHAR(50) NOT NULL,
    Capacidade INT NOT NULL,
    PrecoNoite DECIMAL(10, 2) NOT NULL,
	NumeroQuartos INT NOT NULL,
	NumeroWC INT NOT NULL,
	PermiteAnimais BIT NOT NULL DEFAULT 0,
	TemPiscina BIT NOT NULL DEFAULT 0,
	PermiteFumadores BIT NOT NULL DEFAULT 0
);

-- Tabela Reservas
CREATE TABLE Reservas (
    IDReserva INT PRIMARY KEY IDENTITY(1,1),
    IDCliente INT NOT NULL,
    IDAlojamento INT NOT NULL,
    DataCheckIn DATETIME NOT NULL,
    DataCheckOut DATETIME NOT NULL,
    NumeroPessoas INT NOT NULL,
	ValorTotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (IDCliente) REFERENCES Clientes(IDCliente),
    FOREIGN KEY (IDAlojamento) REFERENCES Alojamentos(IDAlojamento)
);

INSERT INTO Clientes (Nome, Email, Telefone)
VALUES('João Silva', 'joao.silva@email.com', '912345678');

INSERT INTO Alojamentos (Nome, Região, Morada, Tipologia, Capacidade, PrecoNoite, NumeroQuartos, NumeroWC, PermiteAnimais, TemPiscina, PermiteFumadores)
VALUES('Casa do Lago', 'Algarve', 'Rua da Praia, nº 15', 'Apartamento', 4, 120.00, 2, 1, 1, 1, 0);

INSERT INTO Reservas (IDCliente, IDAlojamento, DataCheckIn, DataCheckOut, NumeroPessoas, ValorTotal)
VALUES(1, 1, '2024-12-10 14:00:00', '2024-12-15 12:00:00', 4, 600.00);


SELECT * FROM Clientes;
SELECT * FROM Alojamentos;
SELECT * FROM Reservas;


ALTER TABLE Alojamentos ADD Imagem VARBINARY(MAX);

