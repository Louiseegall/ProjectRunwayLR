create view Schedule

as

select Appointment.AppointmentNo, AppointmentTime, AppointmentDate,
Staff.StaffNo,
Treatment.TreatmentNo

From Appointment

JOIN Appointment on StaffAppointment.AppointmentNo = Appointment.AppointmentNo
JOIN StaffAppointment on Staff.StaffNo = StaffAppointment.StaffNo
JOIN Treatment on StaffAppointment.TreatmentNo = Treatment.TreatmentNo

