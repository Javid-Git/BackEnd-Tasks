create database JoinSqlFirst

use JoinSqlFirst

--1 , 2
create table Brands (
Id int constraint PK_brands_id primary key identity,
Name nvarchar(25)
)

insert into Brands(Name)
Values
('Asus'),
('Acer'),
('HP'),
('MSI'),
('Apple'),
('Samsung'),
('Xiaomi')

drop table Notebooks
drop table Brands
drop table Phones

create table Notebooks (
Id int constraint PK_notebooks_id primary key identity,
Name nvarchar(25),
Price money,
BrandId int constraint FK_notebook_brand_id foreign key references Brands(Id)
)

insert into Notebooks(Name, Price, BrandId)
Values
('k52jt', 350, 1),
('Macbook Pro', 2800, 5),
('Nitro-5', 2500, 2),
('Vivobook', 1550, 1),
('Aspire', 1500, 2),
('Pavilion', 800, 3),
('Predator', 2600, 2),
('Macbook Air', 2400, 5),
('Prestige', 3100, 4),
('Raider Dragonshield', 3000, 4),
('Chromebook', 2200, 3)

create table Phones (
Id int constraint PK_phones_id primary key identity,
Name nvarchar(25),
Price money,
BrandId int constraint FK_phone_brand_id foreign key references Brands(Id)
)
insert into Phones(Name, Price, BrandId)
Values
('Note', 500, 6),
('Galaxy S22', 2300, 6),
('Iphone 13', 2600, 5),
('Iphone 12', 2000, 5),
('Poco', 700, 7),
('Redmi', 600, 7),
('Zenfone', 1300, 1),
('Rog Phone', 2000, 1),
('Liquid', 200, 2),
('Elite', 650, 3),
('Iconia', 340, 2)


--3

select (Brands.Name+' '+ Notebooks.Name) as 'BrandName' from Brands
inner join Notebooks on Notebooks.BrandId = Brands.Id

--4

select (Brands.Name+' '+ Notebooks.Name) as 'BrandName' from Brands 
inner join Notebooks on Notebooks.BrandId = Brands.Id where (Brands.Name Like '%s%')

--5

select (Brands.Name+' '+ Notebooks.Name) as 'BrandName' from Brands 
inner join Notebooks on Notebooks.BrandId = Brands.Id where Notebooks.Price between 2000 and 5000 or Notebooks.Price > 5000

--6

select (Brands.Name+' '+ Phones.Name) as 'BrandName' from Brands 
inner join Phones on Phones.BrandId = Brands.Id where Phones.Price between 1000 and 1500 or Phones.Price > 1500

--7

select (Brands.Name+' '+ Notebooks.Name) as 'BrandName' from Brands
inner join Notebooks on Notebooks.BrandId = Brands.Id
join Phones on Phones.BrandId = Brands.Id

--8

select distinct Brands.Name as 'BrandName', (select Count(Notebooks.BrandId) from Notebooks where Notebooks.BrandId = Brands.Id) as 'Amount of Notebooks' from Brands
inner join Notebooks on Notebooks.BrandId = Brands.Id

--9

select distinct Brands.Name as 'BrandName', (select Count(Phones.BrandId) from Phones where Phones.BrandId = Brands.Id) as 'Amount of Phones' from Brands
inner join Phones on Phones.BrandId = Brands.Id

--10

select distinct Brands.Name from Brands
inner join Phones on Phones.BrandId = Brands.Id
join Notebooks on Notebooks.BrandId = Phones.BrandId

--11

select * from Notebooks
union
select * from Phones

--12

select * from Notebooks
join Brands  on BrandId = Brands.Id 
union
select * from Phones
join Brands on BrandId = Brands.Id 

--13

select e.Id, e.Name, e.Price, s.Name as 'BrandName' from Notebooks e
join Brands s  on BrandId = s.Id where e.Price > 1000
union
select a.Id, a.Name, a.Price, s.Name as 'BrandName' from Phones a
join Brands s on BrandId = s.Id where a.Price > 1000

--14

select distinct b.Name as 'BrandName',(select sum(n.Price) from Notebooks n where n.BrandId = b.Id) as 'TotalPrice',  (select Count(n.BrandId) from Notebooks n where n.BrandId = b.Id) as 'TotalCount'  from Brands b
join Notebooks n on n.BrandId = b.Id

--15
select distinct b.Name as 'BrandName',(select sum(p.Price) from Phones p where p.BrandId = b.Id) as 'TotalPrice',  (select Count(p.BrandId) from Phones p where p.BrandId = b.Id) as 'TotalCount'  from Brands b
join Phones p on p.BrandId = b.Id

