use master

drop database if exists CatDB

create database CatDB
go

use CatDB
go

create table Breeds (
	BreedId int not null identity(1,1) primary key,
	BreedName nvarchar(50)
)

insert into Breeds values ('Abyssinian')
insert into Breeds values ('AmericanBobTail')
insert into Breeds values ('Mainecoon')
insert into Breeds values ('Tabby')
insert into Breeds values ('Sphinx')

create table Cats (
	CatId int not null identity(1,1) primary key,
	CatName nvarchar(50),
	CatAge int,
	BreedId int FOREIGN KEY REFERENCES Breeds(BreedId) 
)

insert into Cats values ('Ozzies', 15, 3)
insert into Cats values ('Lucy', 3, 5)
insert into Cats values ('Jasper', 1, 1)

select * from Cats c
inner join Breeds b on b.BreedId = c.BreedId