--Create Database Runway;
use Runway;
CREATE TABLE [dbo].[Customer]
(
	CustomerNo			INT			NOT NULL  PRIMARY KEY,
	CustomerForename	VARCHAR		NOT NULL,
	CustomerSurname		VARCHAR		NOT NULL,
	CustomerDOB			DATETIME	NOT NULL,
	CustomerStreet		VARCHAR		NOT NULL,
	CustomerTown		VARCHAR		NOT NULL,
	CustomerCounty		VARCHAR		NOT NULL,
	CustomerCountry		VARCHAR		NOT NULL,
	CustomerPostcode	VARCHAR		NOT NULL,
	CustomerTel			INT			NOT NULL,
	CustomerEmail		VARCHAR		NOT NULL,

)
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

