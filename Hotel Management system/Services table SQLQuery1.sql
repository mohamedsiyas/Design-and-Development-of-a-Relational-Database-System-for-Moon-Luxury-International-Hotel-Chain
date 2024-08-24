Create table Services(
Service_ID int primary key Not null Identity(1,1),
Service_Name varchar(100),
Price decimal(10,2)
); 

insert into Services values('Meals',1500)
insert into Services values('spa',2000)
insert into Services values('Poolside bar',1000)
insert into Services values('Swimming pool',3000)
insert into Services values('Gym',3500)

select * from Services

