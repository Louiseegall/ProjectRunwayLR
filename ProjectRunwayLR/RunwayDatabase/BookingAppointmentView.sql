Create View bookingAppointment
as 

select distinct Appointment.AppointmentNo, AppointmentTime,AppointmentDate,
Customer.customerNo,customerForename,
customerSurname,Staff.StaffNo,staffForename, staffSurname,
Treatment.TreatmentNo,treatmentDesc,treatmentPrice, Qty,
treatmentPrice*AppointmentTreatment.qty as totalAppointmentCost

From Appointment

 join Customer on Appointment.CustomerNo=Customer.customerNo
 join StaffAppointment on Appointment.AppointmentNo=StaffAppointment.AppointmentNo 
inner join Staff on StaffAppointment.StaffNo=Staff.staffNo
inner JOIN AppointmentTreatment on Appointment.appointmentNo = AppointmentTreatment.appointmentNo
inner JOIN Treatment on AppointmentTreatment.TreatmentNo = Treatment.TreatmentNo
