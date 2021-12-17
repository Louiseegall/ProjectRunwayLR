--Create Database Runway;
Go
use Runway;


IF OBJECT_ID ('StaffAppointment') IS NOT NULL
DROP table StaffAppointment
GO
IF OBJECT_ID ('AppointmentTreatment') IS NOT NULL
DROP table AppointmentTreatment
GO
IF OBJECT_ID ('Appointment') IS NOT NULL
DROP table Appointment
GO
IF OBJECT_ID ('Staff') IS NOT NULL
DROP table Staff
GO
IF OBJECT_ID ('Treatment') IS NOT NULL
DROP table Treatment
GO

IF OBJECT_ID ('Room') IS NOT NULL
DROP table Room
GO
IF OBJECT_ID ('TreatmentType') IS NOT NULL
DROP table TreatmentType
GO
IF OBJECT_ID ('Customer') IS NOT NULL
DROP table Customer
GO

Create Table Login(
UserName VarChar(50) primary key,
UserPassword Varchar(50)
)
insert into login(UserName,UserPassword)
Values('Louisegall@runway.com','Password10$$'),
('Teresa@nwrc.ac.uk','Password10$$')



CREATE TABLE [dbo].[Customer]
(
	CustomerNo			INT				NOT NULL  PRIMARY KEY,
	CustomerTitle		VarChar(4)		NOT Null,
	CustomerForename	VARCHAR(30)		NOT NULL,
	CustomerSurname		VARCHAR(30)		NOT NULL,
	CustomerDOB			DATE			NOT NULL,
	CustomerStreet		VARCHAR(30) 	NOT NULL,
	CustomerTown		VARCHAR(30)		NOT NULL,
	CustomerCounty		VARCHAR(30)		NOT NULL,
	CustomerCountry		VARCHAR(30)		NOT NULL,
	CustomerPostcode	VARCHAR(30)		NOT NULL,
	CustomerTelNo		VARCHAR(15)		NOT NULL,
	CustomerEmail		VARCHAR(50)		NOT NULL,
	
)
insert into Customer(customerNo,CustomerTitle,CustomerForename, CustomerSurname,CustomerDOB, 
CustomerStreet,CustomerTown,CustomerCounty,CustomerCountry,CustomerPostcode
, CustomerTelNo, CustomerEmail)
Values(5000,'Ms','Louise','Gallagher','1996/11/12','Hill View','Letterkenny','Donegal','Ireland','F92 A7D6',
'0861225405','Louise@gmail.com' ),
(5001,'Miss','Laura','Smith','1990/02/01','Moutain Top','Buncranna','Donegal','Ireland','F93 A7H4',
'0863482736','Laura@gmail.com'),
(5002,'Mrs','Sheila','Craig','1978/07/21',' Pine Lake','Ballyshannon','Donegal','Ireland','F98 TTD3',
'0877711533','Sheila@gmail.com' ),
(5003,'Mrs','Georgie','Doherty','1980/05/29','Beach Road','Letterkenny','Donegal','Ireland','F92 KK46',
'0832134876','Georgie@gmail.com' ),
(5004,'Miss','Tina','Ferry','1992/11/05','Castle Park','Buncranna','Donegal','Ireland','F93 YY86',
'0890056783','Tina@gmail.com' ),
(5005,'Mrs','Sarah','Mooney','1991/01/18','Manor Hill','Drumkeen','Donegal','Ireland','F92 TY65',
'089125575','Sarah@gmail.com' ),
(5006,'Mr','Mark','Daniels','1995/01/21','Ard Mor','Newtown','Donegal','Ireland','F92 FC43',
'089918702','Mark@gmail.com'),
(5007,'Mr','Rob','Cannon','1989/08/24','Roads Square','Manor','Donegal','Ireland','F92 TE36',
'0891628736','rob@gmail.com' ),
(5008,'Mrs','Kylie','Clarke','1995/10/18','Beach Mor','Letterkenny','Donegal','Ireland','F92 F553',
'0823456432','KylieCl@yahoo.com'),
(5009,'Miss','Sara','Connell','1996/03/03','Claddagh','Manor','Donegal','Ireland','F93 KK43',
'0812187332','ConSara@gmail.com'),
(5010,'Mr','Max','Gallen','1992/09/08','Thornberry','Letterkenny','Donegal','Ireland','F92 FC43',
'0891827467','MaxGal@gmail.com'),
(5011,'Mrs','Shannon','Doherty','1999/11/20','Wood Land','Drumkeen','Donegal','Ireland','F92 YYT2',
'0852343454','ShannonDob@gmail.com'),
(5012,'Mr','John','Campbell','1991/06/18','Fox Hill','Letterkenny','Donegal','Ireland','F92 TTR8',
'0887653422','johnC@gmail.com'),
(5013,'Miss','Mia','Smith','1995/12/21','Ashfield','Letterkenny','Donegal','Ireland','F92 YYT5',
'0897652434','Mia@gmail.com'),
(5014,'Mrs','Helena','Frawley','1989/07/17','Brooke Meadow','Newtown','Donegal','Ireland','F92 F5TY',
'0871245367','FrawleyHel@gmail.com'),
(5015,'Mr','Johnny','Curley','1998/08/19','Tierlann Heights','Derry','Derry','Ireland',' BT2 33NN',
'089918987','Johnny@gmail.com'),
(5016,'Miss','Chloe','Tolan','1993/01/12','Forest Road','Newtown','Donegal','Ireland','F92 FY43',
'083345702','TolChlo@gmail.com')


CREATE TABLE [dbo].[Staff]
(
	StaffNo			 INT				NOT NULL PRIMARY KEY,
	StaffTitle		 VARCHAR(4)			NOT NULL,
	StaffForename	 VARCHAR(20)		NOT NULL,
	StaffSurname	 VARCHAR(20)		NOT NULL,
	StaffDOB		 DATETIME			NOT NULL,
	StaffStreet		 VARCHAR(40)		NOT NULL,
	StaffTown		 VARCHAR(20)		NOT NULL,
	County			 VARCHAR(20)		NOT NULL,
	Country			 VARCHAR(20)		NOT NULL,
	PostCode		 VARCHAR(20)		NOT NULL,
	TelNo			 VARCHAR(20)		NOT NULL,
	Email			 VARCHAR(40)		NOT NULL,
	EmergencyContact VARCHAR(20)		NOT NULL,		
	Speciality		 VARCHAR(20)		NOT NULL

)
insert into Staff(StaffNo,StaffTitle,StaffForename,StaffSurname,StaffDOB,StaffStreet,
StaffTown,County,Country,PostCode,TelNo,Email,EmergencyContact,Speciality)
Values(1001, 'Mr', 'Ryan', 'Campbell', 02/01/2000, 'Marlborough Road', 'Derry', 'Derry', 'Ireland', 'BT489BH', '02896496431',
'ryan-123@hotmail.co.uk', '07546033351', 'Hairdresser'),
(1002, 'Ms', 'Shannon', 'McAnaney', 03/08/1998, 'Elaghmoore', 'Derry', 'Derry', 'Ireland', 'BT488DE', '02896496431',
'shannonmcananey@yahoo.co.uk', '07764728612', 'Makeup Artist'),
(1003, 'Ms', 'Karla', 'Kelsy', 02/01/2000, 'Marlborough Road', 'Strabane', 'Derry', 'Ireland', 'BT465FH', '02896496431',
'karlak223@hotmail.co.uk', '02896496784', 'Hairdresser'),
(1004, 'Ms', 'Angela', 'Doherty', 02/01/2000, 'Marlborough Road', 'Derry', 'Derry', 'Ireland', 'BT489BH', '02896496431',
'angedoherty3@gmail.com', '02896496181', 'Hairdresser'),
(1005, 'Ms', 'Anne', 'Tifft', 02/01/2000, 'Marlborough Road', 'Belfast', 'Antrim', 'Ireland', 'BT49BH', '02896496431',
'annetifft02@hotmail.com', '02896496308', 'Masseuse'),
(1006, 'Miss', 'Moyra', 'Sheenan', 02/01/2000, 'Marlborough Road', 'Omagh', 'Tyrone', 'Ireland', 'BT529BH', '02896496431',
'moyra-36@hotmail.co.uk', '02896496236', 'Hairdresser'),
(1007, 'Ms', 'Zoie', 'Donahey', 02/01/2000, 'Marlborough Road', 'Letterkenny', 'Donegal', 'Ireland', 'ROI', '02896496431',
'zdonahey002@hotmail.co.uk', '02896496155', 'Makeup Artist'),
(1008, 'Mrs', 'Addison', 'Pratt', 02/01/2000, 'Shantallow', 'Derry', 'Derry', 'Ireland', 'BT489KJ', '02896496431', 
'addipratt3@hotmail.co.uk', '02896496431', 'Nail Tech')




CREATE TABLE [dbo].[TreatmentType]
(
	TreatmentType	INT		NOT NULL Primary Key,
	TreatmentTypeDesc	VARCHAR(30)	NOT NULL,
)
--1-3 deparments ie nails, spa ,hair
insert into TreatmentType(TreatmentType,TreatmentTypeDesc)
Values(1,'Hair'),
(2,'Nails'),
(3,'Spa'),
(4,'Waxing')

CREATE TABLE [dbo].[Room]
(
	RoomNo		INT	NOT NULL	PRIMARY KEY,
	RoomDesc	VARCHAR(15)	NOT NULL,
	TreatmentType int NOT NULL,
    CONSTRAINT [FKTreatmentTypeID] FOREIGN KEY (TreatmentType) REFERENCES TreatmentType(TreatmentType),
)
insert into Room(RoomNo, RoomDesc,TreatmentType)
Values(1, 'Hair',1),
(2, 'Nails',2),
(3, 'Spa ',3),
(4, 'Waxing ',4),
(5,'Hair 2',1)



CREATE TABLE [dbo].[Treatment]
(
	TreatmentNo			INT	NOT NULL primary key,
	TreatmentDesc		varChar(50) not null,
	TreatmentPrice		INT	NOT NULL,
	TreatmentDuration	INT	NOT NULL,
	TreatmentType		INT NOT NULL, 
    CONSTRAINT [FKTreatmentType] FOREIGN KEY (TreatmentType) REFERENCES TreatmentType(TreatmentType),

)
insert into Treatment( TreatmentNo,TreatmentDesc, TreatmentPrice, TreatmentDuration, treatmentType )
Values(500,'wash cut blow dry',35, 1,1), --duration 1 slot =30 mins
(501,'Colour',75, 2,1),
(502,'highlights',35, 1,1),
(503,'Manicure',15, 1,2),
(504,'Pedicure',15, 1,2),
(505,'Manicure & Pedicure',25, 2,2),
(506,'Hot Stone',55, 2,3),
(507,'Massage',30, 1,3),
(508,'Facial',25, 1,3),
(509,'Full Leg',35, 1,4),
(510,'Biniki',45, 1,4),
(511,'Hollywood',65, 2,2)


CREATE TABLE [dbo].[Appointment]
(
	AppointmentNo			INT			NOT NULL	PRIMARY KEY,
	AppointmentTime			TIME	NOT NULL,
	AppointmentDate			DATE	NOT NULL,
	CustomerNo				INT			NOT NULL,

    CONSTRAINT FKCustomerNo FOREIGN KEY (CustomerNo) REFERENCES Customer(CustomerNo), 



)
insert into Appointment(AppointmentNo,AppointmentTime,AppointmentDate, CustomerNo )
Values(10000, '09:00' ,'2021-12-20',5000),
(10001, '10:30' ,'2021-12-20',5001),
(10002, '12:00' ,'2021-12-20',5002),
(10003, '13:30' ,'2021-12-20',5003),
(10004, '16:30', '2021-12-20', 5005),
(10005, '13:30', '2021-12-22', 5006),
(10006, '16:30', '2021-12-21', 5007),
(10007, '09:30', '2021-12-21', 5001),
(10008, '11:30', '2021-12-23', 5004),
(10009, '16:30', '2021-12-23', 5003),
(10010, '12:30', '2021-12-24', 5004),
(10011, '15:00', '2021-12-24', 5002),
(10012, '16:00', '2021-12-24', 5007),
(10013, '12:00', '2021-12-27', 5005),
(10014, '15:00', '2021-12-27', 5006)



create table AppointmentTreatment(


	AppointmentNo	INT			NOT NULL,
	TreatmentNo		INT			NOT NULL,
	
	RoomNo			INT			NOT NULL, 
	TreatmentTime	time		NOT NULL,
	CONSTRAINT FKRoomNo FOREIGN KEY (RoomNo) REFERENCES Room(RoomNo),
	CONSTRAINT FKTreatmentNum FOREIGN KEY (TreatmentNo) REFERENCES Treatment(TreatmentNo),
	CONSTRAINT FKAppointmentNo FOREIGN KEY (AppointmentNo) REFERENCES Appointment(AppointmentNo),
	primary key clustered(TreatmentNo, AppointmentNo)

)
insert into AppointmentTreatment(AppointmentNo, TreatmentNo,RoomNo,TreatmentTime)
Values
(10000,500,1,'09:00'),(10000,501,5,'09:30'),--two treatments that will happen in that one appointment 
(10001,502,1,'10:30'),-- one treatment for one appointment 
(10002,503,2,'12:00'),
(10003,504,2,'13:30'),
(10004 ,505,2,'16:30'),
(10005,506,3,'13:30'),(10005,500,5,'14:30'),(10005,510,4,'15:00'),
(10006 ,507,3,'16:30'),
(10007 ,508,3,'09:30'),
(10008 ,509,4,'11:30'),(10008, 500, 1,'12:00'),(10008,508,3,'12:30'),
(10009 ,510,4,'16:30'),
(10010 ,510,4,'12:30'),
(10011 ,510,5,'15:00'),
(10012 ,501,5,'16:00'),
(10013 ,500,5,'12:00'),(10013,503,2,'12:30'),(10013,509,4,'13:00'),(10013,506,3,'14:00'),
(10014 ,502,5,'15:00')



CREATE TABLE [dbo].[StaffAppointment]
(
	StaffNo			INT		NOT NULL,
	AppointmentNo	INT		NOT NULL,
	AppointmentTime	TIME NOT NULL,
	AppointmentDate DATE NOT NULL,
	TreatmentNo		INT		NOT NULL,
	TreatmentDuration INT NOT NULL,
    CONSTRAINT FKStaffNo FOREIGN KEY (StaffNo) REFERENCES Staff(StaffNo),
	CONSTRAINT FKAppointmentNum FOREIGN KEY (AppointmentNo) REFERENCES Appointment(AppointmentNo),
	CONSTRAINT FKTreatmentNo FOREIGN KEY (TreatmentNo) REFERENCES Treatment(TreatmentNo),
	primary key clustered(staffNo, AppointmentNo, TreatmentNo)
)
insert into StaffAppointment(StaffNo ,AppointmentNo, AppointmentTime, AppointmentDate,TreatmentNo, TreatmentDuration)
Values
(1001,10000,'11:00' ,'2021-12-12', 500, 1),(1002,10000,'11:00' ,'2021-12-12', 501, 2),--two staff doing same appointment
(1001,10001,'11:00', '2022-12-13', 500, 1),
(1003,10002,'10:00','2021-12-15',500, 1),
(1001,10003,'10:30','2022-1-14',500, 1)