create database Consts
use Consts

drop table Employees
drop table Departments


create table Departments(
PK_Id int not null primary key,
Name nvarchar(50) not null check(LEN(Name)>3)
)

create table Employees(
Id int not null unique, 
FullName nvarchar(50) not null check(LEN(FullName)>3), 
Salary decimal check(Salary>=0), 
Email nvarchar(100) not null unique,
FK_DepartmentId int not null foreign key references Departments(PK_Id)
)

