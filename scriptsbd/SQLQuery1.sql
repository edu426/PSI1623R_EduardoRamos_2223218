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

Insert into Jogoscolecao values ('Jogo1',1,1,1,''),('Jogo2',1,1,1,''),('Jogo3',1,1,1,''),('Jogo4',1,1,1,'')
select * from Jogoscolecao
drop table Jogoscolecao
 
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
drop table whislist
 
create table Plataformas(
IdPlataforma int primary key identity(1,1),
NomePlataforma varchar(50),
)

Insert into plataformas Values ('PS4'), ('PC'), ('Xbox One'), ('Nintendo Switch'), ('Outros')
Select * from Plataformas
drop table Plataformas
 
create table Genero(
IdGenero int primary key identity(1,1),
NomeGenero varchar(50),
)

Insert into genero Values ('RPG'), ('Aventura'), ('FPS'), ('Terror'), ('Outros')	
select * from Genero
drop table genero
 
create table Utilizador(
IdUtilizador int primary key identity(1,1),
Nome varchar(50),
Password varchar(50),
UserPic varchar(300),
)
SELECT * FROM Utilizador

SELECT titulo FROM Jogoscolecao WHERE titulo = 'job simulator' AND userid = 1006
