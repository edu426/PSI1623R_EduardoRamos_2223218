Create database collection
use collection

create table Utilizador(
IdUtilizador int primary key identity(1,1),
Nome varchar(50),
Password varchar(50),
UserPic varchar(300),
)
Select* From Utilizador
Insert Into Utilizador Values ('Admin', '@dmin','https://t3.ftcdn.net/jpg/00/07/32/48/360_F_7324855_mx4CEBWTr81XLOrlQccCROtP2uNR7xbk.jpg')
--User Exemplo
Insert Into Utilizador Values ('Eduardo','Ramos','https://media.istockphoto.com/id/468388312/pt/foto/fogo-letra-e.jpg?s=612x612&w=0&k=20&c=Fe8o_69oi6osn4LvESXE-6qITJDeDlfTEY2fk_2kLMI=')

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

--Jogos do utilizador exemplo
INSERT INTO JogosColecao (Titulo, PlataformaId, Genero, GamePic, UserId)
VALUES 
('The Witcher 3', 1, 1, 'https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/qezXTVn1ExqBjVjR5Ipm97IK.png', 2),
('God of War', 2, 1, 'https://upload.wikimedia.org/wikipedia/en/thumb/a/a7/God_of_War_4_cover.jpg/250px-God_of_War_4_cover.jpg', 2),
('Zelda BOTW', 4, 3, 'https://cdn.europosters.eu/image/750/34557.jpg', 2),
('Call of Duty', 3, 2, 'https://i.pinimg.com/originals/39/35/1e/39351eee511aedea02f809a244687730.jpg', 2),
('Elden Ring', 1, 4, 'https://i.pinimg.com/736x/07/f4/6a/07f46a0f97081a976b4d72bc79169cdb.jpg', 2),
('Mario Kart 8', 6, 3, 'https://i.pinimg.com/736x/6b/2b/3e/6b2b3e086029bc8efba96c0aeaf6959c.jpg',2),
('Dark Souls II', 1, 2, 'https://i.etsystatic.com/6824854/r/il/f7ea4a/1099245251/il_570xN.1099245251_6yg7.jpg', 2)
 
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

--Table drops
DROP TABLE Utilizador
DROP TABLE JogosColecao
DROP TABLE Whislist
DROP TABLE Plataformas
DROP TABLE Genero
