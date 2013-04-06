IF(db_id('team_up')) IS NULL
BEGIN
	CREATE DATABASE team_up
END

USE team_up

CREATE TABLE Profile(
ID INT PRIMARY KEY,
Name VARCHAR(255),
Email VARCHAR(255),
)

CREATE TABLE ProfileServices(
ProfileID INT,
ServiceID INT,
Email VARCHAR(255) 
)

CREATE TABLE Project(
ID INT,
ProfileID INT,
Name VARCHAR(255),
LastUpdated DATETIME,
CreationDate DATETIME,
DueDate DATETIME
)

CREATE TABLE Task(
ID INT,
ProjectID INT,
Content VARCHAR(255),
DueDate DATETIME
)

CREATE TABLE Changes(
ID INT,
ProfileID INT,
ProjectID INT,
TaskID INT,
Comment VARCHAR(255)
)