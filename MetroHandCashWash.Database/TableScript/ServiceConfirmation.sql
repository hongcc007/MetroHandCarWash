CREATE TABLE ServiceConfirmation(
    ServiceId int IDENTITY(1,1) PRIMARY KEY,
    BookingId  int,
    ServiceDateTime DateTime,
	IsServiceCompleted     bit Not Null DEFAULT 0,
    Cost     decimal,
	IsWalkedIn     bit Not Null DEFAULT 0,
	CreationDate  Datetime,
	ModifiedDate   DateTime,
);