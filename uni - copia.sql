USE master;
GO
 
IF EXISTS(SELECT * FROM sysdatabases WHERE NAME='univ')
BEGIN
	RAISERROR('Dropping univ',0,1)
	DROP DATABASE univ;
END
GO

CREATE DATABASE univ;
GO

USE univ;
GO

IF db_name()<>'univ'
BEGIN
	RAISERROR('Error to create univ database',22,127) WITH log
	DROP DATABASE univ;
END
GO

CREATE TABLE dbo.deparment
(
deparment_id INT PRIMARY KEY IDENTITY NOT NULL,
descr VARCHAR(32) NOT NULL
);
GO

CREATE TABLE dbo.professor
(
professor_id INT PRIMARY KEY IDENTITY NOT NULL,
last_name VARCHAR(32) NOT NULL,
first_name VARCHAR(32) NOT NULL,
department_id INT REFERENCES deparment(deparment_id),
username VARCHAR(32) NOT NULL,
user_passw VARCHAR(32) NOT NULL,
is_admin INT NOT NULL
);
GO

CREATE TABLE dbo.course
(
course_id INT PRIMARY KEY IDENTITY NOT NULL,
code VARCHAR(32) NOT NULL,
descr VARCHAR(32) NOT NULL,
);
GO

CREATE TABLE dbo.period
(
period_id INT PRIMARY KEY IDENTITY NOT NULL,
descr VARCHAR(32) NOT NULL,
begin_date DATE NOT NULL,
end_date DATE NOT NULL
);
GO

CREATE TABLE dbo.time_block
(
time_block_id INT PRIMARY KEY NOT NULL,
begin_minute INT NOT NULL,
end_minute INT NOT NULL,
descr VARCHAR(32) NOT NULL,
monday VARCHAR(32) NOT NULL,
tuesday  VARCHAR(32) NOT NULL,
wednesday VARCHAR(32) NOT NULL,
thursday VARCHAR(32) NOT NULL,
friday VARCHAR(32) NOT NULL,
saturday VARCHAR(32) NOT NULL
);
GO
CREATE TABLE dbo.classroom
(
classrom_id INT PRIMARY KEY NOT NULL,
descr VARCHAR(32) NOT NULL,
seat_count INT NOT NULL,
has_projector VARCHAR(32) NOT NULL,
building VARCHAR(1) NOT NULL
);
Go
CREATE TABLE dbo.schedule
(
schedule_id INT UNIQUE ,
professor_id INT REFERENCES professor(professor_id),
course_id  INT REFERENCES course(course_id),
period_id INT REFERENCES period(period_id),
time_block_id INT REFERENCES time_block(time_block_id),
classrom_id INT REFERENCES classroom(classrom_id)
);
GO
--SE llena la tabla classrom
INSERT INTO classroom(classrom_id,descr,seat_count,has_projector,building) VALUES(1,101,22,'True','A');
INSERT INTO classroom(classrom_id,descr,seat_count,has_projector,building) VALUES(2,102,20,'True','A');
INSERT INTO classroom(classrom_id,descr,seat_count,has_projector,building) VALUES(3,101,10,'False','B');
--Se llena la tabla course
INSERT INTO course(code,descr) VALUES('ABP01','Programming 1');
INSERT INTO course(code,descr) VALUES('ICS01','Information Systems 1');
INSERT INTO course(code,descr) VALUES('ICS02','Information Systems 2');
INSERT INTO course(code,descr) VALUES('ICG02','Communication System');
INSERT INTO course(code,descr) VALUES('CEP01','Signal Processing');
----SE llena la tabla deparment
INSERT INTO deparment(descr) VALUES('Electrical Enginnering');
INSERT INTO deparment(descr) VALUES('Computer Science');
INSERT INTO deparment(descr) VALUES('Chemistry');
INSERT INTO deparment(descr) VALUES('Math');
INSERT INTO deparment(descr) VALUES('Civil Engineering');
INSERT INTO deparment(descr) VALUES('Managment');
INSERT INTO deparment(descr) VALUES('Arts');
--Se llena la tabla periodo
INSERT INTO period(descr,begin_date,end_date) VALUES('Winter 2014', '1/10/2014 12:00:00 AM','4/11/2014 12:00:00 AM') ;

--se llena la tabla profesor
INSERT INTO professor(last_name,first_name,department_id,username,user_passw,is_admin) VALUES('Orozco','Peter',1,'pete','asd55',0);
INSERT INTO professor(last_name,first_name,department_id,username,user_passw,is_admin) VALUES('Smith','Mary',1,'mary','hola200',1);
INSERT INTO professor(last_name,first_name,department_id,username,user_passw,is_admin) VALUES('Ledesma','Sergio',2,'sergio','2200',0);
INSERT INTO professor(last_name,first_name,department_id,username,user_passw,is_admin) VALUES('Peavler','John',6,'john','bye456',0);
--se llena time block


