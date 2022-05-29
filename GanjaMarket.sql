CREATE DATABASE GanjaMarket

USE GanjaMarket

CREATE TABLE Products (Id INT, Name nvarchar(25), Price DECIMAL)

ALTER TABLE Products ADD Brand nvarchar(25)

INSERT INTO Products (Id, Name, Brand, Price)
VALUES
(1, N'Potato', N'Bravo', 10),
(2, N'Tomato', N'Araz', 15),
(3, N'Carrot', N'Favorit', 17),
(4, N'Onion', N'Bizim Sufre', 11),
(5, N'Garlic', N'Br', 12),
(6, N'Spinach', N'Fav', 13),
(7, N'Broccoli', N'Ar', 11.4),
(8, N'Kale', N'Tema', 10.7),
(9, N'Green peas', N'Some', 19.3),
(10, N'Swiss chard', N'Thing', 16)


SELECT * FROM Products WHERE PRICE < (SELECT AVG(PRICE) FROM Products)

SELECT * FROM Products WHERE PRICE > 10

SELECT (Name + ' ' + Brand) 'ProductInfo' FROM Products WHERE LEN(Brand) < 5
