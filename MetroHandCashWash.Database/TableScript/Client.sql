CREATE TABLE Client (
    ClientId int IDENTITY(1,1) PRIMARY KEY,
    LastName  varchar(255) Not null,
    FirstName varchar(255),
	Password varchar(500) Not null,
	Email     varchar(255) Not null,
	Mobile     varchar(255),  
	CreationDate  Datetime,
	ModifiedDate   DateTime,
	IsActive    bit Not Null DEFAULT 1
);