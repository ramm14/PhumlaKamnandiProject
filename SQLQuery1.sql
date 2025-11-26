CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY IDENTITY(1,1),
    BookingReference NVARCHAR(50) NOT NULL UNIQUE,
    GuestID INT NOT NULL,
    RoomID INT NOT NULL,
    CheckInDate DATE NOT NULL,
    CheckOutDate DATE NOT NULL,
    NumberOfGuests INT NOT NULL,
    TotalAmount DECIMAL(10,2) NOT NULL,
    DepositAmount DECIMAL(10,2) NOT NULL,
    DepositPaidDate DATETIME NULL,
    BookingStatus INT NOT NULL DEFAULT 0,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
    ModifiedDate DATETIME NOT NULL DEFAULT GETDATE(),
    SpecialRequests NVARCHAR(500) NULL,
    CONSTRAINT FK_Bookings_Guests FOREIGN KEY (GuestID) REFERENCES Guests(GuestID),
    CONSTRAINT FK_Bookings_Rooms FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID),
    CONSTRAINT CHK_CheckOutAfterCheckIn CHECK (CheckOutDate > CheckInDate),
    CONSTRAINT CHK_NumberOfGuests CHECK (NumberOfGuests >= 1 AND NumberOfGuests <= 4)
);

-- Create indexes for better query performance
CREATE INDEX IX_Bookings_GuestID ON Bookings(GuestID);
CREATE INDEX IX_Bookings_RoomID ON Bookings(RoomID);
CREATE INDEX IX_Bookings_CheckInDate ON Bookings(CheckInDate);
CREATE INDEX IX_Bookings_BookingReference ON Bookings(BookingReference);
CREATE INDEX IX_Bookings_BookingStatus ON Bookings(BookingStatus);

-- Update Payments table if needed
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Payments')
BEGIN
    CREATE TABLE Payments (
        PaymentID INT PRIMARY KEY IDENTITY(1,1),
        BookingID INT NOT NULL,
        PaymentDate DATETIME NOT NULL DEFAULT GETDATE(),
        Amount DECIMAL(10,2) NOT NULL,
        PaymentMethod NVARCHAR(50) NOT NULL,
        PaymentStatus NVARCHAR(20) NOT NULL DEFAULT 'Pending',
        TransactionReference NVARCHAR(100) NULL,
        CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
        CONSTRAINT FK_Payments_Bookings FOREIGN KEY (BookingID) REFERENCES Bookings(BookingID)
    );
    
    CREATE INDEX IX_Payments_BookingID ON Payments(BookingID);
END