CREATE TABLE [dbo].[StaffAppointment]
(
	StaffNo			INT		NOT NULL,
	AppointmentNo	INT		NOT NULL, 
    CONSTRAINT FKStaffNo FOREIGN KEY (StaffNo) REFERENCES Staff(StaffNo),
	CONSTRAINT FKAppointmentNo FOREIGN KEY (AppointmentNo) REFERENCES Appointment(AppointmentNo)

)
