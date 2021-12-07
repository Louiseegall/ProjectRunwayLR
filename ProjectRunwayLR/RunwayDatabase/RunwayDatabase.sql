--Create Database Runway;
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
IF OBJECT_ID ('TreatmentType') IS NOT NULL
DROP table TreatmentType
GO
IF OBJECT_ID ('Room') IS NOT NULL
DROP table Room
GO
IF OBJECT_ID ('Customer') IS NOT NULL
DROP table Customer
GO

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
'0891628736','rob@gmail.com' )


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


CREATE TABLE [dbo].[Room]
(
	RoomNo		INT	NOT NULL	PRIMARY KEY,
	RoomDesc	VARCHAR(15)	NOT NULL
)
insert into Room(RoomNo, RoomDesc)
Values(001, 'Hair'),
(002, 'Makeup/Nails'),
(003, 'Massage')


CREATE TABLE [dbo].[TreatmentType]
(
	TreatmentType	INT		NOT NULL Primary Key,
	TreatmentDesc	VARCHAR	NOT NULL,
)


CREATE TABLE [dbo].[Treatment]
(
	TreatmentNo			INT	NOT NULL primary key,
	TreatmentPrice		INT	NOT NULL,
	TreatmentDuration	INT	NOT NULL,
	TreatmentType		INT NOT NULL, 
    CONSTRAINT [FKTreatmentType] FOREIGN KEY (TreatmentType) REFERENCES TreatmentType(TreatmentType),

)

CREATE TABLE [dbo].[Appointment]
(
	AppointmentNo			INT			NOT NULL	PRIMARY KEY,
	AppointmentTime			DATETIME	NOT NULL,
	AppointmentDate			DATETIME	NOT NULL,
	CustomerNo				INT			NOT NULL,
	TreatmentNo				INT			NOT NULL,
	TreatmentDesc			VARCHAR(20)	NOT NULL,
	TreatmentCost			INT			NOT NULL,
	QuantityOfTreatment		INT			NOT NULL,
	TreatmentDuration		INT			NOT NULL,
	RoomNo					INT			NOT NULL, 
    CONSTRAINT FKCustomerNo FOREIGN KEY (CustomerNo) REFERENCES Customer(CustomerNo), 
    CONSTRAINT FKRoomNo FOREIGN KEY (RoomNo) REFERENCES Room(RoomNo),
	CONSTRAINT FKTreatmentNo FOREIGN KEY (TreatmentNo) REFERENCES Treatment(TreatmentNo),

)

create table AppointmentTreatment(
	AppointmentNo INT NOT NULL,
	TreatmentNo INT NOT NULL,
	Qty	int not null,

	CONSTRAINT FKTreatmentNum FOREIGN KEY (TreatmentNo) REFERENCES Treatment(TreatmentNo),
	CONSTRAINT FKAppointmentNo FOREIGN KEY (AppointmentNo) REFERENCES Appointment(AppointmentNo),
	primary key clustered(TreatmentNo, AppointmentNo)

)


CREATE TABLE [dbo].[StaffAppointment]
(
	StaffNo			INT		NOT NULL,
	AppointmentNo	INT		NOT NULL, 
    CONSTRAINT FKStaffNo FOREIGN KEY (StaffNo) REFERENCES Staff(StaffNo),
	CONSTRAINT FKAppointmentNum FOREIGN KEY (AppointmentNo) REFERENCES Appointment(AppointmentNo),
	primary key clustered(staffNo, AppointmentNo)
)