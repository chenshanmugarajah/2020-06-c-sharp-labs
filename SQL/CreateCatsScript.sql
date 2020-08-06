use master

drop database if exists LibraryDB

create database LibraryDB
go

use LibraryDB
go

create table BoroughLibrarys (
	LibraryId int not null identity(1,1) primary key,
	LibraryName nvarchar(50)
)

insert into BoroughLibrarys values ('Redbridge Library')
insert into BoroughLibrarys values ('Fullwell Cross Library')
insert into BoroughLibrarys values ('Ilford Library')
insert into BoroughLibrarys values ('Havering Library')
insert into BoroughLibrarys values ('Oaks Park Library')

create table Books (
	BookId int not null identity(1,1) primary key,
	BookTitle nvarchar(50),
	BookAuthor nvarchar(50),
	LibraryId int FOREIGN KEY REFERENCES BoroughLibrarys(LibraryId) 
)

insert into Books values ('Of Mice and Men', 'J.K.Rowling', 3)
insert into Books values ('Harry Potter 1', 'Stanley', 5)
insert into Books values ('Indiana Jones', 'Author2', 1)