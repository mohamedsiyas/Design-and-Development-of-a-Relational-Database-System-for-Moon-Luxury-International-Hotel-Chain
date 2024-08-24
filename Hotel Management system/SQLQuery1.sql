Create database Moon_Luxury_Hotel;

use Moon_Luxury_Hotel;

Create table Guest(
Guest_ID int primary key Not null Identity(1,1),
First_Name varchar(100) Not null,
Last_Name varchar(100) Not null,
Address varchar(100) Not null,
NIC_No varchar(20) Not null, 
Email varchar(300) Not null,
Bed_type varchar(100) Not null
);

insert into Guest values('kumar','kishor','23A madman road,Kalmunai','200221704492','kumar@gmail.com','Double bed')
insert into Guest values('Ajay','raw','56B, Kandy ','197419202757','Ajay30@gmail.com','Single bed')
insert into Guest values('jayasuthan','Sivakumar','20A, marudhainai Colombo','200320508686','jaya10@gmail.com','Double bed')
insert into Guest values('Siva','Villa','234C, aguranai Colombo','200530407689','Siva20@gmail.com','Double bed')
insert into Guest values('arvaindh','Kumar','123A, Mawatha Puttalam','741922757','Ara30@gmail.com','Single bed')

Create table Guest_Phone_No(
Guest_ID int Identity(1,1)Primary key not null,
Phone_No varchar(10) Not null,
foreign key (Guest_ID) References Guest(Guest_ID)
);

insert into Guest_Phone_No values('0772334265')
insert into Guest_Phone_No values('0752045565')
insert into Guest_Phone_No values('0722003040')
insert into Guest_Phone_No values('0724002030')
insert into Guest_Phone_No values('0754334555')

Create table Preferences(
Guest_ID int Identity(1,1)Primary key not null,
Bed_type varchar(100),
Room_view varchar(100),
foreign key (Guest_ID) references Guest (Guest_ID)
);

insert into Preferences values('Double bed','Sea view')
insert into Preferences values('Single bed','Street view')
insert into Preferences values('Double bed','Sea view')
insert into Preferences values('Double bed','Sea view')
insert into Preferences values('Single bed','Street view')

 

SELECT 
    g.Guest_ID, 
    g.First_Name, 
    g.Last_Name, 
    g.Address, 
    g.NIC_No, 
    g.Email, 
    g.Bed_type,
    pn.Phone_No,
    pr.Room_View
FROM Guest g
LEFT JOIN Guest_Phone_No pn
    ON g.Guest_ID = pn.Guest_ID
    ON g.Guest_ID = pr.Guest_ID;
    
SELECT
    G.Guest_ID,
    G.First_Name,
    G.Last_Name,
    G.Address,
    G.NIC_No,
    G.Email,
    G.Bed_type,
    P.Phone_No,
    PR.Room_view AS Preference_Room_View
FROM Guest G
JOIN Guest_Phone_No P ON G.Guest_ID = P.Guest_ID
JOIN Preferences PR ON G.Guest_ID = PR.Guest_ID    


select * from Guest G INNER JOIN Guest_Phone_No G_p_N on G.Guest_ID=G_p_N.Guest_ID

SELECT G.First_Name, G.Last_Name, GP.Phone_No
FROM Guest G
JOIN Guest_Phone_No GP ON G.Guest_ID = GP.Guest_ID

SELECT G.First_Name, G.Last_Name, P.Bed_type, P.Room_view
FROM Guest G
JOIN Preferences P ON G.Guest_ID = P.Guest_ID
