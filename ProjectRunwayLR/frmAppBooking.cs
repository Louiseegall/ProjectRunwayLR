using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRunwayLR
{
    public partial class frmAppBooking : Form
    {

        SqlDataAdapter daCustomers, daTreatments, daStaff, daRoomsAppointments, daRooms, daBooking, daBokingDet, daBookedAppointments;
        DataSet dsRunway = new DataSet();
        SqlConnection conn;
        SqlCommand cmdCustomerDetails, cmdTreatmentDetails, cmdRoomDetails,cmdRoomAppointmentDetails;


        SqlCommandBuilder cmdBCustomer,cmdBStaff, cmdBBookedRooms, cmdBBookingDet, cmdBTreatments, cmdBBooking;


        DataRow drCustomer, drTreatment;


        String sqlCustomerDetails, sqlTreatmentDetails, sqlStaffDetails ,sqlRoomDetails, sqlRooms, sqlBooking;

      

        String connStr;



        /* put under dataadapter and ds set up
          string[] times = { "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00",
         "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00",
         "16:00:00", "16:30:00", "17:00:00", "17:30:00" };*/
        public frmAppBooking()
        {
            InitializeComponent();
        }  


        private void frmAppBooking_SizeChanged(object sender, EventArgs e)
        {
        //    tabApp.ItemSize = new Size((tabApp.Width - 5) / 3, tabApp.ItemSize.Height);
        }

        private void frmAppBooking_Load(object sender, EventArgs e)
        {

            lblBookingDatee.Text = DateTime.Now.ToShortDateString();
            dtpStartDate.MinDate = DateTime.Now;
            connStr = "Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = Runway; Integrated Security = true";

            conn = new SqlConnection(connStr);

            sqlCustomerDetails = @"Select * from Customer order by CustomerSurname";
            daCustomers = new SqlDataAdapter(sqlCustomerDetails, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomers);
            daCustomers.FillSchema(dsRunway   , SchemaType.Source, "Customer");
            daCustomers.Fill(dsRunway, "Customer");
            populateCustomers();

            //sqlStaffDetails = @"Select * from Staff order by StaffSurname";
            //daStaff = new SqlDataAdapter(sqlStaffDetails, connStr);
            //cmdBStaff = new SqlCommandBuilder(daStaff);
            //daStaff.FillSchema(dsRunway, SchemaType.Source, "Staff");
            //daStaff.Fill(dsRunway, "Staff");
            //populateStaff();

            sqlTreatmentDetails = @"Select * from Treatment order by TreatmentDesc";
            daTreatments = new SqlDataAdapter(sqlTreatmentDetails, connStr);
            cmdBTreatments = new SqlCommandBuilder(daTreatments);
            daTreatments.FillSchema(dsRunway, SchemaType.Source, "Treatment");
            daTreatments.Fill(dsRunway, "Treatment");
            populateTreatments();



            sqlRooms = @"Select * from Room where TreatmentType = @TreatmentType";
            cmdRoomDetails = new SqlCommand(sqlRooms, conn);
            cmdRoomDetails.Parameters.Add("@TreatmentType", SqlDbType.Int);
            daRooms = new SqlDataAdapter(cmdRoomDetails);
            daRooms.FillSchema(dsRunway, SchemaType.Source, "Room");
           



            sqlRoomDetails = @"Select distinct Appointment.AppointmentNo,Room.RoomNo,AppointmentDate,TreatmentTime, sum( Treatment.TreatmentDuration*AppointmentTreatment.Qty)  as Duration
 from Room 

left join AppointmentTreatment on Room.RoomNo= AppointmentTreatment.RoomNo
left join Appointment on AppointmentTreatment.AppointmentNo=Appointment.AppointmentNo
left join Treatment on AppointmentTreatment.TreatmentNo=Treatment.TreatmentNo

Where Room.RoomNo=@RoomNo
Group by Appointment.AppointmentNo,Room.RoomNo,AppointmentDate,TreatmentTime;";
            cmdRoomAppointmentDetails = new SqlCommand(sqlRoomDetails, conn);
            cmdRoomAppointmentDetails.Parameters.Add("@RoomNo", SqlDbType.Int);
            daRoomsAppointments = new SqlDataAdapter(cmdRoomAppointmentDetails);
            daRoomsAppointments.FillSchema(dsRunway, SchemaType.Source, "RoomAppointment");


            sqlBooking = @"SELECT * from Appointment";
            daBooking = new SqlDataAdapter(sqlBooking, conn);
            cmdBBooking = new SqlCommandBuilder(daBooking);
            daBooking.FillSchema(dsRunway, SchemaType.Source, "Appointment");
            daBooking.Fill(dsRunway, "Appointment");

            //set up data adapter for room lready booked details for validation
            //sqlBookedRooms = @"Select booking.bookingNo , dateStart, noDays, dogNo, kennelNo from booking Join bookingDetail On booking.bookingNo = bookingDetail.bookingNo order by bookingNo";
            //daBookedRooms = new SqlDataAdapter(sqlBookedRooms, conn);
            //cmdBBookedRooms = new SqlCommandBuilder(daBookedRooms);
            //daBookedRooms.FillSchema(dsRunway, SchemaType.Source, "BookedRooms");
            //daBookedRooms.Fill(dsRunway, "BookedRooms");

            /* add in tooo for times
             * for (int r = 0; r <= 16; r++)
            {
                dgvAppointments.Rows.Add(new object[] { "", "" });
                if (r % 2 == 0)
                {

                    dgvAppointments.Rows[r].HeaderCell.Value = (r / 2 + 9) + ".00";
                }
                else
                {
                    dgvAppointments.Rows[r].HeaderCell.Value = (r / 2 + 9) + ".30";
                }
            } */
            //   tabApp.ItemSize = new Size((tabApp.Width - 5) / 3, tabApp.ItemSize.Height);
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CustNo = int.Parse(cmbCustomer.Text.Substring(cmbCustomer.Text.Length - 5, 4));
            drCustomer = dsRunway.Tables["Customer"].Rows.Find(CustNo);
            lblCust1.Text = drCustomer["CustomerTelNo"].ToString();
            lblCust2.Text = drCustomer["CustomerEmail"].ToString();
            lblCust3.Text = drCustomer["CustomerPostcode"].ToString();

            dtpStartDate.Enabled = true;
        }
        private void cmbAppointmentTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTreatmentTime.Text = cmbAppointmentTime.Text;
            cmbTreatment.SelectedIndex= -1;

            
        }
        private void cmbTreatment_SelectedIndexChanged(object sender, EventArgs e)//list of room which treatment has been selected
        {
            
            cmbRoomNo.Items.Clear();
            cmbRoomNo.Text = "";
           if (cmbTreatment.SelectedIndex == -1) return;
            int TreatmentNo = int.Parse(cmbTreatment.Text.Substring(cmbTreatment.Text.Length - 4, 3));
            drTreatment = dsRunway.Tables["Treatment"].Rows.Find(TreatmentNo);
            cmdRoomDetails.Parameters["@TreatmentType"].Value= drTreatment["TreatmentType"];
            dsRunway.Tables["Room"].Rows.Clear();
            daRooms.Fill(dsRunway, "Room");
            foreach (DataRow room in dsRunway.Tables["Room"].Rows)
            {
                bool add = true;
                cmdRoomAppointmentDetails.Parameters["@RoomNo"].Value = room["RoomNo"];
                dsRunway.Tables["RoomAppointment"].Rows.Clear();
                daRoomsAppointments.Fill(dsRunway, "RoomAppointment");
                foreach (DataRow ra in dsRunway.Tables["RoomAppointment"].Rows)
                {
                    DateTime date = DateTime.Parse(ra["AppointmentDate"].ToString());
                    if (date.Date != dtpStartDate.Value.Date)
                    {
                        continue;
                    }
                    TimeSpan bookingStart = TimeSpan.Parse(ra["TreatmentTime"].ToString());
                    int minutes = int.Parse(ra["Duration"].ToString()) * 30;
                    TimeSpan bookingEnd = bookingStart.Add(new TimeSpan(minutes / 60, minutes % 60, 0));
                    //new treatment time through these three lines of code, start is new treamtn tim, set label treaemtn end to string 
                    TimeSpan treatmentStart = TimeSpan.Parse(lblTreatmentTime.Text);
                    int minutesT = int.Parse(drTreatment["TreatmentDuration"].ToString()) * 30;
                    TimeSpan treatmentEnd = treatmentStart.Add(new TimeSpan(minutesT / 60, minutesT % 60, 0));
                    if ((bookingStart >= treatmentStart && bookingStart <treatmentEnd)||
                       ( bookingEnd>treatmentStart && bookingEnd<=treatmentEnd)||
                       (bookingStart<treatmentStart && bookingEnd>treatmentEnd))
                    {
                        add = false;
                        break;
                    }

                
                }
                if (add)
                {
                    cmbRoomNo.Items.Add(room["RoomNo"]);
                }
            }



        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            //dtpTime.Enabled = true;
        }
        private void fillAvailibleRooms()
        {

        }
     
      
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.FromArgb(255, 250, 237, 174);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(255, 250, 237, 174);

        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Standard;

        }


        private void populateCustomers()
        {
            int noRows = dsRunway.Tables["Customer"].Rows.Count;
            cmbCustomer.Items.Clear();
            foreach (DataRow dr in dsRunway.Tables["customer"].Rows)
            {
                cmbCustomer.Items.Add(dr["CustomerSurname"].ToString() + ", " + dr["CustomerForename"].ToString() + " (" + dr["CustomerNo"].ToString() + ")");
            }
        }

        //private void populateStaff()
        //{
        //    int noRows = dsRunway.Tables["Staff"].Rows.Count;
        //    cmbStaff.Items.Clear();
        //    foreach (DataRow dr in dsRunway.Tables["Staff"].Rows)
        //    {
        //        cmbStaff.Items.Add(dr["StaffSurname"].ToString() + ", " + dr["StaffForename"].ToString() + " (" + dr["StaffNo"].ToString() + ")");
        //    }
        //}
        private void populateTreatments()
        {
            int noRows = dsRunway.Tables["Treatment"].Rows.Count;
            cmbTreatment.Items.Clear();
            foreach (DataRow dr in dsRunway.Tables["Treatment"].Rows)
            {
                cmbTreatment.Items.Add(dr["TreatmentDesc"].ToString() + ", "+ " (" + dr["TreatmentNo"].ToString() + ")");
            }
        }
  private void btnAddItem_Click(object sender, EventArgs e)
        {

            bool ok = true;
            //bool exits = false;
            if (cmbCustomer.Text == "")
                MessageBox.Show("please select a customer", "Customer");

            else if (dtpStartDate.Value<DateTime.Now.Date)
                MessageBox.Show("please select a Appointment Date", "AppointmentDate");
else if (cmbAppointmentTime.Text == "")
            {
                MessageBox.Show("please select a Appointment Time", "AppointmentTime");

                cmbAppointmentTime.Focus();
            }
            else if (cmbTreatment.Text == "")
                MessageBox.Show("please select a Treatment", "Treatment");
        //else if (cmbStaff.Text == "")
        //        MessageBox.Show("please select a Staff", "Staff");
            

            else if (cmbRoomNo.Text == "")
                MessageBox.Show("please select a Room", "Room");
    
            else
            {
                //foreach (ListViewItem item in lvwBooking.Items)
                //{
                //    if (item.SubItems[1].Text == cmbRoomNo.Text)
                //    {
                //        MessageBox.Show("Room already selected for this booking", "Booking");
                //        exits = true;
                //        break;
                //    }
                //}
                //if (!exits)
                ////{
                //    DateTime start = DateTime.Parse(cmbAppointmentTime.Text.Trim());
                //    foreach (DataRow dr in dsRunway.Tables["Appointment"].Rows)
                //    {
                //        DateTime bookedDate = DateTime.Parse(dr["dateStart"].ToString());
                //        if (start >= bookedDate && start <= bookedDate.AddDays(int.Parse(cmbAppointmentTime.Text)))
                //        {

                //            if ((dr["BookedRooms"] == cmbRoomNo.SelectedValue))
                //            {
                //                MessageBox.Show("the selected Room is already included in a booking for this dayte range. pleasereselect", "Booking");
                //                ok = false;
                //            }
                //            if (!ok)
                //                break;
                //        }
                //    }
                if (ok)
                {
                    pnlCustomer.Enabled = false;

                    int TreatmentNo = int.Parse(cmbTreatment.Text.Substring(cmbTreatment.Text.Length - 4, 3));
                    drTreatment = dsRunway.Tables["Treatment"].Rows.Find(TreatmentNo);
                    //DataRow room = dsRunway.Tables["Room"].Rows.Find(int.Parse(cmbRoomNo.Text));



                    ListViewItem item = new ListViewItem(TreatmentNo.ToString());
                    item.SubItems.Add(drTreatment["TreatmentDesc"].ToString());
                    item.SubItems.Add(lblTreatmentTime.Text);
                    //int StaffNo = int.Parse(cmbStaff.Text.Substring(cmbStaff.Text.Length - 5, 4));
                    //item.SubItems.Add(StaffNo.ToString());
                    item.SubItems.Add(cmbRoomNo.Text);

                    lvwBooking.Items.Add(item);
                    int minutes = int.Parse(drTreatment["TreatmentDuration"].ToString())*30;
                    TimeSpan nextTreatment = TimeSpan.Parse(lblTreatmentTime.Text).Add(new TimeSpan(minutes/60,minutes%60,0));
                    lblTreatmentTime.Text = nextTreatment.ToString(@"hh\:mm");




                }

            }
        }
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {


            if (lvwBooking.SelectedItems.Count != 0)
            {
                var item = lvwBooking.SelectedItems[0];
                lvwBooking.Items.Remove(item);
            }


        }

    }
}

