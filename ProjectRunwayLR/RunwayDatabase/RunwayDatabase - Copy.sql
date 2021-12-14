            --set up data adapter for room  details for all list box 

           Select distinct  Room.RoomNo, Room.TreatmentType from Room
Join TreatmentType on TreatmentType.TreatmentType = Room.TreatmentType
join Appointment on Room.RoomNo = Appointment.RoomNo
--join Treatment on Treatment.TreatmentType=room.TreatmentType
Where Room.TreatmentType=1 and Appointment.AppointmentDate != '2021-12-10'
order by RoomNo;

Select distinct Appointment.AppointmentNo,Room.RoomNo,AppointmentDate,TreatmentTime, sum( Treatment.TreatmentDuration*AppointmentTreatment.Qty)  as Duration
 from Room 

left join AppointmentTreatment on Room.RoomNo= AppointmentTreatment.RoomNo
left join Appointment on AppointmentTreatment.AppointmentNo=Appointment.AppointmentNo
left join Treatment on AppointmentTreatment.TreatmentNo=Treatment.TreatmentNo

--Where Room.RoomNo=1
Group by Appointment.AppointmentNo,Room.RoomNo,AppointmentDate,TreatmentTime;




Select AppointmentNo, Treatment.TreatmentNo,TreatmentTime, TreatmentDuration
from AppointmentTreatment 
join Treatment on AppointmentTreatment.TreatmentNo= Treatment.TreatmentNo
where AppointmentNo=5001



Select distinct Appointment.AppointmentNo,Room.RoomNo,AppointmentDate,AppointmentTime, sum( Treatment.TreatmentDuration)  as Duration
 from Room 

left join AppointmentTreatment on Room.RoomNo= AppointmentTreatment.RoomNo
left join Appointment on AppointmentTreatment.AppointmentNo=Appointment.AppointmentNo
left join Treatment on AppointmentTreatment.TreatmentNo=Treatment.TreatmentNo

Where Room.RoomNo=1
Group by Appointment.AppointmentNo,Room.RoomNo,AppointmentDate,AppointmentTime

Select AppointmentNo, Treatment.TreatmentNo,TreatmentTime, TreatmentDuration
from AppointmentTreatment 
join Treatment on AppointmentTreatment.TreatmentNo= Treatment.TreatmentNo
where RoomNo = 1
