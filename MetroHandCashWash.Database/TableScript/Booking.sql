CREATE TABLE Booking (
    BookingId int IDENTITY(1,1) PRIMARY KEY,
    ClientId  int FOREIGN KEY REFERENCES Client(ClientId),
    BookingDateTime DateTime,
	IsConfirmed     bit Not Null DEFAULT 0,
	IsCancelled     bit Not Null DEFAULT 0,
    BookingCode     varchar,
	CreationDate  Datetime,
	ModifiedDate   DateTime,
);
