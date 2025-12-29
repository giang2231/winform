create database QLSP
GO
create table Category(
CategoryID int primary key,
CategoryName NVARCHAR(50));

CREATE TABLE Productt(
ProducttID int primary key,
ProducttName NVARCHAR(50),
Price decimal,
Quantity int,
CategoryID int FOREIGN KEY REFERENCES Category(CategoryID));
