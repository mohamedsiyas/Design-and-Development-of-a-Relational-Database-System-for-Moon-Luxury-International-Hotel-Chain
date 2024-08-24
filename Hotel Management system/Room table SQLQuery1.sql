Create table Room(
Room_ID int primary key Not null Identity(1,1),
Room_type varchar(50),
Room_availability varchar(20)
);

insert into Room values ('AC','Available')
insert into Room values ('Non-AC','Available')
insert into Room values ('AC','Not Available')
insert into Room values ('AC','Available')
insert into Room values ('Non-AC','Not Available')

Create table Room_Price(
Room_type varchar(50) primary key, 
Price decimal(10,2),
);

insert into Room_Price values('AC',10000)
insert into Room_Price values('Non-AC',5000)


select * from Room

SELECT R.Room_ID, R.Room_type, R.Room_availability, P.Price
FROM Room R
JOIN Room_Price P ON R.Room_type = P.Room_type

SELECT R.Room_ID, R.Room_type, RP.Price
FROM Room R
JOIN Room_Price RP ON R.Room_type = RP.Room_type
WHERE R.Room_availability = 'Available'

select Room_ID, Room_type, Room_availability
from Room
where Room_availability = 'Not Available'

SELECT R.Room_ID, R.Room_type, R.Room_availability, P.Price
FROM Room R
JOIN Room_Price P ON R.Room_type = P.Room_type
WHERE R.Room_availability = 'Available'
AND R.Room_ID NOT IN (
    SELECT Room_ID
    FROM Reservation
    WHERE Check_in_Date <= '2023.05.20'
    AND Check_out_Date >= '2023.05.25'
);

SELECT G.Guest_ID, G.First_Name, G.Last_Name, R.Check_in_Date, R.Check_out_Date
FROM Guest G
JOIN Reservation R ON G.Guest_ID = R.Guest_ID
WHERE R.Reservation_ID = 1

SELECT R.Reservation_ID, SUM(RD.Room_charges + RD.Service_charges + RD.Taxes) AS TotalExpenses
FROM Reservation R
JOIN Reservation_Details RD ON R.Reservation_ID = RD.Reservation_ID
WHERE R.Reservation_ID = 2
GROUP BY R.Reservation_ID;

CREATE PROCEDURE AllocateRoom
    @GuestID INT,
    @RoomID INT,
    @ServiceID INT,
    @CheckInDate DATE,
    @CheckOutDate DATE,
    @BookingDate DATE,
    @PaymentStatus VARCHAR(10)
AS
BEGIN
    DECLARE @ReservationID INT;

    INSERT INTO Reservation (Guest_ID, Room_ID, Service_ID, Check_in_Date, Check_out_Date, Booking_Date, Payment_status)
    VALUES (@GuestID, @RoomID, @ServiceID, @CheckInDate, @CheckOutDate, @BookingDate, @PaymentStatus);

    SET @ReservationID = SCOPE_IDENTITY();

    -- Additional logic for updating room availability, creating bills, etc.

    -- Return the ReservationID for reference
    SELECT @ReservationID AS ReservationID;
END;