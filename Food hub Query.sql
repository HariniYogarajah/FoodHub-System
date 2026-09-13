
CREATE DATABASE FoodHub;

USE FoodHub;

CREATE TABLE Customer
(Cus_ID INT IDENTITY (1,1) PRIMARY KEY,
Cus_Name VARCHAR (50) NOT NULL,
NIC INT NOT NULL,
DOB DATE NOT NULL,
Loc_Number INT NOT NULL,
Lane VARCHAR (50) NOT NULL,
City VARCHAR (50) NOT NULL,
Street VARCHAR (50) NOT NULL);

INSERT INTO Customer (Cus_Name,NIC,DOB,Loc_Number,Lane,City,Street)VALUES
('Thiru',2000128456,'03-30-2000',20,'Temple lane','Matale','Main street'),
('Kumar',2008137450,'01-20-2008',55,'Boundary road','Batticaloa','Park Street'),
('Madhu',2003143815,'05-10-2003',60,'Lake road','Kandy','Garden street');

SELECT * from Customer

DROP DATABASE  FoodHub;

ALTER TABLE Customer
ADD CONSTRAINT CHK_Loc_Number CHECK (Loc_Number > 0);

ALTER TABLE Customer
ADD CONSTRAINT UQ_Customer_NIC UNIQUE (NIC);

INSERT INTO Customer (Cus_Name,NIC,DOB,Loc_Number,Lane,City,Street)VALUES
('Kiru',1998346515,'07-20-1998',13,'UpStair Road','Kalmunai');

SELECT * FROM Customer;

ALTER TABLE Customer
ALTER COLUMN Cus_Name VARCHAR(50) NOT NULL;

ALTER TABLE Customer ADD Email VARCHAR(50);

DROP TABLE Customer;

DROP DATABASE FoodHub;

TRUNCATE TABLE Customer;

UPDATE Customer SET Cus_Name ='Ravi',NIC =2004109763,DOB ='03-30-2004',Loc_Number =10,Lane ='Beach road',Street ='lake street',City ='Colombo'  WHERE Cus_ID = 3;
  
DELETE from Customer WHERE Cus_ID = 3;

SELECT * FROM Customer WHERE City='Kandy';

SELECT * FROM Customer WHERE City='Kandy' AND Street='Garden street';

SELECT * FROM Customer WHERE DOB ='01-20-2008' OR DOB='02-10-2005';

SELECT * FROM Customer WHERE NOT NIC=2000128456;

SELECT * FROM Customer WHERE Loc_Number=20 AND (Cus_Name='Thiru' OR DOB='11-08-2004');

SELECT * FROM Customer WHERE NOT Cus_Name='Madhu' AND NOT Cus_Name='Kumar';

SELECT TOP 50 PERCENT * FROM Customer;

SELECT TOP 3 * FROM Customer WHERE City='Matale';

SELECT * FROM Customer WHERE Cus_Name  LIKE 'K%';

SELECT * FROM Customer WHERE Cus_Name NOT LIKE 'T%';

SELECT * FROM Customer WHERE City IN ('Matale','Batticaloa');

SELECT * FROM Customer WHERE Loc_Number BETWEEN 50 AND 70 ;

EXEC sp_rename 'Customer', 'myCustomer';

SELECT * FROM myCustomer

EXEC sp_rename 'myCustomer.Cus_ID', 'CustomerID', 'COLUMN';

SELECT * FROM Customer ORDER BY City;

SELECT * FROM Customer ORDER BY City DESC;

SELECT COUNT(Cus_ID) AS CustomersCount, City 
FROM Customer GROUP BY City;

SELECT COUNT(Cus_ID) AS CustomersCount, City 
FROM Customer GROUP BY City HAVING COUNT(Cus_ID) >= 1;

TRUNCATE TABLE Customer;

SELECT COUNT(Cus_ID) AS TotalCustomers FROM Customer;

SELECT COUNT(*) AS TotalRows FROM Customer;

CREATE TABLE Food_Item
(Item_Number INT IDENTITY (1,1) PRIMARY KEY,
Item_Name VARCHAR (50) NOT NULL,
Item_Category VARCHAR (50) NOT NULL,
Price Float NOT NULL);

SELECT * FROM Food_Item WHERE Price= 1500.00;

select * from Food_Item;

INSERT INTO Food_Item(Item_Name,Item_Category,Price)VALUES
('Pizza','Fastfood',2000.00),
('Brownie','Dessert',1500.00),
('Juice','Beverage',500.00);


DELETE FROM Food_Item;

SELECT * from Food_Item

UPDATE Food_Item SET Item_Name='Burger',Item_Category='Fastfood',Price= 1700 WHERE Item_Number =1;

DELETE from Food_Item WHERE Item_Number =2;

SELECT AVG(Price) AS PriceAverage FROM Food_Item;

SELECT MAX(Price) AS HighestPrice FROM Food_Item;

SELECT MIN(Price) AS LowestPrice FROM Food_Item;

SELECT SUM(Price) AS TotalItemsOrdered FROM Food_Item;

CREATE TABLE Ingredient
(Ing_ID INT IDENTITY (1,1) PRIMARY KEY,
Ing_Name VARCHAR (50) NOT NULL,
Quantity INT NOT NULL);

INSERT INTO Ingredient (Ing_Name,Quantity)VALUES
('Cheese',100),
('Tomato',100),
('sause',100),
('Coco powder',40),
('butter',40),
('nuts',40),
('Sugar',15),
('water',15),
('milk',15);

SELECT * from Ingredient

UPDATE Ingredient SET Ing_Name ='moyanis', Quantity =150  WHERE Ing_ID = 2;

DELETE from Ingredient WHERE  Ing_ID= 3;

CREATE TABLE Staff
(Emp_ID INT IDENTITY (1,1) PRIMARY KEY,
Empt_Name VARCHAR (50) NOT NULL,
DOB DATE NOT NULL,
Age INT NOT NULL,
NIC INT NOT NULL,
Contact_No INT NOT NULL,
User_Name VARCHAR (50) NOT NULL,
Password VARCHAR (50) NOT NULL);

INSERT INTO Staff(Empt_Name,DOB,Age,NIC,Contact_No,User_Name,Password)VALUES
('Ravi','03-15-2000',25,2000656743,0775366356,'Ravi123','ravi@123'),
('Aisha','11-10-2002',22,2002789017,0775647653,'Aisha02','aisha@02'),
('Rose','09-01-2001',24,2001400376,0774362516,'Rose678','rose@678');

SELECT * from Staff

UPDATE Staff SET Empt_Name='john',DOB= '08-16-2002',Age= 23,NIC =2002568788,Contact_No =0776894345,User_Name='john345',Password='john@789' WHERE Emp_ID=3;

DELETE from Staff WHERE  Emp_ID= 3;

CREATE TABLE Rider
(Emp_No INT IDENTITY (1,1) PRIMARY KEY,
First_Name VARCHAR (50) NOT NULL,
Middle_Name VARCHAR (50) NOT NULL,
Last_Name VARCHAR (50) NOT NULL,
DOB DATE NOT NULL,
Age INT NOT NULL,
NIC INT NOT NULL,
Contact_No INT NOT NULL,
Lic_No VARCHAR (50) NOT NULL,
Address VARCHAR (50) NOT NULL,
User_Name VARCHAR (50) NOT NULL,
Password VARCHAR (50) NOT NULL);

INSERT INTO Rider(First_Name,Middle_Name,Last_Name,DOB,Age,NIC,Contact_No,Lic_No,Address,User_Name,Password)VALUES
('Daniel','James','Miller','03-12-2000',25,2000896602,0777834612,'L0060','10,Bar road, Batticaloa','Miller5','miller@5'),
('Nadarajan','Lakshmi','Priya','09-18-2001',24,2001747734,0778453210,'L0055','25,Garden road, kandy','Priya34','priya@34'),
('Mohammed','Rahman','Ali','11-01-2002', 22,2002811034,0779043705,'L0018','55,Park road,Colombo','Ali6789','ali@6789');

SELECT COUNT(Emp_No) AS Ridercount, Address 
FROM Rider GROUP BY Address HAVING COUNT(Emp_No) >= 1;


SELECT COUNT(Emp_No) AS RiderssCount, Address 
FROM Rider GROUP BY Address;

SELECT * FROM Rider WHERE Age IN (24,22);

SELECT * FROM Rider WHERE Age BETWEEN 25 AND 30 ;

SELECT * from Rider

UPDATE Rider SET First_Name= 'John',Middle_Name ='Michael',Last_Name='Doe', DOB ='05-04-2006',Age='19',NIC =2006894365,Contact_No=0767893210,Lic_No='L0015',Address='30,beach road,Jaffna',User_Name='john45',Password='john@65' WHERE Emp_No=1;

DELETE from Rider WHERE  Emp_No=2;

CREATE TABLE Theme
(Theme_ID INT IDENTITY (1,1) PRIMARY KEY,
Colour  VARCHAR (50) NOT NULL);

INSERT INTO Theme(Colour)VALUES
('Green'),
('Yellow'),
('Brown');

SELECT * FROM Theme ORDER BY Colour;

SELECT * from Theme

UPDATE Theme SET Colour='Pink' WHERE Theme_ID =2;

DELETE from Theme WHERE Theme_ID =3;

CREATE TABLE Contact
(Contact_ID INT IDENTITY (1,1) PRIMARY KEY,
Phone_No INT NOT NULL,
Cus_ID INT FOREIGN KEY REFERENCES Customer(Cus_ID));

INSERT INTO Contact(Phone_No,Cus_ID)VALUES
(0772367891,1),
(0769812653,1),
(0774637466,2),
(0778524638,3);

SELECT * from Contact

UPDATE Contact SET Phone_No=0765790087 WHERE  Contact_ID=2;

DELETE from Contact WHERE Contact_ID =1;

CREATE TABLE Orders
(Order_No INT IDENTITY (1,1) PRIMARY KEY,
Order_Status VARCHAR (50) NOT NULL,
Order_Time TIME NOT NULL,
Order_Date DATE NOT NULL,
Payment VARCHAR (50) NOT NULL,
Dispat_Time TIME NOT NULL,
Cus_ID INT FOREIGN KEY REFERENCES Customer(Cus_ID),
Emp_ID INT FOREIGN KEY REFERENCES Staff(Emp_ID),
Emp_No INT FOREIGN KEY REFERENCES Rider(Emp_No));

INSERT INTO Orders(Order_Status,Order_Time,Order_Date,Payment,Dispat_Time,Cus_ID,Emp_ID,Emp_No)VALUES
('Delivered','04:24:20','12-10-2025','cash','05:00:00',1,1,1),
('Processing','08:15:10','08-11-2025','card','09:20:25',2,2,2),
('Tracking','09:10:30','09-30-2025','cash','10:25:30',3,3,3);

SELECT * from Orders

UPDATE Orders SET Order_Status='Processing',Order_Time='03:15:10',Order_Date='05-04-2025',Payment='card',Dispat_Time='04:30:10',Cus_ID=2,Emp_ID=4,Emp_No=2 WHERE Order_No=5;

DELETE from Orders WHERE Order_No =3;

CREATE TABLE Order_Food_Item
(OFI_No INT IDENTITY (1,1) PRIMARY KEY,
Item_Number INT FOREIGN KEY REFERENCES Food_Item(Item_Number),
Order_No INT FOREIGN KEY REFERENCES Orders(Order_No));

INSERT INTO Order_Food_Item(Item_Number,Order_No)VALUES
(1,1),
(2,2),
(3,3);

SELECT * from Order_Food_Item 

TRUNCATE TABLE Order_Food_Item;

UPDATE Order_Food_Item SET Item_Number=2,Order_No=5 WHERE OFI_No =2;

DELETE from Order_Food_Item WHERE OFI_No =3;

CREATE TABLE Fooditem_Ing
(FiI_No INT IDENTITY (1,1) PRIMARY KEY,
Ing_ID INT FOREIGN KEY REFERENCES Ingredient(Ing_ID),
Item_Number INT FOREIGN KEY REFERENCES Food_Item(Item_Number));

INSERT INTO Fooditem_Ing(Ing_ID,Item_Number)VALUES
(1,1),
(2,1),
(3,1),
(4,2),
(5,2),
(6,2),
(7,3),
(8,3),
(9,3);

SELECT * from Fooditem_Ing

UPDATE  Fooditem_Ing SET Ing_ID=3, Item_Number=1 WHERE FiI_No =2;

DELETE from Fooditem_Ing WHERE FiI_No =3;

DROP TABLE Fooditem_Ing;

CREATE TABLE Motor_Bike_Rider
(MBR_ID INT IDENTITY (1,1) PRIMARY KEY,
Date DATE NOT NULL,
Start_MeterReading INT NOT NULL,
End_MeterReading INT NOT NULL,
Emp_No INT FOREIGN KEY REFERENCES Rider(Emp_No),
Register_No INT FOREIGN KEY REFERENCES Motor_Bike(Register_No));

INSERT INTO Motor_Bike_Rider(Date,Start_MeterReading,End_MeterReading,Emp_No,Register_No)VALUES
('09-05-2025',1200,1500,1,1),
('08-10-2025',800,1300,2,2),
('07-20-2025',500,1000,3,3);

SELECT * from Motor_Bike_Rider

UPDATE Motor_Bike_Rider  SET Date='10-03-2006',Start_MeterReading=2000,End_MeterReading=2500,Emp_No=3,Register_No= WHERE MBR_ID =2;

DELETE from Motor_Bike_Rider WHERE  MBR_ID=3;

CREATE TABLE Dependent
(Dep_Name VARCHAR (50) NOT NULL,
DOB DATE NOT NULL,
Relationship VARCHAR (50) NOT NULL,
Emp_No INT FOREIGN KEY REFERENCES Rider(Emp_No));

INSERT INTO Dependent(Dep_Name,DOB,Relationship,Emp_No)VALUES
('Ben','02-10-2002','Husband',1),
('Asha','06-05-2000','Wife',2),
('John','03-19-2001','Brother',3);

SELECT * from Dependent

UPDATE Dependent SET DOB='11-08-2000',Relationship='sister',Emp_No=1  WHERE Dep_Name='Asha';

DELETE from Dependent WHERE  Dep_Name='Ben';

CREATE TABLE Motor_Bike
(Register_No INT IDENTITY (1,1) PRIMARY KEY,
Veg_Reg_Date DATE NOT NULL,
Brand VARCHAR (50) NOT NULL,
Model VARCHAR (50) NOT NULL,
Engine_No INT NOT NULL,
Colour VARCHAR (50) NOT NULL,
Theme_ID INT FOREIGN KEY REFERENCES Theme(Theme_ID));

INSERT INTO Motor_Bike(Veg_Reg_Date,Brand,Model,Engine_No,Colour,Theme_ID)VALUES
('10-23-2010','Honda','B123',1,'Black',1),
('05-12-2011','Yamaha','FZ_S',2,'Blue',2),
('03-30-2017','Bajaj','Pulsar',3,'Red',3);

SELECT * from Motor_Bike

UPDATE Motor_Bike SET Veg_Reg_Date='06-09-2000', Brand='KTM',Model='RC125',Engine_No=3,Theme_ID=3 WHERE Register_No=8  ;

DELETE from Motor_Bike WHERE Register_No =7;

SELECT c.Cus_Name, c.City, o.Order_No, o.Order_Date, o.Order_Status FROM Customer c
INNER JOIN Orders o ON c.Cus_ID = o.Cus_ID;

SELECT c.Cus_Name, o.Order_No FROM Customer c
LEFT JOIN Orders o ON c.Cus_ID = o.Cus_ID;

SELECT r.First_Name, r.Last_Name, mbr.Date, mbr.Start_MeterReading, mbr.End_MeterReading FROM Rider r 
RIGHT JOIN Motor_Bike_Rider mbr ON r.Emp_No = mbr.Emp_No;

SELECT  c.Cus_Name, c.City, f.Item_Name, f.Price FROM Customer c
FULL OUTER JOIN Orders o  ON c.Cus_ID = o.Cus_ID
FULL OUTER JOIN Food_Item f ON o.Order_No = f.Item_Number;


USE master;

CREATE LOGIN mylogin WITH PASSWORD = '123';

USE FoodHub;

CREATE USER newadmin FOR LOGIN mylogin;

GRANT SELECT ON Customer TO newadmin;

USE FoodHub;

SELECT USER_NAME() AS CurrentDatabaseUser, SUSER_SNAME() AS Currentlogin;

SELECT * from Customer;

SELECT * from Rider






