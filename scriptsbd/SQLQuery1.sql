Create database collection
use collection
 
create table Jogoscolecao(
IdJogos int primary key identity(1,1),
Titulo varchar(50),
UserId int,
foreign key (UserId) References Utilizador (IdUtilizador),
PlataformaId int,
foreign key(PlataformaId) References Plataformas(IdPlataforma),
Genero int,
foreign key(Genero) References Genero(IdGenero),
GamePic varchar(300),
)

select * from Jogoscolecao
 
create table Whislist(
IdWhislist int primary key identity(1,1),
Titulo varchar(50),
PlataformaId int,
foreign key(PlataformaId) References Plataformas(IdPlataforma),
UserId int,
foreign key (UserId) References Utilizador (IdUtilizador),
Preco decimal(4,2) ,
GamePic varchar(300),
)
select * from Whislist
 
create table Plataformas(
IdPlataforma int primary key identity(1,1),
NomePlataforma varchar(50),
)

INSERT INTO plataformas VALUES
('PlayStation 3'),
('PlayStation 4'),
('PlayStation 5'),
('Xbox 360'),
('Xbox One'),
('Xbox Series X/S'),
('Nintendo 3DS'),
('Wii U'),
('Nintendo Switch'),
('PC'),
('Outros')

Select * from Plataformas
 
create table Genero(
IdGenero int primary key identity(1,1),
NomeGenero varchar(50),
)

INSERT INTO genero VALUES
('RPG'),
('Aventura'),
('FPS'),
('Terror'),
('Plataformas'),
('Corrida'),
('Luta'),
('Estratégia'),
('Simulação'),
('Desporto'),
('Puzzle'),
('Sandbox'),
('Survival'),
('Stealth'),
('MMORPG'),
('Visual Novel'),
('Shooter Tático'),
('Mundo Aberto'),
('Hack and Slash'),
('Battle Royale'),
('Outros')

select * from Genero
 
create table Utilizador(
IdUtilizador int primary key identity(1,1),
Nome varchar(50),
Password varchar(50),
UserPic varchar(300),
)

--Table drops
DROP TABLE Utilizador
DROP TABLE JogosColecao
DROP TABLE Wishlist
DROP TABLE Plataforma
DROP TABLE Genero

DROP COLUMN IdJogos, Titulo, UserId, PlataformaId, Genero GamePic FROM Jogoscolecao WHERE Idjogos = 1