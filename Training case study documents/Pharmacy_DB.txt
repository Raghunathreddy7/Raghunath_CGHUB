create table drugs(drugId int IDENTITY(1,1) PRIMARY KEY,drugName varchar(320),Quantity int,price float,expiryDate date,supplierId int  FOREIGN KEY REFERENCES supplier(supplierId));

drop table drugs;
drop table orderDetails;
drop Supplier;
2
drop FinalDb;

Alter table FinalDb  add IsPicked varchar(20);

create table Supplier(supplierId int IDENTITY(1,1) PRIMARY KEY,supplierName varchar(120),supplierEmail varchar(120),supplierContact Bigint);

create table [User](userId int IDENTITY(1,1) PRIMARY KEY,userName varchar(30),UserContact Bigint,userAddress varchar(120), userEmail varchar(120),userPassword varchar(20));




create table FinalDb(orderId int IDENTITY(1,1) PRIMARY KEY,userId int FOREIGN KEY REFERENCES [User](userId),userName varchar(30),  drugId int FOREIGN KEY REFERENCES drugs(drugId),
  drugName varchar(20),userEmail varchar(100) ,quantity int,price float,totalPrice float,drugExp date,OrderDate varchar(40),IsPicked varchar(20))

  insert into Supplier  values('raghu','raghu450@gmail.com',7815862556);
insert into Supplier values('Somesh','somesh@gmail.com',7815862544);
insert into Supplier values('Mahesh','mahesh@gmail.com',7815862887);
insert into Supplier values('Arya','arya23@gmail.com',7815862444);
insert into Supplier values('Sai','sai765@gmail.com',7815862458);
insert into Supplier values('Hemanth','hemanth@gmail.com',7815862419);
insert into Supplier values('Deelip','deelip353@gmail.com',9845862556);
insert into Supplier values('Giri','giriprasad34@gmail.com',8495862556);
insert into Supplier values('Manoj','manoj932@gmail.com',8425862556);
insert into Supplier values('Pandu','pandu8284@gmail.com',9255862556);
insert into Supplier values('Vinay','vinay643@gmail.com',7845862556);

insert into drugs values('dolo234',230,12.5,'2024-05-21',1); 
insert into drugs values('Ciprofloxacin',500,10.2,'2024-07-24',2); 
insert into drugs values('Doxycycline',450,20.0,'2024-04-07',4); 
insert into drugs values('Jardiance',500,12.65,'2024-03-21',3);
 insert into drugs values('Kevzara',300,25.97,'2024-07-16',2); 
 insert into drugs values('Amitriptyline',450,20.0,'2024-05-13',9);
  insert into drugs values('Entyvio',350,17.0,'2023-09-27',5); 
  insert into drugs values('Lexapro',250,22.34,'2023-11-15',6);
   insert into drugs values('Meloxicam',400,8.0,'2023-04-18',7); 
   insert into drugs values('Fentanyl',350,15.0,'2023-05-23',10);