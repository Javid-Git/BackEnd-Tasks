CREATE DATABASE AmazonGanja

USE AmazonGanja

CREATE TABLE Employees(Name nvarchar(25), SurName nvarchar(25), Position nvarchar(50), Salary INT)

INSERT INTO Employees(Name, SurName, Position, Salary)
Values
(N'Javid', N'Alizada', N'Something', 1000),
(N'Pavid', N'Elizada', N'Something', 1500),
(N'David', N'Ilizada', N'Something', 1600),
(N'Navid', N'Olizada', N'Something', 1700),
(N'Havid', N'Ulizada', N'Something', 1800)

SELECT AVG(Salary) 'AVG Salary' FROM Employees 

SELECT (Name + ' ' + SurName) 'FullName' FROM Employees Where Salary > (SELECT AVG(Salary) FROM Employees)

SELECT MIN(Salary) FROM Employees

SELECT MAX(Salary) FROM Employees
