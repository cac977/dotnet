-- 1. create database
CREATE DATABASE DVDLibrary;

Use DVDLibrary
Create Table DVDLibrary(
	DVDCodeNo int Primary Key,
	DVDTitle nvarchar(100) Not Null,
	[Language] nvarchar(20) Not Null,
	SubTitle bit Not Null,
	Price Money Not Null
)

-- 2. create mylogin user and grant db_owner privilege
CREATE LOGIN mylogin WITH PASSWORD = 'mylogin', CHECK_POLICY = OFF;

-- this command is deprecated
--sp_changedbowner mylogin

ALTER ROLE db_owner ADD MEMBER mylogin; 
GO

--insert sample values (debugging only)
insert into DVDLibrary values (999, 'Test Connect Success', 'English', 1, 10.5);
insert into DVDLibrary values (998, 'Test Connect Success', 'English', 2, 12.5);

--delete sample values
TRUNCATE TABLE DVDLibrary;

--5. read database
SELECT * FROM DVDLibrary;