use MASTER;
GO

DROP DATABASE BANK2019;
CREATE DATABASE BANK2019;

USE BANK2019;
GO


CREATE TABLE ADDRESS 
(
	ID integer identity(1,1) primary key,
	STATE nvarchar(20) not null,
	CITY nvarchar(30) not null,
	STREET nvarchar(40) not null,
	HOUSE nvarchar(20) not null,
	HOUSING nvarchar(20) default ('-'),
	FLAT integer not null
)
CREATE TABLE CLIENTS
(
	ID integer identity(1,1) primary key,
	ID_ADDRESS integer foreign key REFERENCES ADDRESS(ID),
	SURNAME nvarchar(20) not null,
	FIRSTNAME nvarchar(20) not null,
	FATHERSNAME nvarchar(20) not null,
	ID_PASSPORT nvarchar(20) not null unique,
	BDAY date not null,
	GENDER char(1) CHECK (GENDER in ('м', 'ж')),
	PHONE nvarchar (20) not null unique,
	MYBALANCE decimal(15,2) foreign key REFERENCES BALANCE(ID)
)
CREATE TABLE USERS
(
	ID integer identity(1,1) primary key,
	ID_CLIENTS integer foreign key REFERENCES CLIENTS(ID),
	LOGIN nvarchar(20) not null,
	PASSWORD nvarchar(40) not null
)


CREATE TABLE BALANCE
(
	ID integer identity(1,1) primary key,
	MYCOUNT nvarchar(20),
	BALANCE DECIMAL(15,2)  not null
)

CREATE TABLE TRANSFER
(
	ID integer identity(1,1) primary key,
	MYID integer foreign key REFERENCES CLIENTS(ID),
	TOIDBALANCE nvarchar(20) foreign key REFERENCES CLIENTS(ID_PASSPORT),
	SUMMA decimal(15,2),
	DATE_TRANSFER datetime
)
CREATE TABLE DEPOSIT
(
	ID integer identity(1,1) primary key,
	MYID integer foreign key REFERENCES CLIENTS(ID),
	SUMMA decimal(15,2) not null,
	DATE_DEPOSIT datetime not null,
	STAVKA decimal(15,2) not null,
	DAYS int not null,
	DATE_FINISH as (dateadd(dd, DAYS, DATE_DEPOSIT))
)

INSERT INTO ADDRESS(STATE, CITY, STREET, HOUSE, HOUSING, FLAT)
	VALUES ('Беларусь', 'Минск','Наполеона Орды', '31', '-', 24),
		   ('Беларусь', 'Минск','Наполеона Орды', '30', '-', 25),
		   ('Беларусь', 'Минск','Яна Чечота', '231', '1', 123)
INSERT INTO CLIENTS(SURNAME, FIRSTNAME, FATHERSNAME, ID_ADDRESS, ID_PASSPORT, BDAY, GENDER, PHONE)
	VALUES  ('Стальмашенко', 'Анастасия', 'Павловна', 1,'20124391203021242553', '1992-02-11', 'ж', '80291242133'),
			('Дубень', 'Полина', 'Васильевна', 2,'32012439121321242553', '1990-05-01', 'ж', '80292242133')
INSERT INTO BALANCE(MYCOUNT, BALANCE)
VALUES  ('20124391203021242553', 4102.12),
		('32012439121321242553', 11232.12)
INSERT INTO USERS(ID_CLIENTS, LOGIN, PASSWORD)
VALUES (1, 'Stalmashenko', 'Stalmashenko'),
	   (2, 'Pomazafa', 'Polyashka')
INSERT INTO DEPOSIT(MYID, SUMMA, STAVKA, DATE_DEPOSIT, DAYS)
VALUES (1, 320101, 10.21,  SYSDATETIME(), 20);
SELECT * FROM ADDRESS;
SELECT * FROM CLIENTS;
SELECT * FROM BALANCE
SELECT * FROM DEPOSIT;
SELECT * FROM USERS;


SELECT C.FIRSTNAME имя, C.SURNAME фамилия, C.ID_PASSPORT мой_счёт, OP.DATE_OPERATION дата_операции, OP.SUM_OPERATION сумма, OP.TOIDBALANCE счет_получателя, OP.TYPE_OPERATION тип_операции
FROM OPERATION OP INNER JOIN CLIENTS C
ON OP.MYID=C.ID_CLIENTS