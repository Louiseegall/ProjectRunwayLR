
Create View bookingAppointment
as 

select distinct Appointment.AppointmentNo, AppointmentTime,AppointmentDate,
Customer.customerNo,customerForename,
customerSurname,Staff.StaffNo,staffForename, staffSurname,
Treatment.TreatmentNo,treatmentDesc,treatmentPrice, Qty,
treatmentPrice*AppointmentTreatment.qty as totalAppointmentCost

From Appointment

join Customer on Appointment.CustomerNo=Customer.customerNo
JOIN AppointmentTreatment on Appointment.AppointmentNo = AppointmentTreatment.AppointmentNo
JOIN Treatment on AppointmentTreatment.TreatmentNo = Treatment.TreatmentNo
--Join StaffAppointment on TreatmentAppointment.TreatmentNo = StaffAppointment.TreatmentNo
--Join StaffAppointment on AppointmentTreatment.appointmentNo = StaffAppointment.appointmentNo and TreatmentAppointment.TreatmentNo = StaffAppointment.TreatmentNo
--join Staff on Staff.StaffNo = StaffAppointment.StaffNo


left Join StaffAppointment on AppointmentTreatment.AppointmentNo = StaffAppointment.AppointmentNo and AppointmentTreatment.TreatmentNo = StaffAppointment.TreatmentNo
left join Staff on Staff.StaffNo = StaffAppointment.StaffNo

