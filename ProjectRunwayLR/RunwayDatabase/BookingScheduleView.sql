IF OBJECT_ID ('Schedule') IS NOT NULL
DROP view Schedule
GO

create view Schedule

as

select Appointment.AppointmentNo, Appointment.AppointmentTime, Appointment.AppointmentDate,
Staff.StaffNo,
Treatment.TreatmentNo

From StaffAppointment

join Appointment on StaffAppointment.AppointmentNo = Appointment.AppointmentNo
join Staff on StaffAppointment.StaffNo = Staff.StaffNo
join Treatment on StaffAppointment.TreatmentNo = Treatment.TreatmentNo

