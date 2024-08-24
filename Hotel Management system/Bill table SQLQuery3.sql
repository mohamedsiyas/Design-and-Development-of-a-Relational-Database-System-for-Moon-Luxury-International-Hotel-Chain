Create table Bill(
Bill_ID int primary key Not null Identity(1,1),
Reservation_ID int,
Total_Payment decimal(10,2),
foreign key (Reservation_ID) references Reservation(Reservation_ID)
);

insert into Bill (Reservation_ID, Total_Payment) values(1,45650)
insert into Bill (Reservation_ID, Total_Payment) values(2,28600)
insert into Bill (Reservation_ID, Total_Payment) values(3,12650)
insert into Bill (Reservation_ID, Total_Payment) values(4,47300)
insert into Bill (Reservation_ID, Total_Payment) values(5,14850)

Create table Reservation_Details(
Reservation_ID int,
Service_ID int,
Room_ID int,
No_of_Days int,
Room_charges decimal(10,2),
Service_charges decimal(10,2),
Taxes Decimal(4,2)
foreign key (Reservation_ID) references Reservation(Reservation_ID),
FOREIGN KEY (Service_ID) references Services(Service_ID),
foreign key (Room_ID) references Room(Room_ID) 
);

insert into Reservation_Details values(1,1,1,4,40000,1500,0.1)
insert into Reservation_Details values(2,2,2,5,25000,1500,0.1)
insert into Reservation_Details values(3,3,3,1,10000,1500,0.1)
insert into Reservation_Details values(4,4,4,4,40000,3000,0.1)
insert into Reservation_Details values(5,5,5,2,10000,3500,0.1)

select * from Reservation_Details

SELECT B.Bill_ID, B.Reservation_ID, R.Service_ID, R.Room_ID, RD.No_of_Days, RD.Room_charges, RD.Service_charges, RD.Taxes, B.Total_Payment
FROM Bill B
JOIN Reservation_Details RD ON B.Reservation_ID = RD.Reservation_ID
JOIN Reservation R ON B.Reservation_ID = R.Reservation_ID;



