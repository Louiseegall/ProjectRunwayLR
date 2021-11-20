--Create Database Runway;
use Runway;
IF OBJECT_ID ('Customer') IS NOT NULL
DROP table Customer
GO
CREATE TABLE [dbo].[Customer]
(
	CustomerNo			INT				NOT NULL  PRIMARY KEY,
	CustomerTitle		VarChar(20)		NOT Null,
	CustomerForename	VARCHAR(30)		NOT NULL,
	CustomerSurname		VARCHAR(30)		NOT NULL,
	CustomerDOB			DATE			NOT NULL,
	CustomerStreet		VARCHAR	(30)	NOT NULL,
	CustomerTown		VARCHAR(30)		NOT NULL,
	CustomerCounty		VARCHAR(30)	NOT NULL,
	CustomerCountry		VARCHAR(30)	NOT NULL,
	CustomerPostcode	VARCHAR(30)	NOT NULL,
	CustomerTelNo		VARCHAR(15)		NOT NULL,
	CustomerEmail		VARCHAR(50)		NOT NULL,
	Discount			DECIMAL			NOT NULL,
)
insert into Customer(customerNo,CustomerTitle,CustomerForename, CustomerSurname,CustomerDOB, 
CustomerStreet,CustomerTown,CustomerCounty,CustomerCountry,CustomerPostcode
, CustomerTelNo, CustomerEmail, Discount)
Values(5000,'Ms','Louise','Gallagher','1996/11/12','Hill View','Letterkenny','Donegal','Ireland','F92 A7D6',
'0861225405','Louise@gmail.com',0 ),
(5001,'Miss','Laura','Smith','1990/02/01','Moutain Top','Buncranna','Donegal','Ireland','F93 A7H4',
'0863482736','Laura@gmail.com',0 ),
(5002,'Mrs','Sheila','Craig','1978/07/21',' Pine Lake','Ballyshannon','Donegal','Ireland','F98 TTD3',
'0877711533','Sheila@gmail.com' ,0),
(5003,'Mrs','Georgie','Doherty','1980/05/29','Beach Road','Letterkenny','Donegal','Ireland','F92 KK46',
'0832134876','Georgie@gmail.com',0 ),
(5004,'Miss','Tina','Ferry','1992/11/05','Castle Park','Buncranna','Donegal','Ireland','F93 YY86',
'0890056783','Tina@gmail.com' ,0),
(5005,'Mrs','Sarah','Mooney','1991/01/18','Manor Hill','Drumkeen','Donegal','Ireland','F92 TY65',
'089125575','Sarah@gmail.com' ,0),
(5006,'Mr','Mark','Daniels','1995/01/21','Ard Mor','Newtown','Donegal','Ireland','F92 FC43',
'089918702','Mark@gmail.com',0 ),
(5007,'Mr','Rob','Cannon','1989/08/24','Roads Square','Manor','Donegal','Ireland','F92 TE36',
'0891628736','rob@gmail.com',0 )
























CREATE TABLE [dbo].[Staff]
(
	StaffNo			 INT				NOT NULL PRIMARY KEY,
	StaffTitle		 INT				NOT NULL,
	StaffForename	 INT				NOT NULL,
	StaffSurname	 INT				NOT NULL,
	StaffDOB		 DATETIME			NOT NULL,
	StaffStreet		 VARCHAR(20)		NOT NULL,
	StaffTown		 VARCHAR(20)		NOT NULL,
	County			 VARCHAR(20)		NOT NULL,
	Country			 VARCHAR(20)		NOT NULL,
	PostCode		 VARCHAR(20)		NOT NULL,
	TelNo			 VARCHAR(11)		NOT NULL,
	Email			 VARCHAR(20)		NOT NULL,
	EmergencyContact VARCHAR(11)		NOT NULL,		
	Speciality		 VARCHAR(20)		NOT NULL


)


CREATE TABLE [dbo].[Room]
(
	RoomNo		INT	NOT NULL	PRIMARY KEY,
	RoomDesc	INT	NOT NULL
)

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
	TreatmentNo		INT			NOT NULL,
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

