CREATE TABLE Reservation (
Reservation_ID int primary key Not null Identity(1,1),
Guest_ID int,
Room_ID int,
Service_ID int,
Check_in_Date date,
Check_out_Date date,
Booking_Date date,
Payment_status varchar(10),
foreign key (Guest_ID) references Guest(Guest_ID),
foreign key (Room_ID) references Room(Room_ID),
foreign key (Service_ID) references Services(Service_ID)
);

insert into Reservation values(1,1,1,'2023.05.20','2023.05.25','2023.05.21','Paid')
insert into Reservation values(2,2,2,'2023.04.19','2023.04.25','2023.04.20','Un Paid')
insert into Reservation values(3,3,3,'2023.07.05','2023.07.07','2023.07.06','Paid')
insert into Reservation values(4,4,4,'2023.04.20','2023.04.25','2023.04.21','Un Paid')
insert into Reservation values(5,5,5,'2023.09.07','2023.09.13','2023.09.11','Paid')

select * from Reservation 

SELECT R.Reservation_ID, R.Guest_ID, R.Room_ID, R.Service_ID, R.Check_in_Date, R.Check_out_Date, R.Booking_Date, R.Payment_status, 
       G.First_Name + ' ' + G.Last_Name as GuestName, 
       Ro.Room_type, 
       S.Service_Name 
FROM Reservation R 
JOIN Guest G ON R.Guest_ID = G.Guest_ID 
JOIN Room Ro ON R.Room_ID = Ro.Room_ID 
JOIN Services S ON R.Service_ID = S.Service_ID;

SELECT RD.Reservation_ID, R.Room_type, RD.No_of_Days, RD.Room_charges, S.Service_Name, RD.Service_charges, RD.Taxes
FROM Reservation_Details RD
JOIN Room R ON RD.Room_ID = R.Room_ID
JOIN Services S ON RD.Service_ID = S.Service_ID
WHERE RD.Reservation_ID = 1

SELECT G.Guest_ID, G.First_Name, G.Last_Name, R.Reservation_ID, R.Check_in_Date, R.Check_out_Date
FROM Guest G
INNER JOIN Reservation R ON G.Guest_ID = R.Guest_ID;

SELECT R.Reservation_ID, G.First_Name, G.Last_Name, Ro.Room_type, S.Service_Name
FROM Reservation R
INNER JOIN Guest G ON R.Guest_ID = G.Guest_ID
INNER JOIN Room Ro ON R.Room_ID = Ro.Room_ID
LEFT JOIN Services S ON R.Service_ID = S.Service_ID;

SELECT R.Reservation_ID, B.Total_Payment
FROM Reservation R
INNER JOIN Bill B ON R.Reservation_ID = B.Reservation_ID;

SELECT R.Reservation_ID, G.First_Name, G.Last_Name, RD.Room_charges, RD.Service_charges
FROM Reservation R
INNER JOIN Reservation_Details RD ON R.Reservation_ID = RD.Reservation_ID
INNER JOIN Guest G ON R.Guest_ID = G.Guest_ID;

