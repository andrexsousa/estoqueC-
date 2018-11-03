CREATE DATABASE estoqueCamisetas ON PRIMARY (NAME = estoqueCamisetas, FILENAME = 'C:\sql\estoqueCamisetas.mdf', SIZE = 6MB, MAXSIZE=20MB, FILEGROWTH = 10%)
LOG ON ( NAME = estoqueCamisetas_log, FILENAME = 'C:\sql\estoqueCamisetas_log.ldf', SIZE= 1MB, FILEGROWTH = 1MB)
GO

//create database estoqueCamisetas

use estoqueCamisetas

create table tblCamiseta (
id int primary key,
nome varchar(50) not null,
cor varchar(8) not null,
tamanho varchar(3) not null,
categoria varchar(8) not null,
genero varchar(9) not null,
preco decimal(5,2) not null, 
quantidade int not null,
img varchar(200) not null)

create table tblLogin(
id smallint primary key identity not null,
nome varchar(25) not null,
email varchar(50) not null,
senha varchar(8) not null)

select * from tblCamiseta;

delete from tblLogin

delete from tblCamiseta

select * from tblLogin;

insert into tblLogin values
('André Sousa', 'andre@email.com', '1234'),
('André Sousa', 'andre@user', '1234')

insert into tblCamiseta values
(1000,'Camiseta Dio','Preta','M','Rock','Unissex',49.90,'100','C:\estoqueCamisetas\img\produto\dio.jpg'),
(1001,'Camiseta Pink Floyd','Branca','M','Rock','Unissex',49.90,'100','C:\estoqueCamisetas\img\produto\pink.jpg'),
(1002,'Camiseta Iron Maiden','Preta','G','Rock','Unissex',49.90,'100','C:\estoqueCamisetas\img\produto\iron.jpg'),
(2000,'Camiseta Rick and Morty','Cinza','P','Filme','Baby Look',49.90,'100','C:\estoqueCamisetas\img\produto\rick.jpg'),
(2001,'Camiseta Breaking Bad','Branca','G','Filme','Unissex',49.90,'100','C:\estoqueCamisetas\img\produto\bad.jpg'),
(2002,'Camiseta Game of Thrones','Branca','M','Filme','Unissex',49.90,'100','C:\estoqueCamisetas\img\produto\game.jpg'),
(3000,'Camiseta Grand Theft Auto V','Cinza','M','Games','Baby Look',49.90,'100','C:\estoqueCamisetas\img\produto\gta.jpg'),
(3001,'Camiseta League of Legends','Cinza','P','Games','Unissex',49.90,'100','C:\estoqueCamisetas\img\produto\league.jpg'),
(3002,'Camiseta Super Choque','Preta','M','Heróis','Unissex',49.90,'100','C:\estoqueCamisetas\img\produto\choque.jpg'),
(4003,'Camiseta Nanatsu no Taizai','Preta','M','Anime','Unissex',49.90,'100','C:\estoqueCamisetas\img\produto\nanatsu.jpg')



