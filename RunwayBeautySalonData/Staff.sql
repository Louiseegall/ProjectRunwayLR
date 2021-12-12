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
