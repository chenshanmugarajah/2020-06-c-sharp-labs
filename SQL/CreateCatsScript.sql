use master

drop database if exists CatDB

create database CatDB
go

use CatDB
go

create table Cats (
	CatId int not null identity(1,1) primary key,
	CatName nvarchar(50),
	CatAge int,
	CatDescription nvarchar(50)
)

insert into Cats values ('Ozzies', 15, 'Mainecoon')
insert into Cats values ('Lucy', 3, 'Sphinx')
insert into Cats values ('Jasper', 1, 'Great Cat')

select * from Cats

create table Breeds (
	BreedId int not null identity(1,1) primary key,
	BreedName nvarchar(50)
)

insert into Breeds values ('Abyssinian')
insert into Breeds values ('AmericanBobTail')
insert into Breeds values ('Mainecoon')
insert into Breeds values ('Tabby')
insert into Breeds values ('Sphinx')