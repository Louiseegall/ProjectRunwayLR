
Create View bookingAppointment
as 

select  Appointment.AppointmentNo, 
Customer.customerNo,customerForename,
customerSurname,CustomerEmail,CustomerTelNo,Convert(varChar,AppointmentTime,8) as ATime,AppointmentDate,
Treatment.TreatmentNo,treatmentDesc,treatmentPrice, Convert(varChar,treatmentTime,8) as TTime, room.RoomNo,Room.RoomDesc

From Appointment

join Customer on Appointment.CustomerNo=Customer.customerNo
JOIN AppointmentTreatment on Appointment.AppointmentNo = AppointmentTreatment.AppointmentNo
JOIN Treatment on AppointmentTreatment.TreatmentNo = Treatment.TreatmentNo
join room on AppointmentTreatment.RoomNo=Room.RoomNo

--Join StaffAppointment on TreatmentAppointment.TreatmentNo = StaffAppointment.TreatmentNo
--Join StaffAppointment on AppointmentTreatment.appointmentNo = StaffAppointment.appointmentNo and TreatmentAppointment.TreatmentNo = StaffAppointment.TreatmentNo
--join Staff on Staff.StaffNo = StaffAppointment.StaffNo



