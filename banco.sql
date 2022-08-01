CREATE DATABASE ProjetoEstoquev;
GO

--DDL - DATA DEFINITION LANGUAGE
CREATE TABLE Nivel(
	codigo int PRIMARY KEY IDENTITY(1,1),
	nome varchar(80) not null
)

SELECT * FROM sys.databases;

--DML - DATA MANIPULATION LANGUAGE
INSERT into Nivel(nome) VALUES ('administrador');
INSERT into Nivel(nome) VALUES ('usuario');

--DQL - DATA QUERY LANGUAGE
SELECT * FROM Nivel;