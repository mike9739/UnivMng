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