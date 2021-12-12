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
