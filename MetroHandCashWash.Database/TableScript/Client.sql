CREATE TABLE Client (
    ClientId int IDENTITY(1,1) PRIMARY KEY,
    LastName  varchar(255) Not null,
    FirstName varchar(255),
	Email     varchar(255), 
	Mobile     varchar(255),  
	CreationDate  Datetime,
	ModifiedDate   DateTime,
	IsActive    bit Not Null DEFAULT 1
);